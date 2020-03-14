using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace TheRealEstateOffice
{
    public partial class Form1 : Form
    {
        List<Place> places = new List<Place>();

        static void OpenDataFromFile(Form1 form1)
        {
            form1.places.Clear();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\places.txt";
            StreamReader myread = new StreamReader(path, System.Text.Encoding.Default);
            string[] str;
            int num = 0;
            try
            {
                string[] str1 = myread.ReadToEnd().Split('\n');
                num = str1.Count() - 1;
                form1.dataGridView1.RowCount = num;
                for (int i = 0; i < num; i++)
                {
                    str = str1[i].Split(new[] { " | " }, StringSplitOptions.None);
                    for (int j = 0; j < form1.dataGridView1.ColumnCount; j++)
                    {
                        try
                        {
                            form1.dataGridView1.Rows[i].Cells[j].Value = str[j];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    string Area = str[0];
                    string Address = str[1];
                    string Type = str[2];
                    int Rooms = Int32.Parse(str[3]); 
                    int FloorNumber = Int32.Parse(str[4]);
                    int SquareMeters = Int32.Parse(str[5]);
                    string Class = str[6];
                    string Condition = str[7];
                    string Other = str[8];
                    int Value = Int32.Parse(str[9]);

                    Location location = new Location(Area, Address);
                    Description description = new Description(Type, Rooms, SquareMeters, FloorNumber, Class, Condition, Other);
                    Place place = new Place(location, description, Value);
                    form1.places.Add(place);       // добавляем новое место в список "places"

                    if (form1.dataGridView1.SelectedCells.Count > 0)   // убирет выделение во всех строках при запуске формы
                    {
                        foreach (DataGridViewCell c in form1.dataGridView1.SelectedCells)
                        {
                            c.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myread.Close();
            }
        }  //статический метод для загрузки данных из файла в таблицу и в список "places"

        static void SaveDataToFile(Form1 form1)
        {
            form1.places.Clear();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\places.txt";
            StreamWriter streamWriter = new StreamWriter(path, false, System.Text.Encoding.Default);
            try
            {
                for(int i = 0; i < form1.dataGridView1.RowCount; i++)
                {
                    for(int j = 0; j < form1.dataGridView1.ColumnCount; j++)
                    {
                        if (j == form1.dataGridView1.ColumnCount - 1)
                        {
                            streamWriter.Write(form1.dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            streamWriter.Write(form1.dataGridView1.Rows[i].Cells[j].Value.ToString() + " | ");
                        }
                    }
                    streamWriter.WriteLine();

                    string Area = form1.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string Address = form1.dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Type = form1.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    int Rooms = Int32.Parse(form1.dataGridView1.Rows[i].Cells[3].Value.ToString());
                    int FloorNumber = Int32.Parse(form1.dataGridView1.Rows[i].Cells[4].Value.ToString());
                    int SquareMeters = Int32.Parse(form1.dataGridView1.Rows[i].Cells[5].Value.ToString());
                    string Class = form1.dataGridView1.Rows[i].Cells[6].Value.ToString();
                    string Condition = form1.dataGridView1.Rows[i].Cells[7].Value.ToString();
                    string Other = form1.dataGridView1.Rows[i].Cells[8].Value.ToString();
                    int Value = Int32.Parse(form1.dataGridView1.Rows[i].Cells[9].Value.ToString());

                    Location location = new Location(Area, Address);
                    Description description = new Description(Type, Rooms, SquareMeters, FloorNumber, Class, Condition, Other);
                    Place place = new Place(location, description, Value);
                    form1.places.Add(place);       // добавляем новое место в список "places"
                    if (form1.dataGridView1.SelectedCells.Count > 0)   // убирет выделение во всех строках при запуске формы
                    {
                        foreach (DataGridViewCell c in form1.dataGridView1.SelectedCells)
                        {
                            c.Selected = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamWriter.Close();
            }
        }    //статический метод для сохранения данных из таблицы в файл и в список "places"

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = dataGridView1;
            OpenDataFromFile(this); 
        }  //конструктор формы Form1

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            DialogResult result = newForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.OK)
            {
                try
                {
                    string Area = newForm.comboBoxArea.SelectedItem.ToString();
                    string Address = newForm.textBoxAdress.Text;
                    Location location = new Location(Area, Address);

                    string Type = newForm.comboBoxType.SelectedItem.ToString();
                    int Rooms = (int)newForm.numericUpDownRoom.Value;
                    int SquareMeters = (int)newForm.numericUpDownSquareMeters.Value;
                    int FloorNumber = (int)newForm.numericUpDownFloorNumber.Value;
                    string Class = newForm.comboBoxClass.SelectedItem.ToString();
                    string Condition = newForm.comboBoxCondition.SelectedItem.ToString();
                    string Other = newForm.textBoxOther.Text;
                    Description description = new Description(Type, Rooms, SquareMeters, FloorNumber, Class, Condition, Other);

                    int Value = (int)newForm.numericUpDownValue.Value;
                    
                    Place place = new Place(location, description, Value);
                    places.Add(place);
                    dataGridView1.Rows.Add(Area, Address, Type, Rooms, FloorNumber, SquareMeters, Class, Condition, Other, Value);

                    SaveDataToFile(this);

                    MessageBox.Show("Новый объект добавлен");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChangePlaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string[] place = new string[10];  // массив строк 'place' хранит информацию о текущем выделенном объекте
                place[0] = dataGridView1.Rows[index].Cells[0].Value.ToString();
                place[1] = dataGridView1.Rows[index].Cells[1].Value.ToString();
                place[2] = dataGridView1.Rows[index].Cells[2].Value.ToString();
                place[3] = dataGridView1.Rows[index].Cells[3].Value.ToString();
                place[4] = dataGridView1.Rows[index].Cells[4].Value.ToString();
                place[5] = dataGridView1.Rows[index].Cells[5].Value.ToString();
                place[6] = dataGridView1.Rows[index].Cells[6].Value.ToString();
                place[7] = dataGridView1.Rows[index].Cells[7].Value.ToString();
                place[8] = dataGridView1.Rows[index].Cells[8].Value.ToString();
                place[9] = dataGridView1.Rows[index].Cells[9].Value.ToString();

                Form2 newForm = new Form2(place);
                DialogResult result = newForm.ShowDialog(this);

                if (result == DialogResult.Cancel) return;
                if (result == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    try
                    {
                        string Area = newForm.comboBoxArea.SelectedItem.ToString();
                        string Address = newForm.textBoxAdress.Text;
                        Location location = new Location(Area, Address);

                        string Type = newForm.comboBoxType.SelectedItem.ToString();
                        int Rooms = (int)newForm.numericUpDownRoom.Value;
                        int SquareMeters = (int)newForm.numericUpDownSquareMeters.Value;
                        int FloorNumber = (int)newForm.numericUpDownFloorNumber.Value;
                        string Class = newForm.comboBoxClass.SelectedItem.ToString();
                        string Condition = newForm.comboBoxCondition.SelectedItem.ToString();
                        string Other = newForm.textBoxOther.Text;
                        Description description = new Description(Type, Rooms, SquareMeters, FloorNumber, Class, Condition, Other);

                        int Value = (int)newForm.numericUpDownValue.Value;

                        Place Place = new Place(location, description, Value);

                        dataGridView1.Rows.Add(Area, Address, Type, Rooms, FloorNumber, SquareMeters, Class, Condition, Other, Value);

                        SaveDataToFile(this);

                        MessageBox.Show("Объект изменен");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Для начала добавьте объект");
                }
                else
                {
                    MessageBox.Show("Для начала выберите объект из списка!");
                }
                return;
            }
        }

        private void DeletePlaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
            }
            catch
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Для начала добавьте объект");
                }
                else
                {
                    MessageBox.Show("Для начала выберите объект из списка!");
                }
                return;
            }
            СonfirmationForm сonfirmationForm = new СonfirmationForm();
            DialogResult result = сonfirmationForm.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.OK)
            {
                try
                {
                    int index = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(index);
                    SaveDataToFile(this);
                    MessageBox.Show("Выбраный объект удален");
                }
                catch
                {
                    MessageBox.Show("Для начала выберите объект из списка!");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();  // удаляет выделение при двойном клике на объект таблицы
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string[] place = new string[10];   // массив строк 'place' хранит информацию о текущем выделенном объекте
                place[0] = dataGridView1.Rows[index].Cells[0].Value.ToString();
                place[1] = dataGridView1.Rows[index].Cells[1].Value.ToString();
                place[2] = dataGridView1.Rows[index].Cells[2].Value.ToString();
                place[3] = dataGridView1.Rows[index].Cells[3].Value.ToString();
                place[4] = dataGridView1.Rows[index].Cells[4].Value.ToString();
                place[5] = dataGridView1.Rows[index].Cells[5].Value.ToString();
                place[6] = dataGridView1.Rows[index].Cells[6].Value.ToString();
                place[7] = dataGridView1.Rows[index].Cells[7].Value.ToString();
                place[8] = dataGridView1.Rows[index].Cells[8].Value.ToString();
                place[9] = dataGridView1.Rows[index].Cells[9].Value.ToString();

                InfoForm infoForm = new InfoForm(place);
                infoForm.Show();
            }
            catch
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Для начала добавьте объект");
                }
                else
                {
                    MessageBox.Show("Для начала выберите объект из списка!");
                }
                return;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Для начала добавьте объект");
                return;
            }
            List<Place> searchResult = new List<Place>();   // лист в котором хранятся результаты поиска
            searchResult.Clear();
            SearchForm newForm = new SearchForm();
            DialogResult result = newForm.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                AddPlaceButton.Visible = false;
                ChangePlaceButton.Visible = false;
                DeletePlaceButton.Visible = false;
                ReturnButton.Visible = true;
                Text = "Результаты поиска";

                foreach (Place place in places)     // реализация поиска
                {
                    bool countArea = false;
                    foreach (string s in newForm.checkedListBoxArea.CheckedItems)
                    {
                        if (place.location.Area == s)
                        {
                            countArea = true;
                        }
                    }
                    bool countType = false;
                    foreach (string s in newForm.checkedListBoxType.CheckedItems)
                    {
                        if (place.description.Type == s)
                        {
                            countType = true;
                        }
                    }
                    bool countClass = false;
                    foreach (string s in newForm.checkedListBoxClass.CheckedItems)
                    {
                        if (place.description.Class == s)
                        {
                            countClass = true;
                        }
                    }
                    bool countCondition = false;
                    foreach (string s in newForm.checkedListBoxCondition.CheckedItems)
                    {
                        if (place.description.Condition == s)
                        {
                            countCondition = true;
                        }
                    }
                    bool countRoom = false;
                    if (place.description.Rooms >= newForm.Room1.Value && place.description.Rooms <= newForm.Room2.Value)
                    {
                        countRoom = true;
                    }
                    bool countFloor = false;
                    if (place.description.FloorNumber >= newForm.Floor1.Value && place.description.FloorNumber <= newForm.Floor2.Value)
                    {
                        countFloor = true;
                    }
                    bool countSquareMeters = false;
                    if (place.description.SquareMeters >= newForm.SquareMeters1.Value && place.description.SquareMeters <= newForm.SquareMeters2.Value)
                    {
                        countSquareMeters = true;
                    }
                    bool countValue = false;
                    if (place.Value >= newForm.Value1.Value && place.Value <= newForm.Value2.Value)
                    {
                        countValue = true;
                    }


                    if (countArea && countType && countClass && countCondition && countRoom &&
                        countFloor && countSquareMeters && countValue)
                    {
                        searchResult.Add(place);
                    }
                }

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("Ничего не найдено!");
                }

                foreach (Place place in searchResult) 
                {
                    dataGridView1.Rows.Add(place.location.Area, place.location.Address, place.description.Type,
                        place.description.Rooms, place.description.FloorNumber, place.description.SquareMeters,
                        place.description.Class, place.description.Condition, place.description.Other, place.Value);
                }

                if (dataGridView1.SelectedCells.Count > 0)   // убирет выделение во всех строках при запуске формы
                {
                    foreach (DataGridViewCell c in dataGridView1.SelectedCells)
                    {
                        c.Selected = false;
                    }
                }
                this.ActiveControl = dataGridView1;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            AddPlaceButton.Visible = true;
            ChangePlaceButton.Visible = true;
            DeletePlaceButton.Visible = true;
            ReturnButton.Visible = false;
            Text = "RealEstateOffice — Главная";
            OpenDataFromFile(this);
            this.ActiveControl = dataGridView1;
        }
    }
    class Place
    {
        public Location location;
        public Description description;
        public int Value;
        public Place(Location location, Description description, int Value)
        {
            this.location = location;
            this.description = description;
            this.Value = Value;
        }
    }
    class Location
    {
        public string Area;
        public string Address;
        public Location(string Area, string Address)
        {
            this.Area = Area;
            this.Address = Address;
        }
    }
    class Description
    {
        public string Type;
        public int Rooms;
        public int SquareMeters;
        public int FloorNumber;
        public string Class;
        public string Condition;
        public string Other;
        public Description(string Type, int Rooms, int SquareMeters, int FloorNumber, string Class, string Condition, string Other)
        {
            this.Type = Type;
            this.Rooms = Rooms;
            this.SquareMeters = SquareMeters;
            this.FloorNumber = FloorNumber;
            this.Class = Class;
            this.Condition = Condition;
            this.Other = Other;
        }
    }
}
