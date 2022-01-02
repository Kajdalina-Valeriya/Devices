
namespace View
{
    partial class NewExaminationView
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
            this.dateOfExaminationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skinMoistureCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pressureCheckBox = new System.Windows.Forms.CheckBox();
            this.pulseCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typesOfMuscleLoading = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.listOfPatients = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.temperatureCheckBox = new System.Windows.Forms.CheckBox();
            this.electricalConductivityCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateOfExaminationTextBox
            // 
            this.dateOfExaminationTextBox.Location = new System.Drawing.Point(290, 424);
            this.dateOfExaminationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateOfExaminationTextBox.Name = "dateOfExaminationTextBox";
            this.dateOfExaminationTextBox.Size = new System.Drawing.Size(131, 26);
            this.dateOfExaminationTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Add date: ";
            // 
            // skinMoistureCheckBox
            // 
            this.skinMoistureCheckBox.AutoSize = true;
            this.skinMoistureCheckBox.Location = new System.Drawing.Point(446, 377);
            this.skinMoistureCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinMoistureCheckBox.Name = "skinMoistureCheckBox";
            this.skinMoistureCheckBox.Size = new System.Drawing.Size(131, 24);
            this.skinMoistureCheckBox.TabIndex = 20;
            this.skinMoistureCheckBox.Text = "Skin moisture";
            this.skinMoistureCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Choose list of physiologic monitoring: ";
            // 
            // pressureCheckBox
            // 
            this.pressureCheckBox.AutoSize = true;
            this.pressureCheckBox.Location = new System.Drawing.Point(446, 345);
            this.pressureCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressureCheckBox.Name = "pressureCheckBox";
            this.pressureCheckBox.Size = new System.Drawing.Size(98, 24);
            this.pressureCheckBox.TabIndex = 18;
            this.pressureCheckBox.Text = "Pressure";
            this.pressureCheckBox.UseVisualStyleBackColor = true;
            // 
            // pulseCheckBox
            // 
            this.pulseCheckBox.AutoSize = true;
            this.pulseCheckBox.Location = new System.Drawing.Point(290, 377);
            this.pulseCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pulseCheckBox.Name = "pulseCheckBox";
            this.pulseCheckBox.Size = new System.Drawing.Size(74, 24);
            this.pulseCheckBox.TabIndex = 17;
            this.pulseCheckBox.Text = "Pulse";
            this.pulseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select type of muscle loading: ";
            // 
            // typesOfMuscleLoading
            // 
            this.typesOfMuscleLoading.FormattingEnabled = true;
            this.typesOfMuscleLoading.Location = new System.Drawing.Point(290, 293);
            this.typesOfMuscleLoading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typesOfMuscleLoading.Name = "typesOfMuscleLoading";
            this.typesOfMuscleLoading.Size = new System.Drawing.Size(598, 28);
            this.typesOfMuscleLoading.TabIndex = 14;
            this.typesOfMuscleLoading.SelectedIndexChanged += new System.EventHandler(this.typesOfMuscleLoading_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.GhostWhite;
            this.backButton.Location = new System.Drawing.Point(142, 499);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 50);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listOfPatients
            // 
            this.listOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPatients.FormattingEnabled = true;
            this.listOfPatients.ItemHeight = 32;
            this.listOfPatients.Location = new System.Drawing.Point(290, 13);
            this.listOfPatients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listOfPatients.Name = "listOfPatients";
            this.listOfPatients.Size = new System.Drawing.Size(598, 260);
            this.listOfPatients.TabIndex = 25;
            this.listOfPatients.Tag = "test";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.GhostWhite;
            this.updateButton.Location = new System.Drawing.Point(16, 238);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(81, 35);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.GhostWhite;
            this.saveButton.Location = new System.Drawing.Point(636, 499);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 50);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // temperatureCheckBox
            // 
            this.temperatureCheckBox.AutoSize = true;
            this.temperatureCheckBox.Location = new System.Drawing.Point(290, 345);
            this.temperatureCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.temperatureCheckBox.Name = "temperatureCheckBox";
            this.temperatureCheckBox.Size = new System.Drawing.Size(126, 24);
            this.temperatureCheckBox.TabIndex = 29;
            this.temperatureCheckBox.Text = "Temperature";
            this.temperatureCheckBox.UseVisualStyleBackColor = true;
            this.temperatureCheckBox.CheckedChanged += new System.EventHandler(this.temperatureCheckBox_CheckedChanged);
            // 
            // electricalConductivityCheckBox
            // 
            this.electricalConductivityCheckBox.AutoSize = true;
            this.electricalConductivityCheckBox.Location = new System.Drawing.Point(616, 360);
            this.electricalConductivityCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.electricalConductivityCheckBox.Name = "electricalConductivityCheckBox";
            this.electricalConductivityCheckBox.Size = new System.Drawing.Size(185, 24);
            this.electricalConductivityCheckBox.TabIndex = 30;
            this.electricalConductivityCheckBox.Text = "Electrical conductivity";
            this.electricalConductivityCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Select patient:";
            // 
            // NewExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.electricalConductivityCheckBox);
            this.Controls.Add(this.temperatureCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.listOfPatients);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateOfExaminationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.skinMoistureCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pressureCheckBox);
            this.Controls.Add(this.pulseCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typesOfMuscleLoading);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewExaminationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewExaminationView";
            this.Load += new System.EventHandler(this.NewExaminationView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dateOfExaminationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox skinMoistureCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox pressureCheckBox;
        private System.Windows.Forms.CheckBox pulseCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typesOfMuscleLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listOfPatients;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox temperatureCheckBox;
        private System.Windows.Forms.CheckBox electricalConductivityCheckBox;
        private System.Windows.Forms.Label label5;
    }
}