﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MuhasebeOtomasyon.Modul_Banka
{
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        int IslemID = -1;
        int BankaID = -1;
        string EvrakTURU;

        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            var lst = from s in DB.VW_BANKAHAREKETLERI
                      where s.BANKAID == BankaID
                      select s;
            Liste.DataSource = lst;
        }



        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALISTESI Banka = new Fonksiyonlar.VW_BANKALISTESI();
                txtHesapAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtGiris.Text = Banka.GIRIS.Value.ToString();
                txtCikis.Text = Banka.CIKIS.Value.ToString();
                txtBakiye.Text = Banka.BAKIYE.Value.ToString();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);    //BankaListesi formundan gelen id 'Id' adlı değişkene eşitleniyor
            if (Id > 0) 
                BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (IslemID > 0)
            {
                IslemID = -1;
                if (EvrakTURU == "Banka İşlem")
                {
                    BankaIslemiDuzenle.Enabled = true;
                    ParaTransferiDuzenle.Enabled = false;
                }
                else if (EvrakTURU == "Banka EFT" || EvrakTURU == "Banka Havale")
                {
                    BankaIslemiDuzenle.Enabled = false;
                    ParaTransferiDuzenle.Enabled = true;
                }
            }
        }

        void Sec()
        {
            try
            {
                IslemID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                EvrakTURU = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();
            }
            catch (Exception)
            {
                IslemID = -1;
                EvrakTURU = "";
            }
        }

        private void BankaIslemiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true, IslemID);
            Listele();
        }

        private void ParaTransferiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            Listele();
        }
    }
}