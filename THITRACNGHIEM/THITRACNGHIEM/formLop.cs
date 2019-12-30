using System;
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
    public partial class formLop : Form
    {
        public int vitriLop;
        public int vitriSV;
        public formLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        public void load()
        {
            DS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
        } 
        private void formLop_Load(object sender, EventArgs e)
        {
            

            DS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.DS.BANGDIEM);
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = true;
                grbLop.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                btnGhi.Enabled = btnUndo.Enabled = false;
                grbLop.Enabled = false;
            }
           
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriLop = bdsLop.Position;
            grbLop.Enabled = true;
            bdsLop.AddNew();

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp đã có giáo viên đăng ký!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.DS.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriLop = bdsLop.Position;
            grbLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcLop.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            if (btnThem.Enabled == false)
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DS.LOP);
            }
            bdsLop.Position = vitriLop;
            gcLop.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcLop.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbLop.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (cmbKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã khoa!", "", MessageBoxButtons.OK);
                cmbKhoa.Focus();
                return;
            }
            string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_KTMALOP '" + txtMaLop.Text + "'" +
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            int positionMALOP = bdsLop.Find("MALOP", txtMaLop.Text);
            if (result == 1 && (bdsLop.Position != positionMALOP) )
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                bdsLop.Position = vitriLop;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.DS.LOP);

                MessageBox.Show("Ghi lớp thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcLop.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbLop.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được ghi!\n Bạn chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdsLop.CancelEdit();
                    Close();
                }
                else return;
            }
            else
                Close();
        }

        //Thêm sửa xóa ghi sinh viên////////////
        public string maSV, hoSV, tenSV, ngaySinhSV, diaChiSV;

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên đã làm bài thi!", "", MessageBoxButtons.OK);
                return;
            }
            
            if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            vitriLop = bdsLop.Position;
            vitriSV = bdsSV.Position;
            formSV frm = new formSV();
            frm.masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
            frm.hosv = ((DataRowView)bdsSV[bdsSV.Position])["HO"].ToString();
            frm.tensv = ((DataRowView)bdsSV[bdsSV.Position])["TEN"].ToString();
            frm.ngaysinh = ((DataRowView)bdsSV[bdsSV.Position])["NGAYSINH"].ToString();
            frm.diachisv = ((DataRowView)bdsSV[bdsSV.Position])["DIACHI"].ToString();
            frm.maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            frm.mydata = new formSV.GETDATA(getValue);
            frm.ShowDialog();
            if (frm.flagAdd)
            {
                ghiSV();
            }
            else
            {
                bdsSV.Position = vitriSV;
                bdsSV.CancelEdit();
            }
        }

        public void getValue(string ma, string ho, string ten, string ngaySinh, string diaChi)
        {
            maSV = ma;
            hoSV = ho;
            tenSV = ten;
            ngaySinhSV = ngaySinh;
            diaChiSV = diaChi;
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            vitriLop = bdsLop.Position;
            vitriSV = bdsSV.Position;
            bdsSV.AddNew();
            formSV frm = new formSV();
            frm.maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
            frm.mydata = new formSV.GETDATA(getValue);
            frm.ShowDialog();

            if (frm.flagAdd)
            {
                ghiSV();
            }
            else
            {
                
                bdsSV.CancelEdit();
                bdsSV.Position = vitriSV;

            }

        }

        private void ghiSV()
        {
            
            try
            {
                ((DataRowView)bdsSV[bdsSV.Position])["MASV"] = maSV;
                ((DataRowView)bdsSV[bdsSV.Position])["HO"] = hoSV;
                ((DataRowView)bdsSV[bdsSV.Position])["TEN"] = tenSV;
                ((DataRowView)bdsSV[bdsSV.Position])["NGAYSINH"] = ngaySinhSV;
                ((DataRowView)bdsSV[bdsSV.Position])["DIACHI"] = diaChiSV;
                ((DataRowView)bdsSV[bdsSV.Position])["MALOP"] = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                bdsLop.Position = vitriLop;
                bdsSV.Position = vitriSV;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.DS.SINHVIEN);

                MessageBox.Show("Ghi sinh viên thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
