namespace BacodeSystem.RPTS
{
    partial class RP_Cars
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RP_Cars));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTabledata = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.CarModelCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTablecol = new DevExpress.XtraReports.UI.XRTable();
            this.tblColName = new DevExpress.XtraReports.UI.XRTableRow();
            this.cell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.typereport = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.countrow = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.RigName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCrossBandBox1 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox2 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox3 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.xrCrossBandBox4 = new DevExpress.XtraReports.UI.XRCrossBandBox();
            this.dsCars1 = new BacodeSystem.DS.DSCars();
            this.user = new DevExpress.XtraReports.Parameters.Parameter();
            this.count = new DevExpress.XtraReports.Parameters.Parameter();
            this.RpType = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTablecol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCars1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 15F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 23F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTabledata});
            this.Detail.HeightF = 44.99999F;
            this.Detail.Name = "Detail";
            // 
            // xrTabledata
            // 
            this.xrTabledata.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTabledata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.xrTabledata.LocationFloat = new DevExpress.Utils.PointFloat(46.46564F, 0F);
            this.xrTabledata.Name = "xrTabledata";
            this.xrTabledata.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTabledata.SizeF = new System.Drawing.SizeF(741.6535F, 44.99999F);
            this.xrTabledata.StylePriority.UseBorders = false;
            this.xrTabledata.StylePriority.UseFont = false;
            this.xrTabledata.StylePriority.UseTextAlignment = false;
            this.xrTabledata.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTabledata.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTabledata_BeforePrint);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.CarModelCell});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // CarModelCell
            // 
            this.CarModelCell.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.CarModelCell.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModelCell.Name = "CarModelCell";
            this.CarModelCell.StylePriority.UseBorders = false;
            this.CarModelCell.StylePriority.UseFont = false;
            this.CarModelCell.Text = "CarModelCell";
            this.CarModelCell.Weight = 2.6606309642489405D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.ReportHeader.HeightF = 167.8813F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(26.43029F, 10F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(768.0016F, 141.3336F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTablecol,
            this.typereport});
            this.PageHeader.HeightF = 149.068F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTablecol
            // 
            this.xrTablecol.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTablecol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrTablecol.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTablecol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTablecol.LocationFloat = new DevExpress.Utils.PointFloat(46.46561F, 110.4222F);
            this.xrTablecol.Name = "xrTablecol";
            this.xrTablecol.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tblColName});
            this.xrTablecol.SizeF = new System.Drawing.SizeF(741.6535F, 38.64581F);
            this.xrTablecol.StylePriority.UseBackColor = false;
            this.xrTablecol.StylePriority.UseBorders = false;
            this.xrTablecol.StylePriority.UseFont = false;
            this.xrTablecol.StylePriority.UseTextAlignment = false;
            this.xrTablecol.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTablecol.AfterPrint += new System.EventHandler(this.xrTablecol_AfterPrint);
            // 
            // tblColName
            // 
            this.tblColName.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cell1});
            this.tblColName.Name = "tblColName";
            this.tblColName.Weight = 1D;
            // 
            // cell1
            // 
            this.cell1.CanGrow = false;
            this.cell1.Font = new System.Drawing.Font("JF Flat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cell1.Name = "cell1";
            this.cell1.StylePriority.UseFont = false;
            this.cell1.Text = "ت";
            this.cell1.Weight = 2.9220507477630533D;
            // 
            // typereport
            // 
            this.typereport.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[RpType]")});
            this.typereport.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.typereport.ForeColor = System.Drawing.Color.Red;
            this.typereport.LocationFloat = new DevExpress.Utils.PointFloat(28.93725F, 12.08334F);
            this.typereport.Multiline = true;
            this.typereport.Name = "typereport";
            this.typereport.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.typereport.SizeF = new System.Drawing.SizeF(765.9183F, 85.24558F);
            this.typereport.StylePriority.UseFont = false;
            this.typereport.StylePriority.UseForeColor = false;
            this.typereport.StylePriority.UseTextAlignment = false;
            this.typereport.Text = "typereport";
            this.typereport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.typereport.TextFormatString = "{0:#,#}";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.countrow,
            this.xrLabel3,
            this.xrPageInfo1,
            this.RigName,
            this.xrLabel11,
            this.xrLabel5});
            this.PageFooter.HeightF = 108.078F;
            this.PageFooter.Name = "PageFooter";
            // 
            // countrow
            // 
            this.countrow.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[count]")});
            this.countrow.Font = new System.Drawing.Font("Jaridah", 9.75F, System.Drawing.FontStyle.Bold);
            this.countrow.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.countrow.LocationFloat = new DevExpress.Utils.PointFloat(179.498F, 21.65254F);
            this.countrow.Name = "countrow";
            this.countrow.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.countrow.SizeF = new System.Drawing.SizeF(60.3452F, 31.33334F);
            this.countrow.StylePriority.UseFont = false;
            this.countrow.StylePriority.UseForeColor = false;
            this.countrow.StylePriority.UseTextAlignment = false;
            this.countrow.Text = "countrow";
            this.countrow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.countrow.TextFormatString = "{0:#,#}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("JF Flat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(46.46564F, 21.65254F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(132.6087F, 31.33336F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "العدد الكلي :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(757.1735F, 84.1663F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(56.25018F, 23.9117F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // RigName
            // 
            this.RigName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[user]")});
            this.RigName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.RigName.ForeColor = System.Drawing.Color.Red;
            this.RigName.LocationFloat = new DevExpress.Utils.PointFloat(577.8394F, 84.6805F);
            this.RigName.Name = "RigName";
            this.RigName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.RigName.SizeF = new System.Drawing.SizeF(75.93542F, 23.39749F);
            this.RigName.StylePriority.UseFont = false;
            this.RigName.StylePriority.UseForeColor = false;
            this.RigName.StylePriority.UseTextAlignment = false;
            this.RigName.Text = "UserName";
            this.RigName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(510.2214F, 84.68047F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(67.19427F, 23.39752F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "اسم المستخدم: ";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.42371F, 84.6805F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(499.374F, 23.39749F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "العتبة العباسية المقدسة // قسم الاليات __ البيانات الالكترونية_ هاتف 1793 // الها" +
    "تف الارضي ( البدالة) 1159// موبايل 07602363277";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrCrossBandBox1
            // 
            this.xrCrossBandBox1.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox1.EndBand = this.ReportHeader;
            this.xrCrossBandBox1.EndPointFloat = new DevExpress.Utils.PointFloat(12.50694F, 164.7854F);
            this.xrCrossBandBox1.Name = "xrCrossBandBox1";
            this.xrCrossBandBox1.StartBand = this.ReportHeader;
            this.xrCrossBandBox1.StartPointFloat = new DevExpress.Utils.PointFloat(12.50694F, 0F);
            this.xrCrossBandBox1.WidthF = 798.8334F;
            // 
            // xrCrossBandBox2
            // 
            this.xrCrossBandBox2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox2.EndBand = this.ReportHeader;
            this.xrCrossBandBox2.EndPointFloat = new DevExpress.Utils.PointFloat(26.43029F, 151.3336F);
            this.xrCrossBandBox2.Name = "xrCrossBandBox2";
            this.xrCrossBandBox2.StartBand = this.ReportHeader;
            this.xrCrossBandBox2.StartPointFloat = new DevExpress.Utils.PointFloat(26.43029F, 10F);
            this.xrCrossBandBox2.WidthF = 772.3292F;
            // 
            // xrCrossBandBox3
            // 
            this.xrCrossBandBox3.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox3.EndBand = this.PageFooter;
            this.xrCrossBandBox3.EndPointFloat = new DevExpress.Utils.PointFloat(26.43029F, 75.57269F);
            this.xrCrossBandBox3.Name = "xrCrossBandBox3";
            this.xrCrossBandBox3.StartBand = this.PageHeader;
            this.xrCrossBandBox3.StartPointFloat = new DevExpress.Utils.PointFloat(26.43029F, 10F);
            this.xrCrossBandBox3.WidthF = 772.3291F;
            // 
            // xrCrossBandBox4
            // 
            this.xrCrossBandBox4.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandBox4.EndBand = this.PageFooter;
            this.xrCrossBandBox4.EndPointFloat = new DevExpress.Utils.PointFloat(12.50696F, 84.68057F);
            this.xrCrossBandBox4.Name = "xrCrossBandBox4";
            this.xrCrossBandBox4.StartBand = this.PageHeader;
            this.xrCrossBandBox4.StartPointFloat = new DevExpress.Utils.PointFloat(12.50696F, 0F);
            this.xrCrossBandBox4.WidthF = 799.257F;
            // 
            // dsCars1
            // 
            this.dsCars1.DataSetName = "DSCars";
            this.dsCars1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user
            // 
            this.user.Name = "user";
            // 
            // count
            // 
            this.count.Name = "count";
            // 
            // RpType
            // 
            this.RpType.Name = "RpType";
            // 
            // RP_Cars
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsCars1});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandBox4,
            this.xrCrossBandBox3,
            this.xrCrossBandBox2,
            this.xrCrossBandBox1});
            this.DataMember = "RPCD_CarType";
            this.DataSource = this.dsCars1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(13, 13, 15, 23);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.user,
            this.count,
            this.RpType});
            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            this.Version = "19.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RP_Cars_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTabledata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTablecol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCars1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox1;
        public DevExpress.XtraReports.UI.XRTable xrTabledata;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell CarModelCell;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        public DevExpress.XtraReports.UI.XRLabel typereport;
        public DevExpress.XtraReports.UI.XRLabel countrow;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        public DevExpress.XtraReports.UI.XRLabel RigName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox2;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox3;
        private DevExpress.XtraReports.UI.XRCrossBandBox xrCrossBandBox4;
        private DS.DSCars dsCars1;
        private DevExpress.XtraReports.Parameters.Parameter user;
        private DevExpress.XtraReports.Parameters.Parameter count;
        private DevExpress.XtraReports.Parameters.Parameter RpType;
        private DevExpress.XtraReports.UI.XRTable xrTablecol;
        private DevExpress.XtraReports.UI.XRTableRow tblColName;
        private DevExpress.XtraReports.UI.XRTableCell cell1;
    }
}
