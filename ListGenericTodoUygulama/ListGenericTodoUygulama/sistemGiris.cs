using ListGenericTodoUygulama.businessService;
using ListGenericTodoUygulama.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListGenericTodoUygulama
{
    public partial class sistemGiris : Form
    {
        public sistemGiris()
        {
            InitializeComponent();
        }

        private void txt_kullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;

        }

        private void txt_kullaniciadi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kullaniciadi.Text) || !string.IsNullOrEmpty(txt_sifre.Text))
            {
                kullaniciService kullaniciService = new kullaniciService();
                kullanici kontrolKullanici = kullaniciService.kullaniciKontrol(txt_kullaniciadi.Text, txt_sifre.Text);
                if (kontrolKullanici != null)
                {
                    Form anaForm = Application.OpenForms["Form1"];
                    Panel solpanel = (Panel)anaForm.Controls["pnlIslemListesi"];
                    GroupBox gbIslemListe = (GroupBox)solpanel.Controls["grpBoxIslemListe"];

                    foreach (Control item in gbIslemListe.Controls) 
                    {
                        if (item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                    MessageBox.Show("Merhaba " + kontrolKullanici.kullaniciAdi,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();

                }
                else 
                {
                    MessageBox.Show("kullanıcı bulunamadı","hata",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("giriş bilgilerini eksiksiz giriniz","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

        }
    }
}
