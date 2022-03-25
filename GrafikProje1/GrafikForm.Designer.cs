namespace GrafikProje1
{
    partial class GrafikForm
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
            this.SuspendLayout();
            // 
            // GrafikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GrafikForm";
            this.Text = "Grafik Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GrafikForm_FormClosing);
            this.Load += new System.EventHandler(this.GrafikForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GrafikForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GrafikForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GrafikForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GrafikForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

