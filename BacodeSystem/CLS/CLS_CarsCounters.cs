using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using Guna.UI.WinForms;
using System.Collections;
using Guna.UI.WinForms;


namespace BacodeSystem.CLS
{
    class CLS_CarsCounters
    {
        GunaTextBox C_ID;
        GunaTextBox C_CarNo;
        GunaComboBox C_CarType;
        GunaComboBox C_Day;
        GunaDateTimePicker C_Date;
        GunaTextBox C_Carcounter;
        GunaTextBox C_RegisterName;
        GunaTextBox C_AddingTime;
        GunaTextBox C_AddingDate;
        GunaComboBox C_Advisor;



        string CarCountersTable = "CarsCounters";
        string CarCountersGetter = "CarCounters_Getter";
        string CarCountersSetter = "CarCounters_Setter";
        string CarCountersUpdatter = "CarCounters_Updatter";
        string CarCountersDeletter = "CarCounters_Deletter";
        string MaxCarCountersID = "CarCounters_ID";

        


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CarCountersGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(CarCountersTable);
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
        public DataTable GetCarsCounterID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCarCountersID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarCountersSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarCountersUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarCountersDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView,DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].HeaderText = "التاريخ";
            dataGridView.Columns[5].HeaderText = "العداد";
            dataGridView.Columns[6].Visible = false;
            dataGridView.Columns[7].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[9].HeaderText = "التبديل";

        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(C_ID);
            controls.Add(C_CarNo);
            controls.Add(C_CarType);
            controls.Add(C_Day);
            controls.Add(C_Date);
            controls.Add(C_Carcounter);
            controls.Add(C_RegisterName);
            controls.Add(C_AddingTime);
            controls.Add(C_AddingDate);
            controls.Add(C_Advisor);

            return controls;

        }

    }

   
}
