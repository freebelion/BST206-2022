namespace ListeProje1
{
    partial class ListeForm
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
            this.tbEleman = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbEleman
            // 
            this.tbEleman.BackColor = System.Drawing.Color.PeachPuff;
            this.tbEleman.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEleman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEleman.Location = new System.Drawing.Point(0, 0);
            this.tbEleman.Name = "tbEleman";
            this.tbEleman.Size = new System.Drawing.Size(240, 29);
            this.tbEleman.TabIndex = 0;
            this.tbEleman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEleman_KeyDown);
            // 
            // lbListe
            // 
            this.lbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 24;
            this.lbListe.Items.AddRange(new object[] {
            "Recai",
            "Sezai",
            "Mesai",
            "Dubai",
            "Nevai"});
            this.lbListe.Location = new System.Drawing.Point(0, 29);
            this.lbListe.Name = "lbListe";
            this.lbListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbListe.Size = new System.Drawing.Size(240, 277);
            this.lbListe.TabIndex = 1;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            this.lbListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListeKutusu_TusaBasildi);
            // 
            // ListeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(240, 306);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.tbEleman);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ListeForm";
            this.Text = "Liste Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEleman;
        private System.Windows.Forms.ListBox lbListe;
    }
}

