namespace Devices
{
    partial class ListOfDevices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOfBloodPressure = new System.Windows.Forms.Button();
            this.buttonOfSkinTemperature = new System.Windows.Forms.Button();
            this.buttonOfSkinMoisture = new System.Windows.Forms.Button();
            this.buttonOfElectricalConductivity = new System.Windows.Forms.Button();
            this.buttonOfHeartRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOfBloodPressure
            // 
            this.buttonOfBloodPressure.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonOfBloodPressure.Location = new System.Drawing.Point(291, 91);
            this.buttonOfBloodPressure.Name = "buttonOfBloodPressure";
            this.buttonOfBloodPressure.Size = new System.Drawing.Size(221, 43);
            this.buttonOfBloodPressure.TabIndex = 0;
            this.buttonOfBloodPressure.Text = "Кровянного давления";
            this.buttonOfBloodPressure.UseVisualStyleBackColor = false;
            this.buttonOfBloodPressure.Click += new System.EventHandler(this.buttonOfBloodPressure_Click);
            // 
            // buttonOfSkinTemperature
            // 
            this.buttonOfSkinTemperature.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonOfSkinTemperature.Location = new System.Drawing.Point(291, 160);
            this.buttonOfSkinTemperature.Name = "buttonOfSkinTemperature";
            this.buttonOfSkinTemperature.Size = new System.Drawing.Size(221, 38);
            this.buttonOfSkinTemperature.TabIndex = 1;
            this.buttonOfSkinTemperature.Text = "Температуры кожи";
            this.buttonOfSkinTemperature.UseVisualStyleBackColor = false;
            this.buttonOfSkinTemperature.Click += new System.EventHandler(this.buttonOfSkinTemperature_Click);
            // 
            // buttonOfSkinMoisture
            // 
            this.buttonOfSkinMoisture.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonOfSkinMoisture.Location = new System.Drawing.Point(291, 229);
            this.buttonOfSkinMoisture.Name = "buttonOfSkinMoisture";
            this.buttonOfSkinMoisture.Size = new System.Drawing.Size(221, 38);
            this.buttonOfSkinMoisture.TabIndex = 2;
            this.buttonOfSkinMoisture.Text = "Влажности кожи";
            this.buttonOfSkinMoisture.UseVisualStyleBackColor = false;
            this.buttonOfSkinMoisture.Click += new System.EventHandler(this.buttonOfSkinMoisture_Click);
            // 
            // buttonOfElectricalConductivity
            // 
            this.buttonOfElectricalConductivity.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonOfElectricalConductivity.Location = new System.Drawing.Point(291, 294);
            this.buttonOfElectricalConductivity.Name = "buttonOfElectricalConductivity";
            this.buttonOfElectricalConductivity.Size = new System.Drawing.Size(221, 49);
            this.buttonOfElectricalConductivity.TabIndex = 3;
            this.buttonOfElectricalConductivity.Text = "Электрической проводимости кожи";
            this.buttonOfElectricalConductivity.UseVisualStyleBackColor = false;
            this.buttonOfElectricalConductivity.Click += new System.EventHandler(this.buttonOfElectricalConductivity_Click);
            // 
            // buttonOfHeartRate
            // 
            this.buttonOfHeartRate.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonOfHeartRate.Location = new System.Drawing.Point(291, 358);
            this.buttonOfHeartRate.Name = "buttonOfHeartRate";
            this.buttonOfHeartRate.Size = new System.Drawing.Size(221, 37);
            this.buttonOfHeartRate.TabIndex = 4;
            this.buttonOfHeartRate.Text = "Частоты пульса сердечного ритма";
            this.buttonOfHeartRate.UseVisualStyleBackColor = false;
            this.buttonOfHeartRate.Click += new System.EventHandler(this.buttonOfHeartRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Устройства для измерения:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Location = new System.Drawing.Point(23, 402);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 36);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ListOfDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOfHeartRate);
            this.Controls.Add(this.buttonOfElectricalConductivity);
            this.Controls.Add(this.buttonOfSkinMoisture);
            this.Controls.Add(this.buttonOfSkinTemperature);
            this.Controls.Add(this.buttonOfBloodPressure);
            this.Name = "ListOfDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfDevices";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOfBloodPressure;
        private System.Windows.Forms.Button buttonOfSkinTemperature;
        private System.Windows.Forms.Button buttonOfSkinMoisture;
        private System.Windows.Forms.Button buttonOfElectricalConductivity;
        private System.Windows.Forms.Button buttonOfHeartRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}