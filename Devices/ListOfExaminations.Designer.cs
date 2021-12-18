namespace Devices
{
    partial class ListOfExaminations
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
            this.buttonAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxExaminations = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonAssign
            // 
            this.buttonAssign.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAssign.Location = new System.Drawing.Point(345, 381);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(125, 36);
            this.buttonAssign.TabIndex = 3;
            this.buttonAssign.Text = "Назначить";
            this.buttonAssign.UseVisualStyleBackColor = false;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Упражнения";
            // 
            // checkedListBoxExaminations
            // 
            this.checkedListBoxExaminations.BackColor = System.Drawing.Color.GhostWhite;
            this.checkedListBoxExaminations.FormattingEnabled = true;
            this.checkedListBoxExaminations.Items.AddRange(new object[] {
            "Бег",
            "Ходьба",
            "Силовые",
            "Прыжки",
            "Вело"});
            this.checkedListBoxExaminations.Location = new System.Drawing.Point(186, 94);
            this.checkedListBoxExaminations.Name = "checkedListBoxExaminations";
            this.checkedListBoxExaminations.Size = new System.Drawing.Size(441, 257);
            this.checkedListBoxExaminations.TabIndex = 6;
            this.checkedListBoxExaminations.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxExaminations_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(392, 138);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(392, 160);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker4.TabIndex = 10;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(392, 180);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // ListOfExaminations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBoxExaminations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAssign);
            this.Name = "ListOfExaminations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfExaminations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxExaminations;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
    }
}