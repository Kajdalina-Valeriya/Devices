
namespace View
{
    partial class MedicalExaminationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalExaminationView));
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ThermometerPic = new System.Windows.Forms.Button();
            this.PressurePic = new System.Windows.Forms.Button();
            this.SkinMoisturePic = new System.Windows.Forms.Button();
            this.PulsometerPic = new System.Windows.Forms.Button();
            this.ElectricalConductivityPic = new System.Windows.Forms.Button();
            this.diagnoseButton = new System.Windows.Forms.Button();
            this.hangSensorsButton = new System.Windows.Forms.Button();
            this.sturtButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(447, 13);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(628, 390);
            this.infoTextBox.TabIndex = 16;
            this.infoTextBox.TextChanged += new System.EventHandler(this.infoTextBox_TextChanged);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.GhostWhite;
            this.Update.Location = new System.Drawing.Point(722, 499);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(115, 68);
            this.Update.TabIndex = 30;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.GhostWhite;
            this.backButton.Location = new System.Drawing.Point(968, 499);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 68);
            this.backButton.TabIndex = 36;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // ThermometerPic
            // 
            this.ThermometerPic.Location = new System.Drawing.Point(160, 100);
            this.ThermometerPic.Name = "ThermometerPic";
            this.ThermometerPic.Size = new System.Drawing.Size(12, 15);
            this.ThermometerPic.TabIndex = 38;
            this.ThermometerPic.UseVisualStyleBackColor = true;
            this.ThermometerPic.Click += new System.EventHandler(this.ThermometerPic_Click);
            // 
            // PressurePic
            // 
            this.PressurePic.Location = new System.Drawing.Point(147, 235);
            this.PressurePic.Name = "PressurePic";
            this.PressurePic.Size = new System.Drawing.Size(13, 15);
            this.PressurePic.TabIndex = 39;
            this.PressurePic.UseVisualStyleBackColor = true;
            this.PressurePic.Click += new System.EventHandler(this.PressurePic_Click);
            // 
            // SkinMoisturePic
            // 
            this.SkinMoisturePic.Location = new System.Drawing.Point(339, 215);
            this.SkinMoisturePic.Name = "SkinMoisturePic";
            this.SkinMoisturePic.Size = new System.Drawing.Size(12, 11);
            this.SkinMoisturePic.TabIndex = 40;
            this.SkinMoisturePic.UseVisualStyleBackColor = true;
            this.SkinMoisturePic.Click += new System.EventHandler(this.SkinMoisturePic_Click);
            // 
            // PulsometerPic
            // 
            this.PulsometerPic.Location = new System.Drawing.Point(136, 424);
            this.PulsometerPic.Name = "PulsometerPic";
            this.PulsometerPic.Size = new System.Drawing.Size(10, 13);
            this.PulsometerPic.TabIndex = 41;
            this.PulsometerPic.UseVisualStyleBackColor = true;
            this.PulsometerPic.Click += new System.EventHandler(this.PulsometerPic_Click);
            // 
            // ElectricalConductivityPic
            // 
            this.ElectricalConductivityPic.Location = new System.Drawing.Point(323, 437);
            this.ElectricalConductivityPic.Name = "ElectricalConductivityPic";
            this.ElectricalConductivityPic.Size = new System.Drawing.Size(11, 14);
            this.ElectricalConductivityPic.TabIndex = 42;
            this.ElectricalConductivityPic.UseVisualStyleBackColor = true;
            this.ElectricalConductivityPic.Click += new System.EventHandler(this.ElectricalConductivityPic_Click);
            // 
            // diagnoseButton
            // 
            this.diagnoseButton.Location = new System.Drawing.Point(0, 0);
            this.diagnoseButton.Name = "diagnoseButton";
            this.diagnoseButton.Size = new System.Drawing.Size(75, 23);
            this.diagnoseButton.TabIndex = 45;
            // 
            // hangSensorsButton
            // 
            this.hangSensorsButton.Location = new System.Drawing.Point(0, 0);
            this.hangSensorsButton.Name = "hangSensorsButton";
            this.hangSensorsButton.Size = new System.Drawing.Size(75, 23);
            this.hangSensorsButton.TabIndex = 44;
            // 
            // sturtButton
            // 
            this.sturtButton.BackColor = System.Drawing.Color.GhostWhite;
            this.sturtButton.Location = new System.Drawing.Point(447, 499);
            this.sturtButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sturtButton.Name = "sturtButton";
            this.sturtButton.Size = new System.Drawing.Size(132, 68);
            this.sturtButton.TabIndex = 23;
            this.sturtButton.Text = "Start";
            this.sturtButton.UseVisualStyleBackColor = false;
            this.sturtButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MedicalExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1092, 761);
            this.Controls.Add(this.ElectricalConductivityPic);
            this.Controls.Add(this.PulsometerPic);
            this.Controls.Add(this.SkinMoisturePic);
            this.Controls.Add(this.PressurePic);
            this.Controls.Add(this.ThermometerPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hangSensorsButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.sturtButton);
            this.Controls.Add(this.diagnoseButton);
            this.Controls.Add(this.infoTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MedicalExaminationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalExaminationView";
            this.Load += new System.EventHandler(this.MedicalExaminationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ThermometerPic;
        private System.Windows.Forms.Button PressurePic;
        private System.Windows.Forms.Button SkinMoisturePic;
        private System.Windows.Forms.Button PulsometerPic;
        private System.Windows.Forms.Button ElectricalConductivityPic;
        private System.Windows.Forms.Button diagnoseButton;
        private System.Windows.Forms.Button hangSensorsButton;
        private System.Windows.Forms.Button sturtButton;
    }
}