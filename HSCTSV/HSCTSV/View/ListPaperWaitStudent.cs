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
using HSCTSV.Model;
using HSCTSV.ConnectDB;
using HSCTSV.Report;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Net;

namespace HSCTSV.View
{
    public partial class ListPaperWaitStudent : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListPaperWaitStudent()
        {
            InitializeComponent();
            DateEnd.Value = DateTime.Now.AddMonths(-1);
            DateEnd.Value = DateTime.Today.AddDays(+1);
            gvInforPaperStudent.BestFitColumns();
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
                GetByDate();
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
        public async void DelPaperStudent()
        {
            var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"RowID",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle, "RowID").ToString() }
            };
            var objRes = await new PaperDB().DelStudentPaper(objReq);

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

        private void btnreload_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
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

        private void gvInforPaperStudent_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "Mới tạo";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "Đã xem";
                if (Convert.ToDecimal(e.Value) == 2) e.DisplayText = "Đã in";
                if (Convert.ToDecimal(e.Value) == 100) e.DisplayText = "Chỉnh sửa";
                if (Convert.ToDecimal(e.Value) == -1) e.DisplayText = "Đã hủy";
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            GetByDate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 ô để thêm ghi chú !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xác nhận thêm ghi chú?", "xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            DonePaperStudent();
            GetByDate();
            txtNote.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 ô để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                if (MessageBox.Show("Xác nhận xóa yêu cầu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DelPaperStudent();
                    GetByDate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnRepair_Click(object sender, EventArgs e)
        {
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 ô để chỉnh sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Xác nhận chỉnh sửa?", "Xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

      

        private void ListPaperWaitStudent_Load(object sender, EventArgs e)
        {
            GetByDate();
        }

       

        private void gvDetail_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                if (Convert.ToDecimal(e.Value) == 0) e.DisplayText = "Mới tạo";
                if (Convert.ToDecimal(e.Value) == 1) e.DisplayText = "Đã xem";
                if (Convert.ToDecimal(e.Value) == 2) e.DisplayText = "Đã in";
                if (Convert.ToDecimal(e.Value) == 100) e.DisplayText = "Chỉnh sửa";
                if (Convert.ToDecimal(e.Value) == -1) e.DisplayText = "Đã hủy";
            }
        }

        private void gvDetail_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

       

        private async void btnPrintP_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            HSPrint.DetailC = null;
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 ô để in !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // In
        public async void DownLoadFile()
        {
            var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode }
            };
            var objRes = await new PaperDB().GetPaperLst(objReq);
            try
            {
                if (objRes.HSPaperLst == null)
                {
                    MessageBox.Show("Không tìm thấy file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                bool folderExists = Directory.Exists(@"C:/Giay_To");
                if (!folderExists)
                {
                    Directory.CreateDirectory(@"C:/Giay_To");
                }
                foreach (var a in objRes.HSPaperLst.ToList())
                {
                    Thread thread = new Thread(() =>
                    {
                        WebClient client1 = new WebClient();
                        //client1.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        //client1.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                        client1.DownloadFileAsync(new Uri("http://202.191.56.101/HSCTSV/File/Download?FileName=" + a.FilePath + "&TokenCode=" + Login.userLogin.TokenCode), "C:/Giay_To/" + a.FilePath);
                    });
                    thread.Start();
                }
                MessageBox.Show("Tải file hoàn tất, xin hãy kiểm tra thư mục: C:/ Giay_To", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        HSStudentInfo student = new HSStudentInfo();
        public async void getUStudentByID()
        {
            var objReq = new Dictionary<string, string>()
                {
                    {"UNumberId",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle,"IDStudent").ToString() },
                    {"TokenCode",Login.userLogin.TokenCode }
                };
            var objRes = await new StudentDB().GetStudentById(objReq);
            student = objRes.HSStudentInfo;           
        }
        public async void GetStudentPaper(string Type, Microsoft.Office.Interop.Word.Document document)
        {
            string dateBirth;
            string monthBirth;
            string yearBirth;
            var objReq1 = new Dictionary<string, string>()
                {
                    {"TokenCode",Login.userLogin.TokenCode },
                    {"IDStudent",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle,"IDStudent").ToString() }
                };
            var objRes1 = await new StudentDB().GetInfoByIdStudent(objReq1);
            var objReq2 = new Dictionary<string, string>()
            {
                {"UNumberId",gvInforPaperStudent.GetRowCellValue(gvInforPaperStudent.FocusedRowHandle,"IDStudent").ToString() },
                {"TokenCode",Login.userLogin.TokenCode }
            };
            var objRes2 = await new StudentDB().GetStudentById(objReq2);
            var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"RowHeader",Type },

            };
            var objRes = await new PaperDB().GetPaperByRowHeader(objReq);
            if (objRes.RespCode == 0)
            {
                if (student.UBirthDay == null)
                {
                    dateBirth = "";
                    monthBirth = "";
                    yearBirth = "";
                }
                else
                {
                    char[] spearator = { '/' };
                    String[] strlist = student.UBirthDay.Split(spearator);
                    dateBirth = strlist[0];
                    monthBirth = strlist[1];
                    yearBirth = strlist[2];
                    DateTime now = DateTime.Now;
                    foreach (Microsoft.Office.Interop.Word.Field field in document.Fields)
                    {
                        if (field.Code.Text.Contains("name"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UFullName);
                        }
                        else if (field.Code.Text.Contains("address"))
                        {
                            field.Select();
                            string addr = "";
                            addr = student.UAddress.ToLower();
                            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

                            application.Selection.TypeText(myTI.ToTitleCase(addr));
                        }
                        else if (field.Code.Text.Contains("city"))
                        {
                            field.Select();
                            string city = "";
                            city = student.UCity.ToLower();
                            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                            application.Selection.TypeText(myTI.ToTitleCase(city));
                        }
                        else if (field.Code.Text.Contains("birthDay"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UBirthDay);
                        }

                        else if (field.Code.Text.Contains("db"))
                        {
                            field.Select();
                            application.Selection.TypeText(dateBirth);
                        }
                        else if (field.Code.Text.Contains("mb"))
                        {
                            field.Select();
                            application.Selection.TypeText(monthBirth);
                        }
                        else if (field.Code.Text.Contains("yb"))
                        {
                            field.Select();
                            application.Selection.TypeText(yearBirth);
                        }
                        else if (field.Code.Text.Contains("class"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UClass);
                        }
                        else if (field.Code.Text.Contains("kStudent"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UGroupLevel);
                        }
                        else if (field.Code.Text.Contains("idStudent"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UNumberId);
                        }
                        else if (field.Code.Text.Contains("dn"))
                        {
                            field.Select();
                            application.Selection.TypeText(now.Day.ToString());
                        }
                        else if (field.Code.Text.Contains("mn"))
                        {
                            field.Select();
                            application.Selection.TypeText(now.Month.ToString());
                        }
                        else if (field.Code.Text.Contains("yn"))
                        {
                            field.Select();
                            application.Selection.TypeText(now.Year.ToString());
                        }
                        else if (field.Code.Text.Contains("sex"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.Usex);
                        }
                        else if (field.Code.Text.Contains("nganhStudent"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UFaculty);
                        }
                        else if (field.Code.Text.Contains("marjor"))
                        {
                            field.Select();
                            application.Selection.TypeText(student.UFaculty);
                        }
                        else if (field.Code.Text.Contains("dantoc"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.Nation);
                        }
                        else if (field.Code.Text.Contains("LevelProgram"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes2.HSStudentInfo.LevelProgram);
                        }
                        else if (field.Code.Text.Contains("program"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes2.HSStudentInfo.Program);
                        }
                        else if (field.Code.Text.Contains("emailStudent"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.Email);
                        }
                        else if (field.Code.Text.Contains("level"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.LevelStudent);
                        }
                        else if (field.Code.Text.Contains("Semester"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.Semester);
                        }
                        else if (field.Code.Text.Contains("cmt"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.CMT);
                        }
                        else if (field.Code.Text.Contains("BHYT"))
                        {
                            field.Select();

                            application.Selection.TypeText(objRes1.Infor.BHYT);
                        }
                    }
                    for (int i = 0; i < objRes.HSStudentQuestionPaperLst.Count; i++)
                    {
                        foreach (Microsoft.Office.Interop.Word.Field field in document.Fields)
                        {

                            if (field.Code.Text.Contains(i.ToString()))
                            {
                                field.Select();
                                application.Selection.TypeText(objRes.HSStudentQuestionPaperLst[i].Answer);
                            }
                        }

                    }

                }
            }
        }
        Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
        Microsoft.Office.Interop.Word.Document document = new Microsoft.Office.Interop.Word.Document();

        HSStudentPaperById paper = new HSStudentPaperById();
        public async void AcceptPaperStudent()
        {
            Int32[] seclectedRowHandles = gvInforPaperStudent.GetSelectedRows();
            for (int i = 0; i < seclectedRowHandles.Length; i++)
            {
                var HSAcceptPaper = gvInforPaperStudent.GetRow(seclectedRowHandles[i]) as HSStudentPaperById;

                var objReq = new Dictionary<string, string>()
            {
                {"TokenCode",Login.userLogin.TokenCode },
                {"RowID",HSAcceptPaper.RowID.ToString()},
                {"Note",txtNote.Text }
            };
                var objRes = await new PaperDB().AcceptPaperStudent(objReq);
            }
        }
        public async void PrintPaper()
        {
           
            if (MessageBox.Show("Xác nhận phê duyệt và In", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Int32[] selectedRowsHandles = gvInforPaperStudent.GetSelectedRows();
            for (int i = 0; i < selectedRowsHandles.Length; i++)
            {
                var hSStudentPaperInfo = gvInforPaperStudent.GetRow(selectedRowsHandles[i]) as HSStudentPaperById;
                paper = hSStudentPaperInfo;
                //var accept = gvpaperwait.GetRow(selectedRowHandles[i]) as HSStudentPaperById;
                var objReq = new Dictionary<string, string>()
                        {
                           {"TokenCode",Login.userLogin.TokenCode },
                            {"ID",hSStudentPaperInfo.RowID.ToString() }
                        };
                var objRes = await new PaperDB().GetPaperDetailByID(objReq);
                bool folderExists = File.Exists("C:/Giay_To/" + objRes.Data.FileName);
                if (!folderExists)
                {
                    MessageBox.Show("Chưa có mẫu giấy, đang Tải mẫu !");
                    DownLoadFile();
                    return;
                    
                }
                try
                {
                    document = application.Documents.Add(Template: @"C:\Giay_To\" + objRes.Data.FileName);
                    application.Visible = true;
                    GetStudentPaper(objRes.Data.RowID, document);                   
                    AcceptPaperStudent();
                    getUStudentByID();
                    MessageBox.Show("In thành công!", "Thông báo", MessageBoxButtons.OK);

                }
                catch
                {
                    MessageBox.Show(@"Cấp quyền ghi đọc file ở đường dẫn C:\Giay_To\" + objRes.Data.FileName);
                    return;
                }

            }
        }
        private void btPrint_Click(object sender, EventArgs e)
        {
            if (gvInforPaperStudent.SelectedRowsCount == 0 || gvInforPaperStudent.SelectedRowsCount > 1)
            {
                MessageBox.Show("Vui lòng chọn 1 ô để in giấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gvInforPaperStudent.SelectedRowsCount > 0)
                PrintPaper();
        }

        
    }
}