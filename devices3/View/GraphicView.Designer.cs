
namespace View
{
    partial class GraphicView
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
            this.Grafic = new System.Windows.Forms.PictureBox();
            this.buttonGraf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grafic)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafic
            // 
            this.Grafic.BackColor = System.Drawing.Color.GhostWhite;
            this.Grafic.Location = new System.Drawing.Point(12, 24);
            this.Grafic.Name = "Grafic";
            this.Grafic.Size = new System.Drawing.Size(876, 434);
            this.Grafic.TabIndex = 0;
            this.Grafic.TabStop = false;
            // 
            // buttonGraf
            // 
            this.buttonGraf.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonGraf.Location = new System.Drawing.Point(386, 493);
            this.buttonGraf.Name = "buttonGraf";
            this.buttonGraf.Size = new System.Drawing.Size(139, 42);
            this.buttonGraf.TabIndex = 1;
            this.buttonGraf.Text = "Check results";
            this.buttonGraf.UseVisualStyleBackColor = false;
            this.buttonGraf.Click += new System.EventHandler(this.buttonGraf_Click);
            // 
            // GraphicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.buttonGraf);
            this.Controls.Add(this.Grafic);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GraphicView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicView";
            this.Load += new System.EventHandler(this.GraphicView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Grafic;
        private System.Windows.Forms.Button buttonGraf;
    }
}