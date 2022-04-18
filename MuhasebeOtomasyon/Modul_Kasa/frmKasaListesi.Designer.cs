namespace MuhasebeOtomasyon.Modul_Kasa
{
    partial class frmKasaListesi
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KASAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 25;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 2;
            this.GIRIS.Width = 94;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 25;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 3;
            this.CIKIS.Width = 94;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.MinWidth = 23;
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 4;
            this.BAKIYE.Width = 87;
            // 
            // KASAKODU
            // 
            this.KASAKODU.Caption = "KASA KODU";
            this.KASAKODU.FieldName = "KASAKODU";
            this.KASAKODU.MinWidth = 23;
            this.KASAKODU.Name = "KASAKODU";
            this.KASAKODU.OptionsColumn.AllowEdit = false;
            this.KASAKODU.OptionsColumn.AllowFocus = false;
            this.KASAKODU.OptionsColumn.FixedWidth = true;
            this.KASAKODU.Visible = true;
            this.KASAKODU.VisibleIndex = 0;
            this.KASAKODU.Width = 87;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 23;
            this.ID.Name = "ID";
            this.ID.Width = 87;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KASAKODU,
            this.KASAADI,
            this.BAKIYE,
            this.GIRIS,
            this.CIKIS,
            this.ACIKLAMA});
            this.gridView1.DetailHeight = 431;
            gridFormatRule1.Column = this.GIRIS;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = 0;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.CIKIS;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue2.Value1 = 0;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.BAKIYE;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue3.Appearance.Options.UseFont = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue3.Value1 = 0;
            gridFormatRule3.Rule = formatConditionRuleValue3;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // KASAADI
            // 
            this.KASAADI.Caption = "KASA ADI";
            this.KASAADI.FieldName = "KASAADI";
            this.KASAADI.MinWidth = 23;
            this.KASAADI.Name = "KASAADI";
            this.KASAADI.OptionsColumn.AllowEdit = false;
            this.KASAADI.OptionsColumn.AllowFocus = false;
            this.KASAADI.OptionsColumn.FixedWidth = true;
            this.KASAADI.Visible = true;
            this.KASAADI.VisibleIndex = 1;
            this.KASAADI.Width = 87;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 25;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            this.ACIKLAMA.Width = 94;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(782, 657);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(118, 158);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 47);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "TEMİZLE";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(13, 158);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(98, 47);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(13, 111);
            this.txtKasaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(185, 22);
            this.txtKasaAdi.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(13, 47);
            this.txtKasaKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(185, 22);
            this.txtKasaKodu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtKasaAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtKasaKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(232, 627);
            this.xtraTabPage1.Text = "Arama";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(234, 657);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1028, 657);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // frmKasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 657);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.Kasa_Liste32x32;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Listesi";
            this.Load += new System.EventHandler(this.frmKasaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn KASAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KASAADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
    }
}