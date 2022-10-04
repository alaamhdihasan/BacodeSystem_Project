using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BacodeSystem.FRMS
{
    public partial class FRM_CarReport : Form
    {
        public FRM_CarReport()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_reportType.Text)
            {
                case "حسب نوع العجلة":
                    lbl1.Visible = true;
                    lbl1.Text = "نوع العجلة";
                    lbl2.Visible = false;
                    
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS type = new CLS.CLS_CARS();
                    type.CarTypes(cbo_input1);
                    break;
                case "حسب الشركة المصنعة":
                    lbl1.Visible = true;
                    lbl1.Text = "الشركة المصنعة";
                    lbl2.Visible = false;
                    
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS brand = new CLS.CLS_CARS();
                    brand.CarBrands(cbo_input1);
                    break;
                case "حسب الحالة":
                    lbl1.Visible = true;
                    lbl1.Text = "حالة العجلة";
                    lbl2.Visible = false;
                   
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    string[] s = { "جيدة", "متوسطة", "رديئة" };

                    for(int i=0; i < s.Length; i++)
                    {
                        cbo_input1.Properties.Items.Add(s[i]);
                    }
                    break;
                case "حسب العائدية":
                    lbl1.Visible = true;
                    lbl1.Text = "عائدية العجلة";
                    lbl2.Visible = false;
                    
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
                    dept.GetDepartments(cbo_input1);
                    break;
                case "حسب نوع الوقود":
                    lbl1.Visible = true;
                   
                    lbl1.Text = "نوع الوقود";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;
                   
                    cbo_input1.Properties.Items.Clear();
                    string[] s1 = { "بنزين", "كاز" };

                    for (int i = 0; i < s1.Length; i++)
                    {
                        cbo_input1.Properties.Items.Add(s1[i]);
                    }
                
                    break;
                case "حسب الموديل":
                    lbl1.Visible = true;
                   
                    lbl1.Text = "موديل العجلة";
                    lbl2.Visible = false;
                    
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;
                    cbo_input1.Properties.Items.Clear();
                    break;
                case "حسب قياس الاطارات":
                    lbl1.Visible = true;
                    
                    lbl1.Text = "قياس الاطار";
                    lbl2.Visible = false;
                    
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;
                    cbo_input1.Properties.Items.Clear();
                    break;
                case "حسب الشركة المصنعة والموديل":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "الشركة المصنعة";
                    lbl2.Text = "موديل العجلة";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS brand1 = new CLS.CLS_CARS();
                    brand1.CarBrands(cbo_input1);
                    break;
                case "حسب نوع العجلة والموديل":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "نوع العجلة";
                    lbl2.Text = "موديل العجلة";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS type1 = new CLS.CLS_CARS();
                    type1.CarTypes(cbo_input1);
                    break;
                case "حسب الحالة والموديل":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "حالة العجلة";
                    lbl2.Text = "موديل العجلة";

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = true;
                    
                    cbo_input1.Properties.Items.Clear();
                    string[] s2 = { "جيدة", "متوسطة", "رديئة" };

                    for (int i = 0; i < s2.Length; i++)
                    {
                        cbo_input1.Properties.Items.Add(s2[i]);
                    }
                    break;
                case "حسب نوع العجلة والعائدية":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "نوع العجلة";
                    lbl2.Text = "عائدية العجلة";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS type2 = new CLS.CLS_CARS();
                    type2.CarTypes(cbo_input1);

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept1 = new CLS.CLS_DEPARTMENTS();
                    dept1.GetDepartments(cbo_input2);
                    break;
                case "حسب الحالة والعائدية":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "حالة العجلة";
                    lbl2.Text = "عائدية العجلة";

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = true;
                    
                    cbo_input1.Properties.Items.Clear();
                    string[] s3 = { "جيدة", "متوسطة", "رديئة" };

                    for (int i = 0; i < s3.Length; i++)
                    {
                        cbo_input1.Properties.Items.Add(s3[i]);
                    }

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept2 = new CLS.CLS_DEPARTMENTS();
                    dept2.GetDepartments(cbo_input2);
                    break;
                case "حسب القسم والشعبة":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "القسم";
                    lbl2.Text = "الشعبة";

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = true;
                    
                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept3 = new CLS.CLS_DEPARTMENTS();
                    dept3.GetDepartments(cbo_input1);
                    cbo_input2.Properties.Items.Clear();

                    CLS.CLS_CARS div = new CLS.CLS_CARS();
                    div.Cardivision(cbo_input2);
                    break;
                case "خلاصة حسب نوع العجلة":
                    lbl1.Visible = true;
                    lbl1.Text = "نوع العجلة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;   
                    
                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS type3 = new CLS.CLS_CARS();
                    type3.CarTypes(cbo_input1);
                    break;
                case "خلاصة حسب الشعبة":                    
                    lbl1.Visible = true;
                    lbl2.Visible =true;
                    lbl1.Text = "القسم";
                    lbl2.Text = "الشعبة";
                    cbo_input1.Visible = true;
                    cbo_input2.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept4 = new CLS.CLS_DEPARTMENTS();
                    dept4.GetDepartments(cbo_input1);
                    cbo_input2.Properties.Items.Clear();

                    CLS.CLS_CARS div1 = new CLS.CLS_CARS();
                    div1.Cardivision(cbo_input2);
                    break;
                case "خلاصة حسب العائدية":
                case "طباعة باركود السائقين":
                case "طباعة باركود العجلات":
                case "حوادث بين تاريخين":
                    lbl2.Visible = false;
                    lbl1.Visible = false;
                    
                    cbo_input2.Visible = false;
                    cbo_input1.Visible = false;
                    break;
                case "حوادث عجلة بين تاريخين":
                    lbl1.Visible = true;
                    lbl1.Text = "رقم العجلة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS car_no = new CLS.CLS_CARS();
                    car_no.CarNo(cbo_input1);
                    break;
                case "حوادث سائق بين تاريخين":
                    lbl1.Visible = true;
                    lbl1.Text = "اسم السائق";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DRIVERS driver_name = new CLS.CLS_DRIVERS();
                    driver_name.GetDriverName(cbo_input1);
                    break;
            }

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                CLS.CLS_CARSREPORT rept = new CLS.CLS_CARSREPORT();
                string StoredName = null;
                DataTable dt;
                switch (cbo_reportType.Text)
                {
                    case "حسب نوع العجلة":                       
                        StoredName = "RPCD_CarType";
                        List<Control> controls1 = new List<Control>();
                        controls1.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls1);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الشركة المصنعة":
                        StoredName = "RPCD_CarCo";
                        List<Control> controls2 = new List<Control>();
                        controls2.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls2);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الحالة":
                        StoredName = "RPCD_CarState";
                        List<Control> controls3 = new List<Control>();
                        controls3.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls3);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب العائدية":
                        StoredName = "RPCD_CarDep";
                        List<Control> controls4 = new List<Control>();
                        controls4.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls4);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب نوع الوقود":
                        StoredName = "RPCD_Carfuel";
                        List<Control> controls5 = new List<Control>();
                        controls5.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls5);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الموديل":
                        StoredName = "RPCD_CarModel";
                        List<Control> controls6 = new List<Control>();
                        controls6.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls6);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب قياس الاطارات":
                        StoredName = "RPCD_CarTireSize";
                        List<Control> controls7 = new List<Control>();
                        controls7.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls7);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الشركة المصنعة والموديل":
                        StoredName = "RPCD_CarCoandModel";
                        List<Control> controls8 = new List<Control>();
                        controls8.Add(cbo_input1);
                        controls8.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls8);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب نوع العجلة والموديل":
                        StoredName = "RPCD_CarTypeandModel";
                        List<Control> controls9 = new List<Control>();
                        controls9.Add(cbo_input1);
                        controls9.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls9);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الحالة والموديل":
                        StoredName = "RPCD_CarStateandModel";
                        List<Control> controls10 = new List<Control>();
                        controls10.Add(cbo_input1);
                        controls10.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls10);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب نوع العجلة والعائدية":
                        StoredName = "RPCD_CarTypeandDep";
                        List<Control> controls11 = new List<Control>();
                        controls11.Add(cbo_input1);
                        controls11.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls11);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب الحالة والعائدية":
                        StoredName = "RPCD_CarStateandDep";
                        List<Control> controls12 = new List<Control>();
                        controls12.Add(cbo_input1);
                        controls12.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls12);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حسب القسم والشعبة":
                        StoredName = "RPCD_CarDivisionandDep";
                        List<Control> controls13 = new List<Control>();
                        controls13.Add(cbo_input1);
                        controls13.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls13);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب نوع العجلة":
                        StoredName = "RPCD_SummryCarByType";
                        List<Control> controls14 = new List<Control>();
                        controls14.Add(cbo_input1);
                        
                        dt = rept.GET_RPCD_(StoredName, controls14);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الشعبة":
                        StoredName = "RPCD_SummryCarByDivision";
                        List<Control> controls15 = new List<Control>();
                        controls15.Add(cbo_input1);
                        controls15.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls15);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب العائدية":
                        StoredName = "RPCD_SummryCarByDepartment";
                        dt = rept.GET_RPCD_(StoredName);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "طباعة باركود السائقين":
                        StoredName = "Drivers_Getter";
                        dt = rept.GET_RPCD_(StoredName);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "طباعة باركود العجلات":
                        StoredName = "Cars_GetterRp";
                        dt = rept.GET_RPCD_(StoredName);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حوادث بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_BetweenTwoDates";
                        List<Control> controls16 = new List<Control>();
                        controls16.Add(Date1);
                        controls16.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls16);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حوادث عجلة بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates";
                        List<Control> controls17 = new List<Control>();
                        controls17.Add(cbo_input1);
                        controls17.Add(Date1);
                        controls17.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls17);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حوادث سائق بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates";
                        List<Control> controls18 = new List<Control>();
                        controls18.Add(cbo_input1);
                        controls18.Add(Date1);
                        controls18.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls18);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
  
            try
            {
                DS.DSCars dss = new DS.DSCars();
                CLS.CLS_CARSREPORT rept = new CLS.CLS_CARSREPORT();
                string StoredName = null, RpType=null;
                DataTable dt=null;
                string datamember=null;
                string[] col=null;
                int[] colsize=null;
                string[] data=null;
                
                switch (cbo_reportType.Text)
                {
                    case "حسب نوع العجلة":
                        StoredName = "RPCD_CarType";
                        List<Control> controls1 = new List<Control>();
                        controls1.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls1);                       

                        dss.Tables["RPCD_CarType"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarType"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarType";
                        string[] col1 = { "رقم العجلة", "الشركة المصنعة", "موديل العجلة", "عائدية العجلة" };
                        int[] colsize1 = { 30, 150, 150, 150, 260 };
                        string[] data1 = { "[id]", "[CarNO]", "[TheBrand]", "[CarModel]", "[DepartmentName]" };
                        col = col1; colsize = colsize1; data = data1;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\n نوع العجلة: " + cbo_input1.Text; ;
                        break;
                  
                    case "حسب الشركة المصنعة":
                        StoredName = "RPCD_CarCo";
                        List<Control> controls2 = new List<Control>();
                        controls2.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls2);
                        dss.Tables["RPCD_CarCo"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarCo"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarCo";
                        string[] col2 = { "رقم العجلة", "نوع العجلة", "موديل العجلة", "عائدية العجلة" };
                        int[] colsize2 = { 30, 150, 150, 150, 260 };
                        string[] data2 = { "[id]", "[CarNO]", "[CarType]", "[CarModel]", "[DepartmentName]" };
                        col = col2; colsize = colsize2; data = data2;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالشركة المصنعة: " + cbo_input1.Text; 
                        break;
                  
                    case "حسب الحالة":
                        StoredName = "RPCD_CarState";
                        List<Control> controls3 = new List<Control>();
                        controls3.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls3);
                        dss.Tables["RPCD_CarState"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarState"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                        }

                        datamember = "RPCD_CarState";
                        string[] col3 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "موديل العجلة", "عائدية العجلة" };
                        int[] colsize3 = { 30, 120, 120, 120, 120, 230 };
                        string[] data3 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[CarModel]", "[DepartmentName]" };
                        col = col3; colsize = colsize3; data = data3;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\n الحالة: " + cbo_input1.Text; 
                        break;
                  
                    case "حسب العائدية":
                        StoredName = "RPCD_CarDep";
                        List<Control> controls4 = new List<Control>();
                        controls4.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls4);
                        dss.Tables["RPCD_CarDep"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarDep"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarDep";
                        string[] col4 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "موديل العجلة" };
                        int[] colsize4 = { 30, 150, 205, 205, 150 };
                        string[] data4 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[CarModel]" };
                        col = col4; colsize = colsize4; data = data4;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nعائدية العجلة: " + cbo_input1.Text; 
                        break;
                  
                    case "حسب نوع الوقود":
                        StoredName = "RPCD_Carfuel";
                        List<Control> controls5 = new List<Control>();
                        controls5.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls5);
                        dss.Tables["RPCD_Carfuel"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_Carfuel"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                        }

                        datamember = "RPCD_Carfuel";
                        string[] col5 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "موديل العجلة", "عائدية العجلة" };
                        int[] colsize5 = { 30, 120, 120,120, 120, 230 };
                        string[] data5 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[CarModel]", "[DepartmentName]" };
                        col = col5; colsize = colsize5; data = data5;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nنوع الوقود: " + cbo_input1.Text; 
                        break;
                   
                    case "حسب الموديل":
                        StoredName = "RPCD_CarModel";
                        List<Control> controls6 = new List<Control>();
                        controls6.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls6);
                        dss.Tables["RPCD_CarModel"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarModel"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarModel";
                        string[] col6 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "عائدية العجلة" };
                        int[] colsize6 = { 30, 150, 150, 150, 260 };
                        string[] data6 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[DepartmentName]" };
                        col = col6; colsize = colsize6; data = data6;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالموديل: " + cbo_input1.Text; 
                        break;
               
                    case "حسب قياس الاطارات":
                        StoredName = "RPCD_CarTireSize";
                        List<Control> controls7 = new List<Control>();
                        controls7.Add(cbo_input1);
                        dt = rept.GET_RPCD_(StoredName, controls7);
                        dss.Tables["RPCD_CarTireSize"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarTireSize"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                        }

                        datamember = "RPCD_CarTireSize";
                        string[] col7 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "عائدية العجلة", "موديل العجلة" };
                        int[] colsize7 = { 30, 120, 120, 120, 230, 120 };
                        string[] data7 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[DepartmentName]", "[CarModel]" };
                        col = col7; colsize = colsize7; data = data7;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nقياس الاطار: " + cbo_input1.Text; 
                        break;
                 
                    case "حسب الشركة المصنعة والموديل":
                        StoredName = "RPCD_CarCoandModel";
                        List<Control> controls8 = new List<Control>();
                        controls8.Add(cbo_input1);
                        controls8.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls8);
                        dss.Tables["RPCD_CarCoandModel"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarCoandModel"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                        }

                        datamember = "RPCD_CarCoandModel";
                        string[] col8 = { "رقم العجلة", "نوع العجلة", "عائدية العجلة" };
                        int[] colsize8 = { 30, 225, 225, 260};
                        string[] data8 = { "[id]", "[CarNO]", "[CarType]", "[DepartmentName]" };
                        col = col8; colsize = colsize8; data = data8;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالشركة المصنعة: " + cbo_input1.Text + " \r\nالموديل: " + cbo_input2.Text; 
                        break;
                  
                    case "حسب نوع العجلة والموديل":
                        StoredName = "RPCD_CarTypeandModel";
                        List<Control> controls9 = new List<Control>();
                        controls9.Add(cbo_input1);
                        controls9.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls9);
                        dss.Tables["RPCD_CarTypeandModel"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarTypeandModel"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                        }

                        datamember = "RPCD_CarTypeandModel";
                        string[] col9 = { "رقم العجلة", "الشركة المصنعة", "عائدية العجلة" };
                        int[] colsize9 = { 30, 225, 225, 260 };
                        string[] data9 = { "[id]", "[CarNO]", "[TheBrand]", "[DepartmentName]" };
                        col = col9; colsize = colsize9; data = data9;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nنوع العجلة: " + cbo_input1.Text + " \r\nالموديل: " + cbo_input2.Text; 
                        break;
                   
                    case "حسب الحالة والموديل":
                        StoredName = "RPCD_CarStateandModel";
                        List<Control> controls10 = new List<Control>();
                        controls10.Add(cbo_input1);
                        controls10.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls10);
                        dss.Tables["RPCD_CarStateandModel"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarStateandModel"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarStateandModel";
                        string[] col10 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "عائدية العجلة" };
                        int[] colsize10 = { 30, 150, 150, 150, 260 };
                        string[] data10 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[DepartmentName]" };
                        col = col10; colsize = colsize10; data = data10;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + " \r\nالموديل: " + cbo_input2.Text; 
                        break;
                  
                    case "حسب نوع العجلة والعائدية":
                        StoredName = "RPCD_CarTypeandDep";
                        List<Control> controls11 = new List<Control>();
                        controls11.Add(cbo_input1);
                        controls11.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls11);
                        dss.Tables["RPCD_CarTypeandDep"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarTypeandDep"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                        }

                        datamember = "RPCD_CarTypeandDep";
                        string[] col11 = { "رقم العجلة", "نوع العجلة", "موديل العجلة"};
                        int[] colsize11 = { 30, 225, 260, 225 };
                        string[] data11 = { "[id]", "[CarNO]", "[TheBrand]", "[CarModel]" };
                        col = col11; colsize = colsize11; data = data11;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nنوع العجلة: " + cbo_input1.Text + " \r\nعائدية العجلة: " + cbo_input2.Text; 
                        break;
                 
                    case "حسب الحالة والعائدية":
                        StoredName = "RPCD_CarStateandDep";
                        List<Control> controls12 = new List<Control>();
                        controls12.Add(cbo_input1);
                        controls12.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls12);
                        dss.Tables["RPCD_CarStateandDep"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarStateandDep"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarStateandDep";
                        string[] col12 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "موديل العجلة" };
                        int[] colsize12 = { 30, 150, 150, 260, 150 };
                        string[] data12 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[CarModel]" };
                        col = col12; colsize = colsize12; data = data12;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + " \r\nعائدية العجلة: " + cbo_input2.Text; 
                        break;
                  
                    case "حسب القسم والشعبة":
                        StoredName = "RPCD_CarDivisionandDep";
                        List<Control> controls13 = new List<Control>();
                        controls13.Add(cbo_input1);
                        controls13.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls13);
                        dss.Tables["RPCD_CarDivisionandDep"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarDivisionandDep"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]);
                        }

                        datamember = "RPCD_CarDivisionandDep";
                        string[] col13 = { "رقم العجلة", "نوع العجلة", "الشركة المصنعة", "موديل العجلة" };
                        int[] colsize13 = { 30, 150, 150, 260, 150 };
                        string[] data13 = { "[id]", "[CarNO]", "[CarType]", "[TheBrand]", "[CarModel]" };
                        col = col13; colsize = colsize13; data = data13;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالقسم: " + cbo_input1.Text + "\r\nالشعبة: " + cbo_input2.Text; 
                        break;
                   
                    case "خلاصة حسب نوع العجلة":
                        StoredName = "RPCD_SummryCarByType";
                        List<Control> controls14 = new List<Control>();
                        controls14.Add(cbo_input1);

                        dt = rept.GET_RPCD_(StoredName, controls14);
                        dss.Tables["RPCD_SummryCarByType"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_SummryCarByType"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                        }

                        datamember = "RPCD_SummryCarByType";
                        string[] col14 = {  "العائدية", "العدد" };
                        int[] colsize14 = { 30, 355, 355};
                        string[] data14 = { "[id]", "[DepartmentName]", "[thecount]"};
                        col = col14; colsize = colsize14; data = data14;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nنوع العجلة: " + cbo_input1.Text; ;
                        break;
                  
                    case "خلاصة حسب الشعبة":
                        StoredName = "RPCD_SummryCarByDivision";
                        List<Control> controls15 = new List<Control>();
                        controls15.Add(cbo_input1);
                        controls15.Add(cbo_input2);
                        dt = rept.GET_RPCD_(StoredName, controls15);
                        dss.Tables["RPCD_SummryCarByDivision"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_SummryCarByDivision"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                        }

                        datamember = "RPCD_SummryCarByDivision";
                        string[] col15 = { "نوع العجلة","عائدية العجلة", "العدد" };
                        int[] colsize15 = { 30, 260, 225, 225};
                        string[] data15 = { "[id]", "[Beneficiary_Div]", "[CarType]", "[thecount]" };
                        col = col15; colsize = colsize15; data = data15;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nالقسم: " + cbo_input1.Text + "\r\nالشعبة: " + cbo_input2.Text;
                        break;
                 
                    case "خلاصة حسب العائدية":
                        StoredName = "RPCD_SummryCarByDepartment";
                        dt = rept.GET_RPCD_(StoredName);
                        dss.Tables["RPCD_SummryCarByDepartment"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_SummryCarByDepartment"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                        }

                        datamember = "RPCD_SummryCarByDepartment";
                        string[] col16 = { "عائدية العجلة", "نوع العجلة", "العدد" };
                        int[] colsize16 = { 30, 260, 225, 225 };
                        string[] data16 = { "[id]", "[DepartmentName]", "[CarType]", "[thecount]"};
                        col = col16; colsize = colsize16; data = data16;
                        RpType = "تقرير العجلات " + cbo_reportType.Text;
                        break;
                    case "طباعة باركود السائقين":
                        StoredName = "Drivers_Getter";
                        dt = rept.GET_RPCD_(StoredName);

                        RPTS.RP_Barcode rpbar = new RPTS.RP_Barcode(dt);
                        RPTS.Report frm = new RPTS.Report();
                        frm.documentViewer1.DocumentSource = rpbar;
                        frm.ShowDialog();
                        break;
                    case "طباعة باركود العجلات":
                        StoredName = "Cars_GetterRp";
                        dt = rept.GET_RPCD_(StoredName);
                      
                        RPTS.RP_Barcode rpbar1 = new RPTS.RP_Barcode(dt);
                        RPTS.Report frm1 = new RPTS.Report();
                        frm1.documentViewer1.DocumentSource = rpbar1;
                        frm1.ShowDialog();
                        break;
                    case "حوادث بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_BetweenTwoDates";
                        List<Control> controls17 = new List<Control>();
                        controls17.Add(Date1);
                        controls17.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls17);
                        dss.Tables["RPCD_CarsAccident_Getter_BetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarsAccident_Getter_BetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]).ToString("dd/MM/yyyy"), dt.Rows[i][9]);
                        }

                        datamember = "RPCD_CarsAccident_Getter_BetweenTwoDates";
                        string[] col17 = { "رقم العجلة", "نوع العجلة", "يوم الحادث", "تاريخ الحادث", "اسم السائق" };
                        int[] colsize17 = { 30, 140, 140, 140, 140, 140 };
                        string[] data17 = { "[id]", "[CarNO]", "[CarType]", "[AccidentDay]", "[AccidentDate]", "[DriverName]" };
                        col = col17; colsize = colsize17; data = data17;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nمن: " + Date1.Text + "\r\nالى: " + Date2.Text;
                        break;
                    case "حوادث عجلة بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates";
                        List<Control> controls18 = new List<Control>();
                        controls18.Add(cbo_input1);
                        controls18.Add(Date1);
                        controls18.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls18);
                        dss.Tables["RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][2], dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]).ToString("dd/MM/yyyy"), dt.Rows[i][9]);
                        }

                        datamember = "RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates";
                        string[] col18 = { "نوع العجلة", "يوم الحادث", "تاريخ الحادث", "اسم السائق" };
                        int[] colsize18 = { 30, 175, 175, 175, 175 };
                        string[] data18 = { "[id]", "[CarType]", "[AccidentDay]", "[AccidentDate]", "[DriverName]" };
                        col = col18; colsize = colsize18; data = data18;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nرقم العجلة: " + cbo_input1.Text + "\r\nمن: " + Date1.Text + "  الى: " + Date2.Text;
                        break;
                    case "حوادث سائق بين تاريخين":
                        StoredName = "RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates";
                        List<Control> controls19 = new List<Control>();
                        controls19.Add(cbo_input1);
                        controls19.Add(Date1);
                        controls19.Add(Date2);
                        dt = rept.GET_RPCD_(StoredName, controls19);
                        dss.Tables["RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]).ToString("dd/MM/yyyy"));
                        }

                        datamember = "RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates";
                        string[] col19 = { "رقم العجلة", "نوع العجلة", "يوم الحادث", "تاريخ الحادث" };
                        int[] colsize19 = { 30, 175, 175, 175, 175 };
                        string[] data19 = { "[id]", "[CarNO]", "[CarType]", "[AccidentDay]", "[AccidentDate]" };
                        col = col19; colsize = colsize19; data = data19;
                        RpType = "تقرير العجلات " + cbo_reportType.Text + "\r\nاسم السائق: " + cbo_input1.Text + "\r\nمن: " + Date1.Text + "  الى: " + Date2.Text;
                        break;
                }

                if (cbo_reportType.Text != "طباعة باركود السائقين" && cbo_reportType.Text != "طباعة باركود العجلات")
                {
                    RPTS.RP_Cars rp = new RPTS.RP_Cars(datamember, col, colsize, data);

                    rp.Parameters["RpType"].Value = RpType;

                    rp.Parameters["count"].Value = dt.Rows.Count;
                    rp.Parameters["user"].Value = Properties.Settings.Default.UserName;
                    rp.RequestParameters = false;
                    rp.DataSource = dss;
                    RPTS.Report frm = new RPTS.Report();
                    frm.documentViewer1.DocumentSource = rp;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
