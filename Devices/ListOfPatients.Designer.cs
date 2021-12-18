namespace Devices
{
    partial class ListOfPatients
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
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.buttonScheduleAnExamination = new System.Windows.Forms.Button();
            this.buttonCheckAnExamination = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonNewPatient = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonDeletePatient.Location = new System.Drawing.Point(12, 367);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(153, 71);
            this.buttonDeletePatient.TabIndex = 0;
            this.buttonDeletePatient.Text = "Удалить пациента";
            this.buttonDeletePatient.UseVisualStyleBackColor = false;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAddPatient.Location = new System.Drawing.Point(229, 367);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(153, 71);
            this.buttonAddPatient.TabIndex = 1;
            this.buttonAddPatient.Text = "Добавить пациента";
            this.buttonAddPatient.UseVisualStyleBackColor = false;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonScheduleAnExamination
            // 
            this.buttonScheduleAnExamination.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonScheduleAnExamination.Location = new System.Drawing.Point(441, 367);
            this.buttonScheduleAnExamination.Name = "buttonScheduleAnExamination";
            this.buttonScheduleAnExamination.Size = new System.Drawing.Size(153, 71);
            this.buttonScheduleAnExamination.TabIndex = 2;
            this.buttonScheduleAnExamination.Text = "Назначить обследование";
            this.buttonScheduleAnExamination.UseVisualStyleBackColor = false;
            this.buttonScheduleAnExamination.Click += new System.EventHandler(this.buttonScheduleAnExamination_Click);
            // 
            // buttonCheckAnExamination
            // 
            this.buttonCheckAnExamination.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonCheckAnExamination.Location = new System.Drawing.Point(635, 367);
            this.buttonCheckAnExamination.Name = "buttonCheckAnExamination";
            this.buttonCheckAnExamination.Size = new System.Drawing.Size(153, 71);
            this.buttonCheckAnExamination.TabIndex = 3;
            this.buttonCheckAnExamination.Text = "Просмотреть текущее обследование";
            this.buttonCheckAnExamination.UseVisualStyleBackColor = false;
            this.buttonCheckAnExamination.Click += new System.EventHandler(this.buttonCheckAnExamination_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 346);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // radioButtonNewPatient
            // 
            this.radioButtonNewPatient.AutoSize = true;
            this.radioButtonNewPatient.Location = new System.Drawing.Point(12, 25);
            this.radioButtonNewPatient.Name = "radioButtonNewPatient";
            this.radioButtonNewPatient.Size = new System.Drawing.Size(278, 24);
            this.radioButtonNewPatient.TabIndex = 5;
            this.radioButtonNewPatient.TabStop = true;
            this.radioButtonNewPatient.Text = "Кайдалина Валерия Андреевна";
            this.radioButtonNewPatient.UseVisualStyleBackColor = true;
            this.radioButtonNewPatient.CheckedChanged += new System.EventHandler(this.radioButtonNewPatient_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(21, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(21, 20);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ListOfPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButtonNewPatient);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonCheckAnExamination);
            this.Controls.Add(this.buttonScheduleAnExamination);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.buttonDeletePatient);
            this.Name = "ListOfPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfPatients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button buttonScheduleAnExamination;
        private System.Windows.Forms.Button buttonCheckAnExamination;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonNewPatient;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}