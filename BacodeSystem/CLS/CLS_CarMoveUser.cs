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
    class CLS_CarMoveUser
    {
        GunaTextBox IDMove;
        GunaTextBox CarsNo;
        GunaTextBox CarsType;
        GunaTextBox GoingTime;
        GunaTextBox DriverName1;
        GunaTextBox CommingTime;
        GunaTextBox DriverName2;
        GunaComboBox TheType;
        GunaComboBox CustomerName;
        GunaComboBox Distenation;
        GunaComboBox TheBeneficiary;
        GunaTextBox RegisterName1;
        GunaTextBox RegisterName2;
        GunaTextBox TransCount;
        GunaTextBox TypeWater;
        GunaTextBox Barcode;

        string MovementTable = "CarsMovements";
        string MovementsGetter = "Movements_Getter";
        string MovementsGetter2 = "Movements_Getter_byCarDivision";
        string MovementsGetter3 = "MovementsUser_Getter_ByCar";
        string MovementsSetter = "MovementsUser_Setter";
        string MovementsUpdatter = "MovementsUser_Updater";
        string MovementsDeletter = "Movements_Deletter";
        string MaxMovementsID = "Movements_ID";



        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(list, MovementsGetter3);
            DataTable Dt2 = GettingData.ReadDataSP2(MovementTable);
            foreach (Control item in list)
            {
                item.DataBindings.Clear();
            }
            int j = 0;
            for (int i = 0; i < Dt2.Rows.Count; i++)
            {
                if(i!=12 && i!= 15 && i!=18 && i!= 19 && i!=20)
                    list[j++].DataBindings.Add("text", Dt, Dt2.Rows[i][0].ToString());
            }


            return Dt;

        }
        public DataTable GettingData2(List<Control> controls)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, MovementsGetter2);
            return Dt;
        }


        public DataTable GetMovementID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxMovementsID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {

            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, MovementsSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, MovementsUpdatter);
        }


        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, MovementsDeletter);
        }


        public void DGVdesign(GunaDataGridView DGV, DataTable data)
        {


        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(IDMove);
            controls.Add(CarsNo);
            controls.Add(CarsType);
            controls.Add(GoingTime);
            controls.Add(DriverName1);
            controls.Add(CommingTime);
            controls.Add(DriverName2);
            controls.Add(TheType);
            controls.Add(CustomerName);
            controls.Add(Distenation);
            controls.Add(TheBeneficiary);
            controls.Add(RegisterName1);
            controls.Add(RegisterName2);
            controls.Add(TransCount);
            controls.Add(TypeWater);
            controls.Add(Barcode);
            return controls;
        }
    }
}
