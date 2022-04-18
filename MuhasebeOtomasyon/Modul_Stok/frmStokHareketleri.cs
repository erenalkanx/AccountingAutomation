using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MuhasebeOtomasyon.Modul_Stok
{
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {


        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();


        public bool Secim = false;

        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }


        void Listele()
        {
            var lst = from s in DB.TBL_STOKHAREKETLERI
                      //where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                      select s;

            Liste.DataSource = lst;
        }

       

     
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }

        private void btnPrntToPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Adobe Acrobat|*.pdf";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToPdf(sf.FileName);
                }
            }
        }

        private void btnPrntToXLS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Excel|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Liste.ExportToXls(sf.FileName);
                }
            }
        }

    }
}