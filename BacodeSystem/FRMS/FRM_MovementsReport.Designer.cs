namespace BacodeSystem.FRMS
{
    partial class FRM_MovementsReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MovementsReport));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexitapplication = new Guna.UI.WinForms.GunaImageButton();
            this.DGV_Report = new Guna.UI.WinForms.GunaDataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btn_view = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_print = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cbo_reportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_input1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_input2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dte_From = new System.Windows.Forms.DateTimePicker();
            this.dte_To = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Report)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_reportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_input1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_input2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btnexitapplication, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Report, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnexitapplication
            // 
            this.btnexitapplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexitapplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexitapplication.Image = global::BacodeSystem.Properties.Resources.Delete_32px;
            this.btnexitapplication.ImageSize = new System.Drawing.Size(32, 32);
            this.btnexitapplication.Location = new System.Drawing.Point(3, 3);
            this.btnexitapplication.Name = "btnexitapplication";
            this.btnexitapplication.OnHoverImage = null;
            this.btnexitapplication.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnexitapplication.Size = new System.Drawing.Size(37, 46);
            this.btnexitapplication.TabIndex = 6;
            this.btnexitapplication.Click += new System.EventHandler(this.btnexitapplication_Click);
            // 
            // DGV_Report
            // 
            this.DGV_Report.AllowUserToAddRows = false;
            this.DGV_Report.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Report.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DGV_Report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Report.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Report.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Report.EnableHeadersVisualStyles = false;
            this.DGV_Report.GridColor = System.Drawing.Color.Silver;
            this.DGV_Report.Location = new System.Drawing.Point(3, 55);
            this.DGV_Report.Name = "DGV_Report";
            this.DGV_Report.ReadOnly = true;
            this.DGV_Report.RowHeadersVisible = false;
            this.DGV_Report.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Report.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Report.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold);
            this.DGV_Report.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Report.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Report.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Report.RowTemplate.Height = 35;
            this.DGV_Report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Report.Size = new System.Drawing.Size(741, 691);
            this.DGV_Report.TabIndex = 9;
            this.DGV_Report.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGV_Report.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Report.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Report.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Report.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Report.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DGV_Report.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.DGV_Report.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.DGV_Report.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Report.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Report.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Report.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_Report.ThemeStyle.HeaderStyle.Height = 35;
            this.DGV_Report.ThemeStyle.ReadOnly = true;
            this.DGV_Report.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Report.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Report.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Report.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Report.ThemeStyle.RowsStyle.Height = 35;
            this.DGV_Report.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Report.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(750, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 52);
            this.label10.TabIndex = 22;
            this.label10.Text = "تقارير حركة العجلات";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_view, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_print, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.cbo_reportType, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbo_input1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbo_input2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dte_From, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dte_To, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(750, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34355F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.39112F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.39112F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.92269F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6322F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.6322F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 691);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 71);
            this.label1.TabIndex = 23;
            this.label1.Text = "نوع التقرير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(223, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(88, 71);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "مدخل اول";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(223, 142);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(88, 71);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "مدخل ثاني";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl2.Visible = false;
            // 
            // btn_view
            // 
            this.btn_view.AnimationHoverSpeed = 0.07F;
            this.btn_view.AnimationSpeed = 0.03F;
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_view.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_view.BorderSize = 1;
            this.btn_view.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_view.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_view.CheckedForeColor = System.Drawing.Color.White;
            this.btn_view.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_view.CheckedImage")));
            this.btn_view.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_view.FocusedColor = System.Drawing.Color.Empty;
            this.btn_view.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Image = null;
            this.btn_view.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_view.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_view.Location = new System.Drawing.Point(3, 530);
            this.btn_view.Name = "btn_view";
            this.btn_view.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_view.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_view.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_view.OnHoverImage = null;
            this.btn_view.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_view.OnPressedColor = System.Drawing.Color.Black;
            this.btn_view.Radius = 6;
            this.btn_view.Size = new System.Drawing.Size(214, 74);
            this.btn_view.TabIndex = 29;
            this.btn_view.Text = "معاينة";
            this.btn_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_print
            // 
            this.btn_print.AnimationHoverSpeed = 0.07F;
            this.btn_print.AnimationSpeed = 0.03F;
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_print.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_print.BorderSize = 1;
            this.btn_print.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_print.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_print.CheckedForeColor = System.Drawing.Color.White;
            this.btn_print.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_print.CheckedImage")));
            this.btn_print.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_print.FocusedColor = System.Drawing.Color.Empty;
            this.btn_print.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Image = null;
            this.btn_print.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_print.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_print.Location = new System.Drawing.Point(3, 610);
            this.btn_print.Name = "btn_print";
            this.btn_print.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_print.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_print.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_print.OnHoverImage = null;
            this.btn_print.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_print.OnPressedColor = System.Drawing.Color.Black;
            this.btn_print.Radius = 6;
            this.btn_print.Size = new System.Drawing.Size(214, 78);
            this.btn_print.TabIndex = 30;
            this.btn_print.Text = "طباعة";
            this.btn_print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // cbo_reportType
            // 
            this.cbo_reportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_reportType.Location = new System.Drawing.Point(3, 3);
            this.cbo_reportType.Name = "cbo_reportType";
            this.cbo_reportType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_reportType.Properties.Appearance.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_reportType.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbo_reportType.Properties.Appearance.Options.UseBackColor = true;
            this.cbo_reportType.Properties.Appearance.Options.UseFont = true;
            this.cbo_reportType.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_reportType.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_reportType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_reportType.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.cbo_reportType.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbo_reportType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbo_reportType.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbo_reportType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbo_reportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_reportType.Properties.Items.AddRange(new object[] {
            "رقم العجلة بين تاريخين",
            "نوع العجلة بين تاريخين",
            "اسم سائق بين تاريخين",
            "جهة مقصودة بين تاريخين",
            "جهة مستفيدة بين تاريخين",
            "حالة بين تاريخين",
            "سائق وحالة بين تاريخين",
            "بين تاريخين",
            "حالة وجهة مستفيدة بين تاريخين",
            "حالة وجهة مقصودة بين تاريخين",
            "خلاصة حسب الجهات المستفيدة",
            "خلاصة حسب الجهات المقصودة",
            "خلاصة حسب الحالة",
            "خلاصة الحوضيات",
            "رقم العجلة بين تاريخين(اقسام)",
            "نوع العجلة بين تاريخين(اقسام)",
            "اسم سائق بين تاريخين(اقسام)",
            "جهة مقصودة بين تاريخين(اقسام)",
            "جهة مستفيدة بين تاريخين(اقسام)",
            "حالة بين تاريخين(اقسام)",
            "سائق وحالة بين تاريخين(اقسام)",
            "بين تاريخين(اقسام)",
            "حالة وجهة مستفيدة بين تاريخين(اقسام)",
            "حالة وجهة مقصودة بين تاريخين(اقسام)",
            "خلاصة حسب الجهات المستفيدة(اقسام)",
            "خلاصة حسب الجهات المقصودة(اقسام)",
            "خلاصة حسب الحالة(اقسام)"});
            this.cbo_reportType.Size = new System.Drawing.Size(214, 32);
            this.cbo_reportType.TabIndex = 31;
            this.cbo_reportType.SelectedIndexChanged += new System.EventHandler(this.cbo_reportType_SelectedIndexChanged);
            // 
            // cbo_input1
            // 
            this.cbo_input1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_input1.Location = new System.Drawing.Point(3, 74);
            this.cbo_input1.Name = "cbo_input1";
            this.cbo_input1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_input1.Properties.Appearance.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_input1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbo_input1.Properties.Appearance.Options.UseBackColor = true;
            this.cbo_input1.Properties.Appearance.Options.UseFont = true;
            this.cbo_input1.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_input1.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_input1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_input1.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.cbo_input1.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbo_input1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbo_input1.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbo_input1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbo_input1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_input1.Size = new System.Drawing.Size(214, 32);
            this.cbo_input1.TabIndex = 32;
            this.cbo_input1.Visible = false;
            // 
            // cbo_input2
            // 
            this.cbo_input2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_input2.Location = new System.Drawing.Point(3, 145);
            this.cbo_input2.Name = "cbo_input2";
            this.cbo_input2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_input2.Properties.Appearance.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_input2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbo_input2.Properties.Appearance.Options.UseBackColor = true;
            this.cbo_input2.Properties.Appearance.Options.UseFont = true;
            this.cbo_input2.Properties.Appearance.Options.UseForeColor = true;
            this.cbo_input2.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbo_input2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_input2.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.cbo_input2.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.cbo_input2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbo_input2.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.cbo_input2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cbo_input2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_input2.Size = new System.Drawing.Size(214, 32);
            this.cbo_input2.TabIndex = 33;
            this.cbo_input2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 71);
            this.label2.TabIndex = 34;
            this.label2.Text = "من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(223, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 71);
            this.label3.TabIndex = 35;
            this.label3.Text = "الى";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dte_From
            // 
            this.dte_From.CustomFormat = "";
            this.dte_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dte_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_From.Location = new System.Drawing.Point(3, 216);
            this.dte_From.Name = "dte_From";
            this.dte_From.Size = new System.Drawing.Size(214, 30);
            this.dte_From.TabIndex = 36;
            // 
            // dte_To
            // 
            this.dte_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dte_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_To.Location = new System.Drawing.Point(3, 287);
            this.dte_To.Name = "dte_To";
            this.dte_To.Size = new System.Drawing.Size(214, 30);
            this.dte_To.TabIndex = 37;
            // 
            // FRM_MovementsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1067, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_MovementsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_MovementsReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Report)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_reportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_input1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_input2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaImageButton btnexitapplication;
        public Guna.UI.WinForms.GunaDataGridView DGV_Report;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_view;
        private Guna.UI.WinForms.GunaAdvenceButton btn_print;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_reportType;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_input1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_input2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dte_From;
        private System.Windows.Forms.DateTimePicker dte_To;
    }
}