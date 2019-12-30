using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            
            InitializeComponent();
            if (Program.mGroup.CompareTo("SINHVIEN") == 0)
            {
                MA.Text = "Mã: " + Program.mlogin;
                HOTEN.Text = "Họ và Tên: " + Program.mHoten;
            }
            else
            {
                MA.Text = "Mã: " + Program.username;
                HOTEN.Text = "Họ và Tên: " + Program.mHoten;
                NHOM.Text = "Nhóm: " + Program.mGroup;
            }
            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TenCS";
            cmbCoSo.ValueMember = "TenServer";
            cmbCoSo.SelectedIndex = Program.mCoSo;
            if (Program.mGroup == "TRUONG")
            {
                btnThi.Enabled = false;
                cmbCoSo.Enabled = true;
            }


            if (Program.mGroup == "GIANGVIEN")
            {
                btnMH.Enabled = false;
                btnKhoa.Enabled = false;
                btnLop.Enabled = false;
            }
            if (Program.mGroup == "SINHVIEN")
            {
                btnMH.Enabled = false;
                btnKhoa.Enabled = false;
                btnLop.Enabled = false;
                btnBode.Enabled = false;
            }
            if (Program.mGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                
            }
            Program.formKhoa = new formKhoa();
            Program.formLop = new formLop();
            Program.formNhapDe = new formNhapDe();
            btnLogout.Enabled = true;
            
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                formMonHoc m = new formMonHoc();
                m.MdiParent = this;
                m.Show();
            }
        }


        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.formChinh.Close();
                Program.formDangNhap.Close();
            }
            else return;

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKhoa));
            if (frm != null) frm.Activate();
            else
            {
                Program.formKhoa = new formKhoa();
                Program.formKhoa.MdiParent = this;
                Program.formKhoa.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(formLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.formLop = new formLop();
                Program.formLop.MdiParent = this;
                Program.formLop.Show();
            }
        }

        

        private void btnNhapDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formNhapDe));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhapDe = new formNhapDe();
                Program.formNhapDe.MdiParent = this;
                Program.formNhapDe.Show();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.ValueMember != "")
            {
                if (cmbCoSo.SelectedValue != null && Program.servername != cmbCoSo.SelectedValue.ToString())
                {

                    Program.servername = cmbCoSo.SelectedValue.ToString();

                    if (Program.mlogin != Program.remoteLogin)
                    {
                        Program.mlogin = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }

                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Program.formKhoa.load();
                        Program.formLop.load();
                        Program.formNhapDe.load();
                    }
                }
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.formChinh.MA.Text = "";
            Program.formChinh.HOTEN.Text = "";
            Program.formChinh.NHOM.Text = "";
            Program.formDangNhap.Visible = true;
            Program.formChinh.Close();
        }

        
    }
}
