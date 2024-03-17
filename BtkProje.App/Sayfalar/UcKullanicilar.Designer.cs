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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colKullaniciAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colParola = new DevExpress.XtraGrid.Columns.GridColumn();
            colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Left;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1 });
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
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colKullaniciAd, colParola, colYetki, colSil });
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
            colKullaniciAd.Width = 134;
            // 
            // colParola
            // 
            colParola.Caption = "Parola";
            colParola.FieldName = "Parola";
            colParola.MinWidth = 25;
            colParola.Name = "colParola";
            colParola.Visible = true;
            colParola.VisibleIndex = 1;
            colParola.Width = 134;
            // 
            // colYetki
            // 
            colYetki.Caption = "Yetki";
            colYetki.FieldName = "Yetki";
            colYetki.MinWidth = 25;
            colYetki.Name = "colYetki";
            colYetki.Visible = true;
            colYetki.VisibleIndex = 2;
            colYetki.Width = 134;
            // 
            // colSil
            // 
            colSil.Caption = "Sil";
            colSil.ColumnEdit = repositoryItemButtonEdit1;
            colSil.MinWidth = 25;
            colSil.Name = "colSil";
            colSil.Visible = true;
            colSil.VisibleIndex = 3;
            colSil.Width = 30;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = Properties.Resources.close_16x161;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAd;
        private DevExpress.XtraGrid.Columns.GridColumn colParola;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
