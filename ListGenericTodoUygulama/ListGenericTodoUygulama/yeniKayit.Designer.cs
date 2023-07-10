namespace ListGenericTodoUygulama
{
    partial class yeniKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kisaAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_derece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık :";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(120, 44);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(225, 22);
            this.txt_baslik.TabIndex = 1;
            this.txt_baslik.Enter += new System.EventHandler(this.txt_baslik_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kısa Açıklama";
            // 
            // txt_kisaAciklama
            // 
            this.txt_kisaAciklama.Location = new System.Drawing.Point(120, 84);
            this.txt_kisaAciklama.Multiline = true;
            this.txt_kisaAciklama.Name = "txt_kisaAciklama";
            this.txt_kisaAciklama.Size = new System.Drawing.Size(225, 68);
            this.txt_kisaAciklama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama :";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(120, 179);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(225, 68);
            this.txt_aciklama.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Önem Derecesi :";
            // 
            // txt_derece
            // 
            this.txt_derece.Location = new System.Drawing.Point(120, 269);
            this.txt_derece.Name = "txt_derece";
            this.txt_derece.Size = new System.Drawing.Size(225, 22);
            this.txt_derece.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Durum :";
            // 
            // cmb_durum
            // 
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal Edildi",
            "Ertelendi"});
            this.cmb_durum.Location = new System.Drawing.Point(120, 307);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(225, 24);
            this.cmb_durum.TabIndex = 2;
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Location = new System.Drawing.Point(158, 352);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(148, 47);
            this.btn_yenikayit.TabIndex = 3;
            this.btn_yenikayit.Text = "Yeni Kayıt";
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.btn_yenikayit_Click);
            // 
            // yeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.btn_yenikayit);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kisaAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_derece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yeniKayit";
            this.Text = "Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kisaAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_derece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_durum;
        private System.Windows.Forms.Button btn_yenikayit;
    }
}