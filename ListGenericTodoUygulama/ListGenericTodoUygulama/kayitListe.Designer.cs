namespace ListGenericTodoUygulama
{
    partial class kayitListe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpboxliste = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.btn_tumliste = new System.Windows.Forms.Button();
            this.btn_tamamlandi = new System.Windows.Forms.Button();
            this.btn_tamamlanamadi = new System.Windows.Forms.Button();
            this.btn_iptaledildi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpboxliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_iptaledildi);
            this.groupBox1.Controls.Add(this.btn_tamamlanamadi);
            this.groupBox1.Controls.Add(this.btn_tamamlandi);
            this.groupBox1.Controls.Add(this.btn_tumliste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // grpboxliste
            // 
            this.grpboxliste.Controls.Add(this.grdListe);
            this.grpboxliste.Location = new System.Drawing.Point(262, 12);
            this.grpboxliste.Name = "grpboxliste";
            this.grpboxliste.Size = new System.Drawing.Size(619, 426);
            this.grpboxliste.TabIndex = 0;
            this.grpboxliste.TabStop = false;
            this.grpboxliste.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.AllowUserToAddRows = false;
            this.grdListe.AllowUserToDeleteRows = false;
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 18);
            this.grdListe.Name = "grdListe";
            this.grdListe.ReadOnly = true;
            this.grdListe.RowHeadersWidth = 51;
            this.grdListe.RowTemplate.Height = 24;
            this.grdListe.Size = new System.Drawing.Size(613, 405);
            this.grdListe.TabIndex = 0;
            // 
            // btn_tumliste
            // 
            this.btn_tumliste.Location = new System.Drawing.Point(36, 63);
            this.btn_tumliste.Name = "btn_tumliste";
            this.btn_tumliste.Size = new System.Drawing.Size(158, 57);
            this.btn_tumliste.TabIndex = 0;
            this.btn_tumliste.Text = "Tüm Liste";
            this.btn_tumliste.UseVisualStyleBackColor = true;
            this.btn_tumliste.Click += new System.EventHandler(this.btn_tumliste_Click);
            // 
            // btn_tamamlandi
            // 
            this.btn_tamamlandi.Location = new System.Drawing.Point(36, 148);
            this.btn_tamamlandi.Name = "btn_tamamlandi";
            this.btn_tamamlandi.Size = new System.Drawing.Size(158, 57);
            this.btn_tamamlandi.TabIndex = 0;
            this.btn_tamamlandi.Text = "Tamamlandı";
            this.btn_tamamlandi.UseVisualStyleBackColor = true;
            this.btn_tamamlandi.Click += new System.EventHandler(this.btn_tamamlandi_Click);
            // 
            // btn_tamamlanamadi
            // 
            this.btn_tamamlanamadi.Location = new System.Drawing.Point(36, 235);
            this.btn_tamamlanamadi.Name = "btn_tamamlanamadi";
            this.btn_tamamlanamadi.Size = new System.Drawing.Size(158, 57);
            this.btn_tamamlanamadi.TabIndex = 0;
            this.btn_tamamlanamadi.Text = "Tamamlanamadı";
            this.btn_tamamlanamadi.UseVisualStyleBackColor = true;
            this.btn_tamamlanamadi.Click += new System.EventHandler(this.btn_tamamlanamadi_Click);
            // 
            // btn_iptaledildi
            // 
            this.btn_iptaledildi.Location = new System.Drawing.Point(36, 314);
            this.btn_iptaledildi.Name = "btn_iptaledildi";
            this.btn_iptaledildi.Size = new System.Drawing.Size(158, 57);
            this.btn_iptaledildi.TabIndex = 0;
            this.btn_iptaledildi.Text = "İptal Edildi";
            this.btn_iptaledildi.UseVisualStyleBackColor = true;
            this.btn_iptaledildi.Click += new System.EventHandler(this.btn_iptaledildi_Click);
            // 
            // kayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.grpboxliste);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Liste";
            this.Load += new System.EventHandler(this.kayitListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpboxliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxliste;
        private System.Windows.Forms.DataGridView grdListe;
        private System.Windows.Forms.Button btn_tumliste;
        private System.Windows.Forms.Button btn_tamamlanamadi;
        private System.Windows.Forms.Button btn_tamamlandi;
        private System.Windows.Forms.Button btn_iptaledildi;
    }
}