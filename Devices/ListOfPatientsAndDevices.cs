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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public ListOfPatientsAndDevices(DoctorOrAdmin f)
        {
            InitializeComponent();
        }

        private void buttonbuttonListOfDevices_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Hide();
        }

        private void buttonListOfPatients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список пациентов пуст! Введите данные пациента");
            Form4 newForm = new Form4();
            newForm.Show();
            Hide();
        }
    }
}
