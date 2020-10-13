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
using HSCTSV.ConnectDB;

namespace HSCTSV.View
{
    public partial class ListWait : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListWait()
        {
            InitializeComponent();
            GetPaperAllNoAccept();
        }
        public async void GetPaperAllNoAccept()
        {
            var objReq = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                };
            var objRes = await new PaperDB().GetPaperAllNoAccept(objReq);
            grCtrListWait.DataSource = objRes.HSPaperStudentInforLst.ToList();
            gvListWait.BestFitColumns();
        }

        private async void gvListWait_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                rtbchitiet.Text = null;
                var objReq = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                    {"ID",gvListWait.GetRowCellValue(gvListWait.FocusedRowHandle, "RowID").ToString() }
                };
                var objRes2 = await new PaperDB().GetPaperDetailByID(objReq);
                int i = 1;
                int j = 1;
                foreach (var a in objRes2.Data.QuestionLst)
                {
                    label5.Visible = true;
                    rtbchitiet.AppendText(i++ + ". " + a.Question + "  " + a.Answer + "\n");
                    rtbchitiet.Find(j++ + ". " + a.Question);
                    rtbchitiet.SelectionColor = Color.Gray;
                }
                var objReq5 = new Dictionary<string, string>()
                {
                   {"UNumberId",gvListWait.GetRowCellValue(gvListWait.FocusedRowHandle, "IDStudent").ToString() },
                   {"TokenCode",Login.userLogin.TokenCode }
                };
                var objRes5 = await new StudentDB().GetStudentById(objReq5);
                rtbinfoo2.Text = "Họ và tên: " + objRes5.HSStudentInfo.UFullName
                               + "\t" + "MSSV: " + gvListWait.GetRowCellValue(gvListWait.FocusedRowHandle, "IDStudent").ToString() + "\n\n"
                               + "Yêu cầu: " + gvListWait.GetRowCellValue(gvListWait.FocusedRowHandle, "Description").ToString() + "\n\n" +
                                 "Ngày tạo: " + gvListWait.GetRowCellValue(gvListWait.FocusedRowHandle, "TimeCreate").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvListWait_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                //gvInforPaperStudent.IndicatorWidth = e.Info.DisplayText.Length;
            }
        }
    }
}