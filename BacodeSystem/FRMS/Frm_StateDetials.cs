using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.FRMS
{
    public partial class Frm_StateDetials : Form
    {
        string[] data;
        public Frm_StateDetials(string[] data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_StateDetials_Load(object sender, EventArgs e)
        {
           
        }

        private void Frm_StateDetials_Load_1(object sender, EventArgs e)
        {
            lbl_carno.Text = data[0];
            lbl_cartype.Text = data[1];
            lbl_going.Text = data[2];
            lbl_comming.Text = data[4];
            lbl_driver1.Text = data[5];
            lbl_driver2.Text = data[6];
            lbl_distenation.Text = data[7];
            lbl_beneficiray.Text = data[8];
            lbl_customer.Text = data[9];
            lbl_notice.Text = data[10];
            lbl_transcount.Text = data[11];
            lbl_watertype.Text = data[12];
            lbl_regis1.Text = data[13];
            lbl_regis2.Text = data[14];
            lbl_state.Text = "تفاصيل الحالة (" + data[15] + ")";
            lbl_Barcode.Text = data[16];
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FRM_CarsMovements f = new FRM_CarsMovements(lbl_Barcode.Text);
            f.ShowDialog();
        }
    }
}
