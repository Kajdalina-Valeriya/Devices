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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Список пациентов пуст! Введите данные пациента");
            Form4 newForm = new Form4();
            newForm.Show();
            Hide();
        }
    }
}
