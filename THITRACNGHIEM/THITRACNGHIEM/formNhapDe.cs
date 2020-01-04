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
    public partial class formNhapDe : Form
    {
        public formNhapDe()
        {
            InitializeComponent();
        }
        public int vitri;
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        public void load()
        {
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsBoDe.Filter = "MAGV = '" + Program.username + "'";
            }
        }
        private void formNhapDe_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;            
            this.bODETableAdapter.Fill(this.DS.BODE);

            if (Program.mGroup == "TRUONG")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnUndo.Enabled = false;
                btnReload.Enabled = true;
                grbBODE.Enabled = false;
            }
            else
            {
                btnGhi.Enabled = btnUndo.Enabled = false;
                grbBODE.Enabled = false;
            }
            if(Program.mGroup == "GIANGVIEN")
            {
                bdsBoDe.Filter = "MAGV = '" + Program.username + "'"; 
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsBoDe.Position;
            grbBODE.Enabled = true;
            bdsBoDe.AddNew();
            string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_MAXCH " +
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            speCauHoi.Value = result + 1;
            cmbTrinhDo.SelectedIndex = cmbDapAn.SelectedIndex = -1;
            txtMaGV.Text = Program.username;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcBODE.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"].ToString().Trim().CompareTo(Program.username.Trim()) != 0)
            {
                MessageBox.Show("Bạn không có quyền xóa câu hỏi này!", "", MessageBoxButtons.OK);
                return;
            }
            else {
                if (MessageBox.Show("Bạn có thực sự muốn xóa câu hỏi này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsBoDe.RemoveCurrent();
                        this.bODETableAdapter.Update(this.DS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa câu hỏi!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (((DataRowView)bdsBoDe[bdsBoDe.Position])["MAGV"].ToString().Trim().CompareTo(Program.username.Trim()) != 0)
            {
                MessageBox.Show("Bạn không có quyền hiệu chỉnh câu hỏi này!", "", MessageBoxButtons.OK);
                return;
            }
            vitri = bdsBoDe.Position;
            grbBODE.Enabled = true;

            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcBODE.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBoDe.CancelEdit();
            if (btnThem.Enabled == false)
            {
                this.bODETableAdapter.Fill(this.DS.BODE);
                if (Program.mGroup == "GIANGVIEN")
                {
                    bdsBoDe.Filter = "MAGV = '" + Program.username + "'";
                }
            }
            bdsBoDe.Position = vitri;
            gcBODE.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcBODE.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbBODE.Enabled = false;
            
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn mã môn học!", "", MessageBoxButtons.OK);
                cmbMaMH.Focus();
                return;
            }
            if (cmbTrinhDo.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn trình độ!", "", MessageBoxButtons.OK);
                cmbTrinhDo.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim() == "" || txtAA.Text.Trim() == "" ||
                txtBB.Text.Trim() == "" || txtCC.Text.Trim() == ""|| txtDD.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung và đáp án không được để trống!", "", MessageBoxButtons.OK);
                return;
            }
            if(cmbDapAn.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đáp án đúng!", "", MessageBoxButtons.OK);
                cmbDapAn.Focus();
                return;
            }
            try
            {
                bdsBoDe.EndEdit();
                bdsBoDe.ResetCurrentItem();
                bdsBoDe.Position = vitri;
                this.bODETableAdapter.Update(this.DS.BODE);

                MessageBox.Show("Ghi câu hỏi thành công!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi câu hỏi!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = gcBODE.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            grbBODE.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.bODETableAdapter.Fill(this.DS.BODE);
            if (Program.mGroup == "GIANGVIEN")
            {
                bdsBoDe.Filter = "MAGV = '" + Program.username + "'";
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnGhi.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được ghi!\n Bạn chắc chắn muốn thoát?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdsBoDe.CancelEdit();
                    Close();
                }
                else return;
            }
            else
                Close();
        }


    }
}
