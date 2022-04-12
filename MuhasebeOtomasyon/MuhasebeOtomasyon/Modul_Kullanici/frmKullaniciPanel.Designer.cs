
namespace MuhasebeOtomasyon.Modul_Kullanici
{
    partial class frmKullaniciPanel
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifreT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIsim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnAktif = new System.Windows.Forms.RadioButton();
            this.rbtnPasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(123, 31);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(125, 22);
            this.txtKullanici.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(123, 59);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(125, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Şifre(Tekrar):";
            // 
            // txtSifreT
            // 
            this.txtSifreT.Location = new System.Drawing.Point(123, 87);
            this.txtSifreT.Name = "txtSifreT";
            this.txtSifreT.Size = new System.Drawing.Size(125, 22);
            this.txtSifreT.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(85, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İsim:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(123, 115);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(125, 22);
            this.txtIsim.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(65, 146);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Soyisim:";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(123, 143);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(125, 22);
            this.txtSoyisim.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(32, 174);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 16);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Kullanıcı Türü:";
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.EditValue = "Normal";
            this.txtKullaniciKodu.Location = new System.Drawing.Point(123, 171);
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKullaniciKodu.Properties.Items.AddRange(new object[] {
            "Yönetici",
            "Normal"});
            this.txtKullaniciKodu.Size = new System.Drawing.Size(125, 22);
            this.txtKullaniciKodu.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(266, 113);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 33);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Sil32x32;
            this.btnTemizle.Location = new System.Drawing.Point(266, 72);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(90, 33);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Kaydet24x24;
            this.btnKaydet.Location = new System.Drawing.Point(266, 31);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 33);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rbtnAktif
            // 
            this.rbtnAktif.AutoSize = true;
            this.rbtnAktif.Location = new System.Drawing.Point(266, 153);
            this.rbtnAktif.Name = "rbtnAktif";
            this.rbtnAktif.Size = new System.Drawing.Size(55, 21);
            this.rbtnAktif.TabIndex = 6;
            this.rbtnAktif.TabStop = true;
            this.rbtnAktif.Text = "Aktif";
            this.rbtnAktif.UseVisualStyleBackColor = true;
            // 
            // rbtnPasif
            // 
            this.rbtnPasif.AutoSize = true;
            this.rbtnPasif.Location = new System.Drawing.Point(266, 180);
            this.rbtnPasif.Name = "rbtnPasif";
            this.rbtnPasif.Size = new System.Drawing.Size(56, 21);
            this.rbtnPasif.TabIndex = 7;
            this.rbtnPasif.TabStop = true;
            this.rbtnPasif.Text = "Pasif";
            this.rbtnPasif.UseVisualStyleBackColor = true;
            // 
            // frmKullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.rbtnPasif);
            this.Controls.Add(this.rbtnAktif);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSifreT);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtKullaniciKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKullaniciPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullaniciPanel_FormClosed);
            this.Load += new System.EventHandler(this.frmKullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifreT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciKodu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSifreT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtIsim;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoyisim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtKullaniciKodu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.RadioButton rbtnAktif;
        private System.Windows.Forms.RadioButton rbtnPasif;
    }
}