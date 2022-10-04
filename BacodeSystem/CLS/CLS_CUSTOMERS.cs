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
using DevExpress.XtraEditors;

namespace BacodeSystem.CLS
{
    class CLS_CUSTOMERS
    {
        GunaTextBox CustomerID;
        GunaTextBox CustomerName;
        GunaComboBox CustomerDistenation;
        GunaComboBox CustomerBenefiairy;
        GunaComboBox CustomerType;
        GunaComboBox CustomerJob;
        GunaTextBox RegisterName;
        string CustomerTable = "TheCustomers";
        string CustomerGetter = "Customer_Getter";
        string CustomerGetter2 = "Customer_Getter2";
        string CustomerGetter3 = "Customer_Getter3";
        string CustomerGetter4 = "Customer_Getter4";
        string CustomerGetter5 = "Customer_Getter5";
        string CustomerGetter6 = "Customer_Getter6";
        string CustomerGetter7 = "Customer_Getter7";
        string CustomerGetter8 = "Customer_Getter8";
        string CustomerGetter9 = "Customer_Getter9";
        string CustomerSetter = "Customer_Setter";
        string CustomerUpdatter = "Customer_Updatter";
        string CustomerDeletter = "Customer_Deletter";
        string MaxCustomerID = "Customer_ID";

        string InsertData = "Insert";
        string UpdateData = "Update";
        string DeleteData = "Delete";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(CustomerTable);
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
        public DataTable GetCustomerID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCustomerID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CustomerSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CustomerUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CustomerDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView,DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "اسم المستفيد";
            dataGridView.Columns[2].HeaderText = "الجهة المقصودة";
            dataGridView.Columns[3].HeaderText = "الجهة المستفيدة";
            dataGridView.Columns[4].HeaderText = "الحالة";
            dataGridView.Columns[5].HeaderText = "الوظيفة";
            dataGridView.Columns[6].Visible = false;

        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(CustomerID);
            controls.Add(CustomerName);
            controls.Add(CustomerDistenation);
            controls.Add(CustomerBenefiairy);
            controls.Add(CustomerType);
            controls.Add(CustomerJob);
            controls.Add(RegisterName);

            return controls;

        }

        //get customer for combobox
        public void customer(ComboBoxEdit carbrand)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                carbrand.Properties.Items.Add(Dt.Rows[i][1]);
            }

        }

        //get customer to datatable
        public DataTable customerDt()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter);
            return Dt;
        }
        //get customer to datatable
        public DataTable customerDt2()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter2);
            return Dt;
        }
        //get customer to datatable
        public DataTable customerDt3()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter3);
            return Dt;
        }
        //get customer to datatable
        public DataTable customerDt4()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter4);
            return Dt;
        }
        //get customer to datatable
        public DataTable customerDt5()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter5);
            return Dt;
        }
        //get customer to datatable
        public DataTable customerDt6()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter6);
            return Dt;
        }

        public DataTable customerDt7()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter7);
            return Dt;
        }

        public DataTable customerDt8()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter8);
            return Dt;
        }

        public DataTable customerDt9()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(CustomerGetter9);
            return Dt;
        }

    }

   
}
