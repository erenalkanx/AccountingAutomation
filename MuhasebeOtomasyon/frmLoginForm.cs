using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeOtomasyon
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmLoginForm()
        {
            InitializeComponent();
            txtKullanici.Focus();

        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILAR.First(s => s.KULLANICI == txtKullanici.Text.Trim() &&
                s.SIFRE == txtSifre.Text.Trim());
                Kullanici.LASTLOGIN = DateTime.Now;
                DB.SubmitChanges();


                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Giriş yapılamadı. Kullanıcı adı ya da şifreniz geçersiz olabilir. Lütfen düzeltip tekrar deneyiniz");
            }

            
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();
        }
    }
}