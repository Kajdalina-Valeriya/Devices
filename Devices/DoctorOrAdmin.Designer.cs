namespace Devices
{
    partial class DoctorOrAdmin
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
            this.buttonDoctor = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoctor
            // 
            this.buttonDoctor.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonDoctor.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoctor.Location = new System.Drawing.Point(302, 143);
            this.buttonDoctor.Name = "buttonDoctor";
            this.buttonDoctor.Size = new System.Drawing.Size(237, 49);
            this.buttonDoctor.TabIndex = 0;
            this.buttonDoctor.Text = "Доктор";
            this.buttonDoctor.UseVisualStyleBackColor = false;
            this.buttonDoctor.Click += new System.EventHandler(this.buttonDoctor_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonAdmin.Font = new System.Drawing.Font("Old English Text MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Location = new System.Drawing.Point(302, 270);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(237, 51);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Администратор";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // DoctorOrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonDoctor);
            this.Name = "DoctorOrAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorOrAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Button buttonAdmin;
    }
}

