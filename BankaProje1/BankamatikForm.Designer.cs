namespace BankaProje1
{
    partial class BankamatikForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbBakiye = new System.Windows.Forms.TextBox();
            this.btnYatir10TL = new System.Windows.Forms.Button();
            this.btnYatir50TL = new System.Windows.Forms.Button();
            this.btnYatir20TL = new System.Windows.Forms.Button();
            this.btnCek20TL = new System.Windows.Forms.Button();
            this.btnCek50TL = new System.Windows.Forms.Button();
            this.btnCek10TL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBakiye
            // 
            this.tbBakiye.Location = new System.Drawing.Point(12, 12);
            this.tbBakiye.Name = "tbBakiye";
            this.tbBakiye.Size = new System.Drawing.Size(264, 26);
            this.tbBakiye.TabIndex = 0;
            // 
            // btnYatir10TL
            // 
            this.btnYatir10TL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnYatir10TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatir10TL.Location = new System.Drawing.Point(12, 54);
            this.btnYatir10TL.Name = "btnYatir10TL";
            this.btnYatir10TL.Size = new System.Drawing.Size(78, 75);
            this.btnYatir10TL.TabIndex = 1;
            this.btnYatir10TL.Text = "10 TL Yatır";
            this.btnYatir10TL.UseVisualStyleBackColor = false;
            this.btnYatir10TL.Click += new System.EventHandler(this.btnYatir10TL_Click);
            // 
            // btnYatir50TL
            // 
            this.btnYatir50TL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnYatir50TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatir50TL.Location = new System.Drawing.Point(198, 54);
            this.btnYatir50TL.Name = "btnYatir50TL";
            this.btnYatir50TL.Size = new System.Drawing.Size(78, 75);
            this.btnYatir50TL.TabIndex = 2;
            this.btnYatir50TL.Text = "50 TL Yatır";
            this.btnYatir50TL.UseVisualStyleBackColor = false;
            this.btnYatir50TL.Click += new System.EventHandler(this.btnYatir50TL_Click);
            // 
            // btnYatir20TL
            // 
            this.btnYatir20TL.BackColor = System.Drawing.Color.PaleGreen;
            this.btnYatir20TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatir20TL.Location = new System.Drawing.Point(105, 54);
            this.btnYatir20TL.Name = "btnYatir20TL";
            this.btnYatir20TL.Size = new System.Drawing.Size(78, 75);
            this.btnYatir20TL.TabIndex = 3;
            this.btnYatir20TL.Text = "20 TL Yatır";
            this.btnYatir20TL.UseVisualStyleBackColor = false;
            this.btnYatir20TL.Click += new System.EventHandler(this.Yatir20TL);
            // 
            // btnCek20TL
            // 
            this.btnCek20TL.BackColor = System.Drawing.Color.Cyan;
            this.btnCek20TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek20TL.Location = new System.Drawing.Point(105, 148);
            this.btnCek20TL.Name = "btnCek20TL";
            this.btnCek20TL.Size = new System.Drawing.Size(78, 75);
            this.btnCek20TL.TabIndex = 6;
            this.btnCek20TL.Text = "20 TL Çek";
            this.btnCek20TL.UseVisualStyleBackColor = false;
            // 
            // btnCek50TL
            // 
            this.btnCek50TL.BackColor = System.Drawing.Color.Cyan;
            this.btnCek50TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek50TL.Location = new System.Drawing.Point(198, 148);
            this.btnCek50TL.Name = "btnCek50TL";
            this.btnCek50TL.Size = new System.Drawing.Size(78, 75);
            this.btnCek50TL.TabIndex = 5;
            this.btnCek50TL.Text = "50 TL Çek";
            this.btnCek50TL.UseVisualStyleBackColor = false;
            // 
            // btnCek10TL
            // 
            this.btnCek10TL.BackColor = System.Drawing.Color.Cyan;
            this.btnCek10TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCek10TL.Location = new System.Drawing.Point(12, 148);
            this.btnCek10TL.Name = "btnCek10TL";
            this.btnCek10TL.Size = new System.Drawing.Size(78, 75);
            this.btnCek10TL.TabIndex = 4;
            this.btnCek10TL.Text = "10 TL Çek";
            this.btnCek10TL.UseVisualStyleBackColor = false;
            // 
            // BankamatikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(285, 233);
            this.Controls.Add(this.btnCek20TL);
            this.Controls.Add(this.btnCek50TL);
            this.Controls.Add(this.btnCek10TL);
            this.Controls.Add(this.btnYatir20TL);
            this.Controls.Add(this.btnYatir50TL);
            this.Controls.Add(this.btnYatir10TL);
            this.Controls.Add(this.tbBakiye);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BankamatikForm";
            this.Text = "Bankamatik Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBakiye;
        private System.Windows.Forms.Button btnYatir10TL;
        private System.Windows.Forms.Button btnYatir50TL;
        private System.Windows.Forms.Button btnYatir20TL;
        private System.Windows.Forms.Button btnCek20TL;
        private System.Windows.Forms.Button btnCek50TL;
        private System.Windows.Forms.Button btnCek10TL;
    }
}

