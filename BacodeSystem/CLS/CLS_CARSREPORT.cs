using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.CLS
{
    class CLS_CARSREPORT
    {
        string RPCD_CarType = "RPCD_CarType";
        string RPCD_CarCo = "RPCD_CarCo";
        string RPCD_CarState = "RPCD_CarState";
        string RPCD_CarDep = "RPCD_CarDep";
        string RPCD_Carfuel = "RPCD_Carfuel";
        string RPCD_CarModel = "RPCD_CarModel";
        string RPCD_CarTireSize = "RPCD_CarTireSize";
        string RPCD_CarTypeandModel = "RPCD_CarTypeandModel";
        string RPCD_CarCoandModel = "RPCD_CarCoandModel";
        string RPCD_CarStateandModel = "RPCD_CarStateandModel";
        string RPCD_CarTypeandDep = "RPCD_CarTypeandDep";
        string RPCD_CarStateandDep = "RPCD_CarStateandDep";
        string RPCD_CarDivisionandDep = "RPCD_CarDivisionandDep";
        string RPCD_SummryCarByType = "RPCD_SummryCarByType";
        string RPCD_SummryCarByDepartment = "RPCD_SummryCarByDepartment";
        string RPCD_SummryCarByDivision = "RPCD_SummryCarByDivision";

        string CarsTable = "DivisionCars";

        public DataTable GET_RPCD_(string StoredName, List<Control> controls)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls,StoredName);

            return Dt;
        }

        public DataTable GET_RPCD_(string StoredName)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(StoredName);

            return Dt;
        }
        public void DGVdesign(GunaDataGridView DGV, DataTable data, string StoredName)
        {
            DGV.DataSource = data;

            switch (StoredName)
            {
                case "RPCD_CarType":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "الشركة المصنعة";
                    DGV.Columns[2].HeaderText = "موديل العجلة";
                    DGV.Columns[3].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarCo":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "موديل العجلة";
                    DGV.Columns[3].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarState":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";
                    DGV.Columns[4].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarDep":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";                  
                    break;
                case "RPCD_Carfuel":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";
                    DGV.Columns[4].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarModel":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";
                    break;
                case "RPCD_CarTireSize":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "عائدية العجلة";
                    DGV.Columns[4].HeaderText = "موديل العجلة";                    
                    break;
                case "RPCD_CarTypeandModel":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "الشركة المصنعة";
                    DGV.Columns[2].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarCoandModel":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarStateandModel":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "عائدية العجلة";
                    break;
                case "RPCD_CarTypeandDep":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "الشركة المصنعة";
                    DGV.Columns[2].HeaderText = "موديل العجلة";
                    break;
                case "RPCD_CarStateandDep":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";
                    break;
                case "RPCD_CarDivisionandDep":
                    DGV.Columns[0].HeaderText = "رقم العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "الشركة المصنعة";
                    DGV.Columns[3].HeaderText = "موديل العجلة";
                    break;
                case "RPCD_SummryCarByType":
                    DGV.Columns[0].HeaderText = "عائدية العجلة";
                    DGV.Columns[1].HeaderText = "العدد";
                    break;
                case "RPCD_SummryCarByDepartment":
                    DGV.Columns[0].HeaderText = "عائدية العجلة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "العدد";
                    break;
                case "RPCD_SummryCarByDivision":
                    DGV.Columns[0].HeaderText = "الشعبة";
                    DGV.Columns[1].HeaderText = "نوع العجلة";
                    DGV.Columns[2].HeaderText = "العدد";
                    break;
                case "Drivers_Getter":
                    DGV.Columns[0].Visible = false;
                    DGV.Columns[1].HeaderText = "اسم السائق";
                    DGV.Columns[2].HeaderText = "القسم";
                    DGV.Columns[3].HeaderText = "الشعبة";
                    DGV.Columns[4].Visible = false;
                    DGV.Columns[5].Visible = false;
                    break;
                case "Cars_GetterRp":                    
                    DGV.Columns[0].HeaderText = "رقم الاضبارة";
                    DGV.Columns[1].HeaderText = "رقم العجلة";
                    DGV.Columns[2].HeaderText = "نوع العجلة";
                    DGV.Columns[3].HeaderText = "الشركة المصنعة";
                    DGV.Columns[4].HeaderText = "القسم";
                    DGV.Columns[5].Visible = false;
                    break;
                case "RPCD_CarsAccident_Getter_BetweenTwoDates":
                    DGV.Columns[0].Visible = false;
                    DGV.Columns[1].HeaderText = "رقم العجلة";
                    DGV.Columns[2].HeaderText = "نوع العجلة";
                    DGV.Columns[3].HeaderText = "يوم الحادث";
                    DGV.Columns[4].HeaderText = "تاريخ الحادث";
                    DGV.Columns[5].Visible = false;
                    DGV.Columns[6].Visible = false;
                    DGV.Columns[7].Visible = false;
                    DGV.Columns[8].Visible = false;
                    DGV.Columns[9].HeaderText = "اسم السائق";
                    break;
                case "RPCD_CarsAccident_Getter_CarNo_BetweenTwoDates":
                    DGV.Columns[0].Visible = false;
                    DGV.Columns[1].Visible = false;
                    DGV.Columns[2].HeaderText = "نوع العجلة";
                    DGV.Columns[3].HeaderText = "يوم الحادث";
                    DGV.Columns[4].HeaderText = "تاريخ الحادث";
                    DGV.Columns[5].Visible = false;
                    DGV.Columns[6].Visible = false;
                    DGV.Columns[7].Visible = false;
                    DGV.Columns[8].Visible = false;
                    DGV.Columns[9].HeaderText = "اسم السائق";
                    break;
                case "RPCD_CarsAccident_Getter_DriverName_BetweenTwoDates":
                    DGV.Columns[0].Visible = false;
                    DGV.Columns[1].HeaderText = "رقم العجلة";
                    DGV.Columns[2].HeaderText = "نوع العجلة";
                    DGV.Columns[3].HeaderText = "يوم الحادث";
                    DGV.Columns[4].HeaderText = "تاريخ الحادث";
                    DGV.Columns[5].Visible = false;
                    DGV.Columns[6].Visible = false;
                    DGV.Columns[7].Visible = false;
                    DGV.Columns[8].Visible = false;
                    DGV.Columns[9].Visible = false;
                    break;
            }
        }

    }
}
