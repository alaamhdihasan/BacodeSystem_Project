using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.FRMS
{
    public partial class FRM_UserCarMovements : Form
    {
        bool update=false;
        public FRM_UserCarMovements()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_InsertType_Click(object sender, EventArgs e)
        {
            try {
                update = true;
                CLS.CLS_THETYPE type = new CLS.CLS_THETYPE();
                DataTable dt = type.GettypeDt();
                
                string[] data = { "حالة"};
                FRM_EntryWords f = new FRM_EntryWords(dt, txt_TheType, txt_Customer, txt_Department, txt_Distenation, data);
                f.ShowDialog();
                 }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_InsertCustomer_Click(object sender, EventArgs e)
        {
            try {
                update = true;
                
                string[] data = {"شيخ", "مهندس", "خط","سيد" , "مستفيد اخر", "استاذ", "حوضيات", "دكتور" };
                FRM_EntryWords f = new FRM_EntryWords(txt_Customer, txt_TheType, txt_Department, txt_Distenation,  data);
                f.ShowDialog();
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_InsertDepartment_Click(object sender, EventArgs e)
        {
            try {
                update = true;
               
                string[] data = { "قسم", "جهات اخرى" };
                FRM_EntryWords f = new FRM_EntryWords(txt_Department, data);
                f.ShowDialog();           
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_InsertDistenation_Click(object sender, EventArgs e)
        {
            try {
                update = true;
                
                string[] data = {   "محافظات", "احياء","مواقع ومراكز" , "اماكن اخرى" };
                FRM_EntryWords f = new FRM_EntryWords(txt_Distenation, data);
                f.ShowDialog();           
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_InsertWaterType_Click(object sender, EventArgs e)
        {
            try {
                update = true;
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("id");
                dt.Columns.Add("word");
                object[] o1 = { 0, "اسالة" };
                dt.Rows.Add(o1);
                object[] o2 = { 1, "سقي" };
                dt.Rows.Add(o2);
                object[] o3 = { 2, "سحب مياه" };
                dt.Rows.Add(o3);
                
                string[] data = { "ماء" };
                FRM_EntryWords f = new FRM_EntryWords(dt, txt_TypeWater, data);
                f.ShowDialog();           
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
            controls.Add(txt_TheType);
            controls.Add(txt_Customer);
            controls.Add(txt_Distenation);
            controls.Add(txt_Department);         
            controls.Add(txt_register1);
            controls.Add(txt_register2);         
            controls.Add(txt_MoveCount);
            controls.Add(txt_TypeWater);
          
            return controls;
        }

        public List<Control> GetArrayUpdate()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_IDMovements);
            controls.Add(txt_carNo);
            controls.Add(txt_carType);
            controls.Add(txt_timein);
            controls.Add(txt_driver2);
            controls.Add(txt_TheType);
            controls.Add(txt_Customer);
            controls.Add(txt_Distenation);
            controls.Add(txt_Department);
            controls.Add(txt_register2);
            controls.Add(txt_MoveCount);
            controls.Add(txt_TypeWater);

            return controls;
        }

        public List<Control> GetArray2()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_Searching);

            return controls;

        }
        private void ClearData(List<Control> controls)
        {
            foreach (Control item in controls)
            {
                item.Text = "";
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


        private void txt_Searching_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                update = false;
                ClearData(GetArray());
                txt_driverbarcode1.Text = "";
                txt_driverbarcode2.Text = "";
                if (e.KeyCode == Keys.Enter)
                {

                    CLS.CLS_CarMoveUser GetCar = new CLS.CLS_CarMoveUser();
                    DataTable DtGetCar = GetCar.GettingData2(GetArray2());

                    if (DtGetCar.Rows.Count == 0)
                    {
                        MessageBox.Show("هذه العجلة غير موجودة في النظام");
                    }
                    else
                    {
                        txt_carNo.Text = DtGetCar.Rows[0][0].ToString();
                        txt_carType.Text = DtGetCar.Rows[0][1].ToString();

                        DataTable DtGetCar2;
                        List<Control> controls = GetArray();
                        controls.Insert(1, txt_Searching);
                        CLS.CLS_CarMoveUser GetCar1 = new CLS.CLS_CarMoveUser();
                        DtGetCar2 = GetCar1.GettingData(controls);
                        if (DtGetCar2.Rows.Count > 0)
                        {
                            if (DtGetCar2.Rows[0][6].ToString() == null || DtGetCar2.Rows[0][6].ToString() == "")
                            {                               
                                btnState(DtGetCar2.Rows[0][4].ToString(), DtGetCar2.Rows[0][6].ToString());
                            }
                            else
                            {
                                ClearData(GetArray());
                                txt_carNo.Text = DtGetCar.Rows[0][0].ToString();
                                txt_carType.Text = DtGetCar.Rows[0][1].ToString();
                                
                                txt_Customer.Text= DtGetCar.Rows[0][3].ToString();
                                txt_Department.Text= DtGetCar.Rows[0][4].ToString();
                                txt_Distenation.Text= DtGetCar.Rows[0][5].ToString();

                                List<Control> controls1 = GetArray();
                                controls1.Add(txt_Searching);
                                CLS.CLS_CarMoveUser insertData = new CLS.CLS_CarMoveUser();
                                DataTable DtmaxID = insertData.GetMovementID();
                                txt_IDMovements.Text = DtmaxID.Rows[0][0].ToString();
                               
                                //insertData.insertData(controls1);
                                btnState(null, null);
                            }
                        }
                        else
                        {
                            ClearData(GetArray());
                            txt_carNo.Text = DtGetCar.Rows[0][0].ToString();
                            txt_carType.Text = DtGetCar.Rows[0][1].ToString();
                           
                            txt_Customer.Text = DtGetCar.Rows[0][3].ToString();
                            txt_Department.Text = DtGetCar.Rows[0][4].ToString();
                            txt_Distenation.Text = DtGetCar.Rows[0][5].ToString();

                            List<Control> controls1 = GetArray();
                            controls1.Add(txt_Searching);
                            CLS.CLS_CarMoveUser insertData = new CLS.CLS_CarMoveUser();
                            DataTable DtmaxID = insertData.GetMovementID();
                            txt_IDMovements.Text = DtmaxID.Rows[0][0].ToString();
                          //  insertData.insertData(controls1);
                            btnState(null, null);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

     

        private void txt_driverbarcode2_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
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
                    txt_timein.Text = DateTime.Now.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US"));
                    
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txt_driverbarcode1_KeyDown(object sender, KeyEventArgs e)
        {
            try { 
            if (e.KeyCode == Keys.Enter)
            {
                CLS.CLS_DRIVERS DriverName = new CLS.CLS_DRIVERS();
                DataTable dtdrivername = DriverName.GettingData_bybarcode(GetDriverName1());
                if (dtdrivername.Rows.Count == 0)
                {                 txt_driver1.Text = "";
                    MessageBox.Show("هذا السائق غير موجود في النظام");
                }
                else
                {
                    txt_driver1.Text = dtdrivername.Rows[0][1].ToString();
                    txt_driverbarcode1.Text = "";
                    txt_register1.Text = Properties.Settings.Default.UserName;
                    txt_timeout.Text = DateTime.Now.ToString(@"yyyy/MM/dd hh:mm:ss tt", new CultureInfo("en-US"));
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            //try {
                if (txt_driverbarcode2.Visible == true)
                {
                    if (txt_timein.Text != null && txt_timein.Text != "" && txt_driver2.Text != null && txt_driver2.Text != "")
                    {
                        if (txt_Searching.Text != null && txt_Searching.Text != "")
                        {
                            List<Control> controls = GetArrayUpdate();
                            controls.Add(txt_Searching);

                            CLS.CLS_CarMoveUser UpdataData = new CLS.CLS_CarMoveUser();
                            UpdataData.updateData(controls);
                            ClearData(GetArray());
                            txt_Searching.Text = null;
                            btnState(null, null);
                            txt_Searching.Focus();
                        }
                        else
                        {
                            MessageBox.Show("ادخل باركود العجلة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ادخل باركود السائق");
                    }
                }
                else if (txt_driverbarcode1.Visible == true)
                {
                    if (txt_timeout.Text != null && txt_timeout.Text != "" && txt_driver1.Text != null && txt_driver1.Text != "")
                    {
                        if (txt_Searching.Text != null && txt_Searching.Text != "")
                        {
                            List<Control> controls1 = GetArray();
                            controls1.Add(txt_Searching);
                            CLS.CLS_CarMoveUser insertData = new CLS.CLS_CarMoveUser();
                            DataTable DtmaxID = insertData.GetMovementID();
                            txt_IDMovements.Text = DtmaxID.Rows[0][0].ToString();

                            CLS.CLS_CarMoveUser UpdataData = new CLS.CLS_CarMoveUser();
                            UpdataData.insertData(controls1);
                            ClearData(GetArray());
                            txt_Searching.Text = null;
                            btnState(null, null);
                            txt_Searching.Focus();
                        }
                        else
                        {
                            MessageBox.Show("ادخل باركود العجلة");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ادخل باركود السائق");
                    }
                }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnState(string timeout , string timein)
        {
            if (timeout == null || timeout == "")
            {
               
                
                txt_register1.Text = Properties.Settings.Default.UserName;

                txt_timeout.Visible = true;
                txt_driver1.Visible = true;
                txt_driverbarcode1.Visible = true;
                txt_register1.Visible = true;
                lbl_TimeOut.Visible = true;
                lbl_driver1.Visible = true;
                lbl_DriverBarcode1.Visible = true;
                btn_DelDriverBarcode1.Visible = true;
                txt_timeout.Text = null;
                txt_driver1.Text = null;

                txt_driver2.Visible = false;
                txt_driverbarcode2.Visible = false;
                txt_register2.Visible = false;
                lbl_Driver2.Visible = false;
                lbl_DriverBarcode2.Visible = false;
                lbl_TimeIn.Visible = false;
                txt_timein.Visible = false;
                btn_DelDriverBarcode2.Visible = false;

                txt_driverbarcode1.Focus();
            }
            else if (timein == null || timein == "")
            {
                txt_driverbarcode2.Focus();
                
                txt_register2.Text = Properties.Settings.Default.UserName;

                txt_timeout.Visible = false;
                txt_driver1.Visible = false;
                txt_driverbarcode1.Visible = false;
                txt_register1.Visible = false;
                lbl_TimeOut.Visible = false;
                lbl_driver1.Visible = false;
                lbl_DriverBarcode1.Visible = false;
                btn_DelDriverBarcode1.Visible = false;

                txt_driver2.Visible = true;
                txt_driverbarcode2.Visible = true;
                txt_register2.Visible = true;
                lbl_Driver2.Visible = true;
                lbl_DriverBarcode2.Visible = true;
                lbl_TimeIn.Visible = true;
                txt_timein.Visible = true;
                btn_DelDriverBarcode2.Visible = true;

                txt_driverbarcode2.Focus();
            }
        }

        private void num_MoveCount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Btn_InsertMoveCount_Click(object sender, EventArgs e)
        {
            update = true;
            FRM_EntryNumber f = new FRM_EntryNumber(txt_MoveCount);
            f.ShowDialog();           
        }

        private void btnexitapplication_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TheType_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Customer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Department_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Distenation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_TypeWater_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_MoveCount_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        //public void updatedata()
        //{
        //    try { 
        //    if (update == true)
        //    {
        //        List<Control> controls = GetArray();
        //        controls.Add(txt_Searching);

        //        CLS.CLS_CarMoveUser UpdataData = new CLS.CLS_CarMoveUser();
        //        UpdataData.updateData(controls);
        //        update = false;
        //    }
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //}

        private void txt_carType_TextChanged(object sender, EventArgs e)
        {
            if (txt_carType.Text == "تنكر" || txt_carType.Text == "ساحبة")
            {
                lb_typewater.Visible = true;
                txt_TypeWater.Visible = true;
                Btn_InsertWaterType.Visible = true;
                Btn_DelWaterType.Visible = true;

                lb_countwater.Visible = true;
                txt_MoveCount.Visible = true;
                Btn_InsertMoveCount.Visible = true;
                Btn_DelMoveCount.Visible = true;
            }
            else
            {
                lb_typewater.Visible = false;
                txt_TypeWater.Visible = false;
                Btn_InsertWaterType.Visible = false;
                Btn_DelWaterType.Visible = false;

                lb_countwater.Visible = false;
                txt_MoveCount.Visible = false;
                Btn_InsertMoveCount.Visible = false;
                Btn_DelMoveCount.Visible = false;
            }
        }

        private void txt_driverbarcode1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            txt_TheType.Text = null;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            txt_Customer.Text = null;
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            txt_Department.Text = null;
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            txt_Distenation.Text = null;
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            txt_TypeWater.Text = null;
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            txt_MoveCount.Text = null;
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            txt_Searching.Text = null;
            txt_Searching.Focus();
        }

        private void btn_DelDriverBarcode1_Click(object sender, EventArgs e)
        {
            txt_driverbarcode1.Text = null;
            txt_driverbarcode1.Focus();
        }

        private void btn_DelDriverBarcode2_Click(object sender, EventArgs e)
        {
            txt_driverbarcode2.Text = null;
            txt_driverbarcode1.Focus();
        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
