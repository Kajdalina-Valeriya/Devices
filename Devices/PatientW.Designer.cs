namespace Devices
{
    partial class PatientW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientW));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOfSkinTemperature = new System.Windows.Forms.Button();
            this.buttonOfBloodPressure = new System.Windows.Forms.Button();
            this.buttonOfElectricalConductivity = new System.Windows.Forms.Button();
            this.buttonOfSkinMoisture = new System.Windows.Forms.Button();
            this.buttonOfHeartRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 636);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOfSkinTemperature
            // 
            this.buttonOfSkinTemperature.Location = new System.Drawing.Point(158, 84);
            this.buttonOfSkinTemperature.Name = "buttonOfSkinTemperature";
            this.buttonOfSkinTemperature.Size = new System.Drawing.Size(75, 126);
            this.buttonOfSkinTemperature.TabIndex = 3;
            this.buttonOfSkinTemperature.UseVisualStyleBackColor = true;
            this.buttonOfSkinTemperature.Visible = false;
            this.buttonOfSkinTemperature.Click += new System.EventHandler(this.buttonOfSkinTemperature_Click);
            // 
            // buttonOfBloodPressure
            // 
            this.buttonOfBloodPressure.Location = new System.Drawing.Point(68, 326);
            this.buttonOfBloodPressure.Name = "buttonOfBloodPressure";
            this.buttonOfBloodPressure.Size = new System.Drawing.Size(125, 142);
            this.buttonOfBloodPressure.TabIndex = 4;
            this.buttonOfBloodPressure.UseVisualStyleBackColor = true;
            this.buttonOfBloodPressure.Visible = false;
            this.buttonOfBloodPressure.Click += new System.EventHandler(this.buttonOfBloodPressure_Click);
            // 
            // buttonOfElectricalConductivity
            // 
            this.buttonOfElectricalConductivity.Location = new System.Drawing.Point(532, 305);
            this.buttonOfElectricalConductivity.Name = "buttonOfElectricalConductivity";
            this.buttonOfElectricalConductivity.Size = new System.Drawing.Size(75, 81);
            this.buttonOfElectricalConductivity.TabIndex = 5;
            this.buttonOfElectricalConductivity.UseVisualStyleBackColor = true;
            this.buttonOfElectricalConductivity.Visible = false;
            this.buttonOfElectricalConductivity.Click += new System.EventHandler(this.buttonOfElectricalConductivity_Click);
            // 
            // buttonOfSkinMoisture
            // 
            this.buttonOfSkinMoisture.Location = new System.Drawing.Point(421, 206);
            this.buttonOfSkinMoisture.Name = "buttonOfSkinMoisture";
            this.buttonOfSkinMoisture.Size = new System.Drawing.Size(61, 60);
            this.buttonOfSkinMoisture.TabIndex = 6;
            this.buttonOfSkinMoisture.UseVisualStyleBackColor = true;
            this.buttonOfSkinMoisture.Visible = false;
            this.buttonOfSkinMoisture.Click += new System.EventHandler(this.buttonOfSkinMoisture_Click);
            // 
            // buttonOfHeartRate
            // 
            this.buttonOfHeartRate.Location = new System.Drawing.Point(254, 531);
            this.buttonOfHeartRate.Name = "buttonOfHeartRate";
            this.buttonOfHeartRate.Size = new System.Drawing.Size(63, 57);
            this.buttonOfHeartRate.TabIndex = 7;
            this.buttonOfHeartRate.UseVisualStyleBackColor = true;
            this.buttonOfHeartRate.Visible = false;
            this.buttonOfHeartRate.Click += new System.EventHandler(this.buttonOfHeartRate_Click);
            // 
            // PatientW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(750, 632);
            this.Controls.Add(this.buttonOfHeartRate);
            this.Controls.Add(this.buttonOfSkinMoisture);
            this.Controls.Add(this.buttonOfElectricalConductivity);
            this.Controls.Add(this.buttonOfBloodPressure);
            this.Controls.Add(this.buttonOfSkinTemperature);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PatientW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOfSkinTemperature;
        private System.Windows.Forms.Button buttonOfBloodPressure;
        private System.Windows.Forms.Button buttonOfElectricalConductivity;
        private System.Windows.Forms.Button buttonOfSkinMoisture;
        private System.Windows.Forms.Button buttonOfHeartRate;
    }
}