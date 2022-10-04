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
    class CLS_DISTENATION
    {
        GunaTextBox DistenationID;
        GunaTextBox DistenationName;

        string DistenationTable = "Distenation";
        string DistenationGetter = "Distenation_Getter";
        string DistenationGetter2 = "Distenation_Getter2";
        string DistenationGetter3 = "Distenation_Getter3";
        string DistenationGetter4 = "Distenation_Getter4";
        string DistenationGetter5 = "Distenation_Getter5";
        string DistenationSetter = "Distenation_Setter";
        string DistenationUpdatter = "Distenation_Updatter";
        string DistenationDeletter = "Distenation_Deletter";
        string MaxDistenationID = "Distenation_ID";

        string InsertData = "Insert";
        string UpdateData = "Update";
        string DeleteData = "Delete";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(DistenationTable);
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
        public DataTable GetDistenationID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxDistenationID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, DistenationSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, DistenationUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, DistenationDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView, DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "الجهة";


        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(DistenationID);
            controls.Add(DistenationName);

            return controls;

        }

        //get place for combobox
        public void GetPlaces(ComboBoxEdit cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter);
            cbo.Properties.Items.Clear();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Properties.Items.Add(Dt.Rows[i][1].ToString());
            }

        }

        //get place for datatable
        public DataTable GetPlacesDt()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter);
            return Dt;
        }

        //get place for datatable
        public DataTable GetPlacesDt2()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter2);
            return Dt;
        }
        //get place for datatable
        public DataTable GetPlacesDt3()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter3);
            return Dt;
        }
        //get place for datatable
        public DataTable GetPlacesDt4()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter4);
            return Dt;
        }
        //get place for datatable
        public DataTable GetPlacesDt5()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DistenationGetter5);
            return Dt;
        }
    }
}
