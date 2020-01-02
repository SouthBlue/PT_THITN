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
    public partial class formBangDiem : Form
    {
        public formBangDiem()
        {
            InitializeComponent();
        }



        private void formBangDiem_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DS.LOP);

            cmbLan.SelectedIndex = 0;

        }

        private void btnIN_Click(object sender, EventArgs e)
        {
             
            rptBanDiem rpt = new rptBanDiem(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), Int16.Parse(cmbLan.Text));
            rpt.labelTitle.Text = "BẢNG ĐIỂM THI HẾT MÔN " + cmbMonHoc.Text + " CỦA LỚP " + cmbLop.Text; ;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
