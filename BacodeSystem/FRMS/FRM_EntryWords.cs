using Guna.UI.WinForms;
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
    public partial class FRM_EntryWords : Form
    {
        DataTable dt;
        GunaTextBox t, txt_TheType, txt_Department, txt_Distenation;
        string[] data;
        public FRM_EntryWords(DataTable dt, GunaTextBox t,  string []data)
        {
            InitializeComponent();
            this.dt = dt;
            this.t = t;
            
            this.data = data;
        }
        public FRM_EntryWords(GunaTextBox t, string[] data)
        {
            InitializeComponent();
            this.t = t;
           
            this.data = data;
        }

        public FRM_EntryWords(GunaTextBox t,  GunaTextBox txt_TheType, GunaTextBox txt_Department, GunaTextBox txt_Distenation, string[] data)
        {
            InitializeComponent();
            this.t = t;
            this.data = data;
            this.txt_TheType = txt_TheType;
            this.txt_Department = txt_Department;
            this.txt_Distenation = txt_Distenation;
        }

        public FRM_EntryWords(DataTable dt, GunaTextBox t, GunaTextBox txt_TheType, GunaTextBox txt_Department, GunaTextBox txt_Distenation, string[] data)
        {
            InitializeComponent();
            this.dt = dt;
            this.t = t;
            this.data = data;
            this.txt_TheType = txt_TheType;
            this.txt_Department = txt_Department;
            this.txt_Distenation = txt_Distenation;
        }

        private void FRM_EntryWords_Load(object sender, EventArgs e)
        {
           
            if (data.Length > 1)
            {
                int x = 10, y = 10;
                for (int i = 0; i < data.Length; i++)
                {
                    GunaAdvenceButton btn = new GunaAdvenceButton();
                    btn.Size = new Size(255, 120);
                    btn.BaseColor = Color.FromArgb(221, 0, 63);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("JF Flat", 20, FontStyle.Bold);
                    btn.OnHoverBaseColor = Color.FromArgb(180, 0, 63);
                    btn.Radius = 7;
                    btn.Image = null;
                    btn.TextAlign = HorizontalAlignment.Center;
                    pnl.Controls.Add(btn);
                    btn.Location = new Point(x, y);
                    if (x >= pnl.Width-400)
                    {
                        x = 10;
                        y += 130;
                    }
                    else
                    {
                        x += 265;
                    }
                    btn.Text = data[i];
                    btn.Click += (sender1, args) =>
                    {
                        switch (btn.Text)
                        {
                            case "قسم":
                                CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
                                DataTable dt = dept.GetDepartmentsDt2();
                                string  []d ={"قسم" };
                                FRM_EntryWords f = new FRM_EntryWords(dt, t, d);
                                f.ShowDialog();
                                this.Close();
                                break;
                            case "جهات اخرى":
                                CLS.CLS_DEPARTMENTS dept1 = new CLS.CLS_DEPARTMENTS();
                                DataTable dt1 = dept1.GetDepartmentsDt3();
                                string[] d1 = { "اخرى" };
                                FRM_EntryWords f1 = new FRM_EntryWords(dt1, t,  d1);
                                f1.ShowDialog();
                                this.Close();
                                break;
                            case "شيخ":
                                CLS.CLS_CUSTOMERS customer = new CLS.CLS_CUSTOMERS();
                                DataTable dt2 = customer.customerDt2();
                                string[] d2 = { "شيخ" };
                                FRM_EntryWords f2 = new FRM_EntryWords(dt2, t,txt_TheType, txt_Department, txt_Distenation, d2);
                                f2.ShowDialog();
                                this.Close();
                                break;
                            case "مهندس":
                                CLS.CLS_CUSTOMERS customer1 = new CLS.CLS_CUSTOMERS();
                                DataTable dt3 = customer1.customerDt3();
                                string[] d3 = { "مهندس" };
                                FRM_EntryWords f3 = new FRM_EntryWords(dt3, t, txt_TheType, txt_Department, txt_Distenation, d3);
                                f3.ShowDialog();
                                this.Close();
                                break;
                            case "خط":
                                CLS.CLS_CUSTOMERS customer2 = new CLS.CLS_CUSTOMERS();
                                DataTable dt4 = customer2.customerDt4();
                                string[] d4 = { "خط" };
                                FRM_EntryWords f4 = new FRM_EntryWords(dt4, t, txt_TheType, txt_Department, txt_Distenation, d4);
                                f4.ShowDialog();
                                this.Close();
                                break;
                            case "مستفيد اخر":
                                CLS.CLS_CUSTOMERS customer3 = new CLS.CLS_CUSTOMERS();
                                DataTable dt5 = customer3.customerDt5();
                                string[] d5 = { "اخرى" };
                                FRM_EntryWords f5 = new FRM_EntryWords(dt5, t, txt_TheType, txt_Department, txt_Distenation, d5);
                                f5.ShowDialog();
                                this.Close();
                                break;
                            case "سيد":
                                CLS.CLS_CUSTOMERS customer4 = new CLS.CLS_CUSTOMERS();
                                DataTable dt6 = customer4.customerDt6();
                                string[] d6 = { "سيد" };
                                FRM_EntryWords f6 = new FRM_EntryWords(dt6, t, txt_TheType, txt_Department, txt_Distenation, d6);
                                f6.ShowDialog();
                                this.Close();
                                break;
                            case "استاذ":
                                CLS.CLS_CUSTOMERS customer5 = new CLS.CLS_CUSTOMERS();
                                DataTable dt11 = customer5.customerDt7();
                                string[] d11 = { "استاذ" };
                                FRM_EntryWords f11 = new FRM_EntryWords(dt11, t, txt_TheType, txt_Department, txt_Distenation, d11);
                                f11.ShowDialog();
                                this.Close();
                                break;
                            case "حوضيات":
                                CLS.CLS_CUSTOMERS customer6 = new CLS.CLS_CUSTOMERS();
                                DataTable dt12 = customer6.customerDt8();
                                string[] d12 = { "حوضيات" };
                                FRM_EntryWords f12 = new FRM_EntryWords(dt12, t, txt_TheType, txt_Department, txt_Distenation, d12);
                                f12.ShowDialog();
                                this.Close();
                                break;
                            case "دكتور":
                                CLS.CLS_CUSTOMERS customer7 = new CLS.CLS_CUSTOMERS();
                                DataTable dt13 = customer7.customerDt9();
                                string[] d13 = { "دكتور" };
                                FRM_EntryWords f13 = new FRM_EntryWords(dt13, t, txt_TheType, txt_Department, txt_Distenation, d13);
                                f13.ShowDialog();
                                this.Close();
                                break;
                            case "اماكن اخرى":
                                CLS.CLS_DISTENATION dis = new CLS.CLS_DISTENATION();
                                DataTable dt7 = dis.GetPlacesDt2();
                                string[] d7 = { "اخرى" };
                                FRM_EntryWords f7 = new FRM_EntryWords(dt7, t,  d7);
                                f7.ShowDialog();
                                this.Close();
                                break;
                            case "احياء":
                                CLS.CLS_DISTENATION dis1 = new CLS.CLS_DISTENATION();
                                DataTable dt8 = dis1.GetPlacesDt3();
                                string[] d8 = { "حي" };
                                FRM_EntryWords f8 = new FRM_EntryWords(dt8, t,  d8);
                                f8.ShowDialog();
                                this.Close();
                                break;
                            case "محافظات":
                                CLS.CLS_DISTENATION dis2 = new CLS.CLS_DISTENATION();
                                DataTable dt9 = dis2.GetPlacesDt4();
                                string[] d9 = { "محافظة" };
                                FRM_EntryWords f9 = new FRM_EntryWords(dt9, t,  d9);
                                f9.ShowDialog();
                                this.Close();
                                break;
                            case "مواقع ومراكز":
                                CLS.CLS_DISTENATION dis3 = new CLS.CLS_DISTENATION();
                                DataTable dt10 = dis3.GetPlacesDt5();
                                string[] d10 = { "مواقع" };
                                FRM_EntryWords f10 = new FRM_EntryWords(dt10, t, d10);
                                f10.ShowDialog();
                                this.Close();
                                break;
                           
                        }

                    };
                }
            }
            else { 
                int x = 10,y = 10;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    GunaAdvenceButton btn = new GunaAdvenceButton();
                    GunaAdvenceButton btn2 = new GunaAdvenceButton();
                    btn.Size = new Size(255, 120);
                    btn.BaseColor = Color.FromArgb(221, 0, 63);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("JF Flat", 20, FontStyle.Bold);
                    btn.OnHoverBaseColor = Color.FromArgb(180, 0, 63);
                    btn.Radius = 7;
                    btn.Image = null;
                    btn.TextAlign = HorizontalAlignment.Center;
                    pnl.Controls.Add(btn);
                    btn.Location = new Point(x, y);
                    if (x >= pnl.Width-400)
                    {
                        x = 10;
                        y += 130;
                    }
                    else
                    {
                        x += 265;
                    }
                    btn.Text = dt.Rows[i][1].ToString();
                    btn2.Text = i.ToString();
                    btn.Click += (sender1, args) =>
                     {
                         t.Text = btn.Text;
                         if (txt_Department != null)
                         {
                             if (dt.Rows[int.Parse(btn2.Text)][4].ToString().Length >0)
                                txt_TheType.Text = dt.Rows[int.Parse(btn2.Text)][4].ToString();
                             if (dt.Rows[int.Parse(btn2.Text)][3].ToString().Length > 0)
                                 txt_Department.Text = dt.Rows[int.Parse(btn2.Text)][3].ToString();
                             if (dt.Rows[int.Parse(btn2.Text)][2].ToString().Length > 0)
                                 txt_Distenation.Text = dt.Rows[int.Parse(btn2.Text)][2].ToString();
                         }
                         if(this.data[0]== "حالة")
                         {
                             if (dt.Rows[int.Parse(btn2.Text)][4].ToString().Length > 0)
                                 txt_TheType.Text = dt.Rows[int.Parse(btn2.Text)][4].ToString();
                             if (dt.Rows[int.Parse(btn2.Text)][3].ToString().Length > 0l)
                                 txt_Department.Text = dt.Rows[int.Parse(btn2.Text)][3].ToString();
                             if (dt.Rows[int.Parse(btn2.Text)][2].ToString().Length > 0)
                                 txt_Distenation.Text = dt.Rows[int.Parse(btn2.Text)][2].ToString();
                         }
                         this.Close();

                     };
                }
            }
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
