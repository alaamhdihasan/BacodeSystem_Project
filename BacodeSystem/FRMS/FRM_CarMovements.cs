//using Emgu.CV;
//using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BacodeSystem.FRMS
{
    public partial class FRM_CarsMovements : Form
    {

        string type= "DeptCar";
        //Capture _capture;
        public FRM_CarsMovements()
        {
            InitializeComponent();
        }
        public FRM_CarsMovements(string barcode)
        {
            InitializeComponent();
            txt_Searching.Text = barcode;
            
        }
        private void FRM_CarsMovements_Load_1(object sender, EventArgs e)
        {
            
            btn_out.Visible = false;
            btn_in.Visible = false;

            
            //_capture = new Capture();

            CLS.CLS_THETYPE type = new CLS.CLS_THETYPE();
            type.Gettype(cbo_TheType);
            CLS.CLS_DISTENATION place = new CLS.CLS_DISTENATION();
            place.GetPlaces(cbo_Distenation);
            CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
            dept.GetDepartments(cbo_Department);
            CLS.CLS_CUSTOMERS cust = new CLS.CLS_CUSTOMERS();
            cust.customer(cbo_Customer);

            if(txt_Searching.Text!="" && txt_Searching.Text != null)
            {
                KeyEventArgs args = new KeyEventArgs(Keys.Enter);
                txt_Searching_KeyDown(sender, args);
                richtxt_Notice.Focus();
                btn_exit.Visible = true;
                btn_other.Visible = false;
                btn_in.Visible = false;
                btn_out.Visible = false;
                txt_driverbarcode1.Enabled = false;
                txt_driverbarcode2.Enabled = false;
                txt_Searching.Enabled = false;
                btn_Capture.Visible = false;
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية التعديل", "عملية تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    List<Control> controls = GetArray();
                    controls.Add(txt_Searching);
                    if (type == "DeptCar")
                    {
                        CLS.CLS_CARMOVEMENTS Updatedata = new CLS.CLS_CARMOVEMENTS();
                        Updatedata.updateData(controls);
                    }
                    else
                    {
                        CLS.CLS_CarMoveOther Updatedata = new CLS.CLS_CarMoveOther();
                        Updatedata.updateData(controls);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_IDMovements); 
            controls.Add(txt_carNo);
            controls.Add(txt_carType);
            controls.Add(txt_timeout);
            controls.Add(txt_driver1);
            controls.Add(txt_timein);
            controls.Add(txt_driver2);
            controls.Add(cbo_TheType);
            controls.Add(cbo_Customer);
            controls.Add(cbo_Distenation);
            controls.Add(cbo_Department);
            controls.Add(richtxt_Notice);
            controls.Add(txt_register1);
            controls.Add(txt_register2);
            controls.Add(txt_DateNow);
            controls.Add(txt_MoveCount);
            controls.Add(cbo_TypeWater);
            controls.Add(txt_PicCar);
            controls.Add(txt_PicGo);
            controls.Add(txt_PicBack);
            
            return controls;

        }

        public List<Control> GetArray2()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_Searching);
            
            return controls;

        }



        private void txt_Searching_KeyDown(object sender,System.Windows.Forms.KeyEventArgs e)
        {
            try { 
            ClearData(GetArray());
            txt_driverbarcode1.Text = "";
            txt_driverbarcode2.Text = "";
            if (e.KeyCode == Keys.Enter)
            {
                           
                CLS.CLS_CARMOVEMENTS GetCar = new CLS.CLS_CARMOVEMENTS();
                DataTable DtGetCar = GetCar.GettingData2(GetArray2());
                 
                if (DtGetCar.Rows.Count ==0)
                {
                    MessageBox.Show("هذه العجلة غير موجودة في النظام");
                }
                else
                {
                    txt_carNo.Text = DtGetCar.Rows[0][0].ToString();
                    txt_carType.Text = DtGetCar.Rows[0][1].ToString();
                    
                    DataTable DtGetCar2;
                        List<Control> controls = GetArray();
                        controls.Insert(1,txt_Searching);
                       
                        if (type == "DeptCar")
                        {
                            CLS.CLS_CARMOVEMENTS GetCar1 = new CLS.CLS_CARMOVEMENTS();
                            
                            DtGetCar2 = GetCar1.GettingData(controls);
                           
                        }
                        else
                        {
                            CLS.CLS_CarMoveOther GetCar1 = new CLS.CLS_CarMoveOther();
                            DtGetCar2 = GetCar1.GettingData(controls);
                            
                        }
                       
                    if (DtGetCar2.Rows.Count == 0)
                    {
                        
                        cbo_Customer.Text = DtGetCar.Rows[0][3].ToString();
                        cbo_Department.Text = DtGetCar.Rows[0][4].ToString();
                        cbo_Distenation.Text = DtGetCar.Rows[0][5].ToString();
                        PicCar.Image = new Bitmap(DtGetCar.Rows[0][6].ToString());
                        txt_PicCar.Text = DtGetCar.Rows[0][6].ToString();
                        btnState();
                        
                        
                    }
                    else
                    {
                        btnState();

                    }
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnState()
        {
            if(txt_timeout.Text==null || txt_timeout.Text == "")
            {
                btn_out.Visible = true;
                btn_in.Visible = false;
                txt_driverbarcode1.Focus();
                
                PicVideoGo.Visible = true;
                
                PicVideoBack.Visible = false;           
                Application.Idle += streamingGo;

               
            }
            else if((txt_timein.Text==null || txt_timein.Text =="") &&
                (txt_timeout.Text !="" || txt_timeout.Text != null))
                {
                btn_out.Visible = false;
                btn_in.Visible = true;
                txt_driverbarcode2.Focus();
                
                PicVideoGo.Visible = false;
                
                PicVideoBack.Visible = true;
                Application.Idle += streamingBack;
            }
            else if((txt_timeout.Text !="" || txt_timeout.Text !=null) &&
                (txt_timein.Text !=null || txt_timein.Text !=""))
            {
                btn_out.Visible = true;
                btn_in.Visible = false;
                txt_driverbarcode1.Focus();
               
                PicVideoGo.Visible = true;
                
                PicVideoBack.Visible = false;
                Application.Idle += streamingGo;
            }
        }
        private void ClearData(List<Control> controls)
        {
            foreach (Control item in controls)
            {
                item.Text = "";
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            //if (txt_PicGo.Text != "")
            //{
            List<Control> controls = GetArray();
            controls.Add(txt_Searching);
            if (type.Equals("DeptCar"))
            {

                if (txt_PicGo.Text != "")
                    PicCarGo.Image.Save(txt_PicGo.Text);

                CLS.CLS_CARMOVEMENTS insertData = new CLS.CLS_CARMOVEMENTS();
                DataTable DtmaxID = insertData.GetMovementID();
                txt_IDMovements.Text = DtmaxID.Rows[0][0].ToString();
                insertData.insertData(controls);
                txt_PicGo.Text = null;
                System.Windows.Forms.KeyEventArgs args = new System.Windows.Forms.KeyEventArgs(Keys.Enter);
                txt_Searching_KeyDown(sender, args);
            }
            else
            {
                if (txt_PicGo.Text != "")
                    PicCarGo.Image.Save(txt_PicGo.Text);

                CLS.CLS_CarMoveOther insertData = new CLS.CLS_CarMoveOther();
                DataTable DtmaxID = insertData.GetMovementID();
                txt_IDMovements.Text = DtmaxID.Rows[0][0].ToString();
                insertData.insertData(controls);
                txt_PicGo.Text = null;
                System.Windows.Forms.KeyEventArgs args = new System.Windows.Forms.KeyEventArgs(Keys.Enter);
                txt_Searching_KeyDown(sender, args);
            }
            //}
            //else
            //{
            //    MessageBox.Show("التقط صورة للعجلة");
            //}
        }

       

        private void btn_in_Click(object sender, EventArgs e)
        {
            //if (txt_PicBack.Text != "")
            //{
            List<Control> controls = GetArray();
            controls.Add(txt_Searching);
            if (type == "DeptCar")
            {
                if (txt_PicGo.Text != "")
                    PicCarBack.Image.Save(txt_PicBack.Text);
                CLS.CLS_CARMOVEMENTS UpdataData = new CLS.CLS_CARMOVEMENTS();

                UpdataData.updateData(controls);
                txt_PicBack.Text = null;
                KeyEventArgs args = new KeyEventArgs(Keys.Enter);
                txt_Searching_KeyDown(sender, args);
            }
            else
            {
                if (txt_PicGo.Text != "")
                    PicCarBack.Image.Save(txt_PicBack.Text);
                CLS.CLS_CarMoveOther UpdataData = new CLS.CLS_CarMoveOther();

                UpdataData.updateData(controls);
                txt_PicBack.Text = null;
                KeyEventArgs args = new KeyEventArgs(Keys.Enter);
                txt_Searching_KeyDown(sender, args);
            }
            //}
            //else
            //{
            //    MessageBox.Show("التقط صورة للعجلة");
            //}
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            if(btn_other.Text== "عجلات اخرى")
            {
                type = "OtherCar";
                btn_other.Text = "عجلات القسم";
                btn_out.Text = "دخول";
                btn_in.Text = "خروج";

                lbl1.Text = "وقت الدخول";
                lbl2.Text = "وقت الخروج";

                ClearData(GetArray());
                txt_Searching.Text = "";
                btnState();
            }
            else
            {
                type = "DeptCar";
                btn_other.Text = "عجلات اخرى";
                btn_out.Text = "مغادرة";
                btn_in.Text = "عودة";

                lbl1.Text = "وقت المغادرة";
                lbl2.Text = "وقت العودة";

                ClearData(GetArray());
                txt_Searching.Text = "";
                btnState();
            }
        }

        private void txt_driverbarcode1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLS.CLS_DRIVERS DriverName = new CLS.CLS_DRIVERS();
                DataTable dtdrivername = DriverName.GettingData_bybarcode(GetDriverName1());
                if (dtdrivername.Rows.Count == 0)
                {
                    txt_driver1.Text = "";
                    MessageBox.Show("هذا السائق غير موجود في النظام");
                }
                else
                {
                    txt_driver1.Text = dtdrivername.Rows[0][1].ToString();
                    txt_driverbarcode1.Text = "";
                    txt_register1.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        public List<Control> GetDriverName1()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_driverbarcode1); 
            return controls;

        }
        public List<Control> GetDriverName2()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_driverbarcode2);
            return controls;

        }

        private void txt_driverbarcode2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLS.CLS_DRIVERS DriverName = new CLS.CLS_DRIVERS();
                DataTable dtdrivername = DriverName.GettingData_bybarcode(GetDriverName2());
                if (dtdrivername.Rows.Count == 0)
                {
                    txt_driver2.Text = "";
                    MessageBox.Show("هذا السائق غير موجود في النظام");
                }
                else
                {
                    txt_driver2.Text = dtdrivername.Rows[0][1].ToString();
                    txt_driverbarcode2.Text = "";
                    txt_register2.Text = Properties.Settings.Default.UserName;
                }
            }
        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
         /*   if (PicVideoGo.Visible == true && PicVideoBack.Visible == false)
            {
                PicCarGo.Image = PicVideoGo.Image;
                Random x = new Random();
                string newpath = Properties.Settings.Default.BarcodeArchPath + x.Next().ToString() + ".jpg";
               
                txt_PicGo.Text = newpath;
            }
            else if (PicVideoGo.Visible == false && PicVideoBack.Visible == true)
            {
                PicCarBack.Image = PicVideoBack.Image;
                Random x = new Random();
                string newpath = Properties.Settings.Default.BarcodeArchPath + x.Next().ToString() + ".jpg";
                
                txt_PicBack.Text = newpath;
            }*/

        }

        private void streamingGo(object sender, System.EventArgs e)
        {
            //try
           // {
              //  var img = _capture.QueryFrame().ToImage<Bgr, byte>();
              //  var bmp = img.Bitmap;
              //  PicVideoGo.Image = bmp;
           // }
           // catch (Exception ex) { }
        }
        private void streamingBack(object sender, System.EventArgs e)
        {
            //try
           // {
           //     var img = _capture.QueryFrame().ToImage<Bgr, byte>();
           ////     var bmp = img.Bitmap;
           //     PicVideoBack.Image = bmp;
           // }
          //  catch (Exception ex) { }
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
