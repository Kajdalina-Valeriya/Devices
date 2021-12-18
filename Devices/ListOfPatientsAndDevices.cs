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
    public partial class ListOfPatientsAndDevices : Form
    {
        public ListOfPatientsAndDevices()
        {
            InitializeComponent();
            //if ()
            //    buttonbuttonListOfDevices.Enabled = false;
            //else buttonbuttonListOfDevices.Enabled = true;

        }

        //private void Form2_Load(object sender, EventArgs e)
        //{

        //}

        public ListOfPatientsAndDevices(DoctorOrAdmin f)
        {
            InitializeComponent();
        }

        private void buttonbuttonListOfDevices_Click(object sender, EventArgs e)
        {
            ListOfDevices newForm = new ListOfDevices();
            newForm.Show();
            Hide();
        }

        private void buttonListOfPatients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список пациентов пуст! Введите данные пациента");
            FormToAddNewPatient newForm = new FormToAddNewPatient();
            newForm.Show();
            Hide();
        }
    }
}
