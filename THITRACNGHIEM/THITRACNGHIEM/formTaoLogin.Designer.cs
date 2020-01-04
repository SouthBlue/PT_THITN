namespace THITRACNGHIEM
{
    partial class formTaoLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSV = new System.Windows.Forms.RadioButton();
            this.rdGV = new System.Windows.Forms.RadioButton();
            this.rdCoSo = new System.Windows.Forms.RadioButton();
            this.rdTruong = new System.Windows.Forms.RadioButton();
            this.DS = new THITRACNGHIEM.DS();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new THITRACNGHIEM.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bdsGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GVCSTableAdapter = new THITRACNGHIEM.DSTableAdapters.SP_GVCSTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSV);
            this.groupBox1.Controls.Add(this.rdGV);
            this.groupBox1.Controls.Add(this.rdCoSo);
            this.groupBox1.Controls.Add(this.rdTruong);
            this.groupBox1.Location = new System.Drawing.Point(282, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUYỀN";
            // 
            // rdSV
            // 
            this.rdSV.AutoSize = true;
            this.rdSV.Location = new System.Drawing.Point(114, 111);
            this.rdSV.Name = "rdSV";
            this.rdSV.Size = new System.Drawing.Size(105, 23);
            this.rdSV.TabIndex = 3;
            this.rdSV.TabStop = true;
            this.rdSV.Text = "SINH VIÊN";
            this.rdSV.UseVisualStyleBackColor = true;
            this.rdSV.CheckedChanged += new System.EventHandler(this.rdSV_CheckedChanged);
            // 
            // rdGV
            // 
            this.rdGV.AutoSize = true;
            this.rdGV.Location = new System.Drawing.Point(114, 85);
            this.rdGV.Name = "rdGV";
            this.rdGV.Size = new System.Drawing.Size(118, 23);
            this.rdGV.TabIndex = 2;
            this.rdGV.TabStop = true;
            this.rdGV.Text = "GIẢNG VIÊN";
            this.rdGV.UseVisualStyleBackColor = true;
            this.rdGV.CheckedChanged += new System.EventHandler(this.rdGV_CheckedChanged);
            // 
            // rdCoSo
            // 
            this.rdCoSo.AutoSize = true;
            this.rdCoSo.Location = new System.Drawing.Point(114, 55);
            this.rdCoSo.Name = "rdCoSo";
            this.rdCoSo.Size = new System.Drawing.Size(75, 23);
            this.rdCoSo.TabIndex = 1;
            this.rdCoSo.TabStop = true;
            this.rdCoSo.Text = "SƠ CỞ";
            this.rdCoSo.UseVisualStyleBackColor = true;
            this.rdCoSo.CheckedChanged += new System.EventHandler(this.rdCoSo_CheckedChanged);
            // 
            // rdTruong
            // 
            this.rdTruong.AutoSize = true;
            this.rdTruong.Location = new System.Drawing.Point(114, 25);
            this.rdTruong.Name = "rdTruong";
            this.rdTruong.Size = new System.Drawing.Size(93, 23);
            this.rdTruong.TabIndex = 0;
            this.rdTruong.TabStop = true;
            this.rdTruong.Text = "TRƯỜNG";
            this.rdTruong.UseVisualStyleBackColor = true;
            this.rdTruong.CheckedChanged += new System.EventHandler(this.rdTruong_CheckedChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN";
            this.bdsSinhVien.DataSource = this.DS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(282, 205);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(369, 26);
            this.txtLoginName.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(282, 300);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(369, 26);
            this.txtPass.TabIndex = 6;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(282, 346);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(369, 26);
            this.txtConfirmPass.TabIndex = 7;
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(282, 250);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(369, 27);
            this.cmbUsername.TabIndex = 8;
            this.cmbUsername.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(282, 412);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(130, 33);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo tài khoản";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(521, 412);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // bdsGiaoVien
            // 
            this.bdsGiaoVien.DataMember = "SP_GVCS";
            this.bdsGiaoVien.DataSource = this.DS;
            // 
            // sP_GVCSTableAdapter
            // 
            this.sP_GVCSTableAdapter.ClearBeforeFill = true;
            // 
            // formTaoLogin
            // 
            this.AcceptButton = this.btnTao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 475);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formTaoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Login";
            this.Load += new System.EventHandler(this.formTaoLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSV;
        private System.Windows.Forms.RadioButton rdGV;
        private System.Windows.Forms.RadioButton rdCoSo;
        private System.Windows.Forms.RadioButton rdTruong;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource bdsGiaoVien;
        private DSTableAdapters.SP_GVCSTableAdapter sP_GVCSTableAdapter;
    }
}