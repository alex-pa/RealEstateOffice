using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace TheRealEstateOffice
{
    public partial class InfoForm : Form
    {
        public InfoForm(string[] place) //конструктор Form2 который принимает массив строк
        {
            InitializeComponent();
            this.ActiveControl = label1;

            Area.Text = $"{place[0]}";
            Adress.Text = $"{place[1]}";
            Type.Text = $"{place[2]}";
            Room.Text = $"{place[3]}";
            FloorNumber.Text = $"{place[4]}";
            SquareMeters.Text = $"{place[5]}";
            Class.Text = $"{place[6]}";
            Condition.Text = $"{place[7]}";
            Other.Text = $"{place[8]}";
            Value.Text = $"{place[9]}";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
