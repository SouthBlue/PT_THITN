using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class rptBanDiem : DevExpress.XtraReports.UI.XtraReport
    {
       
        public rptBanDiem(string maLop, String maMH, Int16 lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_BANGDIEMLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BANGDIEMLOPTableAdapter.Fill(ds1.SP_BANGDIEMLOP, maLop, maMH, lan);

        }

    }
}
