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
    public partial class Frm_Control : Form
    {
       
        public Frm_Control()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Control_Load(object sender, EventArgs e)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            string StoredName = "SummryCarByType";
            DataTable Dtcar = GettingData.ReadData(StoredName);
            for(int i = 0; i < Dtcar.Rows.Count; i++)
            {
                CNT.CarCount count = new CNT.CarCount(Dtcar.Rows[i][0].ToString(), Dtcar.Rows[i][1].ToString());
                pnl2.Controls.Add(count);
                count.Location = new Point(20,10+i*50);
            }

            string StoredName1 = "Cars_GetterByNo";
            DataTable Dt = GettingData.ReadData(StoredName1);
            int x = 10, y = 20;
            for(int i = 0;i< Dt.Rows.Count; i++)
            {
                
                TextBox t = new TextBox();
                t.Text = Dt.Rows[i][2].ToString();
                List<Control> controls1 = new List<Control>();
                controls1.Add(t);
                DataTable Dt2 = GettingData.ReadingData(controls1, "Movements_Getter_ByCarNo");
                CNT.CarState card;
                string[] data = new string[17];
                if (Dt2.Rows.Count > 0)
                {

                    data[0] = Dt2.Rows[0][2].ToString();
                    data[1] = Dt2.Rows[0][3].ToString();
                    data[2] = Dt2.Rows[0][4].ToString();
                    data[4] = Dt2.Rows[0][6].ToString();
                    data[5] = Dt2.Rows[0][5].ToString();
                    data[6] = Dt2.Rows[0][7].ToString();
                    data[7] = Dt2.Rows[0][10].ToString();
                    data[8] = Dt2.Rows[0][11].ToString();
                    data[9] = Dt2.Rows[0][9].ToString();
                    data[10] = Dt2.Rows[0][12].ToString();
                    data[11] = Dt2.Rows[0][16].ToString();
                    data[12] = Dt2.Rows[0][17].ToString();
                    data[13] = Dt2.Rows[0][13].ToString();
                    data[14] = Dt2.Rows[0][14].ToString();
                    data[15] = Dt2.Rows[0][8].ToString();
                    data[16] = Dt2.Rows[0][1].ToString();
                    card = new CNT.CarState(Dt.Rows[i][32].ToString(), Dt.Rows[i][2].ToString(), Dt.Rows[i][3].ToString(), Dt2.Rows[0][8].ToString(), data);

                }
                else
                    card = new CNT.CarState(Dt.Rows[i][32].ToString(), Dt.Rows[i][2].ToString(), Dt.Rows[i][3].ToString(), "جاهزة", data);
                pnl.Controls.Add(card);
                card.Location = new Point(x, y);
                if (x+300 < pnl.Width)
                {                    
                    x+=150;
                }
                else
                {
                    x = 10;
                    y += 170;
                }
             
            }
        }

        private void btnexitapplication_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void card_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            pnl.Controls.Clear();
            pnl2.Controls.Clear();
            Frm_Control_Load(sender, e);
        }
    }
}
