namespace THITRACNGHIEM
{
    partial class formNhapDe
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
            System.Windows.Forms.Label cAUHOILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label aLabel1;
            System.Windows.Forms.Label txtB;
            System.Windows.Forms.Label txtC;
            System.Windows.Forms.Label txtD;
            System.Windows.Forms.Label dAP_ANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formNhapDe));
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
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.bODETableAdapter = new THITRACNGHIEM.DSTableAdapters.BODETableAdapter();
            this.bdsBoDe = new System.Windows.Forms.BindingSource(this.components);
            this.gcBODE = new DevExpress.XtraGrid.GridControl();
            this.gvBODE = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbBODE = new System.Windows.Forms.GroupBox();
            this.speCauHoi = new DevExpress.XtraEditors.SpinEdit();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.cmbDapAn = new System.Windows.Forms.ComboBox();
            this.txtDD = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtBB = new System.Windows.Forms.TextBox();
            this.txtAA = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            cAUHOILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            aLabel1 = new System.Windows.Forms.Label();
            txtB = new System.Windows.Forms.Label();
            txtC = new System.Windows.Forms.Label();
            txtD = new System.Windows.Forms.Label();
            dAP_ANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBODE)).BeginInit();
            this.grbBODE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speCauHoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cAUHOILabel
            // 
            cAUHOILabel.AutoSize = true;
            cAUHOILabel.Location = new System.Drawing.Point(6, 31);
            cAUHOILabel.Name = "cAUHOILabel";
            cAUHOILabel.Size = new System.Drawing.Size(77, 19);
            cAUHOILabel.TabIndex = 0;
            cAUHOILabel.Text = "CÂU HỎI:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(332, 31);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(117, 19);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "MÃ MÔN HỌC:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(785, 32);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(86, 19);
            tRINHDOLabel.TabIndex = 4;
            tRINHDOLabel.Text = "TRÌNH ĐỘ:";
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(6, 64);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(90, 19);
            nOIDUNGLabel.TabIndex = 6;
            nOIDUNGLabel.Text = "NỘI DUNG:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(1064, 31);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(121, 19);
            mAGVLabel.TabIndex = 18;
            mAGVLabel.Text = "MÃ GIÁO VIÊN:";
            // 
            // aLabel1
            // 
            aLabel1.AutoSize = true;
            aLabel1.Location = new System.Drawing.Point(60, 146);
            aLabel1.Name = "aLabel1";
            aLabel1.Size = new System.Drawing.Size(23, 19);
            aLabel1.TabIndex = 21;
            aLabel1.Text = "A:";
            // 
            // txtB
            // 
            txtB.AutoSize = true;
            txtB.Location = new System.Drawing.Point(663, 144);
            txtB.Name = "txtB";
            txtB.Size = new System.Drawing.Size(22, 19);
            txtB.TabIndex = 22;
            txtB.Text = "B:";
            // 
            // txtC
            // 
            txtC.AutoSize = true;
            txtC.Location = new System.Drawing.Point(60, 207);
            txtC.Name = "txtC";
            txtC.Size = new System.Drawing.Size(23, 19);
            txtC.TabIndex = 23;
            txtC.Text = "C:";
            // 
            // txtD
            // 
            txtD.AutoSize = true;
            txtD.Location = new System.Drawing.Point(662, 205);
            txtD.Name = "txtD";
            txtD.Size = new System.Drawing.Size(23, 19);
            txtD.TabIndex = 24;
            txtD.Text = "D:";
            // 
            // dAP_ANLabel
            // 
            dAP_ANLabel.AutoSize = true;
            dAP_ANLabel.Location = new System.Drawing.Point(1233, 144);
            dAP_ANLabel.Name = "dAP_ANLabel";
            dAP_ANLabel.Size = new System.Drawing.Size(69, 19);
            dAP_ANLabel.TabIndex = 27;
            dAP_ANLabel.Text = "ĐÁP ÁN:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1356, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 649);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1356, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1356, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 625);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = this.bODETableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BANGDIEMTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bODETableAdapter
            // 
            this.bODETableAdapter.ClearBeforeFill = true;
            // 
            // bdsBoDe
            // 
            this.bdsBoDe.DataMember = "BODE";
            this.bdsBoDe.DataSource = this.DS;
            // 
            // gcBODE
            // 
            this.gcBODE.DataSource = this.bdsBoDe;
            this.gcBODE.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBODE.Location = new System.Drawing.Point(0, 24);
            this.gcBODE.MainView = this.gvBODE;
            this.gcBODE.MenuManager = this.barManager1;
            this.gcBODE.Name = "gcBODE";
            this.gcBODE.Size = new System.Drawing.Size(1356, 181);
            this.gcBODE.TabIndex = 5;
            this.gcBODE.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBODE});
            // 
            // gvBODE
            // 
            this.gvBODE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUHOI,
            this.colMAMH,
            this.colTRINHDO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colMAGV});
            this.gvBODE.GridControl = this.gcBODE;
            this.gvBODE.GroupPanelText = "DANH SÁCH CÂU HỎI";
            this.gvBODE.Name = "gvBODE";
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.Caption = "CÂU HỎI";
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.Caption = "TRÌNH ĐỘ";
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 2;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "NỘI DUNG";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 3;
            // 
            // colA
            // 
            this.colA.Caption = "A";
            this.colA.FieldName = "A";
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 4;
            // 
            // colB
            // 
            this.colB.Caption = "B";
            this.colB.FieldName = "B";
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 5;
            // 
            // colC
            // 
            this.colC.Caption = "C";
            this.colC.FieldName = "C";
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 6;
            // 
            // colD
            // 
            this.colD.Caption = "D";
            this.colD.FieldName = "D";
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 7;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.Caption = "ĐÁP ÁN";
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 8;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "MAGV";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 9;
            // 
            // grbBODE
            // 
            this.grbBODE.Controls.Add(this.speCauHoi);
            this.grbBODE.Controls.Add(this.cmbTrinhDo);
            this.grbBODE.Controls.Add(this.cmbDapAn);
            this.grbBODE.Controls.Add(dAP_ANLabel);
            this.grbBODE.Controls.Add(txtD);
            this.grbBODE.Controls.Add(this.txtDD);
            this.grbBODE.Controls.Add(txtC);
            this.grbBODE.Controls.Add(this.txtCC);
            this.grbBODE.Controls.Add(txtB);
            this.grbBODE.Controls.Add(this.txtBB);
            this.grbBODE.Controls.Add(aLabel1);
            this.grbBODE.Controls.Add(this.txtAA);
            this.grbBODE.Controls.Add(this.txtNoiDung);
            this.grbBODE.Controls.Add(cAUHOILabel);
            this.grbBODE.Controls.Add(mAMHLabel);
            this.grbBODE.Controls.Add(this.cmbMaMH);
            this.grbBODE.Controls.Add(tRINHDOLabel);
            this.grbBODE.Controls.Add(nOIDUNGLabel);
            this.grbBODE.Controls.Add(mAGVLabel);
            this.grbBODE.Controls.Add(this.txtMaGV);
            this.grbBODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBODE.Location = new System.Drawing.Point(0, 205);
            this.grbBODE.Name = "grbBODE";
            this.grbBODE.Size = new System.Drawing.Size(1356, 444);
            this.grbBODE.TabIndex = 6;
            this.grbBODE.TabStop = false;
            this.grbBODE.Text = "Thông tin câu hỏi";
            // 
            // speCauHoi
            // 
            this.speCauHoi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "CAUHOI", true));
            this.speCauHoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speCauHoi.Location = new System.Drawing.Point(102, 29);
            this.speCauHoi.MenuManager = this.barManager1;
            this.speCauHoi.Name = "speCauHoi";
            this.speCauHoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speCauHoi.Properties.Appearance.Options.UseFont = true;
            this.speCauHoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speCauHoi.Properties.ReadOnly = true;
            this.speCauHoi.Size = new System.Drawing.Size(100, 26);
            this.speCauHoi.TabIndex = 30;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "TRINHDO", true));
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTrinhDo.Location = new System.Drawing.Point(899, 29);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(121, 27);
            this.cmbTrinhDo.TabIndex = 29;
            // 
            // cmbDapAn
            // 
            this.cmbDapAn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "DAP_AN", true));
            this.cmbDapAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDapAn.FormattingEnabled = true;
            this.cmbDapAn.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbDapAn.Location = new System.Drawing.Point(1215, 172);
            this.cmbDapAn.MaxDropDownItems = 4;
            this.cmbDapAn.Name = "cmbDapAn";
            this.cmbDapAn.Size = new System.Drawing.Size(121, 27);
            this.cmbDapAn.TabIndex = 28;
            // 
            // txtDD
            // 
            this.txtDD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "D", true));
            this.txtDD.Location = new System.Drawing.Point(691, 204);
            this.txtDD.Multiline = true;
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(473, 50);
            this.txtDD.TabIndex = 25;
            // 
            // txtCC
            // 
            this.txtCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "C", true));
            this.txtCC.Location = new System.Drawing.Point(102, 204);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(473, 50);
            this.txtCC.TabIndex = 24;
            // 
            // txtBB
            // 
            this.txtBB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "B", true));
            this.txtBB.Location = new System.Drawing.Point(691, 149);
            this.txtBB.Multiline = true;
            this.txtBB.Name = "txtBB";
            this.txtBB.Size = new System.Drawing.Size(473, 50);
            this.txtBB.TabIndex = 23;
            // 
            // txtAA
            // 
            this.txtAA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "A", true));
            this.txtAA.Location = new System.Drawing.Point(102, 149);
            this.txtAA.Multiline = true;
            this.txtAA.Name = "txtAA";
            this.txtAA.Size = new System.Drawing.Size(473, 50);
            this.txtAA.TabIndex = 22;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "NOIDUNG", true));
            this.txtNoiDung.Location = new System.Drawing.Point(102, 64);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(1234, 76);
            this.txtNoiDung.TabIndex = 21;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsBoDe, "MAMH", true));
            this.cmbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsBoDe, "MAMH", true));
            this.cmbMaMH.DataSource = this.bdsMH;
            this.cmbMaMH.DisplayMember = "MAMH";
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(451, 28);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(244, 27);
            this.cmbMaMH.TabIndex = 3;
            this.cmbMaMH.ValueMember = "MAMH";
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBoDe, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(1215, 29);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Properties.Appearance.Options.UseFont = true;
            this.txtMaGV.Properties.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(121, 26);
            this.txtMaGV.TabIndex = 19;
            // 
            // formNhapDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 669);
            this.Controls.Add(this.grbBODE);
            this.Controls.Add(this.gcBODE);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formNhapDe";
            this.Text = "Bộ đề";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formNhapDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBoDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBODE)).EndInit();
            this.grbBODE.ResumeLayout(false);
            this.grbBODE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speCauHoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsMH;
        private DS DS;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.BODETableAdapter bODETableAdapter;
        private System.Windows.Forms.BindingSource bdsBoDe;
        private System.Windows.Forms.GroupBox grbBODE;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
        private DevExpress.XtraGrid.GridControl gcBODE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBODE;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.TextBox txtAA;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtDD;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtBB;
        private System.Windows.Forms.ComboBox cmbDapAn;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DevExpress.XtraEditors.SpinEdit speCauHoi;
    }
}