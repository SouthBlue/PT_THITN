﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class formChuanBiThi : Form
    {
        public formChuanBiThi()
        {
            InitializeComponent();
        }
        public int vitri;
        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formChuanBiThi_Load(object sender, EventArgs e)
        {
            


            DS.EnforceConstraints = false;

            

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);


            cmbMaGV.SelectedIndex = -1;
            cmbMaMH.SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;
            cmbTrinhDo.SelectedIndex = -1;
            grbGVDK.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGVDK.Position;
            bdsGVDK.AddNew();
            seLan.Value = 1;
            seSoCau.Value = 10;
            seThoiGian.Value = 15;
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            gcGVDK.Enabled = false;
            grbGVDK.Enabled = true;
        }

        private void btnUnDo_Click(object sender, EventArgs e)
        {
            cmbMaGV.SelectedIndex = -1;
            cmbMaMH.SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;
            cmbTrinhDo.SelectedIndex = -1;
            seLan.Value = 1;
            seSoCau.Value = 10;
            seThoiGian.Value = 15;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbMaGV.SelectedIndex = -1;
            cmbMaMH.SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;
            cmbTrinhDo.SelectedIndex = -1;
            seLan.Value = 1;
            seSoCau.Value = 10;
            seThoiGian.Value = 15;
            bdsGVDK.EndEdit();
            if (btnThem.Enabled == false)
            {
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            }
            bdsGVDK.Position = vitri;
            btnThem.Enabled = btnXoa.Enabled = gcGVDK.Enabled = btnReload.Enabled = true;
            grbGVDK.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa bản đăng ký này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đăng ký thi!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grbGVDK.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được ghi!\n Bạn chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdsGVDK.CancelEdit();
                    Close();
                }
                else return;
            }
            else
                Close();
        }
        
        private bool checkExists()
        {
            string strLenh = "DECLARE @result int " +
                           "EXEC @result = SP_DANGKYTHI N'" + cmbMaMH.SelectedValue.ToString() + "', N'" 
                           + cmbMaLop.SelectedValue.ToString() + "', N'"
                           + seLan.Value + "' " +
                           " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                return false;
            }
            else
                return true;

        }

        private bool checkSLCH()
        {
            string str = "DECLARE @result int " +
                           "EXEC @result = SP_KTSLCAUHOI N'" + cmbMaMH.SelectedValue.ToString() + "', N'"
                           + cmbTrinhDo.SelectedItem.ToString() + "', " 
                           + seSoCau.Value  + " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(str);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                return false;
            }
            else
                return true;
        }

        private void load()
        {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (cmbMaGV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã giảng viên!", "", MessageBoxButtons.OK);
                cmbMaGV.Focus();
                return;
            }
            if (cmbMaMH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã môn học!", "", MessageBoxButtons.OK);
                cmbMaMH.Focus();
                return;
            }
            if (cmbMaLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã lớp!", "", MessageBoxButtons.OK);
                cmbMaLop.Focus();
                return;
            }
            if (cmbTrinhDo.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trình độ!", "", MessageBoxButtons.OK);
                cmbTrinhDo.Focus();
                return;
            }
            if(dateNgayThi.Value < DateTime.Today )
            {
                MessageBox.Show("Không thể chọn này thi ở quá khứ!", "", MessageBoxButtons.OK);
                dateNgayThi.Focus();
                return;
            }
            if(seLan.Value>2 || seLan.Value < 1)
            {
                MessageBox.Show("Lần thi phải lớn hơn hoặc bằng 1 và nhỏ hơn hoặc bằng 2!", "", MessageBoxButtons.OK);
                seLan.Focus();
                return;
            }
            if (seSoCau.Value < 10 || seSoCau.Value > 100)
            {
                MessageBox.Show("Số câu thi phải lớn hơn hoặc bằng 10 và nhỏ hơn hoặc bằng 100!", "", MessageBoxButtons.OK);
                seSoCau.Focus();
                return;
            }
            if (seThoiGian.Value > 60 || seThoiGian.Value < 15)
            {
                MessageBox.Show("Thời gian thi phải từ 15 đến 60 phút!", "", MessageBoxButtons.OK);
                seThoiGian.Focus();
                return;
            }
            if (!checkExists())
            {
                MessageBox.Show("Môn học "+ cmbMaMH.Text + " đã được đăng ký cho lớp " + cmbMaLop.Text
                    +" thi lần " + seLan.Value, "", MessageBoxButtons.OK);
                return;
            }
            if (!checkSLCH())
            {
                MessageBox.Show("Số lượng câu hỏi trong CSDL không đáp ứng đủ cho đề thi này!", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAGV"] = cmbMaGV.SelectedValue.ToString();
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["MAMH"] = cmbMaMH.SelectedValue.ToString();
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["MALOP"] = cmbMaLop.SelectedValue.ToString();
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["TRINHDO"] = cmbTrinhDo.SelectedItem.ToString(); 
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["NGAYTHI"] = dateNgayThi.Value;
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["LAN"] = seLan.Value;
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["SOCAUTHI"] = seSoCau.Value;
                ((DataRowView)bdsGVDK[bdsGVDK.Position])["THOIGIAN"] = seThoiGian.Value;
                bdsGVDK.EndEdit();
                bdsGVDK.ResetCurrentItem();
                bdsGVDK.Position = vitri;
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.DS.GIAOVIEN_DANGKY);


                load();
                cmbMaGV.SelectedIndex = -1;
                cmbMaMH.SelectedIndex = -1;
                cmbMaLop.SelectedIndex = -1;
                cmbTrinhDo.SelectedIndex = -1;
                seLan.Value = 1;
                seSoCau.Value = 10;
                seThoiGian.Value = 15;

                MessageBox.Show("Ghi bản đăng ký thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bản đăng ký!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
            btnThem.Enabled = btnXoa.Enabled = gcGVDK.Enabled = btnReload.Enabled = true;
            grbGVDK.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();

        }
    }
}
