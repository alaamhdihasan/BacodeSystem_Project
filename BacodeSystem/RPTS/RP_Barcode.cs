using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraPrinting.BarCode;
namespace BacodeSystem.RPTS
{
    public partial class RP_Barcode : DevExpress.XtraReports.UI.XtraReport
    {
        DataTable BarcodeText;
        public RP_Barcode(DataTable BarcodeText)
        {
            this.BarcodeText = BarcodeText;
            InitializeComponent();
        }

        private void RP_Barcode_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int x = 35, y = 10;
            for(int i = 0; i < BarcodeText.Rows.Count; i++)
            {
                if (BarcodeText.Rows[i][5].ToString() != null && BarcodeText.Rows[i][5].ToString() != "")
                {
                    
                    
                    XRBarCode Barcode = new XRBarCode();
                    Barcode.Width = 90;
                    Barcode.Height = 50;                  
                    Barcode.AutoModule = true;
                    Barcode.Text =BarcodeText.Rows[i][5].ToString();                  
                    Barcode.ShowText = false;
                    Barcode.LocationF = new Point(x, y);
                    
                    XRLabel label = new XRLabel();
                    label.AutoWidth = true;
                    label.Text = BarcodeText.Rows[i][1].ToString();
                    label.Font = new Font("Arial", 8);
                    label.LocationF = new Point(x-10, y + 55);
                    if (x >= 610)
                    {
                        x = 35;
                        y += 85;
                    }
                    else
                        x += 110;
                    Detail.Controls.Add(Barcode);
                    Detail.Controls.Add(label);
                }
            }
            

        }
    }
}
