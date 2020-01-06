using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace THITRACNGHIEM
{
    public partial class formLamBaiThi : Form
    {
        public formLamBaiThi()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {

            get
            {

                CreateParams param = base.CreateParams;

                param.ClassStyle = param.ClassStyle | 0x200;

                return param;

            }

        }

        public string maMH, maLop, tenLop, tenSV, trinhDo, ngayThi;

        private int b, c;
        private double Diem;
        private void rbtnB_CheckedChanged(object sender, EventArgs e)
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if(rbtnB.Checked == true) 
            {
                dgvDETHI.Rows[rowSelected].Cells["dachon"].Value = "B";
            }
            
        }

        private void rbtnC_CheckedChanged(object sender, EventArgs e)
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if(rbtnC.Checked == true)
            {
                dgvDETHI.Rows[rowSelected].Cells["dachon"].Value = "C";
            }
                
        }

        private void rbtnD_CheckedChanged(object sender, EventArgs e)
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if (rbtnD.Checked == true)
            {
                dgvDETHI.Rows[rowSelected].Cells["dachon"].Value = "D";
            }
        }



        private void rbtnA_CheckedChanged(object sender, EventArgs e)
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if (rbtnA.Checked == true)
            {
                dgvDETHI.Rows[rowSelected].Cells["dachon"].Value = "A";
            }
        }
        private void selectRBT()
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if (dgvDETHI.Rows[rowSelected].Cells["dachon"].Value == null)
            {
                rbtnA.Checked = rbtnB.Checked = rbtnC.Checked = rbtnD.Checked = false;
                return;
            }
            string se = dgvDETHI.Rows[rowSelected].Cells["dachon"].Value.ToString();
            if (se == "A")
            {
                rbtnA.Checked = true;
            }
            if (se == "B")
            {
                rbtnB.Checked = true;
            }
            if (se == "C")
            {
                rbtnC.Checked = true;
            }
            if (se == "D")
            {
                rbtnD.Checked = true;
            }
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            bdsDETHI.MoveFirst();
            selectRBT();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            bdsDETHI.MovePrevious();
            selectRBT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bdsDETHI.MoveNext();
            selectRBT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bdsDETHI.MoveLast();
            selectRBT();
        }

        private void timerTHI_Tick(object sender, EventArgs e)
        {
            b = Int32.Parse(lbGiay.Text); 
            c = Int32.Parse(lbPhut.Text);   
            b--;
            if (b < 0)
            {
                    b = 59;
                    c--;
            }
            if (b < 10)
            {
                lbGiay.Text = "0" + b;
            }
            else
                lbGiay.Text = b + "";
            if (c < 10)
            {
                lbPhut.Text = "0" + c;
            }
            else
                lbPhut.Text = c + "";

            if (b == 0 && c == 0)
            {
                timerTHI.Stop();
                MessageBox.Show("Hết giờ");
                nopbai();
            }
        }



        private void dgvDETHI_Click(object sender, EventArgs e)
        {
            int rowSelected = dgvDETHI.CurrentRow.Index;
            if (dgvDETHI.Rows[rowSelected].Cells["dachon"].Value == null) 
            {
                rbtnA.Checked = rbtnB.Checked = rbtnC.Checked = rbtnD.Checked = false;
                return;
            } 
            string se = dgvDETHI.Rows[rowSelected].Cells["dachon"].Value.ToString();
            if (se == "A")
            {
                rbtnA.Checked = true;
            }
            if (se == "B")
            {
                rbtnB.Checked = true;
            }
            if (se == "C")
            {
                rbtnC.Checked = true;
            }
            if (se == "D")
            {
                rbtnD.Checked = true;
            }
        }

        private void cT_BANGDIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTBD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        public int soCau, thoiGian;
        public decimal lan;
        private void formLamBaiThi_Load(object sender, EventArgs e)
        {
            txtMALOP.Text = maLop;
            txtTenLop.Text = tenLop;
            txtHoTen.Text = tenSV;


            this.sP_LAYDETHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYDETHITableAdapter.Fill(DS.SP_LAYDETHI, maMH, soCau,trinhDo);

            for (int i = 0; i < dgvDETHI.Rows.Count; i++)
            {
                dgvDETHI.Rows[i].Cells["stt"].Value = i + 1;
            }
            lbPhut.Text = thoiGian.ToString();
            timerTHI.Start();
        }
        private int maCTBT;

        private void nopbai()
        {
            int c = CauDung();
            Diem = Math.Round((10.0 / soCau) * c, 2);
            Console.WriteLine(Diem);
            if(Program.mGroup == "SINHVIEN")
            {
                Program.conn.Close();
                Program.conn = new SqlConnection(Program.connstr);
                Program.conn.Open();

                SqlTransaction tran = Program.conn.BeginTransaction();

                SqlCommand myCommand = Program.conn.CreateCommand();
                myCommand.Transaction = tran;
                try
                {
                    myCommand.CommandText = "INSERT INTO BANGDIEM (MASV, MAMH, LAN, NGAYTHI, DIEM) VALUES ('"
                        + Program.username + "', N'" + maMH + "', " + lan + ", N'" + DateTime.Parse(ngayThi).ToString("yyyy-MM-dd") + "', " + Diem + ")";

                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = "SELECT MABT FROM BANGDIEM WHERE MASV = '" + Program.username + "' AND MAMH = N'" + maMH + "' AND LAN = " + lan;
                    SqlDataReader myreader = myCommand.ExecuteReader();
                    myreader.Read();
                    maCTBT = myreader.GetInt32(0);
                    myreader.Close();

                    string DACHON;
                    for (int i = 0; i < dgvDETHI.Rows.Count; i++)
                    {
                        if (dgvDETHI.Rows[i].Cells["dachon"].Value != null)
                        {
                            DACHON = dgvDETHI.Rows[i].Cells["dachon"].Value.ToString();
                        }
                        else
                            DACHON = "";
                        myCommand.CommandText = "INSERT INTO CT_BANGDIEM (MABT, CAUHOI, NOIDUNG, A, B, C, D, DAP_AN, DACHON) " +
                                                "VALUES (" + maCTBT + ", " + dgvDETHI.Rows[i].Cells[0].Value + ", N'" +
                                                dgvDETHI.Rows[i].Cells[1].Value.ToString() + "', N'" +
                                                dgvDETHI.Rows[i].Cells[2].Value.ToString() + "', N'" +
                                                dgvDETHI.Rows[i].Cells[3].Value.ToString() + "', N'" +
                                                dgvDETHI.Rows[i].Cells[4].Value.ToString() + "', N'" +
                                                dgvDETHI.Rows[i].Cells[5].Value.ToString() + "', N'" +
                                                dgvDETHI.Rows[i].Cells[6].Value.ToString() + "', N'" +
                                                DACHON + "')";
                        myCommand.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu kết quả thất bại!\n" + ex.Message, "", MessageBoxButtons.OK);
                    tran.Rollback();
                }
                finally
                {
                    Program.conn.Close();
                }

            }
            MessageBox.Show("ĐIỂM THI: " + Diem +
                "\nSố câu đúng: " + c + "/" + soCau, "", MessageBoxButtons.OK);
            timerTHI.Stop();
            Close();

        }
        private int CauDung()
        {
            int count = 0;
            for(int i = 0; i < dgvDETHI.RowCount; i++)
            {
                if(dgvDETHI["dachon", i].Value == null)
                {
                    continue;
                }
                if(dgvDETHI[6, i].Value.ToString() == dgvDETHI["dachon", i].Value.ToString())
                {
                    count++;
                }
            }
            return count;
        }
        
        private void btnNopBai_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn nộp bài?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nopbai();
            }
            else
                return;
        }


    }
}
