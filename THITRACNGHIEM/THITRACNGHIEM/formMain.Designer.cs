namespace THITRACNGHIEM
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnMonHoc = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegister = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MA = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.ExpandCollapseItem.Id = 0;
            this.btnMonHoc.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnMonHoc.ExpandCollapseItem,
            this.btnMonHoc.SearchEditItem,
            this.btnDangNhap,
            this.btnMH,
            this.btnExit,
            this.btnRegister,
            this.barButtonItem2,
            this.btnLogout,
            this.barButtonItem5,
            this.barButtonItem6});
            this.btnMonHoc.Location = new System.Drawing.Point(0, 0);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnMonHoc.MaxItemId = 13;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4,
            this.ribbonPage3});
            this.btnMonHoc.Size = new System.Drawing.Size(1384, 158);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnMH
            // 
            this.btnMH.Caption = "Môn học";
            this.btnMH.Id = 2;
            this.btnMH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMH.ImageOptions.SvgImage")));
            this.btnMH.Name = "btnMH";
            this.btnMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMH_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 5;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallWithoutTextWidth = 50;
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Caption = "Đăng ký";
            this.btnRegister.Id = 6;
            this.btnRegister.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegister.ImageOptions.SvgImage")));
            this.btnRegister.Name = "btnRegister";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Lớp";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 8;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Làm bài thi";
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Khoa";
            this.barButtonItem6.Id = 10;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRegister);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tùy chọn";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "QUẢN LÝ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "THI";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "HỖ TRỢ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MA,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 738);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MA
            // 
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(0, 17);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(0, 17);
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(0, 17);
            // 
            // formMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 760);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.Ribbon = this.btnMonHoc;
            this.Text = "THI TRẮC NGHIỆM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl btnMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        public System.Windows.Forms.ToolStripStatusLabel MA;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem btnMH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnRegister;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

