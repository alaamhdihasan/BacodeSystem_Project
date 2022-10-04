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
    class CLS_CARSACCIDENT
    {
        GunaTextBox IDaccident;
        GunaComboBox CarNO;
        GunaComboBox CarType;
        GunaComboBox AccidentDay;
        GunaDateTimePicker AccidentDate;
        GunaTextBox Notice;
        GunaTextBox RegisterName;
        GunaTextBox AddingTime;
        GunaTextBox AddingDate;
        GunaComboBox DriverName;

        string CarsAccidentTable = "CarsAccidents";
        string CarsAccidentGetter = "CarsAccident_Getter";
        string CarsAccidentSetter = "CarsAccident_Setter";
        string CarsAccidentUpdatter = "CarsAccident_Updatter";
        string CarsAccidentDeletter = "CarsAccident_Deletter";
        string MaxCarsAccidentID = "CarsAccident_ID";

        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsAccidentGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(CarsAccidentTable);
            foreach (Control item in list)
            {
                item.DataBindings.Clear();
            }
            for (int i = 0; i < Dt2.Rows.Count; i++)
            {
                list[i].DataBindings.Add("text", Dt, Dt2.Rows[i][0].ToString());
            }
            return Dt;
        }

        public DataTable GetCarsAccidentID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCarsAccidentID);
            return Dt;
        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarsAccidentSetter);
        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarsAccidentUpdatter);

        }

        public void deleteData(List<Control> controls)
        {

            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarsAccidentDeletter);
        }

        public void DGVdesign(GunaDataGridView DGV, DataTable data)
        {
            DGV.DataSource = data;
            for (int i = 0; i <= 9; i++)
            {
                switch (i)
                {
                    case 1:
                        DGV.Columns[i].HeaderText = "رقم العجلة";
                        break;
                    case 2:
                        DGV.Columns[i].HeaderText = "نوع العجلة";
                        break;

                    case 3:
                        DGV.Columns[i].HeaderText = "يوم الحادث";
                        break;

                    case 4:
                        DGV.Columns[i].HeaderText = "تاريخ الحادث";
                        break;
                    case 5:
                        DGV.Columns[i].HeaderText = "ملاحظات";
                        break;
                    case 9:
                        DGV.Columns[i].HeaderText = "اسم السائق";
                        break;
                    default:
                        DGV.Columns[i].Visible = false;
                        break;
                }
            }
        }


        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(IDaccident);
            controls.Add(CarNO);
            controls.Add(CarType);
            controls.Add(AccidentDay);
            controls.Add(AccidentDate);
            controls.Add(Notice);
            controls.Add(RegisterName);
            controls.Add(AddingTime);
            controls.Add(AddingDate);
            controls.Add(DriverName);

            return controls;

        }


        //------------------------------------------------------------------------
        //serach car type by car Number   
        public void CarInfo(ComboBox cmb, ComboBox cartype)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData("Cars_Getter");
            cmb.DataSource = Dt;
            cmb.DisplayMember = "CarNO";
            cmb.ValueMember = "CarType";
            cartype.DataSource = Dt;
            cartype.DisplayMember = "CarType";
        }
    }
}
