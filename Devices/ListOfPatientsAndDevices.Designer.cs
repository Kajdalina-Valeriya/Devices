namespace Devices
{
    partial class ListOfPatientsAndDevices
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
            this.buttonListOfPatients = new System.Windows.Forms.Button();
            this.buttonbuttonListOfDevices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListOfPatients
            // 
            this.buttonListOfPatients.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonListOfPatients.Location = new System.Drawing.Point(283, 132);
            this.buttonListOfPatients.Name = "buttonListOfPatients";
            this.buttonListOfPatients.Size = new System.Drawing.Size(211, 54);
            this.buttonListOfPatients.TabIndex = 0;
            this.buttonListOfPatients.Text = "Список пациентов";
            this.buttonListOfPatients.UseVisualStyleBackColor = false;
            this.buttonListOfPatients.Click += new System.EventHandler(this.buttonListOfPatients_Click);
            // 
            // buttonbuttonListOfDevices
            // 
            this.buttonbuttonListOfDevices.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonbuttonListOfDevices.Location = new System.Drawing.Point(283, 240);
            this.buttonbuttonListOfDevices.Name = "buttonbuttonListOfDevices";
            this.buttonbuttonListOfDevices.Size = new System.Drawing.Size(211, 51);
            this.buttonbuttonListOfDevices.TabIndex = 1;
            this.buttonbuttonListOfDevices.Text = "Список устройств";
            this.buttonbuttonListOfDevices.UseVisualStyleBackColor = false;
            this.buttonbuttonListOfDevices.Click += new System.EventHandler(this.buttonbuttonListOfDevices_Click);
            // 
            // ListOfPatientsAndDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonbuttonListOfDevices);
            this.Controls.Add(this.buttonListOfPatients);
            this.Name = "ListOfPatientsAndDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfPatientsAndDevices";
            //this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListOfPatients;
        private System.Windows.Forms.Button buttonbuttonListOfDevices;
    }
}