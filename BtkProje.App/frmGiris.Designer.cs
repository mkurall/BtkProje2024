namespace BtkProje.App
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtParola = new DevExpress.XtraEditors.TextEdit();
            btnGiris = new DevExpress.XtraEditors.SimpleButton();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            lblBilgi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(104, 121);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(108, 24);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.EditValue = "admin";
            txtKullaniciAd.Location = new Point(234, 114);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            txtKullaniciAd.Size = new Size(246, 30);
            txtKullaniciAd.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(104, 157);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(56, 24);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.EditValue = "1234";
            txtParola.Location = new Point(234, 150);
            txtParola.Name = "txtParola";
            txtParola.Properties.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtParola.Properties.Appearance.Options.UseFont = true;
            txtParola.Properties.Name = "txtParola";
            txtParola.Properties.PasswordChar = '●';
            txtParola.Size = new Size(246, 30);
            txtParola.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Appearance.Options.UseFont = true;
            btnGiris.Location = new Point(343, 196);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(137, 48);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.Click += btnGiris_Click;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(pictureBox1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(500, 96);
            panelControl1.TabIndex = 3;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(103, 24);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(362, 36);
            labelControl3.TabIndex = 1;
            labelControl3.Text = "Btk Proje - Güvenli Giriş";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.security;
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(39, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(39, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(62, 267);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(367, 216);
            labelControl4.TabIndex = 6;
            labelControl4.Text = resources.GetString("labelControl4.Text");
            // 
            // lblBilgi
            // 
            lblBilgi.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBilgi.Appearance.ForeColor = Color.Red;
            lblBilgi.Appearance.Options.UseFont = true;
            lblBilgi.Appearance.Options.UseForeColor = true;
            lblBilgi.Location = new Point(42, 209);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(38, 24);
            lblBilgi.TabIndex = 7;
            lblBilgi.Text = "Bilgi";
            lblBilgi.Visible = false;
            // 
            // frmGiris
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 539);
            Controls.Add(lblBilgi);
            Controls.Add(labelControl4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panelControl1);
            Controls.Add(btnGiris);
            Controls.Add(txtParola);
            Controls.Add(labelControl2);
            Controls.Add(txtKullaniciAd);
            Controls.Add(labelControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oturum Açın";
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblBilgi;
    }
}