using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BacodeSystem.RPTS
{
    public partial class RP_Cars : DevExpress.XtraReports.UI.XtraReport
    {
        string datamember;
        string[] col;
        int[] colsize;
        string[] data;
        public RP_Cars(string datamember, string[] col, int[] colsize, string[] data)
        {
            InitializeComponent();
            this.datamember = datamember;
            this.col = col;
            this.colsize = colsize;
            this.data = data;
        }

    
        private void xrTablecol_AfterPrint(object sender, EventArgs e)
        {

            if (xrTablecol.Rows[0].Cells.Count <= 1)
            {
                for (int i = 0; i < col.GetLength(0); i++)
                {

                    XRTableCell cell = new XRTableCell();
                    cell.Text = col[i];
                    cell.Font = new Font("JF Flat", 10, FontStyle.Bold);

                    xrTablecol.Rows[0].Cells.Add(cell);



                }
            }
            for (int i = 0; i < colsize.Length; i++)
            {
                xrTablecol.Rows[0].Cells[i].SizeF = new SizeF(colsize[i], xrTablecol.Rows[0].Cells[i].SizeF.Height);
                
            }
        }

      

        private void xrTabledata_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            CarModelCell.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", data[0]));
            for (int i = 1; i < data.Length; i++)
            {
                xrTabledata.Rows[0].Cells[i].ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", data[i]));
            }
        }

        private void RP_Cars_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.DataMember = datamember;

            for (int i = 0; i < col.GetLength(0); i++)
            {
                XRTableCell celldata = new XRTableCell();
                celldata.Font = new Font("JF Flat", 10, FontStyle.Bold);
                celldata.Text = data[i];
                xrTabledata.Rows[0].Cells.Add(celldata);
            }
   
            for (int i = 0; i < colsize.Length; i++)
            {
                xrTabledata.Rows[0].Cells[i].SizeF = new SizeF(colsize[i], xrTabledata.Rows[0].Cells[i].SizeF.Height);
            }       
        }

     
    }
}
