﻿namespace BtkProje.App
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            bbiKaydet = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)navBarControl1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(88, 82);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(289, 48);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Form'un tam ekran açılması için;\r\nWindowState = Maximized";
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, bbiKaydet });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 2;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1048, 183);
            ribbonControl1.StatusBar = ribbonStatusBar1;
            // 
            // bbiKaydet
            // 
            bbiKaydet.Caption = "Kaydet";
            bbiKaydet.Id = 1;
            bbiKaydet.ImageOptions.Image = Properties.Resources.save_16x16;
            bbiKaydet.ImageOptions.LargeImage = Properties.Resources.save_32x32;
            bbiKaydet.Name = "bbiKaydet";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Giriş";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(bbiKaydet);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Genel";
            // 
            // ribbonStatusBar1
            // 
            ribbonStatusBar1.Location = new Point(0, 567);
            ribbonStatusBar1.Name = "ribbonStatusBar1";
            ribbonStatusBar1.Ribbon = ribbonControl1;
            ribbonStatusBar1.Size = new Size(1048, 33);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Location = new Point(0, 183);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(navBarControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(labelControl1);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1048, 384);
            splitContainerControl1.SplitterPosition = 294;
            splitContainerControl1.TabIndex = 2;
            // 
            // navBarControl1
            // 
            navBarControl1.ActiveGroup = navBarGroup1;
            navBarControl1.Dock = DockStyle.Fill;
            navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroup1, navBarGroup2, navBarGroup3, navBarGroup4, navBarGroup5 });
            navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] { navBarItem1, navBarItem2 });
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.OptionsNavPane.ExpandedWidth = 294;
            navBarControl1.Size = new Size(294, 384);
            navBarControl1.TabIndex = 0;
            navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            navBarGroup1.Caption = "Temel İşlemler";
            navBarGroup1.Expanded = true;
            navBarGroup1.ImageOptions.SmallImage = Properties.Resources.properties_32x32;
            navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] { new DevExpress.XtraNavBar.NavBarItemLink(navBarItem1), new DevExpress.XtraNavBar.NavBarItemLink(navBarItem2) });
            navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            navBarItem1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            navBarItem1.Appearance.Options.UseFont = true;
            navBarItem1.Caption = "Kullanıcılar";
            navBarItem1.ImageOptions.SmallImage = Properties.Resources.usergroup_32x32;
            navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            navBarItem2.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            navBarItem2.Appearance.Options.UseFont = true;
            navBarItem2.Caption = "Ayarlar";
            navBarItem2.ImageOptions.SmallImage = Properties.Resources.version_32x32;
            navBarItem2.Name = "navBarItem2";
            // 
            // navBarGroup2
            // 
            navBarGroup2.Caption = "Ürün Kategorileri";
            navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            navBarGroup3.Caption = "Ürünler";
            navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup4
            // 
            navBarGroup4.Caption = "Tedarikçiler";
            navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroup5
            // 
            navBarGroup5.Caption = "Müşteriler";
            navBarGroup5.Name = "navBarGroup5";
            // 
            // frmAna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 600);
            Controls.Add(splitContainerControl1);
            Controls.Add(ribbonControl1);
            Controls.Add(ribbonStatusBar1);
            Name = "frmAna";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Shown += frmAna_Shown;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)navBarControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiKaydet;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
    }
}