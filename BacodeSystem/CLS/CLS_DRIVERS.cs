using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BacodeSystem.CLS
{
    class CLS_DRIVERS
    {
        GunaTextBox DriverID;
        GunaTextBox DriverName;
        GunaComboBox DriverDepart;
        GunaTextBox DriverDivision;
        GunaTextBox DriverIdentitfy;
        GunaTextBox DriverBarcode;
        
        string DriverTable = "DriverInfo";
        string DriverGetter = "Drivers_Getter";
        string DriverGetter2 = "Drivers_Getter_bybarcode";
        string DriverSetter = "Drivers_Setter";
        string DriverUpdatter = "Drivers_Updatter";
        string DriverDeletter = "Drivers_Deletter";
        string MaxDriverID = "Drivers_ID";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DriverGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(DriverTable);
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
        public DataTable GettingData_bybarcode(List<Control> controls)
        {
            DAL.CRUD GettingData2 = new DAL.CRUD();
            DataTable Dtgettre2= GettingData2.ReadingData(controls, DriverGetter2);
            return Dtgettre2;
        }

        public DataTable GetDriverID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxDriverID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, DriverSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, DriverUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, DriverDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView, DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "اسم السائق";
            dataGridView.Columns[2].HeaderText = "القسم";
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].Visible = false;
            

        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(DriverID);
            controls.Add(DriverName);
            controls.Add(DriverDepart);
            controls.Add(DriverDivision);
            controls.Add(DriverIdentitfy);
            controls.Add(DriverBarcode);
       

            return controls;

        }

        public void GetDriverName(ComboBoxEdit cmb)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DriverGetter);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cmb.Properties.Items.Add(Dt.Rows[i][1]);
            }
        }
    }
}
