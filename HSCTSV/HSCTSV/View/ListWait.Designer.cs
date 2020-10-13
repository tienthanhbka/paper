namespace HSCTSV.View
{
    partial class ListWait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListWait));
            this.grCtrListWait = new DevExpress.XtraGrid.GridControl();
            this.gvListWait = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btrefresh = new DevExpress.XtraBars.Navigation.NavButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbinfoo2 = new System.Windows.Forms.RichTextBox();
            this.rtbchitiet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grCtrListWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grCtrListWait
            // 
            this.grCtrListWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grCtrListWait.Location = new System.Drawing.Point(290, 38);
            this.grCtrListWait.MainView = this.gvListWait;
            this.grCtrListWait.Name = "grCtrListWait";
            this.grCtrListWait.Size = new System.Drawing.Size(439, 438);
            this.grCtrListWait.TabIndex = 5;
            this.grCtrListWait.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListWait});
            // 
            // gvListWait
            // 
            this.gvListWait.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvListWait.GridControl = this.grCtrListWait;
            this.gvListWait.IndicatorWidth = 35;
            this.gvListWait.Name = "gvListWait";
            this.gvListWait.OptionsBehavior.ReadOnly = true;
            this.gvListWait.OptionsFind.AlwaysVisible = true;
            this.gvListWait.OptionsFind.ShowFindButton = false;
            this.gvListWait.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.gvListWait.OptionsSelection.MultiSelect = true;
            this.gvListWait.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvListWait.OptionsView.ShowGroupPanel = false;
            this.gvListWait.OptionsView.ShowViewCaption = true;
            this.gvListWait.ViewCaption = "Danh sách yêu cầu chưa xử lý";
            this.gvListWait.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvListWait_RowCellClick);
            this.gvListWait.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvListWait_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thời gian tạo";
            this.gridColumn1.FieldName = "TimeCreate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 98;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại thủ tục";
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MSSV";
            this.gridColumn3.FieldName = "IDStudent";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 98;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Sinh viên";
            this.gridColumn4.FieldName = "NameStudent";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.btrefresh);
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
            this.tileNavPane1.Size = new System.Drawing.Size(732, 32);
            this.tileNavPane1.TabIndex = 6;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // btrefresh
            // 
            this.btrefresh.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.btrefresh.Caption = "Tải lại";
            this.btrefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btrefresh.ImageOptions.Image")));
            this.btrefresh.Name = "btrefresh";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtbinfoo2);
            this.panel1.Controls.Add(this.rtbchitiet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.MaximumSize = new System.Drawing.Size(353, 864);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 434);
            this.panel1.TabIndex = 7;
            // 
            // rtbinfoo2
            // 
            this.rtbinfoo2.BackColor = System.Drawing.SystemColors.Control;
            this.rtbinfoo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbinfoo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbinfoo2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbinfoo2.Location = new System.Drawing.Point(16, 23);
            this.rtbinfoo2.Name = "rtbinfoo2";
            this.rtbinfoo2.ReadOnly = true;
            this.rtbinfoo2.Size = new System.Drawing.Size(251, 130);
            this.rtbinfoo2.TabIndex = 33;
            this.rtbinfoo2.Text = "";
            // 
            // rtbchitiet
            // 
            this.rtbchitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbchitiet.BackColor = System.Drawing.SystemColors.Control;
            this.rtbchitiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbchitiet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbchitiet.Location = new System.Drawing.Point(16, 175);
            this.rtbchitiet.Name = "rtbchitiet";
            this.rtbchitiet.ReadOnly = true;
            this.rtbchitiet.Size = new System.Drawing.Size(251, 254);
            this.rtbchitiet.TabIndex = 32;
            this.rtbchitiet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Thông tin yêu cầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Chi tiết:";
            // 
            // ListWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tileNavPane1);
            this.Controls.Add(this.grCtrListWait);
            this.Name = "ListWait";
            this.Text = "ListWait";
            ((System.ComponentModel.ISupportInitialize)(this.grCtrListWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grCtrListWait;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListWait;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton btrefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbinfoo2;
        private System.Windows.Forms.RichTextBox rtbchitiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}