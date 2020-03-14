using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TheRealEstateOffice
{
    public partial class Form2 : Form
    {
        public Form2() //конструктор Form2
        {
            InitializeComponent();
            this.ActiveControl = label1;
            comboBoxArea.SelectedItem = null;
            comboBoxType.SelectedItem = null;
            comboBoxClass.SelectedItem = null;
            comboBoxCondition.SelectedItem = null;
        }

        public Form2(string[] place) //конструктор Form2 который принимает массив строк
        {
            InitializeComponent();
            Text = "Изменение места";
            AddPlaceButtonForm2.Text = "Изменить";

            comboBoxArea.SelectedItem = place[0];
            textBoxAdress.Text = place[1];
            this.ActiveControl = label1;
            comboBoxType.SelectedItem = place[2];
            numericUpDownRoom.Value = Convert.ToInt32(place[3]);
            numericUpDownFloorNumber.Value = Convert.ToInt32(place[4]);
            numericUpDownSquareMeters.Value = Convert.ToInt32(place[5]);
            comboBoxClass.SelectedItem = place[6];
            comboBoxCondition.SelectedItem = place[7];
            textBoxOther.Text = place[8];
            numericUpDownValue.Value = Convert.ToInt32(place[9]);
        }

        private void AddPlaceButtonForm2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBoxAdress.Text == "") count++;
            if (comboBoxArea.SelectedItem == null) count++;
            if (comboBoxType.SelectedItem == null) count++;
            if (comboBoxClass.SelectedItem == null) count++;
            if (comboBoxCondition.SelectedItem == null) count++;

            if (textBoxAdress.Text == "" || comboBoxArea.SelectedItem == null ||
                comboBoxType.SelectedItem == null || comboBoxClass.SelectedItem == null 
                || comboBoxCondition.SelectedItem == null || textBoxAdress.Text.Length < 15)
            {
                if (count > 0)
                {
                    MessageBox.Show("Заполните все необходимые поля. Поле 'Другое' может быть пустым");
                    return;
                }
                if (textBoxAdress.Text.Length < 15)
                {
                    MessageBox.Show("Поле 'Адрес' не должно содержать менее чем 15 символов");
                    return;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)  // регулярные выражения для поля 'Адрес'
        {
            if (Regex.IsMatch(textBoxAdress.Text, @"^[\s]") || textBoxAdress.TextLength >= 40)
            {
                textBoxAdress.Text = textBoxAdress.Text.Remove(textBoxAdress.Text.Length - 1);
                textBoxAdress.SelectionStart = textBoxAdress.TextLength;
            }
        }

        private void textBoxOther_TextChanged(object sender, EventArgs e)  // регулярные выражения для поля 'Другое'
        {
            if (Regex.IsMatch(textBoxOther.Text, @"^[\s]") || textBoxOther.TextLength >= 100)
            {
                textBoxOther.Text = textBoxOther.Text.Remove(textBoxOther.Text.Length - 1);
                textBoxOther.SelectionStart = textBoxOther.TextLength;
            }
        }
    }
}
