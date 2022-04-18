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

namespace MuhasebeOtomasyon.Modul_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullaniciID = -1;

        public frmKullaniciPanel(int ID, bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            if (Ac)
            {
                KullaniciGetir(ID);
                txtKullanici.Enabled = false;
            }
        }



        private void frmKullaniciPanel_Load(object sender, EventArgs e)
        {

        }

        void Temizle()
        {
            txtIsim.Text = "";
            txtKullanici.Text = "";
            txtKullaniciKodu.SelectedIndex = 1;
            txtSifre.Text = "";
            txtSifreT.Text = "";
            txtSoyisim.Text = "";
            rbtnPasif.Checked = true;
            Ac = false;
            KullaniciID = -1;

            
        }


        private void KullaniciGetir(int ID)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILAR.First(s => s.ID == KullaniciID);
                txtIsim.Text = Kullanici.ISIM;
                txtSoyisim.Text = Kullanici.SOYISIM;
                txtKullanici.Text = Kullanici.KULLANICI;
                txtSifre.Text = Kullanici.SIFRE;
                txtSifreT.Text = Kullanici.SIFRE;
                if (Kullanici.KODU == "Normal") txtKullaniciKodu.SelectedIndex = 1;
                if (Kullanici.KODU == "Yönetici") txtKullaniciKodu.SelectedIndex = 0;

                if (Kullanici.AKTIF.Value) rbtnAktif.Checked = true;
                if (!Kullanici.AKTIF.Value) rbtnPasif.Checked = true;
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        void YeniKaydet()
        {
            if (txtSifre.Text.Trim() == txtSifreT.Text.Trim())
            {
                if (txtIsim.Text == "")
                {
                    MessageBox.Show("Bir isim girişi yapmak zorundasınız.");
                    return;
                }
                else if (txtSoyisim.Text == "")
                {
                    MessageBox.Show("Bir soyisim girişi yapmak zorundasınız.");
                    return;
                }
                else if (txtKullanici.Text == "")
                {
                    MessageBox.Show("Bir kullanıcı adı girişi yapmak zorundasınız.");
                    return;
                }
                else if (txtSifre.Text == "")
                {
                    MessageBox.Show("Bir şifre girişi yapmak zorundasınız.");
                    return;
                }
                DialogResult DR = MessageBox.Show(txtKullaniciKodu.Text + " türünde bir kullanıcı açmak üzeresiniz. Emin misiniz?", "Kullanıcı Kaydı Tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        if (!Ac)
                        {
                            if (DB.TBL_KULLANICILAR.Where(s => s.KULLANICI == txtKullanici.Text).Count() > 0)
                            {
                                MessageBox.Show("Böyle bir kullanıcı zaten açılmış. Aynı kullanıcı adını tekrar kullanamazsınız!");
                                return;
                            }
                        }

                        Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!Ac) 
                            Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                        else 
                            Kullanici = DB.TBL_KULLANICILAR.First(s => s.ID == KullaniciID);

                        if (rbtnAktif.Checked) 
                            Kullanici.AKTIF = true;
                        if (rbtnPasif.Checked)
                            Kullanici.AKTIF = false;

                        Kullanici.ISIM = txtIsim.Text;
                        Kullanici.SOYISIM = txtSoyisim.Text;
                        Kullanici.KULLANICI = txtKullanici.Text;
                        Kullanici.KODU = txtKullaniciKodu.Text;
                        Kullanici.SIFRE = txtSifre.Text;

                        if (Ac) 
                            Kullanici.EDITDATE = DateTime.Now;
                        else 
                            Kullanici.SAVEDATE = DateTime.Now;
                        if (!Ac) 
                            DB.TBL_KULLANICILAR.InsertOnSubmit(Kullanici);
                        DB.SubmitChanges();
                        if (Ac) 
                            Mesajlar.Guncelle(true);
                        else 
                            Mesajlar.YeniKayit(txtKullanici.Text + " kullanıcı kaydı açılmıştır.");

                        Temizle();
                    }
                    catch (Exception ex)
                    {
                        Mesajlar.Hata(ex);
                    }
                }
            }
            else
                MessageBox.Show("Şifreler aynı değil!");
        }

        private void frmKullaniciPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKullaniciYonetimi frmKullaniciYonetimi = new frmKullaniciYonetimi();
            frmKullaniciYonetimi.Listele();
        }

        private void frmKullaniciPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmKullaniciYonetimi frmKullaniciYonetimi = new frmKullaniciYonetimi();
            frmKullaniciYonetimi.Listele();
        }
    }
}