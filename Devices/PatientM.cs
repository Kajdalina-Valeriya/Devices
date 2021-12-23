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
using Presentor.Presentors;


namespace Devices
{
    public partial class PatientM : Form
    {
        NewPatientPresentor presentor;
        public PatientM()
        {
            InitializeComponent();
            presentor = new NewPatientPresentor();
        }

        private void buttonOfSkinTemperature_Click(object sender, EventArgs e)
        {
            //
            //
            //    if()
            {
                MessageBox.Show("Датчик для измерения температуры кожи работает исправно");
               
            }
            //   else {
            //          MessageBox.Show("Датчик для измерения температуры кожи работает неисправно");
            //              break;
            //}
            //
        }

        private void buttonOfBloodPressure_Click(object sender, EventArgs e)
        {
            //
            //
            //    if()
            {
                MessageBox.Show("Датчик для измерения кровянного давления работает исправно");
               
            }
            //   else {
            //          MessageBox.Show("Датчик для измерения кровянного давления работает неисправно");
            //              break;
            //}
            //
        }

        private void buttonOfSkinMoisture_Click(object sender, EventArgs e)
        {
            //
            //
            //    if()
            {
                MessageBox.Show("Датчик для измерения влажности кожи работает исправно");
                
            }
            //   else {
            //          MessageBox.Show("Датчик для измерения влажности кожи работает неисправно");
            //              break;
            //}
            //
        }

        private void buttonOfHeartRate_Click(object sender, EventArgs e)
        {
            //
            //
            //    if()
            {
                MessageBox.Show("Датчик для измерения частоты пульса сердечного ритма работает исправно");
                
            }
            //   else {
            //          MessageBox.Show("Датчик для измерения частоты пульса сердечного ритма работает неисправно");
            //              break;
            //}
            //
        }

        private void buttonOfElectricalConductivity_Click(object sender, EventArgs e)
        {
            //
            //
            //    if()
            {
                MessageBox.Show("Датчик для измерения электрической проводимости кожи работает исправно");
                
            }
            //   else {
            //          MessageBox.Show("Датчик для измерения электрической проводимости кожи работает неисправно");
            //              break;
            //}
            //
        }

    }
}
