using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentor;

namespace View
{
    public partial class AuthorizationView1 : Form
    {
        AdministratorPresentor administratorPresentor = new AdministratorPresentor(new AdministratorView());
        DoctorPresentor doctorPresentor = new DoctorPresentor(new DoctorView());
        

        public AuthorizationView1()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            
        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            administratorPresentor.ShowView();
            //Hide();
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
           doctorPresentor.ShowView();
          // Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {

            this.Refresh();
            //Doctor.Enabled = false;
            //Administrator.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Doctor.Text = "People";
            this.Administrator.Text = "Animals";
        }
    }
}
