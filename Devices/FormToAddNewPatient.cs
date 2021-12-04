using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devices
{
    public partial class FormToAddNewPatient : Form
    {
        public FormToAddNewPatient()
        {
            InitializeComponent();
        }

        private void comboBoxChoosePol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddNewPatient_Click(object sender, EventArgs e)
        {
            switch (comboBoxChoosePol.Text) 
            {
                case "М":
                    {
                        ListOfPatients newForm = new ListOfPatients();
                        newForm.Show();
                        Hide();
                        break;
                    }
                case "Ж":
                    {
                        ListOfPatients newForm = new ListOfPatients();
                        newForm.Show();
                        Hide();
                        break;
                    }
                default:
                    MessageBox.Show("Вы не верно ввели пол! Выберите пол из списка");
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfPatientsAndDevices newForm = new ListOfPatientsAndDevices();
            newForm.Show();
            Hide();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
