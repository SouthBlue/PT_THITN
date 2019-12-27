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
        public int vitri;
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
            macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            /* cmbCoSo.DataSource = Program.bds_dspm;
             cmbCoSo.DisplayMember = "TenCS";
             cmbCoSo.ValueMember = "TenServer";
             cmbCoSo.SelectedIndex = Program.mCoSo;
             if (Program.mGroup == "TRUONG") cmbCoSo.Enabled = true;
             else cmbCoSo.Enabled = false;*/
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbKhoa.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKhoa.Position;
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
            vitri = bdsKhoa.Position;
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
            bdsKhoa.Position = vitri;
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
                            "EXEC @result = SP_KTMAKHOA '" + txtMaKhoa.Text + "'" +
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Mã khoa đã tồn tại!", "", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                Program.myReader.Close();
                return;
            }
            try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                bdsKhoa.Position = vitri;
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
    }
}
