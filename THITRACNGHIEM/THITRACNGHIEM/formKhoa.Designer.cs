namespace THITRACNGHIEM
{
    partial class formKhoa
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKhoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DS = new THITRACNGHIEM.DS();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new THITRACNGHIEM.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIAOVIENTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grbKhoa = new System.Windows.Forms.GroupBox();
            this.txtMaCS = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gvKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaGV = new System.Windows.Forms.ToolStripMenuItem();
            this.gvGiaoVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsGVDK = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new THITRACNGHIEM.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.bdsBODE = new System.Windows.Forms.BindingSource(this.components);
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.cosoTableAdapter1 = new THITRACNGHIEM.DSTableAdapters.COSOTableAdapter();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.grbKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBODE)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACSLabel.Location = new System.Drawing.Point(49, 186);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(89, 19);
            mACSLabel.TabIndex = 4;
            mACSLabel.Text = "MÃ CƠ SỞ:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHLabel.Location = new System.Drawing.Point(47, 113);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(92, 19);
            tENKHLabel.TabIndex = 2;
            tENKHLabel.Text = "TÊN KHOA:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(51, 47);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(87, 19);
            mAKHLabel.TabIndex = 0;
            mAKHLabel.Text = "MÃ KHOA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnUndo,
            this.btnGhi,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại danh sách";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.DS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsGV.DataSource = this.bdsKhoa;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grbKhoa);
            this.panelControl1.Controls.Add(this.gcKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1200, 249);
            this.panelControl1.TabIndex = 12;
            // 
            // grbKhoa
            // 
            this.grbKhoa.Controls.Add(mACSLabel);
            this.grbKhoa.Controls.Add(this.txtMaCS);
            this.grbKhoa.Controls.Add(tENKHLabel);
            this.grbKhoa.Controls.Add(this.txtTenKhoa);
            this.grbKhoa.Controls.Add(mAKHLabel);
            this.grbKhoa.Controls.Add(this.txtMaKhoa);
            this.grbKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhoa.Location = new System.Drawing.Point(607, 2);
            this.grbKhoa.Name = "grbKhoa";
            this.grbKhoa.Size = new System.Drawing.Size(591, 245);
            this.grbKhoa.TabIndex = 14;
            this.grbKhoa.TabStop = false;
            this.grbKhoa.Text = "Thông tin khoa";
            // 
            // txtMaCS
            // 
            this.txtMaCS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MACS", true));
            this.txtMaCS.Location = new System.Drawing.Point(144, 183);
            this.txtMaCS.MenuManager = this.barManager1;
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCS.Properties.Appearance.Options.UseFont = true;
            this.txtMaCS.Properties.ReadOnly = true;
            this.txtMaCS.Size = new System.Drawing.Size(176, 26);
            this.txtMaCS.TabIndex = 5;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "TENKH", true));
            this.txtTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "TENKH", true));
            this.txtTenKhoa.Location = new System.Drawing.Point(144, 110);
            this.txtTenKhoa.MenuManager = this.barManager1;
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtTenKhoa.Size = new System.Drawing.Size(419, 26);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhoa, "MAKH", true));
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MAKH", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(144, 43);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(176, 26);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcKhoa.Location = new System.Drawing.Point(2, 2);
            this.gcKhoa.MainView = this.gvKhoa;
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(605, 245);
            this.gcKhoa.TabIndex = 7;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoa});
            // 
            // gvKhoa
            // 
            this.gvKhoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gvKhoa.GridControl = this.gcKhoa;
            this.gvKhoa.GroupPanelText = "DANH SÁCH KHOA";
            this.gvKhoa.Name = "gvKhoa";
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "MÃ KHOA";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "TÊN KHOA";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.Caption = "MÃ CƠ SỞ";
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcGiaoVien);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 273);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1200, 269);
            this.panelControl2.TabIndex = 13;
            // 
            // gcGiaoVien
            // 
            this.gcGiaoVien.ContextMenuStrip = this.contextMenuStrip1;
            this.gcGiaoVien.DataSource = this.bdsGV;
            this.gcGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGiaoVien.Location = new System.Drawing.Point(2, 2);
            this.gcGiaoVien.MainView = this.gvGiaoVien;
            this.gcGiaoVien.MenuManager = this.barManager1;
            this.gcGiaoVien.Name = "gcGiaoVien";
            this.gcGiaoVien.Size = new System.Drawing.Size(1196, 240);
            this.gcGiaoVien.TabIndex = 0;
            this.gcGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGiaoVien});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemGV,
            this.btnXoaGV,
            this.btnSuaGV});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Image = global::THITRACNGHIEM.Properties.Resources.add_16;
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(183, 22);
            this.btnThemGV.Text = "Thêm giáo viên";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Image = global::THITRACNGHIEM.Properties.Resources.delete_16;
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(183, 22);
            this.btnXoaGV.Text = "Xóa giáo viên";
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Image = global::THITRACNGHIEM.Properties.Resources.edit_16;
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(183, 22);
            this.btnSuaGV.Text = "Hiệu chỉnh giáo viên";
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH1});
            this.gvGiaoVien.GridControl = this.gcGiaoVien;
            this.gvGiaoVien.GroupPanelText = "DANH SÁCH GIÁO VIÊN CỦA KHOA";
            this.gvGiaoVien.Name = "gvGiaoVien";
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "MÃ GIÁO VIÊN";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "HỌ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TÊN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "ĐỊA CHỈ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKH1
            // 
            this.colMAKH1.Caption = "MÃ KHOA";
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            // 
            // bdsGVDK
            // 
            this.bdsGVDK.DataMember = "FK_GIAOVIEN_DANGKY_GIAOVIEN1";
            this.bdsGVDK.DataSource = this.bdsGV;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // bdsBODE
            // 
            this.bdsBODE.DataMember = "FK_BODE_GIAOVIEN";
            this.bdsBODE.DataSource = this.bdsGV;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // cosoTableAdapter1
            // 
            this.cosoTableAdapter1.ClearBeforeFill = true;
            // 
            // formKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formKhoa";
            this.Text = "Khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.grbKhoa.ResumeLayout(false);
            this.grbKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGVDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBODE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS DS;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsLop;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsGV;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvGiaoVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox grbKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaCS;
        private DevExpress.XtraEditors.TextEdit txtTenKhoa;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemGV;
        private System.Windows.Forms.ToolStripMenuItem btnXoaGV;
        private System.Windows.Forms.ToolStripMenuItem btnSuaGV;
        private System.Windows.Forms.BindingSource bdsGVDK;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private System.Windows.Forms.BindingSource bdsBODE;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private DSTableAdapters.COSOTableAdapter cosoTableAdapter1;
    }
}