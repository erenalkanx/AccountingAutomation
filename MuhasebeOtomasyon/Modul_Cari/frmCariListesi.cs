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

namespace MuhasebeOtomasyon.Modul_Cari
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();


        public bool Secim = false;
        int SecimID = -1;


        public frmCariListesi()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            var LST = from s in DB.TBL_CARILER
                      where s.CARIADI.Contains(txtCariAdi.Text) && s.CARIADI.Contains(txtCariKodu.Text)
                      select s;
            Liste.DataSource = LST;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {
                SecimID = -1;
            }
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {

        }
    }
}