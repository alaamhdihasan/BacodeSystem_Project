namespace BacodeSystem.FRMS
{
    partial class FRM_DRIVERINFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DRIVERINFO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_New = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Btn_Save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Btn_Delete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.searchtxt = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGV_Drivers = new Guna.UI.WinForms.GunaDataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Driver_Barcode = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Driver_ID = new Guna.UI.WinForms.GunaTextBox();
            this.Driver_Depart = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Driver_Name = new Guna.UI.WinForms.GunaTextBox();
            this.Driver_Division = new Guna.UI.WinForms.GunaTextBox();
            this.Driver_Identitify = new Guna.UI.WinForms.GunaTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Barcode = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BarcodeLabel = new DevExpress.XtraEditors.BarCodeControl();
            this.Btn_PrintBarcode = new Guna.UI.WinForms.GunaAdvenceButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnexitapplication = new Guna.UI.WinForms.GunaImageButton();
            this.lb_formName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver_Depart.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.267091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.86667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.866667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.58621F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.41379F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel5.Controls.Add(this.Btn_New, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Btn_Save, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Btn_Delete, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.searchtxt, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 693);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(454, 54);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // Btn_New
            // 
            this.Btn_New.AnimationHoverSpeed = 0.07F;
            this.Btn_New.AnimationSpeed = 0.03F;
            this.Btn_New.BackColor = System.Drawing.Color.Transparent;
            this.Btn_New.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_New.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_New.BorderSize = 1;
            this.Btn_New.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Btn_New.CheckedBorderColor = System.Drawing.Color.Black;
            this.Btn_New.CheckedForeColor = System.Drawing.Color.White;
            this.Btn_New.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Btn_New.CheckedImage")));
            this.Btn_New.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Btn_New.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_New.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_New.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_New.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_New.ForeColor = System.Drawing.Color.White;
            this.Btn_New.Image = null;
            this.Btn_New.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_New.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_New.Location = new System.Drawing.Point(121, 3);
            this.Btn_New.Name = "Btn_New";
            this.Btn_New.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_New.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_New.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_New.OnHoverImage = null;
            this.Btn_New.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_New.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_New.Radius = 6;
            this.Btn_New.Size = new System.Drawing.Size(72, 48);
            this.Btn_New.TabIndex = 26;
            this.Btn_New.Text = "جديد";
            this.Btn_New.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_New.Click += new System.EventHandler(this.Btn_New_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AnimationHoverSpeed = 0.07F;
            this.Btn_Save.AnimationSpeed = 0.03F;
            this.Btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Save.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Save.BorderSize = 1;
            this.Btn_Save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Btn_Save.CheckedBorderColor = System.Drawing.Color.Black;
            this.Btn_Save.CheckedForeColor = System.Drawing.Color.White;
            this.Btn_Save.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Btn_Save.CheckedImage")));
            this.Btn_Save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Btn_Save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Save.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Save.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Image = null;
            this.Btn_Save.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_Save.Location = new System.Drawing.Point(59, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Save.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Save.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Save.OnHoverImage = null;
            this.Btn_Save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_Save.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Save.Radius = 6;
            this.Btn_Save.Size = new System.Drawing.Size(56, 48);
            this.Btn_Save.TabIndex = 24;
            this.Btn_Save.Text = "حفظ";
            this.Btn_Save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.AnimationHoverSpeed = 0.07F;
            this.Btn_Delete.AnimationSpeed = 0.03F;
            this.Btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Delete.BorderSize = 1;
            this.Btn_Delete.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Btn_Delete.CheckedBorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.CheckedForeColor = System.Drawing.Color.White;
            this.Btn_Delete.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.CheckedImage")));
            this.Btn_Delete.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Delete.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_Delete.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Image = null;
            this.Btn_Delete.ImageSize = new System.Drawing.Size(20, 20);
            this.Btn_Delete.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_Delete.Location = new System.Drawing.Point(3, 3);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_Delete.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_Delete.OnHoverImage = null;
            this.Btn_Delete.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_Delete.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_Delete.Radius = 6;
            this.Btn_Delete.Size = new System.Drawing.Size(50, 48);
            this.Btn_Delete.TabIndex = 23;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.BackColor = System.Drawing.Color.Transparent;
            this.searchtxt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.searchtxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.searchtxt.BorderSize = 1;
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchtxt.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.searchtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.searchtxt.FocusedForeColor = System.Drawing.Color.White;
            this.searchtxt.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.ForeColor = System.Drawing.Color.White;
            this.searchtxt.Location = new System.Drawing.Point(199, 3);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.Radius = 7;
            this.searchtxt.Size = new System.Drawing.Size(252, 48);
            this.searchtxt.TabIndex = 25;
            this.searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.DGV_Drivers, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25865F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74135F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 622);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // DGV_Drivers
            // 
            this.DGV_Drivers.AllowUserToAddRows = false;
            this.DGV_Drivers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Drivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Drivers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Drivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Drivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Drivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Drivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Drivers.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Drivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Drivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Drivers.EnableHeadersVisualStyles = false;
            this.DGV_Drivers.GridColor = System.Drawing.Color.Silver;
            this.DGV_Drivers.Location = new System.Drawing.Point(3, 309);
            this.DGV_Drivers.Name = "DGV_Drivers";
            this.DGV_Drivers.ReadOnly = true;
            this.DGV_Drivers.RowHeadersVisible = false;
            this.DGV_Drivers.RowTemplate.Height = 35;
            this.DGV_Drivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Drivers.Size = new System.Drawing.Size(448, 310);
            this.DGV_Drivers.TabIndex = 7;
            this.DGV_Drivers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGV_Drivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Drivers.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Drivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Drivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Drivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGV_Drivers.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Drivers.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.DGV_Drivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.DGV_Drivers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_Drivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Drivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Drivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV_Drivers.ThemeStyle.HeaderStyle.Height = 35;
            this.DGV_Drivers.ThemeStyle.ReadOnly = true;
            this.DGV_Drivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DGV_Drivers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Drivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("JF Flat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_Drivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Drivers.ThemeStyle.RowsStyle.Height = 35;
            this.DGV_Drivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV_Drivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.56419F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.43581F));
            this.tableLayoutPanel3.Controls.Add(this.gunaAdvenceButton1, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.Driver_Barcode, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Driver_ID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Driver_Depart, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Driver_Name, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Driver_Division, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.Driver_Identitify, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(448, 300);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.gunaAdvenceButton1.BorderSize = 1;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(319, 255);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 6;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(126, 42);
            this.gunaAdvenceButton1.TabIndex = 28;
            this.gunaAdvenceButton1.Text = "تحميل";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // Driver_Barcode
            // 
            this.Driver_Barcode.BackColor = System.Drawing.Color.Transparent;
            this.Driver_Barcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Barcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Driver_Barcode.BorderSize = 0;
            this.Driver_Barcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Driver_Barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_Barcode.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Driver_Barcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Driver_Barcode.FocusedForeColor = System.Drawing.Color.White;
            this.Driver_Barcode.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Barcode.ForeColor = System.Drawing.Color.White;
            this.Driver_Barcode.Location = new System.Drawing.Point(3, 213);
            this.Driver_Barcode.Name = "Driver_Barcode";
            this.Driver_Barcode.PasswordChar = '●';
            this.Driver_Barcode.Radius = 7;
            this.Driver_Barcode.Size = new System.Drawing.Size(310, 36);
            this.Driver_Barcode.TabIndex = 23;
            this.Driver_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Driver_Barcode.UseSystemPasswordChar = true;
            this.Driver_Barcode.TextChanged += new System.EventHandler(this.Driver_Barcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(319, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 42);
            this.label6.TabIndex = 7;
            this.label6.Text = "الباركود";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "ت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم السائق";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "القسم";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "الشعبة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(319, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 42);
            this.label5.TabIndex = 6;
            this.label5.Text = "رقم الباج";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Driver_ID
            // 
            this.Driver_ID.BackColor = System.Drawing.Color.Transparent;
            this.Driver_ID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_ID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Driver_ID.BorderSize = 0;
            this.Driver_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Driver_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_ID.Enabled = false;
            this.Driver_ID.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Driver_ID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Driver_ID.FocusedForeColor = System.Drawing.Color.White;
            this.Driver_ID.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_ID.ForeColor = System.Drawing.Color.White;
            this.Driver_ID.Location = new System.Drawing.Point(3, 3);
            this.Driver_ID.Name = "Driver_ID";
            this.Driver_ID.PasswordChar = '\0';
            this.Driver_ID.Radius = 7;
            this.Driver_ID.Size = new System.Drawing.Size(310, 36);
            this.Driver_ID.TabIndex = 12;
            this.Driver_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Driver_Depart
            // 
            this.Driver_Depart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_Depart.Location = new System.Drawing.Point(3, 87);
            this.Driver_Depart.Name = "Driver_Depart";
            this.Driver_Depart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Depart.Properties.Appearance.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Depart.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.Driver_Depart.Properties.Appearance.Options.UseBackColor = true;
            this.Driver_Depart.Properties.Appearance.Options.UseFont = true;
            this.Driver_Depart.Properties.Appearance.Options.UseForeColor = true;
            this.Driver_Depart.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Depart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("JF Flat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Depart.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.Driver_Depart.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.Driver_Depart.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Driver_Depart.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.Driver_Depart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Driver_Depart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Driver_Depart.Size = new System.Drawing.Size(310, 24);
            this.Driver_Depart.TabIndex = 17;
            // 
            // Driver_Name
            // 
            this.Driver_Name.BackColor = System.Drawing.Color.Transparent;
            this.Driver_Name.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Driver_Name.BorderSize = 0;
            this.Driver_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Driver_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_Name.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Driver_Name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Driver_Name.FocusedForeColor = System.Drawing.Color.White;
            this.Driver_Name.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Name.ForeColor = System.Drawing.Color.White;
            this.Driver_Name.Location = new System.Drawing.Point(3, 45);
            this.Driver_Name.Name = "Driver_Name";
            this.Driver_Name.PasswordChar = '\0';
            this.Driver_Name.Radius = 7;
            this.Driver_Name.Size = new System.Drawing.Size(310, 36);
            this.Driver_Name.TabIndex = 18;
            this.Driver_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Driver_Division
            // 
            this.Driver_Division.BackColor = System.Drawing.Color.Transparent;
            this.Driver_Division.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Division.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Driver_Division.BorderSize = 0;
            this.Driver_Division.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Driver_Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_Division.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Driver_Division.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Driver_Division.FocusedForeColor = System.Drawing.Color.White;
            this.Driver_Division.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Division.ForeColor = System.Drawing.Color.White;
            this.Driver_Division.Location = new System.Drawing.Point(3, 129);
            this.Driver_Division.Name = "Driver_Division";
            this.Driver_Division.PasswordChar = '\0';
            this.Driver_Division.Radius = 7;
            this.Driver_Division.Size = new System.Drawing.Size(310, 36);
            this.Driver_Division.TabIndex = 19;
            this.Driver_Division.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Driver_Identitify
            // 
            this.Driver_Identitify.BackColor = System.Drawing.Color.Transparent;
            this.Driver_Identitify.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Driver_Identitify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Driver_Identitify.BorderSize = 0;
            this.Driver_Identitify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Driver_Identitify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Driver_Identitify.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Driver_Identitify.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Driver_Identitify.FocusedForeColor = System.Drawing.Color.White;
            this.Driver_Identitify.Font = new System.Drawing.Font("JF Flat", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver_Identitify.ForeColor = System.Drawing.Color.White;
            this.Driver_Identitify.Location = new System.Drawing.Point(3, 171);
            this.Driver_Identitify.Name = "Driver_Identitify";
            this.Driver_Identitify.PasswordChar = '\0';
            this.Driver_Identitify.Radius = 7;
            this.Driver_Identitify.Size = new System.Drawing.Size(310, 36);
            this.Driver_Identitify.TabIndex = 20;
            this.Driver_Identitify.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Barcode, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.BarcodeLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Btn_PrintBarcode, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 255);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(310, 42);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // btn_Barcode
            // 
            this.btn_Barcode.AnimationHoverSpeed = 0.07F;
            this.btn_Barcode.AnimationSpeed = 0.03F;
            this.btn_Barcode.BackColor = System.Drawing.Color.Transparent;
            this.btn_Barcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_Barcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_Barcode.BorderSize = 1;
            this.btn_Barcode.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Barcode.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Barcode.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Barcode.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Barcode.CheckedImage")));
            this.btn_Barcode.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Barcode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Barcode.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Barcode.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Barcode.ForeColor = System.Drawing.Color.White;
            this.btn_Barcode.Image = null;
            this.btn_Barcode.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Barcode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Barcode.Location = new System.Drawing.Point(57, 3);
            this.btn_Barcode.Name = "btn_Barcode";
            this.btn_Barcode.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_Barcode.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.btn_Barcode.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Barcode.OnHoverImage = null;
            this.btn_Barcode.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Barcode.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Barcode.Radius = 6;
            this.btn_Barcode.Size = new System.Drawing.Size(46, 36);
            this.btn_Barcode.TabIndex = 29;
            this.btn_Barcode.Text = "|||||";
            this.btn_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Barcode.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLabel.ForeColor = System.Drawing.Color.White;
            this.BarcodeLabel.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BarcodeLabel.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BarcodeLabel.Location = new System.Drawing.Point(109, 3);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.BarcodeLabel.ShowText = false;
            this.BarcodeLabel.Size = new System.Drawing.Size(198, 36);
            this.BarcodeLabel.Symbology = code128Generator1;
            this.BarcodeLabel.TabIndex = 28;
            this.BarcodeLabel.VerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // Btn_PrintBarcode
            // 
            this.Btn_PrintBarcode.AnimationHoverSpeed = 0.07F;
            this.Btn_PrintBarcode.AnimationSpeed = 0.03F;
            this.Btn_PrintBarcode.BackColor = System.Drawing.Color.Transparent;
            this.Btn_PrintBarcode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_PrintBarcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_PrintBarcode.BorderSize = 1;
            this.Btn_PrintBarcode.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Btn_PrintBarcode.CheckedBorderColor = System.Drawing.Color.Black;
            this.Btn_PrintBarcode.CheckedForeColor = System.Drawing.Color.White;
            this.Btn_PrintBarcode.CheckedImage = global::BacodeSystem.Properties.Resources.Print_48px;
            this.Btn_PrintBarcode.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Btn_PrintBarcode.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn_PrintBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_PrintBarcode.FocusedColor = System.Drawing.Color.Empty;
            this.Btn_PrintBarcode.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PrintBarcode.ForeColor = System.Drawing.Color.White;
            this.Btn_PrintBarcode.Image = global::BacodeSystem.Properties.Resources.Print_48px;
            this.Btn_PrintBarcode.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_PrintBarcode.ImageSize = new System.Drawing.Size(30, 30);
            this.Btn_PrintBarcode.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_PrintBarcode.Location = new System.Drawing.Point(3, 3);
            this.Btn_PrintBarcode.Name = "Btn_PrintBarcode";
            this.Btn_PrintBarcode.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_PrintBarcode.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(63)))));
            this.Btn_PrintBarcode.OnHoverForeColor = System.Drawing.Color.White;
            this.Btn_PrintBarcode.OnHoverImage = null;
            this.Btn_PrintBarcode.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Btn_PrintBarcode.OnPressedColor = System.Drawing.Color.Black;
            this.Btn_PrintBarcode.Radius = 6;
            this.Btn_PrintBarcode.Size = new System.Drawing.Size(48, 36);
            this.Btn_PrintBarcode.TabIndex = 27;
            this.Btn_PrintBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn_PrintBarcode.Click += new System.EventHandler(this.Btn_Barcode_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel4.Controls.Add(this.btnexitapplication, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lb_formName, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(454, 56);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnexitapplication
            // 
            this.btnexitapplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexitapplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexitapplication.Image = global::BacodeSystem.Properties.Resources.Delete_32px;
            this.btnexitapplication.ImageSize = new System.Drawing.Size(32, 32);
            this.btnexitapplication.Location = new System.Drawing.Point(3, 3);
            this.btnexitapplication.Name = "btnexitapplication";
            this.btnexitapplication.OnHoverImage = null;
            this.btnexitapplication.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnexitapplication.Size = new System.Drawing.Size(25, 32);
            this.btnexitapplication.TabIndex = 3;
            this.btnexitapplication.Click += new System.EventHandler(this.btnexitapplication_Click);
            // 
            // lb_formName
            // 
            this.lb_formName.AutoSize = true;
            this.lb_formName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_formName.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_formName.ForeColor = System.Drawing.Color.White;
            this.lb_formName.Location = new System.Drawing.Point(34, 0);
            this.lb_formName.Name = "lb_formName";
            this.lb_formName.Size = new System.Drawing.Size(417, 56);
            this.lb_formName.TabIndex = 2;
            this.lb_formName.Text = "ادخال بيانات السواق   ";
            this.lb_formName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_DRIVERINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(460, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_DRIVERINFO";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_DRIVERINFO";
            this.Load += new System.EventHandler(this.FRM_DRIVERINFO_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Driver_Depart.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Guna.UI.WinForms.GunaAdvenceButton Btn_Save;
        private Guna.UI.WinForms.GunaAdvenceButton Btn_Delete;
        private Guna.UI.WinForms.GunaTextBox searchtxt;
        private Guna.UI.WinForms.GunaAdvenceButton Btn_New;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox Driver_ID;
        private Guna.UI.WinForms.GunaTextBox Driver_Barcode;
        private DevExpress.XtraEditors.ComboBoxEdit Driver_Depart;
        private Guna.UI.WinForms.GunaTextBox Driver_Name;
        private Guna.UI.WinForms.GunaTextBox Driver_Division;
        private Guna.UI.WinForms.GunaTextBox Driver_Identitify;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.BarCodeControl BarcodeLabel;
        private Guna.UI.WinForms.GunaAdvenceButton Btn_PrintBarcode;
        public Guna.UI.WinForms.GunaDataGridView DGV_Drivers;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lb_formName;
        private Guna.UI.WinForms.GunaImageButton btnexitapplication;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Barcode;
    }
}