
namespace MuhasebeOtomasyon.Modul_Kasa
{
    partial class frmKasaHareketleri
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.EVRAKTURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DevirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TahsilatOdemeDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EVRAKTURU
            // 
            this.EVRAKTURU.Caption = "EVRAK TÜRÜ";
            this.EVRAKTURU.FieldName = "EVRAKTURU";
            this.EVRAKTURU.MinWidth = 23;
            this.EVRAKTURU.Name = "EVRAKTURU";
            this.EVRAKTURU.OptionsColumn.AllowEdit = false;
            this.EVRAKTURU.OptionsColumn.AllowFocus = false;
            this.EVRAKTURU.OptionsColumn.FixedWidth = true;
            this.EVRAKTURU.Visible = true;
            this.EVRAKTURU.VisibleIndex = 1;
            this.EVRAKTURU.Width = 87;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 23;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            this.ACIKLAMA.Width = 467;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 23;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            this.GIRIS.Width = 87;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(612, 39);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(92, 22);
            this.txtBakiye.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(564, 43);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(457, 73);
            this.txtCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(92, 22);
            this.txtCikis.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(422, 77);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Çıkış:";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(457, 39);
            this.txtGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(92, 22);
            this.txtGiris.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(421, 44);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Giriş:";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(131, 71);
            this.txtKasaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(276, 22);
            this.txtKasaAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // EVRAKID
            // 
            this.EVRAKID.Caption = "EVRAK ID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.MinWidth = 23;
            this.EVRAKID.Name = "EVRAKID";
            this.EVRAKID.Width = 87;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.MinWidth = 23;
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 118;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 23;
            this.ID.Name = "ID";
            this.ID.Width = 87;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 127);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1094, 550);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagTik;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Location = new System.Drawing.Point(2, 28);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1090, 520);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SagTik
            // 
            this.SagTik.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevirKartiDuzenle,
            this.TahsilatOdemeDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(296, 52);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // DevirKartiDuzenle
            // 
            this.DevirKartiDuzenle.Enabled = false;
            this.DevirKartiDuzenle.Name = "DevirKartiDuzenle";
            this.DevirKartiDuzenle.Size = new System.Drawing.Size(295, 24);
            this.DevirKartiDuzenle.Text = "Devir Kartı İşlemini Düzenle";
            this.DevirKartiDuzenle.Click += new System.EventHandler(this.DevirKartiDuzenle_Click);
            // 
            // TahsilatOdemeDuzenle
            // 
            this.TahsilatOdemeDuzenle.Enabled = false;
            this.TahsilatOdemeDuzenle.Name = "TahsilatOdemeDuzenle";
            this.TahsilatOdemeDuzenle.Size = new System.Drawing.Size(295, 24);
            this.TahsilatOdemeDuzenle.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.TahsilatOdemeDuzenle.Click += new System.EventHandler(this.TahsilatOdemeDuzenle_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTURU,
            this.EVRAKID,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA,
            this.TARIH});
            this.gridView1.DetailHeight = 431;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.EVRAKTURU;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleValue1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "Kasa Tahsilat";
            formatConditionRuleValue1.Value1 = "Kasa Tahsilat";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.EVRAKTURU;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "Kasa Ödeme";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.EVRAKTURU;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = "Kasa Devir Kartı";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 23;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            this.CIKIS.Width = 87;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.MinWidth = 25;
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 2;
            this.TARIH.Width = 94;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(131, 39);
            this.txtKasaKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(276, 22);
            this.txtKasaKodu.TabIndex = 0;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1094, 127);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 677);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Kasa_Hareket32x32;
            this.MaximizeBox = false;
            this.Name = "frmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTURU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem DevirKartiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TahsilatOdemeDuzenle;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
    }
}