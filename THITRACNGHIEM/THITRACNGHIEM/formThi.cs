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
                string strLenh = "EXEC SP_LAYLOP '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                cmbLOP.SelectedItem = Program.myReader.GetString(0);
                txtTenLop.Text = Program.myReader.GetString(1);
                Program.myReader.Close();
                cmbLOP.Enabled = false;
                btnBATĐAU.Focus();
            }
        }

        private void btnBATĐAU_Click(object sender, EventArgs e)
        {
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
                l.Show();
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
    }
}
