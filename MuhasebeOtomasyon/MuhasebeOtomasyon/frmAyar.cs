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
    public partial class frmAyar : DevExpress.XtraEditors.XtraForm
    {
        public frmAyar()
        {
            InitializeComponent();
        }

        private void chkYeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            //txtSunucu.Enabled = !txtSunucu.Enabled;
            //txtDatabase.Enabled = !txtDatabase.Enabled;

            txtPassword.Enabled = !txtPassword.Enabled;
            txtUserID.Enabled = !txtUserID.Enabled;
            btnYeniAyarlariKaydet.Enabled = !btnYeniAyarlariKaydet.Enabled;

        }

        private void btnYeniAyarlariKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Sunucu = txtSunucu.Text.Trim() + ";";    //bu şekilde properties-settings kısmına veri kaydedebiliriz
            Properties.Settings.Default.cs_Database = txtDatabase.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txtUserID.Text.Trim() + ";";
            Properties.Settings.Default.cs_Password = txtPassword.Text.Trim() + ";";
            Properties.Settings.Default.Database = txtDatabase.Text.Trim();
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void frmAyar_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Properties.Settings.Default.cs1 +" " + Properties.Settings.Default.cs_Sunucu + " " + Properties.Settings.Default.cs2 + " " +
                Properties.Settings.Default.cs_Database + " " + Properties.Settings.Default.cs3 + " " + Properties.Settings.Default.cs_UserID + " " + Properties.Settings.Default.cs4 + " " +
                Properties.Settings.Default.cs_Password;
        }
    }
}