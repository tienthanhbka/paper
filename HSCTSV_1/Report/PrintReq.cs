using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using HSCTSV_1.ConnectDB;
using HSCTSV_1.Model;
using System.Collections.Generic;
using System.Linq;

namespace HSCTSV_1.Report
{
    public partial class PrintReq : DevExpress.XtraReports.UI.XtraReport
    {
        public PrintReq()
        {
            InitializeComponent();
            GetPaper();
        }
        public async void GetPaper()
        {
            lbDate.Text = string.Format("Ngày :{0}", DateTime.Now.ToString("dd/MM/yyyy"));
            var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"DateStart",HSPaperDetail.saveDateStart },
                {"DateEnd",HSPaperDetail.saveDateEnd }
            };
            var objRes = await new PaperDB().GetPaperByDate(objReq);
            cellName.Text = HSPrint.NameC;
            cellID.Text = HSPrint.IDC;
            cellClass.Text = HSPrint.ClassC;
            cellFaculty.Text = HSPrint.FacultyC;
            cellReq.Text = HSPrint.DecritionC;
            cellDetail.Text = HSPrint.DetailC;
            cellNote.Text = HSPrint.NoteC;
        }
    }
}
