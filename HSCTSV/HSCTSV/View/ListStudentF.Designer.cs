namespace HSCTSV.View
{
    partial class ListStudentF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudentF));
            this.txtMSSV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbinfo = new System.Windows.Forms.RichTextBox();
            this.ptBImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grCtrPaperAccept = new DevExpress.XtraGrid.GridControl();
            this.gvpaperaccept = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grCtrPaperWait = new DevExpress.XtraGrid.GridControl();
            this.gvpaperwait = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRepair = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDetail = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btexel = new DevExpress.XtraBars.Navigation.NavButton();
            this.btDownLoadFile = new DevExpress.XtraBars.Navigation.NavButton();
            this.btPrint = new DevExpress.XtraBars.Navigation.NavButton();
            this.btLoad = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrPaperAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvpaperaccept)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrPaperWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvpaperwait)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(96, 49);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Properties.Appearance.Options.UseFont = true;
            this.txtMSSV.Size = new System.Drawing.Size(155, 20);
            this.txtMSSV.TabIndex = 0;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập MSSV:";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(257, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbinfo);
            this.groupBox1.Controls.Add(this.ptBImage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // rtbinfo
            // 
            this.rtbinfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbinfo.Location = new System.Drawing.Point(119, 21);
            this.rtbinfo.Name = "rtbinfo";
            this.rtbinfo.ReadOnly = true;
            this.rtbinfo.Size = new System.Drawing.Size(194, 132);
            this.rtbinfo.TabIndex = 1;
            this.rtbinfo.Text = "";
            // 
            // ptBImage
            // 
            this.ptBImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptBImage.Location = new System.Drawing.Point(13, 21);
            this.ptBImage.Name = "ptBImage";
            this.ptBImage.Size = new System.Drawing.Size(100, 133);
            this.ptBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptBImage.TabIndex = 0;
            this.ptBImage.TabStop = false;
            this.ptBImage.Click += new System.EventHandler(this.ptBImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.xtraTabControl1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(364, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 410);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giấy tờ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 19);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(480, 388);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grCtrPaperAccept);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(478, 363);
            this.xtraTabPage2.Text = "Giấy tờ đã cấp";
            // 
            // grCtrPaperAccept
            // 
            this.grCtrPaperAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrPaperAccept.Location = new System.Drawing.Point(0, 0);
            this.grCtrPaperAccept.MainView = this.gvpaperaccept;
            this.grCtrPaperAccept.Name = "grCtrPaperAccept";
            this.grCtrPaperAccept.Size = new System.Drawing.Size(478, 363);
            this.grCtrPaperAccept.TabIndex = 0;
            this.grCtrPaperAccept.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvpaperaccept});
            // 
            // gvpaperaccept
            // 
            this.gvpaperaccept.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvpaperaccept.GridControl = this.grCtrPaperAccept;
            this.gvpaperaccept.Name = "gvpaperaccept";
            this.gvpaperaccept.OptionsBehavior.ReadOnly = true;
            this.gvpaperaccept.OptionsFind.AlwaysVisible = true;
            this.gvpaperaccept.OptionsFind.ShowFindButton = false;
            this.gvpaperaccept.OptionsSelection.MultiSelect = true;
            this.gvpaperaccept.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvpaperaccept.OptionsView.ShowGroupPanel = false;
            this.gvpaperaccept.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvpaperaccept_RowCellClick);
            this.gvpaperaccept.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvpaperaccept_CustomDrawRowIndicator);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên Giấy";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thời Gian Tạo";
            this.gridColumn4.FieldName = "TimeCreate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Thời Gian Cấp";
            this.gridColumn5.FieldName = "TimeAccept";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Người Cấp";
            this.gridColumn6.FieldName = "UserAccept";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ghi Chú";
            this.gridColumn7.FieldName = "Note";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grCtrPaperWait);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(478, 363);
            this.xtraTabPage1.Text = "Giấy tờ chờ cấp";
            // 
            // grCtrPaperWait
            // 
            this.grCtrPaperWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grCtrPaperWait.Location = new System.Drawing.Point(0, 0);
            this.grCtrPaperWait.MainView = this.gvpaperwait;
            this.grCtrPaperWait.Name = "grCtrPaperWait";
            this.grCtrPaperWait.Size = new System.Drawing.Size(478, 363);
            this.grCtrPaperWait.TabIndex = 0;
            this.grCtrPaperWait.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvpaperwait});
            // 
            // gvpaperwait
            // 
            this.gvpaperwait.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvpaperwait.GridControl = this.grCtrPaperWait;
            this.gvpaperwait.Name = "gvpaperwait";
            this.gvpaperwait.OptionsBehavior.ReadOnly = true;
            this.gvpaperwait.OptionsFind.AlwaysVisible = true;
            this.gvpaperwait.OptionsFind.ShowFindButton = false;
            this.gvpaperwait.OptionsSelection.MultiSelect = true;
            this.gvpaperwait.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvpaperwait.OptionsView.ShowGroupPanel = false;
            this.gvpaperwait.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvpaperwait_RowCellClick);
            this.gvpaperwait.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvpaperwait_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Giấy";
            this.gridColumn1.FieldName = "Description";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày Tạo";
            this.gridColumn2.FieldName = "TimeCreate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnRepair
            // 
            this.btnRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRepair.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepair.Appearance.Options.UseFont = true;
            this.btnRepair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRepair.ImageOptions.Image")));
            this.btnRepair.Location = new System.Drawing.Point(257, 430);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(86, 21);
            this.btnRepair.TabIndex = 7;
            this.btnRepair.Text = "Chỉnh Sửa";
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.tbDetail);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 148);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết giầy tờ";
            // 
            // tbDetail
            // 
            this.tbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDetail.BackColor = System.Drawing.SystemColors.Control;
            this.tbDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDetail.Location = new System.Drawing.Point(13, 20);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.ReadOnly = true;
            this.tbDetail.Size = new System.Drawing.Size(300, 122);
            this.tbDetail.TabIndex = 2;
            this.tbDetail.Text = "";
            this.tbDetail.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.tbDetail_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ghi Chú:";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(96, 430);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(155, 20);
            this.txtNote.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tileNavPane1);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.btnRepair);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMSSV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 478);
            this.panel1.TabIndex = 0;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.btexel);
            this.tileNavPane1.Buttons.Add(this.btDownLoadFile);
            this.tileNavPane1.Buttons.Add(this.btPrint);
            this.tileNavPane1.Buttons.Add(this.btLoad);
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
            this.tileNavPane1.Size = new System.Drawing.Size(866, 35);
            this.tileNavPane1.TabIndex = 13;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // btexel
            // 
            this.btexel.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btexel.Caption = "Xuất file exel";
            this.btexel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btexel.ImageOptions.Image")));
            this.btexel.Name = "btexel";
            this.btexel.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btexel_ElementClick);
            // 
            // btDownLoadFile
            // 
            this.btDownLoadFile.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btDownLoadFile.Caption = "Tải mẫu";
            this.btDownLoadFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btDownLoadFile.ImageOptions.Image")));
            this.btDownLoadFile.Name = "btDownLoadFile";
            this.btDownLoadFile.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btDownLoadFile_ElementClick);
            // 
            // btPrint
            // 
            this.btPrint.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btPrint.Caption = "In Giấy";
            this.btPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btPrint.ImageOptions.Image")));
            this.btPrint.Name = "btPrint";
            this.btPrint.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btPrint_ElementClick);
            // 
            // btLoad
            // 
            this.btLoad.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btLoad.Caption = "Tải Lại";
            this.btLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btLoad.ImageOptions.Image")));
            this.btLoad.Name = "btLoad";
            this.btLoad.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.btLoad_ElementClick);
            // 
            // ListStudentF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 478);
            this.Controls.Add(this.panel1);
            this.Name = "ListStudentF";
            this.Text = "RibbonForm1";
            ((System.ComponentModel.ISupportInitialize)(this.txtMSSV.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrPaperAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvpaperaccept)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grCtrPaperWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvpaperwait)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMSSV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbinfo;
        private System.Windows.Forms.PictureBox ptBImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnRepair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl grCtrPaperWait;
        private DevExpress.XtraGrid.Views.Grid.GridView gvpaperwait;
        private DevExpress.XtraGrid.GridControl grCtrPaperAccept;
        private DevExpress.XtraGrid.Views.Grid.GridView gvpaperaccept;
        private System.Windows.Forms.RichTextBox tbDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btexel;
        private DevExpress.XtraBars.Navigation.NavButton btDownLoadFile;
        private DevExpress.XtraBars.Navigation.NavButton btPrint;
        private DevExpress.XtraBars.Navigation.NavButton btLoad;
    }
}