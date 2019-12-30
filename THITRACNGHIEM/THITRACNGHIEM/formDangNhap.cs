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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            this.Dispose();
        }
        private void forrmDangNhap_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = "Data Source=VIETNAM-PC\\VNSERVER;Initial Catalog="+Program.database+";Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbCS.DataSource = dt;
            cmbCS.DisplayMember = "TENCS";
            cmbCS.ValueMember = "TENSERVER";
            cmbCS.SelectedIndex = -1;
            cmbCS.SelectedIndex = 0;

        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                Program.servername = cmbCS.SelectedValue.ToString();

            }
            catch (Exception) { };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;

            Program.mCoSo = cmbCS.SelectedIndex;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);    
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            
            MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK);
            
            Program.formChinh = new formMain();
            Program.formChinh.Activate();
            Program.formChinh.Show();
            Program.formDangNhap.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
