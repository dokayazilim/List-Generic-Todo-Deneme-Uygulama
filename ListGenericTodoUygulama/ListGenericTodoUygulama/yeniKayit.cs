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
    public partial class yeniKayit : Form
    {
        public yeniKayit()
        {
            InitializeComponent();
        }

        private void txt_baslik_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void btn_yenikayit_Click(object sender, EventArgs e)
        {
            todoService todoService = new todoService();
            int sonuc = todoService.kayitYeni(new entities.todo()
            {
                id = Guid.NewGuid(),
                baslik = txt_baslik.Text,
                kisaAciklama = txt_kisaAciklama.Text,
                aciklama = txt_aciklama.Text,
                durumAciklama = cmb_durum.SelectedItem.ToString(),
                onemDerece = int.Parse(txt_derece.Text),
                olusturmaTarih = DateTime.Now
                
            });
            if (sonuc > 0)
            {
                MessageBox.Show("kayıt başarılı..");
                DialogResult result = MessageBox.Show("Yeni kayıt eklemek ister misiniz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitListe = Application.OpenForms["kayitListe"];
                    if (kayitListe == null)
                    {
                        kayitListe = new kayitListe();
                        kayitListe.MdiParent = Application.OpenForms["Form1"];
                        kayitListe.StartPosition = FormStartPosition.CenterScreen;
                        kayitListe.Show();
                        this.Close();
                    }
                    else 
                    {
                        GroupBox Liste = (GroupBox)kayitListe.Controls["grpboxliste"];
                        DataGridView grdListe = (DataGridView) Liste.Controls["grdListe"];
                        List<todo> GuncelListe = todoService.kayitListe();
                        grdListe.DataSource = null;
                        grdListe.DataSource = GuncelListe;
                        this.Close();

                    }
                }
            }
            else 
            {
                MessageBox.Show("kayıt eklemede hata..");
            }
        }
    }
}
