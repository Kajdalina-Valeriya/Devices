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
   
    public partial class ListOfExaminations : Form
    {
        public ListOfExaminations()
        {
            InitializeComponent();
        }

        private void buttonAssign_Click(object sender, EventArgs e)
        {
            ListOfPatients newForm = new ListOfPatients();
            newForm.Show();
            Hide();
        }

        private void checkedListBoxExaminations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
