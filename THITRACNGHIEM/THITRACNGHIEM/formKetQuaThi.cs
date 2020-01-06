using DevExpress.XtraReports.UI;
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
    public partial class formKetQuaThi : Form
    {
        public formKetQuaThi()
        {
            InitializeComponent();
        }

        private string lop;
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formKetQuaThi_Load(object sender, EventArgs e)
        {
          
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            if (Program.mGroup == "SINHVIEN")
            {
                txtSinhVien.Text = Program.mHoten;
                string strLenh = "EXEC SP_LAYLOP '" + Program.username + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                lop = Program.myReader.GetString(0);
                txtLop.Text = Program.myReader.GetString(1);
                Program.myReader.Close();
                
            }
            cmbLan.SelectedIndex = 0;
        }
        private bool ktraDaThi()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_KTDATHI '" + Program.username + "', N'" + cmbMonHoc.SelectedValue.ToString() + "', '" + cmbLan.Text + "' " +
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

            }
            return true;
        }
        private DateTime NgayThi()
        {
            string strLenh = "EXEC SP_LAYNGAY '" + Program.username + "', N'"+ cmbMonHoc.SelectedValue.ToString() + "', " + cmbLan.Text;

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            DateTime ngaythi = Program.myReader.GetDateTime(0);
            Program.myReader.Close();
            return ngaythi;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInKQ_Click(object sender, EventArgs e)
        {
            if (ktraDaThi())
            {
                MessageBox.Show("Bạn chưa làm bài thi này!", "", MessageBoxButtons.OK);
                return;
            }
            rptKetQua rpt = new rptKetQua(Program.username, cmbMonHoc.SelectedValue.ToString(), Int16.Parse(cmbLan.Text));
            rpt.xrlLop.Text = lop;
            rpt.xrlMonThi.Text = cmbMonHoc.Text.ToString();
            rpt.xrlNgayThi.Text = NgayThi().ToString("dd/MM/yyyy");
            rpt.xrLHoten.Text = Program.mHoten;
            rpt.xrlLanThi.Text = cmbLan.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
