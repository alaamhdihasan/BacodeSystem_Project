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
    class CLS_THETYPE
    {
        GunaTextBox TheTypeID;
        GunaTextBox TheTypeName;

        string TheTypeTable = "TheType";
        string TheTypeGetter = "TheType_Getter";
        string TheTypeSetter = "TheType_Setter";
        string TheTypeUpdatter = "TheType_Updatter";
        string TheTypeDeletter = "TheType_Deletter";
        string MaxTheTypeID = "TheType_ID";

        string InsertData = "Insert";
        string UpdateData = "Update";
        string DeleteData = "Delete";


        public DataTable GettingData(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(TheTypeGetter);
            DataTable Dt2 = GettingData.ReadDataSP2(TheTypeTable);
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
        public DataTable GetTheTypeID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxTheTypeID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
          
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, TheTypeSetter);
        }

        public void updateData(List<Control> controls)
        {
           
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, TheTypeUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, TheTypeDeletter);
        }


        public void DGVdesign(GunaDataGridView dataGridView, DataTable data)
        {
            dataGridView.DataSource = data;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "الحالة";
            dataGridView.Columns[2].HeaderText = "الحهة المقصودة";
            dataGridView.Columns[3].HeaderText = "الجهة المستفيدة";
            dataGridView.Columns[4].HeaderText = "المستفيد";
        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(TheTypeID);
            controls.Add(TheTypeName);

            return controls;

        }

        //get type for combobox
        public void Gettype(ComboBoxEdit cbo)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(TheTypeGetter);
            cbo.Properties.Items.Clear();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                cbo.Properties.Items.Add(Dt.Rows[i][1].ToString());
            }           
        }

        //get type and return datatable
        public DataTable GettypeDt()
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(TheTypeGetter);
            return Dt;
        }
    }
}
