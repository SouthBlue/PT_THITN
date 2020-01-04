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
    public partial class formTaoLogin : Form
    {
        public formTaoLogin()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formTaoLogin_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DS.SINHVIEN);

            this.sP_GVCSTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GVCSTableAdapter.Fill(this.DS.SP_GVCS);

            if (Program.mGroup == "TRUONG")
            {
                rdCoSo.Enabled = rdGV.Enabled = rdSV.Enabled = false;
            }
            if(Program.mGroup == "COSO")
            {
                rdTruong.Enabled = false;
            }
            if (Program.mGroup == "GIANGVIEN")
            {
                rdCoSo.Enabled = rdTruong.Enabled = rdSV.Enabled = false;
            }

        }

        private void rdTruong_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTruong.Checked == true)
            {
                cmbUsername.DataSource = bdsGiaoVien;
                cmbUsername.DisplayMember = cmbUsername.ValueMember = "MAGV";
                txtLoginName.Text = "";
                txtLoginName.ReadOnly = false;
            }
        }

        private void rdCoSo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCoSo.Checked == true)
            {
                cmbUsername.DataSource = bdsGiaoVien;
                cmbUsername.DisplayMember = cmbUsername.ValueMember = "MAGV";
                txtLoginName.Text = "";
                txtLoginName.ReadOnly = false;
            }
        }

        private void rdGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGV.Checked == true)
            {
                cmbUsername.DataSource = bdsGiaoVien;
                cmbUsername.DisplayMember = cmbUsername.ValueMember = "MAGV";
                txtLoginName.Text = "";
                txtLoginName.ReadOnly = false;
            }
        }

        private void rdSV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSV.Checked == true)
            {
                cmbUsername.DataSource = bdsSinhVien;
                cmbUsername.DisplayMember = cmbUsername.ValueMember = "MASV";
                txtLoginName.Text = cmbUsername.SelectedValue.ToString();
                txtLoginName.ReadOnly = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rdSV.Checked == true)
            {
                txtLoginName.Text = cmbUsername.SelectedValue.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
                this.Close();

        }
        private string role()
        {
            string str = "";
            if (rdTruong.Checked == true) str = "TRUONG";
            if (rdCoSo.Checked == true) str = "COSO";
            if (rdGV.Checked == true) str = "GIANGVIEN";
            if (rdSV.Checked == true) str = "SINHVIEN";
            return str;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLoginName.Text.Trim() == null)
            {
                MessageBox.Show("Vui lòng nhập LoginName!", "", MessageBoxButtons.OK);
                txtLoginName.Focus();
                return;
            }
            if(txtPass.Text.Trim().CompareTo(txtConfirmPass.Text.Trim()) != 0)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_TAOTAIKHOAN N'" + txtLoginName.Text  + "', N'" + txtPass.Text.Trim() + "', N'" +
                            cmbUsername.Text + "', N'"+ role() +"'"+
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }

        
    }
}
