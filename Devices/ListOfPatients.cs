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
    public partial class ListOfPatients : Form
    {
       
        public ListOfPatients(bool flag)
        {
            InitializeComponent();
            if (flag == false)
                buttonScheduleAnExamination.Enabled = false;
            else 
                buttonScheduleAnExamination.Enabled = true;
            
        }

        private void buttonScheduleAnExamination_Click(object sender, EventArgs e)
        {
            ListOfExaminations newForm = new ListOfExaminations();
            newForm.Show();
            Hide();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            FormToAddNewPatient newForm = new FormToAddNewPatient();
            newForm.Show();
            Hide();
        }

        private void radioButtonNewPatient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonCheckAnExamination_Click(object sender, EventArgs e)
        {
            //if (patientm == true)
            //{
                PatientM newForm = new PatientM();
                newForm.Show();
                Hide();
            //}
            //else
            //{
            //    PatientW newForm = new PatientW();
            //    newForm.Show();
            //    Hide();
            //}
        }
    }
}
