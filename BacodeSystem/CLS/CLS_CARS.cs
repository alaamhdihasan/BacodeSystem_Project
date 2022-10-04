using DevExpress.XtraEditors;
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
    class CLS_CARS
    {
        GunaTextBox Cars_ID;
        GunaTextBox CarsDocNo;
        GunaTextBox CarsNo;
        GunaComboBox CarsType;
        GunaComboBox CarsBrand;
        GunaComboBox FuelType;
        GunaTextBox EngineSize;
        GunaTextBox CylinderCount;
        GunaTextBox CarPower;
        GunaNumeric PassengerCount;
        GunaTextBox TyierMeasure;
        GunaNumeric LinesCount;
        GunaTextBox Shasy;
        GunaTextBox IdentityID;
        GunaDateTimePicker IdentityProdunctDate;
        GunaDateTimePicker IdentityExpireDate;
        GunaTextBox CarPag;
        GunaTextBox CarColor;
        GunaTextBox CarModel;
        GunaTextBox CarGage;
        GunaTextBox CarDistance;
        GunaTextBox WorkHours;
        GunaComboBox Depratments;
        GunaComboBox Depart_Div;
        GunaComboBox LineName;
        GunaComboBox TheBeneficiary;
        GunaComboBox distenation;
        GunaComboBox MovementType;       
        GunaTextBox RegisterName;
        GunaTextBox TimeAdding;
        GunaTextBox DateAdding;
        GunaTextBox CarBarcode;
        GunaTextBox Carimage;
       

        string CarsTable = "DivisionCars";
        string CarsGetter = "Cars_Getter";
        string Car_GetterByCarNo = "Car_GetterByCarNo";
        string CarsSetter = "Cars_Setter";
        string CarsUpdatter = "Cars_Updatter";
        string CarsDeletter = "Cars_Deletter";
        string MaxCarsID = "Cars_ID";
        string CarsTheBrand = "Cars_theBrand";
        string CarsTypes = "Cars_type";
        string CarsDivivsion = "Cars_Division";
        string CarsTran = "Cars_TranName";

        string InsertData = "Insert";
        string UpdateData = "Update";
        string DeleteData = "Delete";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsGetter  );
            DataTable Dt2 = GettingData.ReadDataSP2(CarsTable);
            foreach (Control item in list)
            {
                item.DataBindings.Clear();
            }
            for (int i = 0; i < Dt2.Rows.Count; i++)
            {
                if (i == 14 || i == 15)
                {                  
                    list[i].DataBindings.Add("value", Dt, Dt2.Rows[i][0].ToString());
                }
                else
                    list[i].DataBindings.Add("text", Dt, Dt2.Rows[i][0].ToString());      
            }
           
            return Dt;
        }
        public DataTable GetCarsID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCarsID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarsSetter);
        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarsUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarsDeletter);
        }


        public void DGVdesign(GunaDataGridView DGV, DataTable data)
        {
            DGV.DataSource = data;
            for (int i = 0; i < 33; i++)
            {
                switch (i)
                {
                    case 2:
                        DGV.Columns[i].HeaderText = "رقم العجلة";
                        break;
                    case 3:
                        DGV.Columns[i].HeaderText = "نوع العجلة";
                        break;
                    case 22:
                        DGV.Columns[i].HeaderText = "عائدية العجلة";
                        break;
                    case 23:
                        DGV.Columns[i].HeaderText = "الشعبة";
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
            controls.Add(Cars_ID);
            controls.Add( CarsDocNo);
            controls.Add (CarsNo);
            controls.Add (CarsType);
            controls.Add (CarsBrand);
            controls.Add (FuelType);
            controls.Add (EngineSize);
            controls.Add (CylinderCount);
            controls.Add (CarPower);
            controls.Add (PassengerCount);
            controls.Add (TyierMeasure);
            controls.Add (LinesCount);
            controls.Add (Shasy);
            controls.Add (IdentityID);
            controls.Add (IdentityProdunctDate);
            controls.Add (IdentityExpireDate);
            controls.Add (CarPag);
            controls.Add (CarColor);
            controls.Add (CarModel);
            controls.Add (CarGage);
            controls.Add (CarDistance);
            controls.Add (WorkHours);
            controls.Add (Depratments);
            controls.Add (Depart_Div);
            controls.Add (LineName);
            controls.Add (TheBeneficiary);
            controls.Add (distenation);
            controls.Add (MovementType);
            controls.Add (RegisterName);
            controls.Add (TimeAdding);
            controls.Add (DateAdding);
            controls.Add (CarBarcode);
            controls.Add (Carimage);
           

            return controls;

        }

        //------------------------------------------------------------------------
        //get cars type
        public void CarTypes(ComboBoxEdit cartype)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsTypes);
            
            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                cartype.Properties.Items.Add(Dt.Rows[i][0]);
            }

        }

        //get cars brand
        public void CarBrands(ComboBoxEdit carbrand)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsTheBrand);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                carbrand.Properties.Items.Add(Dt.Rows[i][0]);
            }

        }

        //get cars division
        public void Cardivision(ComboBoxEdit cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsDivivsion);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Properties.Items.Add(Dt.Rows[i][0]);
            }

        }

        //get cars Transport Name
        public void CarTranName(ComboBoxEdit cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsTran);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Properties.Items.Add(Dt.Rows[i][0]);
            }

        }

        //------------------------------------------------------------------------
        //serach car type by car Number   
        public void CarInfo(System.Windows.Forms.ComboBox cmb, System.Windows.Forms.ComboBox cartype)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsGetter);
            cmb.DataSource = Dt;
            cmb.DisplayMember = "CarNO";
            cmb.ValueMember = "CarType";
            cartype.DataSource = Dt;
            cartype.DisplayMember = "CarType";
        }

        //------------------------------------------------------------------------
        //get cars Number   
        public void CarNo(ComboBoxEdit cmb)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsGetter);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cmb.Properties.Items.Add(Dt.Rows[i][2]);
            }
        }
        //------------------------------------------------------------------------
        //get car by car Number
        public DataTable GET_Car_GetterByCarNo(List<Control> controls)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, Car_GetterByCarNo);

            return Dt;
        }
    }
}
