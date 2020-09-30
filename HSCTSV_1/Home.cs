using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using HSCTSV_1.View;

namespace HSCTSV_1
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
            FirstView();
           
        }
        public void FirstView()
        {
            plHome.Controls.Clear();
            ListStudentF view = new ListStudentF();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
        }
       

        //private void rcpiListWait_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        //{
        //    plHome.Controls.Clear();
        //    ListInforStudent view = new ListInforStudent();
        //    view.TopLevel = false;
        //    view.Dock = DockStyle.Fill;
        //    view.Visible = true;
        //    plHome.Controls.Add(view);
        //    bvCtrHome.Close();
        //}

        private void rcpiInfor_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListInfoStudent view = new ListInfoStudent();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }

      
        private void rcpiReq_ItemClick_1(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListInforStudent view = new ListInforStudent();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }
        

        private void rpiwaitaccept_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListWait view = new ListWait();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }
        

        private void rcpiInfor_ItemClick_1(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListInfoStudent view = new ListInfoStudent();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }

        private void rpiListInfo_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListStudent view = new ListStudent();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }

        private void rpiPrintPaper_ItemClick(object sender, DevExpress.XtraBars.Ribbon.RecentItemEventArgs e)
        {
            plHome.Controls.Clear();
            ListStudentF view = new ListStudentF();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            view.Visible = true;
            plHome.Controls.Add(view);
            bvCtrHome.Close();
        }
    }
}