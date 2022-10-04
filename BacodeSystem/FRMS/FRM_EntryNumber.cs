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
    public partial class FRM_EntryNumber : Form
    {
        Guna.UI.WinForms.GunaTextBox t;
        
        public FRM_EntryNumber(Guna.UI.WinForms.GunaTextBox t)
        {
            InitializeComponent();
            this.t = t;
            txt_Number.Text = t.Text;
            
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "1";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "2";
        }

        private void Btn_InsertDepartment_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "3";
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "4";
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "5";
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "6";
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "7";
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "8";
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "9";
        }

        private void gunaAdvenceButton11_Click(object sender, EventArgs e)
        {
            txt_Number.Text += "0";
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            t.Text = txt_Number.Text;
            
            this.Close();
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            txt_Number.Text=txt_Number.Text.Remove(txt_Number.Text.Length - 1);
        }
    }
}
