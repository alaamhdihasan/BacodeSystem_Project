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
    class CLS_DEPARTMENTS
    {
        GunaTextBox DepartmentID;
        GunaTextBox DepartmentName;
       
        string DepartmentTable = "Departments";
        string DepartmentGetter = "Departments_Getter";
        string DepartmentGetter2 = "Departments_Getter2";
        string DepartmentGetter3 = "Departments_Getter3";
        string DepartmentSetter = "Departments_Setter";
        string DepartmentUpdatter = "Departments_Updatter";
        string DepartmentDeletter = "Departments_Deletter";
        string MaxDepartmentID = "Department_ID";

        string InsertData = "Insert";
        string UpdateData = "Update";
        string DeleteData = "Delete";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DepartmentGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(DepartmentTable);
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
        public void GettingData2(GunaComboBox cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(DepartmentGetter);
            cbo.Items.Clear();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Items.Add(Dt.Rows[i][1].ToString());
            }
            

        }
        public DataTable GetDepartmentID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxDepartmentID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, DepartmentSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, DepartmentUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, DepartmentDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView, DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "القسم";
           

        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(DepartmentID);
            controls.Add(DepartmentName);
            
            return controls;

        }

        //get departments for combobox
        public void GetDepartments(ComboBoxEdit cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData("Departments_Getter");
            cbo.Properties.Items.Clear();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Properties.Items.Add(Dt.Rows[i][1].ToString());
            }

        }

        //get departments for datatable
        public DataTable GetDepartmentsDt()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData("Departments_Getter");
            return Dt;

        }
        //get departments for datatable 
        public DataTable GetDepartmentsDt2()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData("Departments_Getter2");
            return Dt;

        }
        //get departments for datatable
        public DataTable GetDepartmentsDt3()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData("Departments_Getter3");
            return Dt;

        }

    }
}
