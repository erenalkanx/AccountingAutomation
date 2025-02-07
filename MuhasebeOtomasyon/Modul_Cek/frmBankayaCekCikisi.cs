﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeOtomasyon.Modul_Cek
{
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {


        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CekID = -1;
        int BankaID = -1;

        Fonksiyonlar.TBL_CEKLER Cek;


        public frmBankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void frmBankayaCekCikisi_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }



        void Temizle()
        {
            txtBanka.Text = "";
            txtBankaAdi.Text = "";
            txtBelgeNo.Text = "";
            txtCekNo.Text = "";
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            Cek = null;
            CekID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }


        //CekGetir ve BankaGetir fonkları buttonedit'e girilen bilgilere göre textboxları doldurmaya yarar
        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarihi.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }


        void BankaGetir(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPNO;
                txtBankaAdi.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).BANKAADI;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }




        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı ve " + txtCekNo.Text + " numaralı çekin bankaya çıkışı";
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKID = CekID;
                Hareket.EVRAKTURU = "Bankaya Çek";
                Hareket.GCKODU = 'G';
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " nolu çekin banka hareket kaydı işlenmiştir");

                Cek.VERILENBANKA_BELGENO = txtBelgeNo.Text;
                Cek.VERILENBANKA_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENBANKAID = BankaID;
                Cek.DURUMU = "Bankada";
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtCekNo.Text + " nolu çekin durum güncellemesi yapılmıştır");
                Temizle();

            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

       

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.BankaListesi(true);
            if (id > 0)
            {
                BankaGetir(id);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CekListesi(true);
            if (id > 0)
            {
                CekGetir(id);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Cek != null && CekID>0 && BankaID > 0)
            {
                YeniKaydet();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}