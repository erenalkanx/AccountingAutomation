
namespace MuhasebeOtomasyon
{
    partial class frmLoginForm
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
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnAyar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(119, 46);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(125, 22);
            this.txtKullanici.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(79, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(119, 74);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(125, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(119, 113);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(125, 29);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.Location = new System.Drawing.Point(119, 148);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(125, 29);
            this.btnAyar.TabIndex = 3;
            this.btnAyar.Text = "Bağlantı Ayarları";
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyar);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtKullanici);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(41, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::MuhasebeOtomasyon.Properties.Resources.FireFox32x32;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton btnAyar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}