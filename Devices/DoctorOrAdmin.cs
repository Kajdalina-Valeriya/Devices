using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentor.Presentors;
using Presentor.Interfaces;
using Presentor;

namespace Devices
{
    
    public partial class DoctorOrAdmin : Form, IView
    {
        //private AdministratorPresentor administratorPresentor;
        //private NewExaminationPresentor examinationPresentor = new NewExaminationPresentor(new NewExaminationView());
        //private NewPatientPresentor patientPresentor = new NewPatientPresentor(new NewPatientView());
        bool flag = true;
        public DoctorOrAdmin()
        {
            InitializeComponent();
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            ListOfPatientsAndDevices newForm = new ListOfPatientsAndDevices();
            newForm.Show();
            Hide();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            flag = false;
            ListOfPatients newForm = new ListOfPatients(this.flag);
            newForm.Show();
            Hide();
        }
    }
}
