
namespace MuhasebeOtomasyon.Modul_Kullanici
{
    partial class frmKullaniciYonetimi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOYISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnYenile);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.btnYeniKullanici);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(888, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(94, 29);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(512, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(244, 29);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Seçili Kullanıcıyı Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(262, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(244, 29);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Seçili Kullanıcıyı Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Location = new System.Drawing.Point(12, 12);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(244, 29);
            this.btnYeniKullanici.TabIndex = 0;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Girişi";
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 56);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(994, 589);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KULLANICI,
            this.ISIM,
            this.SOYISIM,
            this.AKTIF,
            this.KODU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 25;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 94;
            // 
            // KULLANICI
            // 
            this.KULLANICI.Caption = "Kullanıcı";
            this.KULLANICI.FieldName = "KULLANICI";
            this.KULLANICI.MinWidth = 25;
            this.KULLANICI.Name = "KULLANICI";
            this.KULLANICI.OptionsColumn.AllowEdit = false;
            this.KULLANICI.OptionsColumn.AllowFocus = false;
            this.KULLANICI.OptionsColumn.FixedWidth = true;
            this.KULLANICI.OptionsColumn.ReadOnly = true;
            this.KULLANICI.Visible = true;
            this.KULLANICI.VisibleIndex = 1;
            this.KULLANICI.Width = 94;
            // 
            // ISIM
            // 
            this.ISIM.Caption = "İsim";
            this.ISIM.FieldName = "ISIM";
            this.ISIM.MinWidth = 25;
            this.ISIM.Name = "ISIM";
            this.ISIM.OptionsColumn.AllowEdit = false;
            this.ISIM.OptionsColumn.AllowFocus = false;
            this.ISIM.OptionsColumn.FixedWidth = true;
            this.ISIM.OptionsColumn.ReadOnly = true;
            this.ISIM.Visible = true;
            this.ISIM.VisibleIndex = 2;
            this.ISIM.Width = 94;
            // 
            // SOYISIM
            // 
            this.SOYISIM.Caption = "Soyisim";
            this.SOYISIM.FieldName = "SOYISIM";
            this.SOYISIM.MinWidth = 25;
            this.SOYISIM.Name = "SOYISIM";
            this.SOYISIM.OptionsColumn.AllowEdit = false;
            this.SOYISIM.OptionsColumn.AllowFocus = false;
            this.SOYISIM.OptionsColumn.FixedWidth = true;
            this.SOYISIM.OptionsColumn.ReadOnly = true;
            this.SOYISIM.Visible = true;
            this.SOYISIM.VisibleIndex = 3;
            this.SOYISIM.Width = 94;
            // 
            // AKTIF
            // 
            this.AKTIF.Caption = "Durum";
            this.AKTIF.FieldName = "AKTIF";
            this.AKTIF.MinWidth = 25;
            this.AKTIF.Name = "AKTIF";
            this.AKTIF.OptionsColumn.AllowEdit = false;
            this.AKTIF.OptionsColumn.AllowFocus = false;
            this.AKTIF.OptionsColumn.FixedWidth = true;
            this.AKTIF.OptionsColumn.ReadOnly = true;
            this.AKTIF.Visible = true;
            this.AKTIF.VisibleIndex = 4;
            this.AKTIF.Width = 94;
            // 
            // KODU
            // 
            this.KODU.Caption = "Kullanıcı Kodu";
            this.KODU.FieldName = "KODU";
            this.KODU.MinWidth = 25;
            this.KODU.Name = "KODU";
            this.KODU.OptionsColumn.AllowEdit = false;
            this.KODU.OptionsColumn.AllowFocus = false;
            this.KODU.OptionsColumn.FixedWidth = true;
            this.KODU.OptionsColumn.ReadOnly = true;
            this.KODU.Visible = true;
            this.KODU.VisibleIndex = 5;
            this.KODU.Width = 94;
            // 
            // frmKullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 645);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.user;
            this.Name = "frmKullaniciYonetimi";
            this.Text = "Kullanıcı Yonetimi";
            this.Load += new System.EventHandler(this.frmKullaniciYonetimi_Load);
            this.Shown += new System.EventHandler(this.frmKullaniciYonetimi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICI;
        private DevExpress.XtraGrid.Columns.GridColumn ISIM;
        private DevExpress.XtraGrid.Columns.GridColumn SOYISIM;
        private DevExpress.XtraGrid.Columns.GridColumn AKTIF;
        private DevExpress.XtraGrid.Columns.GridColumn KODU;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
    }
}