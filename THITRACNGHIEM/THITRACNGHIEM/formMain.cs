using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formDangNhap f = new formDangNhap();
            f.Show();
            /*            Form frm = this.CheckExists(typeof(formDangNhap));
                        if (frm != null) frm.Activate();
                        else
                        {
                            formDangNhap f = new formDangNhap();
                            f.MdiParent = this;
                            f.Show();
                        }*/

        }
        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                formMonHoc m = new formMonHoc();
                m.MdiParent = this;
                m.Show();
            }
        }


        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formKhoa));
            if (frm != null) frm.Activate();
            else
            {
                formKhoa m = new formKhoa();
                m.MdiParent = this;
                m.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formLop));
            if (frm != null) frm.Activate();
            else
            {
                formLop m = new formLop();
                m.MdiParent = this;
                m.Show();
            }
        }
    }
}
