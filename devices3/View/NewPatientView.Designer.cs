
namespace View
{
    partial class NewPatientView
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
            this.saveButton = new System.Windows.Forms.Button();
            this.dateOfBirthLable = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.sexLable = new System.Windows.Forms.Label();
            this.surnameLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.femaleRadioBatton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.GhostWhite;
            this.saveButton.Location = new System.Drawing.Point(531, 418);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 70);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateOfBirthLable
            // 
            this.dateOfBirthLable.AutoSize = true;
            this.dateOfBirthLable.Location = new System.Drawing.Point(245, 324);
            this.dateOfBirthLable.Name = "dateOfBirthLable";
            this.dateOfBirthLable.Size = new System.Drawing.Size(101, 20);
            this.dateOfBirthLable.TabIndex = 29;
            this.dateOfBirthLable.Text = "Date of birth:";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(378, 318);
            this.dateOfBirthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(240, 26);
            this.dateOfBirthTextBox.TabIndex = 28;
            // 
            // sexLable
            // 
            this.sexLable.AutoSize = true;
            this.sexLable.Location = new System.Drawing.Point(245, 240);
            this.sexLable.Name = "sexLable";
            this.sexLable.Size = new System.Drawing.Size(44, 20);
            this.sexLable.TabIndex = 27;
            this.sexLable.Text = "Sex: ";
            // 
            // surnameLable
            // 
            this.surnameLable.AutoSize = true;
            this.surnameLable.Location = new System.Drawing.Point(245, 165);
            this.surnameLable.Name = "surnameLable";
            this.surnameLable.Size = new System.Drawing.Size(82, 20);
            this.surnameLable.TabIndex = 26;
            this.surnameLable.Text = "Surname: ";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Location = new System.Drawing.Point(245, 80);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(59, 20);
            this.nameLable.TabIndex = 25;
            this.nameLable.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(378, 75);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 26);
            this.nameTextBox.TabIndex = 24;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(378, 159);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(240, 26);
            this.surnameTextBox.TabIndex = 23;
            // 
            // femaleRadioBatton
            // 
            this.femaleRadioBatton.AutoSize = true;
            this.femaleRadioBatton.Location = new System.Drawing.Point(531, 240);
            this.femaleRadioBatton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRadioBatton.Name = "femaleRadioBatton";
            this.femaleRadioBatton.Size = new System.Drawing.Size(87, 24);
            this.femaleRadioBatton.TabIndex = 31;
            this.femaleRadioBatton.TabStop = true;
            this.femaleRadioBatton.Text = "Female";
            this.femaleRadioBatton.UseVisualStyleBackColor = true;
            this.femaleRadioBatton.CheckedChanged += new System.EventHandler(this.femaleRadioBatton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(378, 240);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(68, 24);
            this.maleRadioButton.TabIndex = 30;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.GhostWhite;
            this.backButton.Location = new System.Drawing.Point(249, 418);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(98, 70);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // NewPatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.femaleRadioBatton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.dateOfBirthLable);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.sexLable);
            this.Controls.Add(this.surnameLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewPatientView";
            this.Text = "NewPatient";
            this.Load += new System.EventHandler(this.NewPatientView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label dateOfBirthLable;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.Label sexLable;
        private System.Windows.Forms.Label surnameLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.RadioButton femaleRadioBatton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button backButton;
    }
}