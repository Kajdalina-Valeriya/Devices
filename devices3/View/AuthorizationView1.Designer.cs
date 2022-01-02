
namespace View
{
    partial class AuthorizationView1
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
            this.Administrator = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.BackColor = System.Drawing.Color.GhostWhite;
            this.Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Administrator.Location = new System.Drawing.Point(234, 123);
            this.Administrator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(390, 111);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = false;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Doctor
            // 
            this.Doctor.BackColor = System.Drawing.Color.GhostWhite;
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doctor.Location = new System.Drawing.Point(234, 304);
            this.Doctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(390, 111);
            this.Doctor.TabIndex = 1;
            this.Doctor.Text = "Doctor";
            this.Doctor.UseVisualStyleBackColor = false;
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Doctor.Text = "People";
            this.Administrator.Text = "Animals";
            // 
            // AuthorizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.Administrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorizationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Doctor;
        private System.Windows.Forms.Button button1;
    }
}

