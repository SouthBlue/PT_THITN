namespace THITRACNGHIEM
{
    partial class formSV
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSV));
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoSV = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSV = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.DS = new THITRACNGHIEM.DS();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(79, 39);
            mASVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(119, 19);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "MÃ SINH VIÊN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(79, 77);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "HỌ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(79, 115);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "TÊN:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(79, 153);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(97, 19);
            nGAYSINHLabel.TabIndex = 7;
            nGAYSINHLabel.Text = "NGÀY SINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(79, 191);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 19);
            dIACHILabel.TabIndex = 9;
            dIACHILabel.Text = "ĐỊA CHỈ:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(79, 229);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(71, 19);
            mALOPLabel.TabIndex = 11;
            mALOPLabel.Text = "MÃ LỚP:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(235, 36);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Properties.Appearance.Options.UseFont = true;
            this.txtMaSV.Size = new System.Drawing.Size(397, 26);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(235, 74);
            this.txtHoSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoSV.Properties.Appearance.Options.UseFont = true;
            this.txtHoSV.Size = new System.Drawing.Size(397, 26);
            this.txtHoSV.TabIndex = 4;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(235, 112);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSV.Properties.Appearance.Options.UseFont = true;
            this.txtTenSV.Size = new System.Drawing.Size(397, 26);
            this.txtTenSV.TabIndex = 6;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgaySinh.Location = new System.Drawing.Point(235, 150);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(397, 26);
            this.dateNgaySinh.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(235, 188);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(397, 26);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(235, 226);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Properties.Appearance.Options.UseFont = true;
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(397, 26);
            this.txtMaLop.TabIndex = 12;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.DS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnGhi
            // 
            this.btnGhi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGhi.Appearance.Options.UseFont = true;
            this.btnGhi.Appearance.Options.UseForeColor = true;
            this.btnGhi.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGhi.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGhi.AppearancePressed.Options.UseBackColor = true;
            this.btnGhi.AppearancePressed.Options.UseForeColor = true;
            this.btnGhi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Location = new System.Drawing.Point(260, 273);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(135, 38);
            this.btnGhi.TabIndex = 15;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Location = new System.Drawing.Point(473, 273);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(135, 38);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.Text = "Phục hồi";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click_1);
            // 
            // formSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 342);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(mASVLabel);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(hOLabel);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(tENLabel);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(nGAYSINHLabel);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.txtMaLop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên tùy chỉnh";
            this.Load += new System.EventHandler(this.formSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtHoSV;
        private DevExpress.XtraEditors.TextEdit txtTenSV;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
    }
}