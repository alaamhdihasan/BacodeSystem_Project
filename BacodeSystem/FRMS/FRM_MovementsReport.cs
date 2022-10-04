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
    public partial class FRM_MovementsReport : Form
    {
        public FRM_MovementsReport()
        {
            InitializeComponent();
        }

        private void cbo_reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbo_reportType.Text)
            {
                case "بين تاريخين":
                case "بين تاريخين(اقسام)":
                    lbl1.Visible = false;
                    lbl2.Visible = false;

                    cbo_input2.Visible = false;
                    cbo_input1.Visible = false;
                    break;
                case "رقم العجلة بين تاريخين":
                case "رقم العجلة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "رقم العجلة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS No = new CLS.CLS_CARS();
                    No.CarNo(cbo_input1);
                    break;
                case "نوع العجلة بين تاريخين":
                case "نوع العجلة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "نوع العجلة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_CARS type = new CLS.CLS_CARS();
                    type.CarTypes(cbo_input1);
                    break;
                case "اسم سائق بين تاريخين":
                case "اسم سائق بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "اسم السائق";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DRIVERS driver = new CLS.CLS_DRIVERS();
                    driver.GetDriverName(cbo_input1);
                    break;
                case "جهة مقصودة بين تاريخين":
                case "جهة مقصودة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "الجهة المقصودة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DISTENATION place = new CLS.CLS_DISTENATION();
                    place.GetPlaces(cbo_input1);
                    break;
                case "جهة مستفيدة بين تاريخين":
                case "جهة مستفيدة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "الجهة المستفيدة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
                    dept.GetDepartments(cbo_input1);
                    break;
                case "حالة بين تاريخين":
                case "حالة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl1.Text = "الحالة";
                    lbl2.Visible = false;

                    cbo_input1.Visible = true;
                    cbo_input2.Visible = false;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_THETYPE thetype = new CLS.CLS_THETYPE();
                    thetype.Gettype(cbo_input1);
                    break;
                case "سائق وحالة بين تاريخين":
                case "سائق وحالة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "الحالة";
                    lbl2.Text = "اسم السائق";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_THETYPE thetype2 = new CLS.CLS_THETYPE();
                    thetype2.Gettype(cbo_input1);

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_DRIVERS driver2 = new CLS.CLS_DRIVERS();
                    driver2.GetDriverName(cbo_input2);
                    break;

                case "حالة وجهة مستفيدة بين تاريخين":
                case "حالة وجهة مستفيدة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "الحالة";
                    lbl2.Text = "الجهة المستفيدة";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_THETYPE thetype3 = new CLS.CLS_THETYPE();
                    thetype3.Gettype(cbo_input1);

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_DEPARTMENTS dept2 = new CLS.CLS_DEPARTMENTS();
                    dept2.GetDepartments(cbo_input2);
                    break;
                case "حالة وجهة مقصودة بين تاريخين":
                case "حالة وجهة مقصودة بين تاريخين(اقسام)":
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl1.Text = "الحالة";
                    lbl2.Text = "الجهة المقصودة";

                    cbo_input2.Visible = true;
                    cbo_input1.Visible = true;

                    cbo_input1.Properties.Items.Clear();
                    CLS.CLS_THETYPE thetype4 = new CLS.CLS_THETYPE();
                    thetype4.Gettype(cbo_input1);

                    cbo_input2.Properties.Items.Clear();
                    CLS.CLS_DISTENATION place2 = new CLS.CLS_DISTENATION();
                    place2.GetPlaces(cbo_input2);
                    break;
                case "خلاصة حسب الجهات المستفيدة":
                case "خلاصة حسب الجهات المستفيدة(اقسام)":
                    lbl1.Visible =false;
                    lbl2.Visible = false;
                  
                    cbo_input2.Visible = false;
                    cbo_input1.Visible = false;
                    break;
                case "خلاصة حسب الجهات المقصودة":
                case "خلاصة حسب الجهات المقصودة(اقسام)":
                    lbl1.Visible = false;
                    lbl2.Visible = false;

                    cbo_input2.Visible = false;
                    cbo_input1.Visible = false;
                    break;
                case "خلاصة حسب الحالة":
                case "خلاصة حسب الحالة(اقسام)":
                    lbl1.Visible = false;
                    lbl2.Visible = false;

                    cbo_input2.Visible = false;
                    cbo_input1.Visible = false;
                    break;
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //try
            //{
                CLS.CLS_RPCARMOVEMENT rept = new CLS.CLS_RPCARMOVEMENT();
                string StoredName = null;
                DataTable dt;
                switch (cbo_reportType.Text)
                {
                    case "بين تاريخين":
                        StoredName = "RPCM_BetweenTwoDates";
                        List<Control> controls1 = new List<Control>();
                        controls1.Add(dte_From);
                        controls1.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls1);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "رقم العجلة بين تاريخين":
                        StoredName = "RPCM_CarNOBetweenTwoDates";
                        List<Control> controls2 = new List<Control>();
                        controls2.Add(cbo_input1);
                        controls2.Add(dte_From);
                        controls2.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls2);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "نوع العجلة بين تاريخين":
                        StoredName = "RPCM_CarTypeBetweenTwoDates";
                        List<Control> controls3 = new List<Control>();
                        controls3.Add(cbo_input1);
                        controls3.Add(dte_From);
                        controls3.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls3);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "اسم سائق بين تاريخين":
                        StoredName = "RPCM_DriveNameBetweenTwoDates";
                        List<Control> controls4 = new List<Control>();
                        controls4.Add(cbo_input1);
                        controls4.Add(dte_From);
                        controls4.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls4);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "جهة مقصودة بين تاريخين":
                        StoredName = "RPCM_DistenationBetweenTwoDates";
                        List<Control> controls5 = new List<Control>();
                        controls5.Add(cbo_input1);
                        controls5.Add(dte_From);
                        controls5.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls5);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "جهة مستفيدة بين تاريخين":
                        StoredName = "RPCM_TheBeneficiaryBetweenTwoDates";
                        List<Control> controls6 = new List<Control>();
                        controls6.Add(cbo_input1);
                        controls6.Add(dte_From);
                        controls6.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls6);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حالة بين تاريخين":
                        StoredName = "RPCM_TheTypeBetweenTwoDates";
                        List<Control> controls7 = new List<Control>();
                        controls7.Add(cbo_input1);
                        controls7.Add(dte_From);
                        controls7.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls7);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "سائق وحالة بين تاريخين":
                        StoredName = "RPCM_TheTypeAndDriverNameBetweenTwoDates";
                        List<Control> controls8 = new List<Control>();
                        controls8.Add(cbo_input1);
                        controls8.Add(cbo_input2);
                        controls8.Add(dte_From);
                        controls8.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls8);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حالة وجهة مستفيدة بين تاريخين":
                        StoredName = "RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates";
                        List<Control> controls9 = new List<Control>();
                        controls9.Add(cbo_input1);
                        controls9.Add(cbo_input2);
                        controls9.Add(dte_From);
                        controls9.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls9);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "حالة وجهة مقصودة بين تاريخين":
                        StoredName = "RPCM_DistenationAndTheTypeBetweenTwoDates";
                        List<Control> controls10 = new List<Control>();
                        controls10.Add(cbo_input1);
                        controls10.Add(cbo_input2);
                        controls10.Add(dte_From);
                        controls10.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls10);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الجهات المستفيدة":
                        StoredName = "RPCM_SummryByTheBeneficiaryBetweenTwoDates";
                        List<Control> controls11 = new List<Control>();
                        controls11.Add(dte_From);
                        controls11.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls11);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الجهات المقصودة":
                        StoredName = "RPCM_SummryByDistenationBetweenTwoDates";
                        List<Control> controls12 = new List<Control>();
                        controls12.Add(dte_From);
                        controls12.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls12);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الحالة":
                        StoredName = "RPCM_SummryByTheTypeBetweenTwoDates";
                        List<Control> controls13 = new List<Control>();
                        controls13.Add(dte_From);
                        controls13.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls13);
                        rept.DGVdesign(DGV_Report, dt, StoredName);
                        break;
                case "خلاصة الحوضيات":
                    StoredName = "RPCM_SummryByTypeWaterBetweenTwoDates";
                    List<Control> controlsWater = new List<Control>();
                    controlsWater.Add(dte_From);
                    controlsWater.Add(dte_To);
                    dt = rept.GET_RPCM_(StoredName, controlsWater);
                    rept.DGVdesign(DGV_Report, dt, StoredName);
                    break;
                /////////////////////////////////////////////////////////////
                case "بين تاريخين(اقسام)":
                        StoredName = "RPCMother_BetweenTwoDates";
                        List<Control> controlsDept1 = new List<Control>();
                        controlsDept1.Add(dte_From);
                        controlsDept1.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept1);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "رقم العجلة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_CarNOBetweenTwoDates";
                        List<Control> controlsDept2 = new List<Control>();
                        controlsDept2.Add(cbo_input1);
                        controlsDept2.Add(dte_From);
                        controlsDept2.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept2);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "نوع العجلة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_CarTypeBetweenTwoDates";
                        List<Control> controlsDept3 = new List<Control>();
                        controlsDept3.Add(cbo_input1);
                        controlsDept3.Add(dte_From);
                        controlsDept3.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept3);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "اسم سائق بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DriveNameBetweenTwoDates";
                        List<Control> controlsDept4 = new List<Control>();
                        controlsDept4.Add(cbo_input1);
                        controlsDept4.Add(dte_From);
                        controlsDept4.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept4);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "جهة مقصودة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DistenationBetweenTwoDates";
                        List<Control> controlsDept5 = new List<Control>();
                        controlsDept5.Add(cbo_input1);
                        controlsDept5.Add(dte_From);
                        controlsDept5.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept5);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "جهة مستفيدة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheBeneficiaryBetweenTwoDates";
                        List<Control> controlsDept6 = new List<Control>();
                        controlsDept6.Add(cbo_input1);
                        controlsDept6.Add(dte_From);
                        controlsDept6.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept6);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "حالة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheTypeBetweenTwoDates";
                        List<Control> controlsDept7 = new List<Control>();
                        controlsDept7.Add(cbo_input1);
                        controlsDept7.Add(dte_From);
                        controlsDept7.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept7);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "سائق وحالة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheTypeAndDriverNameBetweenTwoDates";
                        List<Control> controlsDept8 = new List<Control>();
                        controlsDept8.Add(cbo_input1);
                        controlsDept8.Add(cbo_input2);
                        controlsDept8.Add(dte_From);
                        controlsDept8.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept8);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "حالة وجهة مستفيدة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheBeneficiaryAndTheTypeBetweenTwoDates";
                        List<Control> controlsDept9 = new List<Control>();
                        controlsDept9.Add(cbo_input1);
                        controlsDept9.Add(cbo_input2);
                        controlsDept9.Add(dte_From);
                        controlsDept9.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept9);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "حالة وجهة مقصودة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DistenationAndTheTypeBetweenTwoDates";
                        List<Control> controlsDept10 = new List<Control>();
                        controlsDept10.Add(cbo_input1);
                        controlsDept10.Add(cbo_input2);
                        controlsDept10.Add(dte_From);
                        controlsDept10.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept10);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الجهات المستفيدة(اقسام)":
                        StoredName = "RPCMOther_SummryByTheBeneficiaryBetweenTwoDates";
                        List<Control> controlsDept11 = new List<Control>();
                        controlsDept11.Add(dte_From);
                        controlsDept11.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept11);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الجهات المقصودة(اقسام)":
                        StoredName = "RPCMOther_SummryByDistenationBetweenTwoDates";
                        List<Control> controlsDept12 = new List<Control>();
                        controlsDept12.Add(dte_From);
                        controlsDept12.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept12);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                    case "خلاصة حسب الحالة(اقسام)":
                        StoredName = "RPCMOther_SummryByTheTypeBetweenTwoDates";
                        List<Control> controlsDept13 = new List<Control>();
                        controlsDept13.Add(dte_From);
                        controlsDept13.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept13);
                        rept.DGVdesignDept(DGV_Report, dt, StoredName);
                        break;
                }
            //}
            //catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                DS.DSCars dss = new DS.DSCars();
                CLS.CLS_RPCARMOVEMENT rept = new CLS.CLS_RPCARMOVEMENT();
                string StoredName = null, RpType = null;
                DataTable dt = null;
                string datamember = null;
                string[] col = null;
                int[] colsize = null;
                string[] data = null;
                bool type=false;
                int count = 0;
                switch (cbo_reportType.Text)
                {
                    case "بين تاريخين":
                        StoredName = "RPCM_BetweenTwoDates";
                        List<Control> controls1 = new List<Control>();
                        controls1.Add(dte_From);
                        controls1.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls1);
                        dss.Tables["RPCM_BetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_BetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12]);
                        }

                        datamember = "RPCM_BetweenTwoDates";

                        int[] colsize1 = { 30, 70, 70, 110, 100, 110, 100, 70, 90, 100, 90, 70, 60 };
                        string[] data1 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col1 = rept.getnamear(data1);
                        col = col1; colsize = colsize1; data = data1;
                        RpType = "تقرير حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "رقم العجلة بين تاريخين":
                        StoredName = "RPCM_CarNOBetweenTwoDates";
                        List<Control> controls2 = new List<Control>();
                        controls2.Add(cbo_input1);
                        controls2.Add(dte_From);
                        controls2.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls2);
                        dss.Tables["RPCM_CarNOBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_CarNOBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_CarNOBetweenTwoDates";

                        int[] colsize2 = { 30, 70, 115, 110, 115, 110, 50, 100, 110, 100, 70, 93, 60 };
                        string[] data2 = { "[id]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col2 = rept.getnamear(data2);
                        col = col2; colsize = colsize2; data = data2;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nرقم العجلة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "نوع العجلة بين تاريخين":
                        StoredName = "RPCM_CarTypeBetweenTwoDates";
                        List<Control> controls3 = new List<Control>();
                        controls3.Add(cbo_input1);
                        controls3.Add(dte_From);
                        controls3.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls3);
                        dss.Tables["RPCM_CarTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_CarTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3] 
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_CarTypeBetweenTwoDates";

                        int[] colsize3 = { 30, 70, 115, 110, 115, 110, 50, 100, 110, 100, 70, 93, 60 };
                        string[] data3 = { "[id]", "[CarNO]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col3 = rept.getnamear(data3);
                        col = col3; colsize = colsize3; data = data3;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nنوع العجلة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "اسم سائق بين تاريخين":
                        StoredName = "RPCM_DriveNameBetweenTwoDates";
                        List<Control> controls4 = new List<Control>();
                        controls4.Add(cbo_input1);
                        controls4.Add(dte_From);
                        controls4.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls4);
                        dss.Tables["RPCM_DriveNameBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DriveNameBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12]);
                        }

                        datamember = "RPCM_DriveNameBetweenTwoDates";

                        int[] colsize4 = { 30, 70, 70, 110, 100, 110, 100, 70, 90, 100, 90, 70, 60 };
                        string[] data4 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col4 = rept.getnamear(data4);
                        col = col4; colsize = colsize4; data = data4;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nاسم السائق: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;

                        break;
                    case "جهة مقصودة بين تاريخين":
                        StoredName = "RPCM_DistenationBetweenTwoDates";
                        List<Control> controls5 = new List<Control>();
                        controls5.Add(cbo_input1);
                        controls5.Add(dte_From);
                        controls5.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls5);
                        dss.Tables["RPCM_DistenationBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DistenationBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_DistenationBetweenTwoDates";

                        int[] colsize5 = { 30, 70, 100, 115, 110, 115, 110, 50, 110, 100, 70, 93, 60 };
                        string[] data5 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col5 = rept.getnamear(data5);
                        col = col5; colsize = colsize5; data = data5;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالجهة المقصودة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "جهة مستفيدة بين تاريخين":
                        StoredName = "RPCM_TheBeneficiaryBetweenTwoDates";
                        List<Control> controls6 = new List<Control>();
                        controls6.Add(cbo_input1);
                        controls6.Add(dte_From);
                        controls6.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls6);
                        dss.Tables["RPCM_TheBeneficiaryBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheBeneficiaryBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheBeneficiaryBetweenTwoDates";

                        int[] colsize6 = { 30, 70, 100, 115, 110, 115, 110, 50, 110, 100, 70, 93, 60 };
                        string[] data6 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[Distenation]",  "[TransCount]", "[TypeWater]","[Notice]" };

                        string[] col6 = rept.getnamear(data6);
                        col = col6; colsize = colsize6; data = data6;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالجهة المستفيدة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة بين تاريخين":
                        StoredName = "RPCM_TheTypeBetweenTwoDates";
                        List<Control> controls7 = new List<Control>();
                        controls7.Add(cbo_input1);
                        controls7.Add(dte_From);
                        controls7.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls7);
                        dss.Tables["RPCM_TheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheTypeBetweenTwoDates";

                        int[] colsize7 = { 30, 70, 100, 110, 100, 110, 100, 100, 100, 100, 70, 83, 60 };
                        string[] data7 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[CustomerName]", "[TheBeneficiary]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col7 = rept.getnamear(data7);
                        col = col7; colsize = colsize7; data = data7;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "سائق وحالة بين تاريخين":
                        StoredName = "RPCM_TheTypeAndDriverNameBetweenTwoDates";
                        List<Control> controls8 = new List<Control>();
                        controls8.Add(cbo_input1);
                        controls8.Add(cbo_input2);
                        controls8.Add(dte_From);
                        controls8.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls8);
                        dss.Tables["RPCM_TheTypeAndDriverNameBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheTypeAndDriverNameBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheTypeAndDriverNameBetweenTwoDates";

                        int[] colsize8 = { 30, 70, 100, 110, 100, 110, 100, 100, 100, 100, 70, 83, 60 };
                        string[] data8 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[CustomerName]", "[TheBeneficiary]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col8 = rept.getnamear(data8);
                        col = col8; colsize = colsize8; data = data8;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nاسم السائق: " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة وجهة مستفيدة بين تاريخين":
                        StoredName = "RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates";
                        List<Control> controls9 = new List<Control>();
                        controls9.Add(cbo_input1);
                        controls9.Add(cbo_input2);
                        controls9.Add(dte_From);
                        controls9.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls9);
                        dss.Tables["RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10]);
                        }

                        datamember = "RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates";

                        int[] colsize9 = { 30, 100, 100, 115, 110, 115, 110, 100, 100, 100, 93, 100};
                        string[] data9 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[CustomerName]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col9 = rept.getnamear(data9);
                        col = col9; colsize = colsize9; data = data9;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nالجهة المستفيدة : " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة وجهة مقصودة بين تاريخين":
                        StoredName = "RPCM_DistenationAndTheTypeBetweenTwoDates";
                        List<Control> controls10 = new List<Control>();
                        controls10.Add(cbo_input1);
                        controls10.Add(cbo_input2);
                        controls10.Add(dte_From);
                        controls10.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls10);
                        dss.Tables["RPCM_DistenationAndTheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DistenationAndTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10]);
                        }

                        datamember = "RPCM_DistenationAndTheTypeBetweenTwoDates";


                        int[] colsize10 = { 30, 100, 100, 115, 110, 115, 110, 100, 100, 100, 93, 100 };
                        string[] data10 = { "[id]", "[CarNO]", "[CarType]", "[GoingTimeDate]", "[DriverName1]",
                                           "[CommingTimeDate]", "[DriverName2]", "[CustomerName]",
                                           "[TheBeneficiary]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] col10 = rept.getnamear(data10);
                        col = col10; colsize = colsize10; data = data10;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nالجهة المقصودة : " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "خلاصة حسب الجهات المستفيدة":
                        StoredName = "RPCM_SummryByTheBeneficiaryBetweenTwoDates";
                        List<Control> controls11 = new List<Control>();
                        controls11.Add(dte_From);
                        controls11.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls11);
                        dss.Tables["RPCM_SummryByTheBeneficiaryBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByTheBeneficiaryBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByTheBeneficiaryBetweenTwoDates";
                        int[] colsize11 = { 30, 350, 350};
                        string[] data11 = { "[id]", "[TheBeneficiary]", "[cnt]" };

                        string[] col11 = rept.getnamear(data11);
                        col = col11; colsize = colsize11; data = data11;
                        RpType = "حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;    
                        break;
                    case "خلاصة حسب الجهات المقصودة":
                        StoredName = "RPCM_SummryByDistenationBetweenTwoDates";
                        List<Control> controls12 = new List<Control>();
                        controls12.Add(dte_From);
                        controls12.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls12);
                        dss.Tables["RPCM_SummryByDistenationBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByDistenationBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByDistenationBetweenTwoDates";
                        int[] colsize12 = { 30, 350, 350 };
                        string[] data12 = { "[id]", "[Distenation]", "[cnt]" };

                        string[] col12 = rept.getnamear(data12);
                        col = col12; colsize = colsize12; data = data12;
                        RpType = "حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;    
                        break;
                    case "خلاصة حسب الحالة":
                        StoredName = "RPCM_SummryByTheTypeBetweenTwoDates";
                        List<Control> controls13 = new List<Control>();
                        controls13.Add(dte_From);
                        controls13.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controls13);
                        dss.Tables["RPCM_SummryByTheTypeBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByTheTypeBetweenTwoDates";
                        int[] colsize13 = { 30, 350, 350 };
                        string[] data13 = { "[id]", "[TheType]", "[cnt]" };

                        string[] col13 = rept.getnamear(data13);
                        col = col13; colsize = colsize13; data = data13;
                        RpType = "حركة العجلات " + cbo_reportType.Text +  "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;
                        break;
                    case "خلاصة الحوضيات":
                        StoredName = "RPCM_SummryByTypeWaterBetweenTwoDates";
                        List<Control> controlsWater = new List<Control>();
                        controlsWater.Add(dte_From);
                        controlsWater.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsWater);
                        dss.Tables["RPCM_SummryByTypeWaterBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByTypeWaterBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2]);
                            count += int.Parse(dt.Rows[i][2].ToString());
                        }

                        datamember = "RPCM_SummryByTypeWaterBetweenTwoDates";
                        int[] colsizeWater = { 50, 230, 230, 230 };
                        string[] dataWater = { "[id]", "[TheBeneficiary]", "[TypeWater]", "[TransCount]" };

                        string[] colWater = rept.getnamear(dataWater);
                        col = colWater; colsize = colsizeWater; data = dataWater;
                        RpType = cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;
                        break;

                    ////////////////////////////////////////////////

                    case "بين تاريخين(اقسام)":
                        StoredName = "RPCMother_BetweenTwoDates";
                        List<Control> controlsDept1 = new List<Control>();
                        controlsDept1.Add(dte_From);
                        controlsDept1.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept1);
                        dss.Tables["RPCM_BetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_BetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12]);
                        }

                        datamember = "RPCM_BetweenTwoDates";

                        int[] colsizeDept1 = { 30, 70, 70, 110, 100, 110, 100, 70, 90, 100, 90, 70, 60 };
                        string[] dataDept1 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept1 = rept.getnamearDept(dataDept1);
                        col = colDept1; colsize = colsizeDept1; data = dataDept1;
                        RpType = "تقرير حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "رقم العجلة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_CarNOBetweenTwoDates";
                        List<Control> controlsDept2 = new List<Control>();
                        controlsDept2.Add(cbo_input1);
                        controlsDept2.Add(dte_From);
                        controlsDept2.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept2);
                        dss.Tables["RPCM_CarNOBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_CarNOBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_CarNOBetweenTwoDates";

                        int[] colsizeDept2 = { 30, 70, 115, 110, 115, 110, 50, 100, 110, 100, 70, 93, 60 };
                        string[] dataDept2 = { "[id]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept2 = rept.getnamearDept(dataDept2);
                        col = colDept2; colsize = colsizeDept2; data = dataDept2;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nرقم العجلة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "نوع العجلة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_CarTypeBetweenTwoDates";
                        List<Control> controlsDept3 = new List<Control>();
                        controlsDept3.Add(cbo_input1);
                        controlsDept3.Add(dte_From);
                        controlsDept3.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept3);
                        dss.Tables["RPCM_CarTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_CarTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_CarTypeBetweenTwoDates";

                        int[] colsizeDept3 = { 30, 70, 115, 110, 115, 110, 50, 100, 110, 100, 70, 93, 60 };
                        string[] dataDept3 = { "[id]", "[CarNO]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept3 = rept.getnamearDept(dataDept3);
                        col = colDept3; colsize = colsizeDept3; data = dataDept3;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nنوع العجلة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "اسم سائق بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DriveNameBetweenTwoDates";
                        List<Control> controlsDept4 = new List<Control>();
                        controlsDept4.Add(cbo_input1);
                        controlsDept4.Add(dte_From);
                        controlsDept4.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept4);
                        dss.Tables["RPCM_DriveNameBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DriveNameBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12]);
                        }

                        datamember = "RPCM_DriveNameBetweenTwoDates";

                        int[] colsizeDept4 = { 30, 70, 70, 110, 100, 110, 100, 70, 90, 100, 90, 70, 60 };
                        string[] dataDept4 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept4 = rept.getnamearDept(dataDept4);
                        col = colDept4; colsize = colsizeDept4; data = dataDept4;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nاسم السائق: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;

                        break;
                    case "جهة مقصودة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DistenationBetweenTwoDates";
                        List<Control> controlsDept5 = new List<Control>();
                        controlsDept5.Add(cbo_input1);
                        controlsDept5.Add(dte_From);
                        controlsDept5.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept5);
                        dss.Tables["RPCM_DistenationBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DistenationBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_DistenationBetweenTwoDates";

                        int[] colsizeDept5 = { 30, 70, 100, 115, 110, 115, 110, 50, 110, 100, 70, 93, 60 };
                        string[] dataDept5 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[TheBeneficiary]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept5 = rept.getnamearDept(dataDept5);
                        col = colDept5; colsize = colsizeDept5; data = dataDept5;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالجهة المقصودة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "جهة مستفيدة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheBeneficiaryBetweenTwoDates";
                        List<Control> controlsDept6 = new List<Control>();
                        controlsDept6.Add(cbo_input1);
                        controlsDept6.Add(dte_From);
                        controlsDept6.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept6);
                        dss.Tables["RPCM_TheBeneficiaryBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheBeneficiaryBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheBeneficiaryBetweenTwoDates";

                        int[] colsizeDept6 = { 30, 70, 100, 115, 110, 115, 110, 50, 110, 100, 70, 93, 60 };
                        string[] dataDept6 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[TheType]", "[CustomerName]",
                                           "[Distenation]",  "[TransCount]", "[TypeWater]","[Notice]" };

                        string[] colDept6 = rept.getnamearDept(dataDept6);
                        col = colDept6; colsize = colsizeDept6; data = dataDept6;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالجهة المستفيدة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheTypeBetweenTwoDates";
                        List<Control> controlsDept7 = new List<Control>();
                        controlsDept7.Add(cbo_input1);
                        controlsDept7.Add(dte_From);
                        controlsDept7.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept7);
                        dss.Tables["RPCM_TheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheTypeBetweenTwoDates";

                        int[] colsizeDept7 = { 30, 70, 100, 110, 100, 110, 100, 100, 100, 100, 70, 83, 60 };
                        string[] dataDept7 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[CustomerName]", "[TheBeneficiary]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept7 = rept.getnamearDept(dataDept7);
                        col = colDept7; colsize = colsizeDept7; data = dataDept7;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "سائق وحالة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheTypeAndDriverNameBetweenTwoDates";
                        List<Control> controlsDept8 = new List<Control>();
                        controlsDept8.Add(cbo_input1);
                        controlsDept8.Add(cbo_input2);
                        controlsDept8.Add(dte_From);
                        controlsDept8.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept8);
                        dss.Tables["RPCM_TheTypeAndDriverNameBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheTypeAndDriverNameBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11]);
                        }

                        datamember = "RPCM_TheTypeAndDriverNameBetweenTwoDates";

                        int[] colsizeDept8 = { 30, 70, 100, 110, 100, 110, 100, 100, 100, 100, 70, 83, 60 };
                        string[] dataDept8 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[CustomerName]", "[TheBeneficiary]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept8 = rept.getnamearDept(dataDept8);
                        col = colDept8; colsize = colsizeDept8; data = dataDept8;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nاسم السائق: " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة وجهة مستفيدة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_TheBeneficiaryAndTheTypeBetweenTwoDates";
                        List<Control> controlsDept9 = new List<Control>();
                        controlsDept9.Add(cbo_input1);
                        controlsDept9.Add(cbo_input2);
                        controlsDept9.Add(dte_From);
                        controlsDept9.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept9);
                        dss.Tables["RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10]);
                        }

                        datamember = "RPCM_TheBeneficiaryAndTheTypeBetweenTwoDates";

                        int[] colsizeDept9 = { 30, 100, 100, 115, 110, 115, 110, 100, 100, 100, 93, 100 };
                        string[] dataDept9 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[CustomerName]",
                                           "[Distenation]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept9 = rept.getnamearDept(dataDept9);
                        col = colDept9; colsize = colsizeDept9; data = dataDept9;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nالجهة المستفيدة : " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "حالة وجهة مقصودة بين تاريخين(اقسام)":
                        StoredName = "RPCMOther_DistenationAndTheTypeBetweenTwoDates";
                        List<Control> controlsDept10 = new List<Control>();
                        controlsDept10.Add(cbo_input1);
                        controlsDept10.Add(cbo_input2);
                        controlsDept10.Add(dte_From);
                        controlsDept10.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept10);
                        dss.Tables["RPCM_DistenationAndTheTypeBetweenTwoDates"].Clear();

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_DistenationAndTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3]
                                , dt.Rows[i][4], dt.Rows[i][5], dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10]);
                        }

                        datamember = "RPCM_DistenationAndTheTypeBetweenTwoDates";


                        int[] colsizeDept10 = { 30, 100, 100, 115, 110, 115, 110, 100, 100, 100, 93, 100 };
                        string[] dataDept10 = { "[id]", "[CarNO]", "[CarType]", "[CommingTimeDate]", "[DriverName1]",
                                           "[GoingTimeDate]", "[DriverName2]", "[CustomerName]",
                                           "[TheBeneficiary]", "[TransCount]", "[TypeWater]", "[Notice]" };

                        string[] colDept10 = rept.getnamearDept(dataDept10);
                        col = colDept10; colsize = colsizeDept10; data = dataDept10;
                        RpType = "تقرير حركة العجلات حسب " + cbo_reportType.Text + "\r\nالحالة: " + cbo_input1.Text + "\r\nالجهة المقصودة : " + cbo_input2.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        break;
                    case "خلاصة حسب الجهات المستفيدة(اقسام)":
                        StoredName = "RPCMOther_SummryByTheBeneficiaryBetweenTwoDates";
                        List<Control> controlsDept11 = new List<Control>();
                        controlsDept11.Add(dte_From);
                        controlsDept11.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept11);
                        dss.Tables["RPCM_SummryByTheBeneficiaryBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByTheBeneficiaryBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByTheBeneficiaryBetweenTwoDates";
                        int[] colsizeDept11 = { 30, 350, 350 };
                        string[] dataDept11 = { "[id]", "[TheBeneficiary]", "[cnt]" };

                        string[] colDept11 = rept.getnamearDept(dataDept11);
                        col = colDept11; colsize = colsizeDept11; data = dataDept11;
                        RpType = "حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;
                        break;
                    case "خلاصة حسب الجهات المقصودة(اقسام)":
                        StoredName = "RPCMOther_SummryByDistenationBetweenTwoDates";
                        List<Control> controlsDept12 = new List<Control>();
                        controlsDept12.Add(dte_From);
                        controlsDept12.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept12);
                        dss.Tables["RPCM_SummryByDistenationBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByDistenationBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByDistenationBetweenTwoDates";
                        int[] colsizeDept12 = { 30, 350, 350 };
                        string[] dataDept12 = { "[id]", "[Distenation]", "[cnt]" };

                        string[] colDept12 = rept.getnamearDept(dataDept12);
                        col = colDept12; colsize = colsizeDept12; data = dataDept12;
                        RpType = "حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;
                        break;
                    case "خلاصة حسب الحالة(اقسام)":
                        StoredName = "RPCMOther_SummryByTheTypeBetweenTwoDates";
                        List<Control> controlsDept13 = new List<Control>();
                        controlsDept13.Add(dte_From);
                        controlsDept13.Add(dte_To);
                        dt = rept.GET_RPCM_(StoredName, controlsDept13);
                        dss.Tables["RPCM_SummryByTheTypeBetweenTwoDates"].Clear();
                        count = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dss.Tables["RPCM_SummryByTheTypeBetweenTwoDates"].Rows.Add(i + 1, dt.Rows[i][0], dt.Rows[i][1]);
                            count += int.Parse(dt.Rows[i][1].ToString());
                        }

                        datamember = "RPCM_SummryByTheTypeBetweenTwoDates";
                        int[] colsizeDept13 = { 30, 350, 350 };
                        string[] dataDept13 = { "[id]", "[TheType]", "[cnt]" };

                        string[] colDept13 = rept.getnamearDept(dataDept13);
                        col = colDept13; colsize = colsizeDept13; data = dataDept13;
                        RpType = "حركة العجلات " + cbo_reportType.Text + "\r\nمن: " + dte_From.Text + "\r\nالى: " + dte_To.Text;
                        type = true;
                        break;
                }

            if (type == false)
            {
                RPTS.RP_CarMovements rp = new RPTS.RP_CarMovements(datamember, col, colsize, data);

                rp.Parameters["RpType"].Value = RpType;

                rp.Parameters["Count"].Value = dt.Rows.Count;
                rp.Parameters["User"].Value = Properties.Settings.Default.UserName;
                rp.RequestParameters = false;
                rp.DataSource = dss;
                RPTS.Report frm = new RPTS.Report();
                frm.documentViewer1.DocumentSource = rp;
                frm.ShowDialog();
            }
            if(type == true)
            {
                RPTS.RP_Cars rp = new RPTS.RP_Cars(datamember, col, colsize, data);

                rp.Parameters["RpType"].Value = RpType;

                rp.Parameters["count"].Value = count;
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
