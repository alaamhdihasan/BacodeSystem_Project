
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
    class CLS_CARSFUEL
    {
        GunaTextBox IDfuel;
        GunaTextBox CarNO;
        GunaComboBox CarType;
        GunaComboBox FuelDay;
        GunaDateTimePicker FuelDate;
        GunaTextBox FuelQuantity;
        GunaTextBox BillNO;
        GunaDateTimePicker BillDate;
        GunaTextBox BillTotalMoney;
        GunaTextBox ImagePath;
        GunaTextBox RegisterName;
        GunaTextBox AddingTime;
        GunaTextBox AddingDate;

        string CarsFuelTable = "CarsFuel";
        string CarsFuelGetter = "CarsFuel_Getter";
        string CarsFuelSetter = "CarsFuel_Setter";
        string CarsFuelUpdatter = "CarsFuel_Updatter";
        string CarsFuelDeletter = "CarsFuel_Deletter";
        string MaxCarsFuelID = "CarsFuel_ID";

        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarsFuelGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(CarsFuelTable);
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

        public DataTable GetCarsFuelID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCarsFuelID);
            return Dt;
        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarsFuelSetter);
        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarsFuelUpdatter);
            
        }

        public void deleteData(List<Control> controls)
        {
          
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarsFuelDeletter);
        }

        public void DGVdesign(GunaDataGridView DGV, DataTable data)
        {
            DGV.DataSource = data;
            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 1:
                        DGV.Columns[i].HeaderText = "رقم العجلة";
                        break;
                    case 2:
                        DGV.Columns[i].HeaderText = "نوع العجلة";
                        break;
                  
                    case 5:
                        DGV.Columns[i].HeaderText = "كمية الوقود";
                        break;
                    case 6:
                        DGV.Columns[i].HeaderText = "رقم الفاتورة";
                        break;
                    case 7:
                        DGV.Columns[i].HeaderText = "تاريخ الفاتورة";
                        break;
                    case 8:
                        DGV.Columns[i].HeaderText = "مبلغ الفاتورة";
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
            controls.Add(IDfuel);
            controls.Add(CarNO);
            controls.Add(CarType);
            controls.Add(FuelDay);
            controls.Add(FuelDate);
            controls.Add(FuelQuantity);
            controls.Add(BillNO);
            controls.Add(BillDate);
            controls.Add(BillTotalMoney);
            controls.Add(ImagePath);
            controls.Add(RegisterName);
            controls.Add(AddingTime);
            controls.Add(AddingDate);

            return controls;

        }


        


    }
}
