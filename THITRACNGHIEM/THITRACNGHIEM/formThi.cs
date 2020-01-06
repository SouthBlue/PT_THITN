using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace THITRACNGHIEM
{
    public partial class formThi : Form
    {
        public formThi()
        {
            InitializeComponent();
        }


        private void formThi_Load(object sender, EventArgs e)
        {
           
            
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            if(Program.mGroup == "SINHVIEN")
            {
                txtHoTen.Text = Program.mHoten;
                string strLenh = "EXEC SP_LAYLOP '" + Program.username + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                cmbLOP.SelectedItem = Program.myReader.GetString(0);
                txtTenLop.Text = Program.myReader.GetString(1);
                Program.myReader.Close();
                cmbLOP.Enabled = false;
            }
        }
        private bool ktraDaThi()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_KTDATHI '" + Program.username +"', N'" + cmbMH.SelectedValue.ToString() + "', '" + seLanThi.Value + "' " +
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
        private void btnBATĐAU_Click(object sender, EventArgs e)
        {
            if (!ktraDaThi())
            {
                MessageBox.Show("Sinh viên đã hoàn thành kỳ thi này!", "", MessageBoxButtons.OK);
                return;
            }
            string date = ((DataRowView)bdsGVDK[bdsGVDK.Position])["NGAYTHI"].ToString();
            string[] temp = date.Split(' ');
            if (DateTime.ParseExact(temp[0], "dd/MM/yyyy", CultureInfo.InvariantCulture) < DateTime.Today)
            {
                MessageBox.Show("Kỳ thi này đã kết thúc!", "", MessageBoxButtons.OK);
                return;
            }
            if (DateTime.ParseExact(temp[0], "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.Today)
            {
                MessageBox.Show("Kỳ thi này chưa bắt đầu!", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                formLamBaiThi l = new formLamBaiThi();
                l.tenSV = txtHoTen.Text;
                l.maLop = cmbLOP.Text;
                l.tenLop = txtTenLop.Text;
                l.maMH = cmbMH.SelectedValue.ToString();
                l.lan = seLanThi.Value;
                l.trinhDo = ((DataRowView)bdsGVDK[bdsGVDK.Position])["TRINHDO"].ToString();
                l.soCau = int.Parse(((DataRowView)bdsGVDK[bdsGVDK.Position])["SOCAUTHI"].ToString());
                l.ngayThi = ((DataRowView)bdsGVDK[bdsGVDK.Position])["NGAYTHI"].ToString();
                l.thoiGian = int.Parse(((DataRowView)bdsGVDK[bdsGVDK.Position])["THOIGIAN"].ToString());
                l.ShowDialog();
            }
                        
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void cmbMH_SelectedValueChanged(object sender, EventArgs e)
        {
            bdsGVDK.Filter = "MAMH = '" + cmbMH.SelectedValue + "' AND LAN = '" + seLanThi.Value  + "'" ;
        }



        private void seLanThi_EditValueChanged(object sender, EventArgs e)
        {
            bdsGVDK.Filter = "MAMH = '" + cmbMH.SelectedValue + "' AND LAN = '" + seLanThi.Value + "'";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
