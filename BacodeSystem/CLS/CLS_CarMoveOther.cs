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
    class CLS_CarMoveOther
    {
        GunaTextBox IDMove;
        GunaTextBox CarsNo;
        GunaTextBox CarsType;
        GunaTextBox CommingTime;
        GunaTextBox DriverName1;
        GunaTextBox GoingTime;
        GunaTextBox DriverName2;
        GunaComboBox TheType;
        GunaComboBox CustomerName;
        GunaComboBox Distenation;
        GunaComboBox TheBeneficiary;
        RichTextBox Notice;
        GunaTextBox RegisterName1;
        GunaTextBox RegisterName2;
        GunaTextBox NowDate;
        GunaTextBox TransCount;
        GunaTextBox TypeWater;
        GunaTextBox PicCar;
        GunaTextBox PicCome;
        GunaTextBox PicGo;
        GunaTextBox Barcode;

        string MovementTable = "CarMoveOther";
        string MovementsGetter = "MovementsOther_Getter";
        string MovementsGetter2 = "MovementsOther_Getter_byCarDivision";
        string MovementsGetter3 = "MovementsOther_Getter_ByCar";
        string MovementsSetter = "MovementsOther_Setter";
        string MovementsUpdatter = "MovementsOther_Updater";
        string MovementsDeletter = "MovementsOther_Deletter";
        string MaxMovementsID = "MovementsOther_ID";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(list, MovementsGetter3);
            DataTable Dt2 = GettingData.ReadDataSP2(MovementTable);
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
            controls.Add(CommingTime);
            controls.Add(DriverName1);
            controls.Add(GoingTime);
            controls.Add(DriverName2);
            controls.Add(TheType);
            controls.Add(CustomerName);
            controls.Add(Distenation);
            controls.Add(TheBeneficiary);
            controls.Add(Notice);
            controls.Add(RegisterName1);
            controls.Add(RegisterName2);
            controls.Add(NowDate);
            controls.Add(TransCount);
            controls.Add(TypeWater);
            controls.Add(PicCar);
            controls.Add(PicCome);
            controls.Add(PicGo);
            controls.Add(Barcode);
            return controls;
        }
    }
}
