using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace THITRACNGHIEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username;
        public static String password;
        public static String mlogin;

        public static String database = "THITN";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123456";

        public static String mloginDN;
        public static String passwordDN;
        public static String mGroup;
        public static String mHoten;
        public static int mCoSo;

        public static BindingSource bds_dspm = new BindingSource();
        public static formMain formChinh;
        public static formDangNhap formDangNhap;
        public static formKhoa formKhoa;
        public static formLop formLop;
        public static formNhapDe formNhapDe;
        

             

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, Program.conn); ;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return 0;
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formDangNhap = new formDangNhap();
            Application.Run(formDangNhap);
        }
    }

}
