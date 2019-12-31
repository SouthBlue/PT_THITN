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
    public partial class formKhoa : Form
    {
        public int vitriKH;
        public int vitriGV;
        public string macs = "";
        public formKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formKhoa_Load(object sender, EventArgs e)
        {
            

            DS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);


            macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = true;
                grbKhoa.Enabled = false;
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                btnGhi.Enabled = btnUndo.Enabled = false;
                grbKhoa.Enabled = false;
            }
            
        }
        public void load()
        {
            DS.EnforceConstraints = false;
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);
        }
        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriKH = bdsKhoa.Position;
            grbKhoa.Enabled = true;
            bdsKhoa.AddNew();
            txtMaCS.Text = macs;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKhoa.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã lập lớp!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGV.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã lập giáo viên!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa khoa này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsKhoa.RemoveCurrent();
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.DS.KHOA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriKH = bdsKhoa.Position;
            grbKhoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcKhoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            if (btnThem.Enabled == false)
            {
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.DS.KHOA);
            }
            bdsKhoa.Position = vitriKH;
            gcKhoa.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcKhoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbKhoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được để trống!", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return;
            }
            string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_KTMAKHOA '" + txtMaKhoa.Text + "', N'" + txtTenKhoa.Text +"' "+
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            int positionMAKH = bdsKhoa.Find("MAKH", txtMaKhoa.Text);
            int positionTenKH = bdsKhoa.Find("TENKH", txtTenKhoa.Text);
            if (result == 1 && (bdsKhoa.Position != positionMAKH))
            {
                MessageBox.Show("Mã khoa đã tồn tại!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();

                return;
            }
            if (result == 2 && (bdsKhoa.Position != positionTenKH))
            {
                MessageBox.Show("Tên khoa đã tồn tại!", "", MessageBoxButtons.OK);
                txtTenKhoa.Focus();

                return;
            }
            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                bdsKhoa.Position = vitriKH;
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Update(this.DS.KHOA);

                MessageBox.Show("Ghi Khoa thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khoa!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcKhoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbKhoa.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);

            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được ghi!\n Bạn chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdsKhoa.CancelEdit();
                    Close();
                }
                else return;
            }
            else
                Close();
        }


        /*-------------------GIÁO VIÊN-------------------*/


        public string maGV, hoGV, tenGV, diaChiGV;
        public void getValue(string ma, string ho, string ten, string diaChi)
        {
            maGV = ma;
            hoGV = ho;
            tenGV = ten;
            diaChiGV = diaChi;
        }
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            vitriKH = bdsKhoa.Position;
            vitriGV = bdsGV.Position;
            bdsGV.AddNew();
            formGiaoVien frm = new formGiaoVien();
            frm.maKH = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
            frm.mydata = new formGiaoVien.GETDATA(getValue);
            frm.ShowDialog();

            if (frm.flagAdd)
            {
                ghiGV();
            }
            else
            {

                bdsGV.CancelEdit();
                bdsGV.Position = vitriGV;

            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên đã đăng ký thi!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Không thể xóa giáo viên đã lập bộ đề!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa giáo viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGV.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        


        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            vitriKH = bdsKhoa.Position;
            vitriGV = bdsGV.Position;
            formGiaoVien frm = new formGiaoVien();
            frm.magv = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
            frm.hogv = ((DataRowView)bdsGV[bdsGV.Position])["HO"].ToString();
            frm.tengv = ((DataRowView)bdsGV[bdsGV.Position])["TEN"].ToString();
            frm.diachigv = ((DataRowView)bdsGV[bdsGV.Position])["DIACHI"].ToString();
            frm.maKH = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
            frm.mydata = new formGiaoVien.GETDATA(getValue);
            frm.ShowDialog();
            if (frm.flagAdd)
            {
                ghiGV();
            }
            else
            {
                bdsGV.Position = vitriGV;
                bdsGV.CancelEdit();
            }
        }
        private void ghiGV()
        {

            try
            {
                ((DataRowView)bdsGV[bdsGV.Position])["MAGV"] = maGV;
                ((DataRowView)bdsGV[bdsGV.Position])["HO"] = hoGV;
                ((DataRowView)bdsGV[bdsGV.Position])["TEN"] = tenGV;
                ((DataRowView)bdsGV[bdsGV.Position])["DIACHI"] = diaChiGV;
                ((DataRowView)bdsGV[bdsGV.Position])["MAKH"] = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                bdsKhoa.Position = vitriKH;
                bdsGV.Position = vitriGV;
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);

                MessageBox.Show("Ghi giáo viên thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm giáo viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

    }
}
