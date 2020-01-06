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
    public partial class formReportDangKyThi : Form
    {
        public formReportDangKyThi()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            rptDSDKTHI rpt = new rptDSDKTHI(dateFrom.Value.ToString("dd/MM/yyyy"), dateTo.Value.ToString("dd/MM/yyyy"));
            rpt.lbNgay.Text = "TỪ NGÀY " + dateFrom.Value.ToString("dd/MM/yyyy") +
                " ĐẾN NGÀY " + dateTo.Value.ToString("dd/MM/yyyy");
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
