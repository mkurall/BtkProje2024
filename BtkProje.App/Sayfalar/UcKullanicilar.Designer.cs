namespace BtkProje.App.Sayfalar
{
    partial class UcKullanicilar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colKullaniciAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Left;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(566, 580);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.HeaderPanel.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            gridView1.Appearance.Row.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            gridView1.Appearance.Row.Options.UseFont = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colKullaniciAd, colParola, colYetki });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colKullaniciAd
            // 
            colKullaniciAd.Caption = "Kullanıcı Adı";
            colKullaniciAd.FieldName = "KullaniciAdi";
            colKullaniciAd.MinWidth = 25;
            colKullaniciAd.Name = "colKullaniciAd";
            colKullaniciAd.Visible = true;
            colKullaniciAd.VisibleIndex = 0;
            colKullaniciAd.Width = 94;
            // 
            // colParola
            // 
            colParola.Caption = "Parola";
            colParola.FieldName = "Parola";
            colParola.MinWidth = 25;
            colParola.Name = "colParola";
            colParola.Visible = true;
            colParola.VisibleIndex = 1;
            colParola.Width = 94;
            // 
            // colYetki
            // 
            colYetki.Caption = "Yetki";
            colYetki.FieldName = "Yetki";
            colYetki.MinWidth = 25;
            colYetki.Name = "colYetki";
            colYetki.Visible = true;
            colYetki.VisibleIndex = 2;
            colYetki.Width = 94;
            // 
            // UcKullanicilar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Name = "UcKullanicilar";
            Size = new Size(779, 580);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAd;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
    }
}
