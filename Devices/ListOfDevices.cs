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
    public partial class ListOfDevices : Form
    {
        public ListOfDevices()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ListOfPatientsAndDevices newForm = new ListOfPatientsAndDevices();
            newForm.Show();
            Hide();
        }

        private void buttonOfBloodPressure_Click(object sender, EventArgs e)
        {

        }

        private void buttonOfSkinTemperature_Click(object sender, EventArgs e)
        {

        }

        private void buttonOfSkinMoisture_Click(object sender, EventArgs e)
        {

        }

        private void buttonOfElectricalConductivity_Click(object sender, EventArgs e)
        {

        }

        private void buttonOfHeartRate_Click(object sender, EventArgs e)
        {

        }
    }
}
