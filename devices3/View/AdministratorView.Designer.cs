
namespace View
{
    partial class AdministratorView
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
            this.newExaminationButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.showTheResult = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.listOfPatients = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newExaminationButton
            // 
            this.newExaminationButton.BackColor = System.Drawing.Color.GhostWhite;
            this.newExaminationButton.Location = new System.Drawing.Point(397, 648);
            this.newExaminationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newExaminationButton.Name = "newExaminationButton";
            this.newExaminationButton.Size = new System.Drawing.Size(158, 88);
            this.newExaminationButton.TabIndex = 12;
            this.newExaminationButton.Text = "New examination";
            this.newExaminationButton.UseVisualStyleBackColor = false;
            this.newExaminationButton.Click += new System.EventHandler(this.newExaminationButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.BackColor = System.Drawing.Color.GhostWhite;
            this.newPatientButton.Location = new System.Drawing.Point(619, 648);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(158, 88);
            this.newPatientButton.TabIndex = 13;
            this.newPatientButton.Text = "New patient";
            this.newPatientButton.UseVisualStyleBackColor = false;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // showTheResult
            // 
            this.showTheResult.BackColor = System.Drawing.Color.GhostWhite;
            this.showTheResult.Location = new System.Drawing.Point(837, 648);
            this.showTheResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showTheResult.Name = "showTheResult";
            this.showTheResult.Size = new System.Drawing.Size(158, 88);
            this.showTheResult.TabIndex = 14;
            this.showTheResult.Text = "Show the result";
            this.showTheResult.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.GhostWhite;
            this.Update.Location = new System.Drawing.Point(202, 648);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(109, 88);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // listOfPatients
            // 
            this.listOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPatients.FormattingEnabled = true;
            this.listOfPatients.ItemHeight = 32;
            this.listOfPatients.Location = new System.Drawing.Point(0, 39);
            this.listOfPatients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listOfPatients.Name = "listOfPatients";
            this.listOfPatients.Size = new System.Drawing.Size(1051, 580);
            this.listOfPatients.TabIndex = 16;
            this.listOfPatients.Tag = "test";
            this.listOfPatients.SelectedIndexChanged += new System.EventHandler(this.listOfPatients_SelectedIndexChanged_1);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.GhostWhite;
            this.BackButton.Location = new System.Drawing.Point(29, 648);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(107, 88);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1052, 781);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.listOfPatients);
            this.Controls.Add(this.showTheResult);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.newExaminationButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministratorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newExaminationButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button showTheResult;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ListBox listOfPatients;
        private System.Windows.Forms.Button BackButton;
    }
}