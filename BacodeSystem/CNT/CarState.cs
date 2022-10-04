using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.CNT
{
    public partial class CarState : UserControl
    {
        string[] data;
        public CarState(string img, string carno, string cartype, string carstate, string[] data)
        {
            InitializeComponent();
            this.data = data;
            lbl_CarNo.Text = carno;
            lbl_CarState.Text = carstate;
           
            if (img != null && img != "")
                Car_Image.Load(img);
            else
                Car_Image.Image = Properties.Resources.car;
            
        }

        private void Car_Image_Click(object sender, EventArgs e)
        {
            FRMS.Frm_StateDetials state = new FRMS.Frm_StateDetials(data);
            state.ShowDialog();
        }

        private void lbl_CarNo_Click(object sender, EventArgs e)
        {
            FRMS.Frm_StateDetials state = new FRMS.Frm_StateDetials(data);
            state.ShowDialog();
        }

     

        private void lbl_CarState_Click(object sender, EventArgs e)
        {
            FRMS.Frm_StateDetials state = new FRMS.Frm_StateDetials(data);
            state.ShowDialog();
        }

        private void CarState_Load(object sender, EventArgs e)
        {
            if ((data[2] != null && data[2] != "") && (data[4] == null || data[4] == ""))
            {
                tableLayoutPanel1.BackColor = Color.DarkRed;
            }
        }
    }
}
