namespace HSCTSV
{
    partial class ListStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudent));
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.exportExel = new DevExpress.XtraBars.Navigation.NavButton();
            this.btnImport = new DevExpress.XtraBars.Navigation.NavButton();
            this.DownTemp = new DevExpress.XtraBars.Navigation.NavButton();
            this.gCtrListUser = new DevExpress.XtraGrid.GridControl();
            this.gvlistuser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrListUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistuser)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileNavPane1.Appearance.Options.UseFont = true;
            this.tileNavPane1.Buttons.Add(this.exportExel);
            this.tileNavPane1.Buttons.Add(this.btnImport);
            this.tileNavPane1.Buttons.Add(this.DownTemp);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(956, 32);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // exportExel
            // 
            this.exportExel.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.exportExel.Caption = "Xuất file exel";
            this.exportExel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exportExel.ImageOptions.Image")));
            this.exportExel.Name = "exportExel";
            this.exportExel.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.exportExel_ElementClick);
            // 
            // btnImport
            // 
            this.btnImport.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btnImport.Caption = "Chọn File";
            this.btnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.ImageOptions.Image")));
            this.btnImport.Name = "btnImport";
            this.btnImport.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btnImport_ElementClick);
            // 
            // DownTemp
            // 
            this.DownTemp.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.DownTemp.Caption = "Tải mẫu";
            this.DownTemp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DownTemp.ImageOptions.Image")));
            this.DownTemp.Name = "DownTemp";
            this.DownTemp.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.DownTemp_ElementClick);
            // 
            // gCtrListUser
            // 
            this.gCtrListUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrListUser.Location = new System.Drawing.Point(12, 38);
            this.gCtrListUser.MainView = this.gvlistuser;
            this.gCtrListUser.Name = "gCtrListUser";
            this.gCtrListUser.Size = new System.Drawing.Size(932, 470);
            this.gCtrListUser.TabIndex = 4;
            this.gCtrListUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlistuser});
            // 
            // gvlistuser
            // 
            this.gvlistuser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn9,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gvlistuser.GridControl = this.gCtrListUser;
            this.gvlistuser.IndicatorWidth = 35;
            this.gvlistuser.Name = "gvlistuser";
            this.gvlistuser.OptionsBehavior.ReadOnly = true;
            this.gvlistuser.OptionsView.ShowGroupPanel = false;
            this.gvlistuser.OptionsView.ShowViewCaption = true;
            this.gvlistuser.ViewCaption = "Thông tin sinh viên";
            this.gvlistuser.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvlistuser_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ và tên";
            this.gridColumn1.FieldName = "UFullName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ngày Sinh";
            this.gridColumn9.FieldName = "UBirthDay";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MSSV";
            this.gridColumn2.FieldName = "UNumberId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Email";
            this.gridColumn3.FieldName = "Email";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Địa Chỉ";
            this.gridColumn4.FieldName = "UAddress";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Lớp";
            this.gridColumn5.FieldName = "UClass";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 7;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Khoa";
            this.gridColumn6.FieldName = "UFaculty";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 9;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Khóa";
            this.gridColumn7.FieldName = "UGroupLevel";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "CT đào tạo";
            this.gridColumn8.FieldName = "Program";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 10;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Năm vào học";
            this.gridColumn10.FieldName = "YearStart";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 11;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Dân tộc";
            this.gridColumn11.FieldName = "UNation";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Giới tính";
            this.gridColumn12.FieldName = "Usex";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            // 
            // ListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 519);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.gCtrListUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListStudent";
            this.Text = "ListStudent";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrListUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btnImport;
        private DevExpress.XtraBars.Navigation.NavButton exportExel;
        private DevExpress.XtraBars.Navigation.NavButton DownTemp;
        private DevExpress.XtraGrid.GridControl gCtrListUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlistuser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}