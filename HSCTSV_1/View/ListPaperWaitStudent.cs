using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HSCTSV_1.ConnectDB;
using HSCTSV_1.Model;
using DevExpress.XtraEditors;
using HSCTSV_1.Report;
using DevExpress.XtraReports.UI;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace HSCTSV_1.View
{
    public partial class ListInforStudent : Form
    {
        public ListInforStudent()
        {
            InitializeComponent();
            DateStart.Value = DateTime.Now.AddMonths(-1);
            DateEnd.Value = DateTime.Today.AddDays(+1);
            label5.Visible = false;
            gvInforPaperStudent.BestFitColumns();
            TestAdmin(Properties.Settings.Default.saveFile);
        }
        /* public async void GetPaperStudentById()
         {
             var objReq = new Dictionary<string, string>()
             {
                 {"IDStudent",txtID.Text },
                 {"Tokencode",Login.userLogin.TokenCode }
             };
             var objRes = await new PaperDB().GetPaperByIdStudentLst(objReq);
             if (objRes.RespCode == 0)
             {
                 grCtrInforPaperStudent.DataSource = objRes.HSPaperStudentInforLst.ToList();
                 gvInforPaperStudent.BestFitColumns();
             }
             else
             {
                 MessageBox.Show(objRes.RespText);
             }

         }*/
        //public async void GetPaperAllByToken()
        //{
        //    var objReq = new Dictionary<string, string>()
        //    {
        //        {"TokenCode",Login.userLogin.TokenCode }
        //    };
        //    var objRes = await new PaperDB().GetPaperAllByToken(objReq);
        //    if (objRes.RespCode == 0)
        //    {
        //        grCtrInforPaperStudent.DataSource = objRes.HSPaperStudentInforLst.ToList();
        //        gvInforPaperStudent.BestFitColumns();

        //    }


        //    else
        //    {
        //        MessageBox.Show(objRes.RespText);
        //    }

        //} 
        //public async void getUStudentByID()
        //{
        //    var objReq = new Dictionary<string, string>()
        //    {
        //        {"UNumberId",txtID.Text},
        //        {"TokenCode",Login.userLogin.TokenCode }
        //    };
        //    var objRes = await new StudentDB().GetStudentById(objReq);
        //    if (objRes.RespCode == 0)
        //    {
        //        grCtrInforPaperStudent.DataSource = objRes.HSStudentInfo;
        //        gvInforPaperStudent.BestFitColumns();
        //    }
        //    else
        //    {
        //        MessageBox.Show(objRes.RespText);
        //    }
        //}
        private void ListInforStudent_Load(object sender, EventArgs e)
        {
            // GetPaperAllByToken();
            GetByDate();
        }
        HSStudentPaperById accept = new HSStudentPaperById();
        public async void DonePaperStudent()
        {
            Int32[] seclectedRowHandles = gvInforPaperStudent.GetSelectedRows();
            for (int i = 0; i < seclectedRowHandles.Length; i++)
            {
                var HSAcceptPaper = gvInforPaperStudent.GetRow(seclectedRowHandles[i]) as HSStudentPaperById;
                accept = HSAcceptPaper;
                var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"RowID",HSAcceptPaper.RowID.ToString()},
                {"Note",txtNote.Text }
            };
                var objRes = await new PaperDB().DonePaperStudent(objReq);
                //GetPaperAllByToken();
                GetByDate();
            }
        }
        private void btnreload_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            //GetPaperAllByToken();
            GetByDate();
            grCtrDetail.DataSource = null;
            txtNote.Text = null;
            rtbinfoo.Text = null;
            tbGhiChu.Text = null;
            label5.Visible = false;

        }
        private void gvInforPaperStudent_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
                //gvInforPaperStudent.IndicatorWidth = e.Info.DisplayText.Length;
            }
        }
        private async void gvInforPaperStudent_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            grCtrDetail.DataSource = null;
            try
            {

                var objReq = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                    {"ID",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "RowID").ToString() }
                };
                var objRes2 = await new PaperDB().GetPaperDetailByID(objReq);
                int i = 1;
                int j = 1;
                tbGhiChu.Text = null;
                foreach (var a in objRes2.Data.QuestionLst)
                {
                    label5.Visible = true;
                    tbGhiChu.AppendText(i++ + ". " + a.Question + "  " + a.Answer + "\n");
                    tbGhiChu.Find(j++ + ". " + a.Question);
                    tbGhiChu.SelectionColor = Color.Gray;

                }
                var objReq5 = new Dictionary<string, string>()
                {
                   {"UNumberId",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "IDStudent").ToString() },
                   {"TokenCode",Login.userLogin.TokenCode }
                };
                var objRes5 = await new StudentDB().GetStudentById(objReq5);
                rtbinfoo.Text = "Họ và tên: " + objRes5.HSStudentInfo.UFullName
                               + "\t" + "MSSV: " + gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "IDStudent").ToString() + "\n\n"
                               + "Yêu cầu: " + gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "Description").ToString() + "\n\n" +
                                 "Ngày tạo: " + gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "TimeCreate").ToString();
                txtNote.Text = objRes2.Data.Note;
                //lbtensv.Text = objRes5.HSStudentInfo.UFullName;
                var objReq8 = new Dictionary<string, string>()
                {
                {"IDStudent",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "IDStudent").ToString() },
                {"TokenCode",Login.userLogin.TokenCode }
                };
                var objRes8 = await new PaperDB().GetPaperAllByIdStudentLst(objReq8);
                grCtrDetail.DataSource = objRes8.HSPaperStudentInforLst.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (gvInforPaperStudent.IsFindPanelVisible)
            {
                gvInforPaperStudent.HideFindPanel();
            }
            else
            {
                gvInforPaperStudent.ShowFindPanel();
            }
        }
        private void gvInforPaperStudent_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "mới tạo";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "đã xem";
                if (Convert.ToDecimal(e.Value) == 2) e.DisplayText = "đã in";
                if (Convert.ToDecimal(e.Value) == 100) e.DisplayText = "chỉnh sửa";
                if (Convert.ToDecimal(e.Value) == -1) e.DisplayText = "đã hủy";
            }
        }
        public async void GetByDate()
        {
            var objReq6 = new Dictionary<string, string>()
                {
                   {"TokenCode",Login.userLogin.TokenCode },
                   {"DateStart",DateStart.Text },
                   {"DateEnd",DateEnd.Text }
                };
            var objRes6 = await new PaperDB().GetPaperByDate(objReq6);
            grCtrInforPaperStudent.DataSource = objRes6.HSPaperStudentInforLst.ToList();
            gvInforPaperStudent.BestFitColumns();
        }
        private void btok_Click(object sender, EventArgs e)
        {
            GetByDate();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thêm ghi chú?", "xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            DonePaperStudent();
            GetByDate();
            txtNote.Text = null;
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                if (MessageBox.Show("Xác nhận xóa yêu cầu ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DelPaperStudent();
                    GetByDate();
                }  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void btnWait_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            var objReq = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                };
            var objRes = await new PaperDB().GetPaperAllNoAccept(objReq);
            grCtrInforPaperStudent.DataSource = objRes.HSPaperStudentInforLst.ToList();
            gvInforPaperStudent.BestFitColumns();
            txtNote.Text = null;
            rtbinfoo.Text = null;
            tbGhiChu.Text = null;
            label5.Visible = false;

        }

        private void btnExportExel_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            SaveFileDialog saveFileExel = new SaveFileDialog();
            saveFileExel.InitialDirectory = @"C\";
            saveFileExel.Title = "Save text Files";
            saveFileExel.Filter = "Text file (*.xlsx)|*.xlsx|Tất cả các file(*.*)|*.*";
            saveFileExel.RestoreDirectory = true;
            if (saveFileExel.ShowDialog() == DialogResult.OK)
            {
                //gvInforPaperStudent.OptionsView.ColumnAutoWidth=true;
                gvInforPaperStudent.ExportToXlsx(saveFileExel.FileName);
              
            }
        }

        private async void btnPrintP_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            HSPrint.DetailC = null;
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 để in !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xác nhận phê duyệt và In", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32[] selectedRowsHandles = gvInforPaperStudent.GetSelectedRows();
            for (int i = 0; i < selectedRowsHandles.Length; i++)
            {
                var HSpaper = gvInforPaperStudent.GetRow(selectedRowsHandles[i]) as HSStudentPaperById;
                var objReq = new Dictionary<string, string>()
                {
                  {"UNumberId",HSpaper.IDStudent },
                  {"TokenCode",Login.userLogin.TokenCode }
                };
                var objRes = await new StudentDB().GetStudentById(objReq);
                var objReq1 = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                    {"ID",HSpaper.RowID }
                };
                var objRes1 = await new PaperDB().GetPaperDetailByID(objReq1);


                foreach (var a in objRes1.Data.QuestionLst)
                {

                    HSPrint.DetailC += "-" + a.Question + " " + a.Answer + "\n";

                }
                HSPrint.ClassC = objRes.HSStudentInfo.UClass;
                HSPrint.FacultyC = objRes.HSStudentInfo.UFaculty;
                HSPrint.NameC = HSpaper.NameStudent;
                HSPrint.IDC = HSpaper.IDStudent;

                HSPrint.DecritionC = HSpaper.Description;
                HSPrint.NoteC = HSpaper.Note;


            }
            PrintReq printreq = new PrintReq();
            ReportPrintTool print = new ReportPrintTool(printreq);
            print.ShowPreview();
        }

        private void gvDetail_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "mới tạo";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "đã xem";
                if (Convert.ToDecimal(e.Value) == 2) e.DisplayText = "đã in";
                if (Convert.ToDecimal(e.Value) == 100) e.DisplayText = "chỉnh sửa";
                if (Convert.ToDecimal(e.Value) == -1) e.DisplayText = "đã hủy";
            }
        }

        private async void btnRepair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận chỉnh sửa?", "xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32[] selectedRowsHandles = gvInforPaperStudent.GetSelectedRows();
            for (int i = 0; i < selectedRowsHandles.Length; i++)
            {
                var hSStudentPaperinfo = gvInforPaperStudent.GetRow(selectedRowsHandles[i]) as HSStudentPaperById;
                var objReq = new Dictionary<string, string>()
                {
                    { "TokenCode",Login.userLogin.TokenCode},
                    { "RowID",hSStudentPaperinfo.RowID},
                    { "Note",txtNote.Text}
                };
                var objRes = await new PaperDB().PausePaperStudent(objReq);
            }
            GetByDate();
            txtNote.Text = null;
        }

        private void tbGhiChu_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
        public async void DelPaperStudent()
        {
            var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"RowID",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "RowID").ToString() }
            };
            var objRes = await new PaperDB().DelStudentPaper(objReq);

        }
        public void TestAdmin(string admin)
        {
            if (admin == "hung.phammanh@hust.edu.vn" || admin == "khai.tranquang@hust.edu.vn")
            {
                btnCancel.Enabled = true;
            }
            else
            {
                btnCancel.Enabled = false;
            }
            
        }
    }
}
