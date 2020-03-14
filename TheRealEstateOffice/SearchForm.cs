using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace TheRealEstateOffice
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        private void Room1_ValueChanged(object sender, EventArgs e)
        {
            if (Room1.Value > Room2.Value)
            {
                Room2.Value = Room1.Value;
            }
        }

        private void Floor1_ValueChanged(object sender, EventArgs e)
        {
            if (Floor1.Value > Floor2.Value)
            {
                Floor2.Value = Floor1.Value;
            }
        }

        private void SquareMeters1_ValueChanged(object sender, EventArgs e)
        {
            if (SquareMeters1.Value > SquareMeters2.Value)
            {
                SquareMeters2.Value = SquareMeters1.Value;
            }
        }

        private void Value1_ValueChanged(object sender, EventArgs e)
        {
            if (Value1.Value > Value2.Value)
            {
                Value2.Value = Value1.Value;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Room1.Value = Room1.Minimum;
            Room2.Value = Room2.Minimum;
            Floor1.Value = Floor1.Minimum;
            Floor2.Value = Floor2.Minimum;
            SquareMeters1.Value = SquareMeters1.Minimum;
            SquareMeters2.Value = SquareMeters2.Minimum;
            Value1.Value = Value1.Minimum;
            Value2.Value = Value2.Minimum;

            checkedListBoxArea.ClearSelected();
            checkedListBoxClass.ClearSelected();
            checkedListBoxCondition.ClearSelected();
            checkedListBoxType.ClearSelected();

            for (int i = 0; i < checkedListBoxArea.Items.Count; i++)
            {
                checkedListBoxArea.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListBoxClass.Items.Count; i++)
            {
                checkedListBoxClass.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListBoxCondition.Items.Count; i++)
            {
                checkedListBoxCondition.SetItemChecked(i, false);
            }
            for (int i = 0; i < checkedListBoxType.Items.Count; i++)
            {
                checkedListBoxType.SetItemChecked(i, false);
            }
        }

        private void Room2_ValueChanged(object sender, EventArgs e)
        {
            if (Room1.Value > Room2.Value)
            {
                Room1.Value = Room2.Value;
            }
        }

        private void Floor2_ValueChanged(object sender, EventArgs e)
        {
            if (Floor1.Value > Floor2.Value)
            {
                Floor1.Value = Floor2.Value;
            }
        }

        private void SquareMeters2_ValueChanged(object sender, EventArgs e)
        {
            if (SquareMeters1.Value > SquareMeters2.Value)
            {
                SquareMeters1.Value = SquareMeters2.Value;
            }
        }

        private void Value2_ValueChanged(object sender, EventArgs e)
        {
            if (Value1.Value > Value2.Value)
            {
                Value1.Value = Value2.Value;
            }
        }

        private void checkedListBoxArea_MouseClick(object sender, MouseEventArgs e)
        {
            checkedListBoxClass.ClearSelected();
            checkedListBoxCondition.ClearSelected();
            checkedListBoxType.ClearSelected();
        }

        private void checkedListBoxType_MouseClick(object sender, MouseEventArgs e)
        {
            checkedListBoxClass.ClearSelected();
            checkedListBoxCondition.ClearSelected();
            checkedListBoxArea.ClearSelected();
        }

        private void checkedListBoxClass_MouseClick(object sender, MouseEventArgs e)
        {
            checkedListBoxArea.ClearSelected();
            checkedListBoxCondition.ClearSelected();
            checkedListBoxType.ClearSelected();
        }

        private void checkedListBoxCondition_MouseClick(object sender, MouseEventArgs e)
        {
            checkedListBoxClass.ClearSelected();
            checkedListBoxArea.ClearSelected();
            checkedListBoxType.ClearSelected();
        }

        private void AllRooms_Click(object sender, EventArgs e)
        {
            Room1.Value = Room1.Minimum;
            Room2.Value = Room2.Maximum;
        }

        private void AllFloors_Click(object sender, EventArgs e)
        {
            Floor1.Value = Floor1.Minimum;
            Floor2.Value = Floor2.Maximum;
        }

        private void AllSquareMeters_Click(object sender, EventArgs e)
        {
            SquareMeters1.Value = SquareMeters1.Minimum;
            SquareMeters2.Value = SquareMeters2.Maximum;
        }

        private void AllValues_Click(object sender, EventArgs e)
        {
            Value1.Value = Value1.Minimum;
            Value2.Value = Value2.Maximum;
        }

        private void AllAreas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxArea.Items.Count; i++)
            {
                checkedListBoxArea.SetItemChecked(i, true);
            }
        }

        private void AllTypes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxType.Items.Count; i++)
            {
                checkedListBoxType.SetItemChecked(i, true);
            }
        }

        private void AllClases_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxClass.Items.Count; i++)
            {
                checkedListBoxClass.SetItemChecked(i, true);
            }
        }

        private void AllConditions_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCondition.Items.Count; i++)
            {
                checkedListBoxCondition.SetItemChecked(i, true);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (checkedListBoxArea.CheckedItems.Count == 0) count++;
            if (checkedListBoxType.CheckedItems.Count == 0) count++;
            if (checkedListBoxClass.CheckedItems.Count == 0) count++;
            if (checkedListBoxCondition.CheckedItems.Count == 0) count++;
            if (checkedListBoxArea.CheckedItems.Count == 0 || checkedListBoxType.CheckedItems.Count == 0 ||
                checkedListBoxClass.CheckedItems.Count == 0 || checkedListBoxCondition.CheckedItems.Count == 0)
            {
                if (count > 1)
                {
                    MessageBox.Show("Выберите подходящие параметры!");
                    return;
                }
                if (checkedListBoxArea.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите подходящий район!");
                    return;
                }
                if (checkedListBoxType.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите подходящий тип!");
                    return;
                }
                if (checkedListBoxClass.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите подходящий класс!");
                    return;
                }
                if (checkedListBoxCondition.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите подходящие состояние!");
                    return;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
