using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;

namespace THITRACNGHIEM
{
    public partial class rptDSDKTHI : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDSDKTHI(string tu, string den)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_DSDKTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_DSDKTHITableAdapter.Fill(ds1.SP_DSDKTHI, DateTime.ParseExact(tu, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact(den, "dd/MM/yyyy", CultureInfo.InvariantCulture));
        }

    }
}
