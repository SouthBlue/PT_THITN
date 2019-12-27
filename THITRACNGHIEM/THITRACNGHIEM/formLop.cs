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
        public int vitri;
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

            /* cmbCoSo.DataSource = Program.bds_dspm;
             cmbCoSo.DisplayMember = "TenCS";
             cmbCoSo.ValueMember = "TenServer";
             cmbCoSo.SelectedIndex = Program.mCoSo           if (Program.mGroup == "TRUONG") cmbCoSo.Enabled = true;
             else cmbCoSo.Enabled = false;*/
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbLop.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLop.Position;
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
            vitri = bdsLop.Position;
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
            bdsLop.Position = vitri;
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
            if (result == 1)
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                bdsLop.Position = vitri;
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

    }
}
