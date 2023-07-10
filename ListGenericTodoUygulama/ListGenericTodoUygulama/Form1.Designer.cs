namespace ListGenericTodoUygulama
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlIslemListesi = new System.Windows.Forms.Panel();
            this.grpBoxIslemListe = new System.Windows.Forms.GroupBox();
            this.btn_YeniKayit = new System.Windows.Forms.Button();
            this.btn_kayitliste = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblzaman = new System.Windows.Forms.Label();
            this.tm_zamanla = new System.Windows.Forms.Timer(this.components);
            this.pnlIslemListesi.SuspendLayout();
            this.grpBoxIslemListe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIslemListesi
            // 
            this.pnlIslemListesi.Controls.Add(this.grpBoxIslemListe);
            this.pnlIslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlIslemListesi.Name = "pnlIslemListesi";
            this.pnlIslemListesi.Size = new System.Drawing.Size(200, 541);
            this.pnlIslemListesi.TabIndex = 1;
            // 
            // grpBoxIslemListe
            // 
            this.grpBoxIslemListe.Controls.Add(this.btn_kapat);
            this.grpBoxIslemListe.Controls.Add(this.btn_kayitliste);
            this.grpBoxIslemListe.Controls.Add(this.btn_YeniKayit);
            this.grpBoxIslemListe.Location = new System.Drawing.Point(3, 117);
            this.grpBoxIslemListe.Name = "grpBoxIslemListe";
            this.grpBoxIslemListe.Size = new System.Drawing.Size(194, 168);
            this.grpBoxIslemListe.TabIndex = 0;
            this.grpBoxIslemListe.TabStop = false;
            this.grpBoxIslemListe.Text = "İşlem Listesi";
            // 
            // btn_YeniKayit
            // 
            this.btn_YeniKayit.Location = new System.Drawing.Point(10, 34);
            this.btn_YeniKayit.Name = "btn_YeniKayit";
            this.btn_YeniKayit.Size = new System.Drawing.Size(178, 23);
            this.btn_YeniKayit.TabIndex = 0;
            this.btn_YeniKayit.Text = "Yeni Kayıt";
            this.btn_YeniKayit.UseVisualStyleBackColor = true;
            this.btn_YeniKayit.Click += new System.EventHandler(this.btn_YeniKayit_Click);
            // 
            // btn_kayitliste
            // 
            this.btn_kayitliste.Location = new System.Drawing.Point(10, 73);
            this.btn_kayitliste.Name = "btn_kayitliste";
            this.btn_kayitliste.Size = new System.Drawing.Size(178, 23);
            this.btn_kayitliste.TabIndex = 0;
            this.btn_kayitliste.Text = "Kayıt Listele";
            this.btn_kayitliste.UseVisualStyleBackColor = true;
            this.btn_kayitliste.Click += new System.EventHandler(this.btn_kayitliste_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(9, 115);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(178, 23);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblzaman);
            this.panel1.Location = new System.Drawing.Point(1079, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.Location = new System.Drawing.Point(51, 45);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(103, 16);
            this.lblzaman.TabIndex = 3;
            this.lblzaman.Text = "10.07.2023 12.38";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlIslemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIslemListesi.ResumeLayout(false);
            this.grpBoxIslemListe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIslemListesi;
        private System.Windows.Forms.GroupBox grpBoxIslemListe;
        private System.Windows.Forms.Button btn_YeniKayit;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_kayitliste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Timer tm_zamanla;
    }
}

