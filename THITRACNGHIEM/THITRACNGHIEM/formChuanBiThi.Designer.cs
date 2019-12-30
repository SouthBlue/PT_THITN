namespace THITRACNGHIEM
{
    partial class formChuanBiThi
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChuanBiThi));
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new THITRACNGHIEM.DS();
            this.gIAOVIEN_DANGKYTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcGVDK = new DevExpress.XtraGrid.GridControl();
            this.gvGVDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgayThi = new System.Windows.Forms.DateTimePicker();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUnDo = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.seLan = new DevExpress.XtraEditors.SpinEdit();
            this.seSoCau = new DevExpress.XtraEditors.SpinEdit();
            this.seThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONHOCTableAdapter();
            this.gIAOVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIAOVIENTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGVDK)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThoiGian.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(10, 28);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(121, 19);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MÃ GIÁO VIÊN:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(10, 75);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(117, 19);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MÃ MÔN HỌC:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(10, 122);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(71, 19);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "MÃ LỚP:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(10, 169);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(86, 19);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "TRÌNH ĐỘ:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(10, 216);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(85, 19);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "NGÀY THI:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(10, 262);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(44, 19);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "LẦN:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(10, 308);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(99, 19);
            sOCAUTHILabel.TabIndex = 12;
            sOCAUTHILabel.Text = "SỐ CÂU THI:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(10, 354);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(133, 19);
            tHOIGIANLabel.TabIndex = 14;
            tHOIGIANLabel.Text = "THỜI GIAN (Phút):";
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "GIAOVIEN_DANGKY";
            this.bdsGVDK.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại danh sách";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 638);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 614);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 614);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcGVDK);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 24);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1200, 485);
            this.panelControl2.TabIndex = 11;
            // 
            // gcGVDK
            // 
            this.gcGVDK.DataSource = this.bdsGVDK;
            this.gcGVDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGVDK.Location = new System.Drawing.Point(493, 2);
            this.gcGVDK.MainView = this.gvGVDK;
            this.gcGVDK.Name = "gcGVDK";
            this.gcGVDK.Size = new System.Drawing.Size(705, 481);
            this.gcGVDK.TabIndex = 1;
            this.gcGVDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGVDK});
            // 
            // gvGVDK
            // 
            this.gvGVDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gvGVDK.GridControl = this.gcGVDK;
            this.gvGVDK.GroupPanelText = "DANH SÁCH ĐĂNG KÝ";
            this.gvGVDK.Name = "gvGVDK";
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "MÃ GIÁO VIÊN";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "MÃ LỚP";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "TRÌNH ĐỘ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.Caption = "NGÀY THI";
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.Caption = "LẦN";
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.Caption = "SỐ CÂU THI";
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.Caption = "THỜI GIAN";
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgayThi);
            this.groupBox1.Controls.Add(this.cmbTrinhDo);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUnDo);
            this.groupBox1.Controls.Add(this.btnGhi);
            this.groupBox1.Controls.Add(mAGVLabel);
            this.groupBox1.Controls.Add(this.cmbMaGV);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.cmbMaMH);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.cmbMaLop);
            this.groupBox1.Controls.Add(tRINHDOLabel);
            this.groupBox1.Controls.Add(nGAYTHILabel);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Controls.Add(this.seLan);
            this.groupBox1.Controls.Add(sOCAUTHILabel);
            this.groupBox1.Controls.Add(this.seSoCau);
            this.groupBox1.Controls.Add(tHOIGIANLabel);
            this.groupBox1.Controls.Add(this.seThoiGian);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dateNgayThi
            // 
            this.dateNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThi.Location = new System.Drawing.Point(136, 210);
            this.dateNgayThi.Name = "dateNgayThi";
            this.dateNgayThi.Size = new System.Drawing.Size(322, 26);
            this.dateNgayThi.TabIndex = 22;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(136, 166);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(323, 27);
            this.cmbTrinhDo.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::THITRACNGHIEM.Properties.Resources.btnUndo_ImageOptions_Image;
            this.btnCancel.Location = new System.Drawing.Point(348, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 38);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "  Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUnDo
            // 
            this.btnUnDo.Image = global::THITRACNGHIEM.Properties.Resources.btnRefresh_ImageOptions_Image;
            this.btnUnDo.Location = new System.Drawing.Point(203, 396);
            this.btnUnDo.Name = "btnUnDo";
            this.btnUnDo.Size = new System.Drawing.Size(117, 39);
            this.btnUnDo.TabIndex = 17;
            this.btnUnDo.Text = "Làm mới";
            this.btnUnDo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnDo.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            this.btnGhi.Image = global::THITRACNGHIEM.Properties.Resources.btnSave_ImageOptions_Image;
            this.btnGhi.Location = new System.Drawing.Point(64, 396);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(117, 39);
            this.btnGhi.TabIndex = 16;
            this.btnGhi.Text = "   Ghi";
            this.btnGhi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "MAGV", true));
            this.cmbMaGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsGiaoVien, "MAGV", true));
            this.cmbMaGV.DataSource = this.bdsGiaoVien;
            this.cmbMaGV.DisplayMember = "MAGV";
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(137, 25);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(323, 27);
            this.cmbMaGV.TabIndex = 1;
            this.cmbMaGV.ValueMember = "MAGV";
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "GIAOVIEN";
            this.bdsGiaoVien.DataSource = this.DS;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "MAMH", true));
            this.cmbMaMH.DataSource = this.bdsMonHoc;
            this.cmbMaMH.DisplayMember = "MAMH";
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(137, 72);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(323, 27);
            this.cmbMaMH.TabIndex = 3;
            this.cmbMaMH.ValueMember = "MAMH";
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "MONHOC";
            this.bdsMonHoc.DataSource = this.DS;
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsGVDK, "MALOP", true));
            this.cmbMaLop.DataSource = this.bdsLop;
            this.cmbMaLop.DisplayMember = "TENLOP";
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(137, 119);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(323, 27);
            this.cmbMaLop.TabIndex = 5;
            this.cmbMaLop.ValueMember = "MALOP";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.DS;
            // 
            // seLan
            // 
            this.seLan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seLan.Location = new System.Drawing.Point(137, 259);
            this.seLan.Name = "seLan";
            this.seLan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seLan.Properties.Appearance.Options.UseFont = true;
            this.seLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seLan.Properties.MaxValue = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.seLan.Size = new System.Drawing.Size(323, 26);
            this.seLan.TabIndex = 11;
            // 
            // seSoCau
            // 
            this.seSoCau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoCau.Location = new System.Drawing.Point(137, 305);
            this.seSoCau.Name = "seSoCau";
            this.seSoCau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoCau.Properties.Appearance.Options.UseFont = true;
            this.seSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoCau.Size = new System.Drawing.Size(323, 26);
            this.seSoCau.TabIndex = 13;
            // 
            // seThoiGian
            // 
            this.seThoiGian.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seThoiGian.Location = new System.Drawing.Point(149, 351);
            this.seThoiGian.Name = "seThoiGian";
            this.seThoiGian.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seThoiGian.Properties.Appearance.Options.UseFont = true;
            this.seThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seThoiGian.Size = new System.Drawing.Size(309, 26);
            this.seThoiGian.TabIndex = 15;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // formChuanBiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChuanBiThi";
            this.Text = "Chuẩn bị thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGVDK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seThoiGian.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS DS;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcGVDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGVDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUnDo;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private DevExpress.XtraEditors.SpinEdit seSoCau;
        private DevExpress.XtraEditors.SpinEdit seThoiGian;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private System.Windows.Forms.DateTimePicker dateNgayThi;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.SpinEdit seLan;
    }
}