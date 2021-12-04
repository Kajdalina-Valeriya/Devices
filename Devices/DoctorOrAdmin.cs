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
    
    public partial class DoctorOrAdmin : Form
    {
        bool flag = true;
        public DoctorOrAdmin()
        {
            InitializeComponent();
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            ListOfPatientsAndDevices newForm = new ListOfPatientsAndDevices(this);
            newForm.Show();
            Hide();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            flag = false;
            ListOfPatients newForm = new ListOfPatients();//flag);
            newForm.Show();
            Hide();
        }
    }
}
