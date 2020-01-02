using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class rptKetQua : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKetQua(string maSV, string maMH, Int16 lan)
        {
            InitializeComponent();
            ds2.EnforceConstraints = false;
            this.sP_KETQUATHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_KETQUATHITableAdapter.Fill(ds2.SP_KETQUATHI, maSV, maMH, lan);
        }


    }
}
