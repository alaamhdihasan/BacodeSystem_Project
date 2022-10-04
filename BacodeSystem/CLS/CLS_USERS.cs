
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
    class CLS_USERS
    {
        string UsersTable = "Users";
        string Users_Deletter = "Users_Deletter";
        string USers_Getter = "USers_Getter";
        string Users_ID = "Users_ID";
        string Users_Setter = "Users_Setter";
        string Users_Updatter = "Users_Updatter";
        string UserLogin = "UserLogin";

        string UserFrmTable = "UserFrm";
        string UserFrm_Deletter = "UserFrm_Deletter";
        string UserFrm_Getter = "UserFrm_Getter";
        string UserFrm_ID = "UserFrm_ID";
        string UserFrm_Setter = "UserFrm_Setter";
        string UserFrm_Updatter = "UserFrm_Updatter";

        string UserPermissionTable = "UserPermission";
        string UserPermission_Deletter = "UserPermission_Deletter";
        string UserPermission_Getter = "UserPermission_Getter";
        string UserPermission_GetterFrm = "UserPermission_GetterFrm";
        string UserPermission_ID = "UserPermission_ID";
        string UserPermission_Setter = "UserPermission_Setter";
        string UserPermission_Updatter = "UserPermission_Updatter";


        //Users Table
        public DataTable GettingDataUsers(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(USers_Getter);
            DataTable Dt2 = GettingData.ReadDataSP2(UsersTable);
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

        public DataTable GettingDataUserLogin(List<Control> list)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(list, UserLogin);          
            return Dt;
        }

        public DataTable GetUsersID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(Users_ID);
            return Dt;

        }

        public void insertDataUsers(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, Users_Setter);
        }

        public void updateDataUsers(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, Users_Updatter);
        }

        public void deleteDataUsers(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, Users_Deletter);
        }

        //-----------------------------------------------------------
        //UserFrm Table
        public DataTable GettingDataUserFrm(ComboBoxEdit cbo)
        {
            cbo.Properties.Items.Clear();
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(UserFrm_Getter);
            for (int i = 0; i < Dt.Rows.Count; i++)
                cbo.Properties.Items.Add(Dt.Rows[i][1]);
            return Dt;
        }

      

        //-----------------------------------------------------------
        //UserPermission Table
        public DataTable GettingDataUserPermission(List<Control> list, List<Control> list1)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(list1, UserPermission_Getter);
            DataTable Dt2 = GettingData.ReadDataSP2(UserPermissionTable);
            foreach (Control item in list)
            {
                item.DataBindings.Clear();
            }
            for (int i = 0; i < Dt2.Rows.Count; i++)
            {
                if(i<4)
                    list[i].DataBindings.Add("text", Dt, Dt2.Rows[i][0].ToString());
                else
                    list[i].DataBindings.Add("Checked", Dt, Dt2.Rows[i][0].ToString());
            }

            return Dt;
        }

        public DataTable GetUserPermissionID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(UserPermission_ID);
            return Dt;

        }

        public void insertDataUserPermission(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, UserPermission_Setter);
        }

        public void updateDataUserPermission(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, UserPermission_Updatter);
        }

        public void deleteDataUserPermission(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, UserPermission_Deletter);
        }

        public void DGVdesign(GunaDataGridView DGV, DataTable data)
        {
            DGV.DataSource = data;
            for (int i = 0; i < 9; i++)
            {
                switch (i)
                {
                    case 3:
                        DGV.Columns[i].HeaderText = "الواجهة";
                        break;
                    case 4:
                        DGV.Columns[i].HeaderText = "جديد";
                        break;
                    case 5:
                        DGV.Columns[i].HeaderText = "اضافة";
                        break;
                    case 6:
                        DGV.Columns[i].HeaderText = "تعديل";
                        break;
                    case 7:
                        DGV.Columns[i].HeaderText = "حذف";
                        break;
                    case 8:
                        DGV.Columns[i].HeaderText = "طباعة";
                        break;
                    default:
                        DGV.Columns[i].Visible = false;
                        break;
                }
            }
        }

        //-------------------------------------------------

        public void FrmPre(List<Control> controls, List<Control> btn)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, UserPermission_Getter);

            for(int i = 0; i < Dt.Rows.Count;i++)
            {
                if (Dt.Rows[i][3].ToString() == "نسخة احتياطية")
                    btn[0].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "استعادة نسخة")
                    btn[1].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "الاعدادات")
                    btn[2].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "المستخدمين")
                    btn[3].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "اقسام العتبة")
                    btn[4].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "مدن و اماكن")
                    btn[5].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "حالة الحركة")
                    btn[6].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "بيانات السواق")
                    btn[7].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "توليد باركود")
                    btn[8].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "المستفيدين")
                    btn[9].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "بيانات العجلات")
                    btn[10].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "نظام الحركة")
                    btn[11].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "العدادات")
                    btn[12].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "الوقود")
                    btn[13].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "الحوادث")
                    btn[14].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "تقارير العجلات")
                    btn[15].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "تقارير الحركة")
                    btn[16].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "لوحة المراقبة")
                    btn[17].Enabled = true;
                if (Dt.Rows[i][3].ToString() == "حركة العجلات")
                    btn[18].Enabled = true;
            }
        }


        public void FrmPreControl1(List<Control> controls, List<Control> btn)
        {

            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, UserPermission_GetterFrm);

            if (Dt.Rows[0][4].ToString() == "True")
            {
                btn[0].Enabled = true;
            }
            else
            {
                btn[0].Enabled = false;
            }
            if (Dt.Rows[0][5].ToString() == "True")
            {
                btn[1].Enabled = true;
            }
            else
            {
                btn[1].Enabled = false;
            }
            if (Dt.Rows[0][7].ToString() == "True")
            {
                btn[2].Enabled = true;
            }
            else
            {
                btn[2].Enabled = false;
            }

        }

        public void FrmPreControl2(List<Control> controls, List<Control> btn)
        {

            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, UserPermission_GetterFrm);

            if (Dt.Rows[0][4].ToString() == "True")
            {
                btn[0].Enabled = true;
            }
            else
            {
                btn[0].Enabled = false;
            }
            if (Dt.Rows[0][5].ToString() == "True")
            {
                btn[1].Enabled = true;
            }
            else
            {
                btn[1].Enabled = false;
            }
            if (Dt.Rows[0][6].ToString() == "True")
            {
                btn[2].Enabled = true;
            }
            else
            {
                btn[2].Enabled = false;
            }
            if (Dt.Rows[0][7].ToString() == "True")
            {
                btn[3].Enabled = true;
            }
            else
            {
                btn[3].Enabled = false;
            }

        }

        public void FrmPreControl3(List<Control> controls, List<Control> btn)
        {

            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, UserPermission_GetterFrm);

            if (Dt.Rows[0][4].ToString() == "True")
            {
                btn[0].Enabled = true;
            }
            else
            {
                btn[0].Enabled = false;
            }
            if (Dt.Rows[0][5].ToString() == "True")
            {
                btn[1].Enabled = true;
            }
            else
            {
                btn[1].Enabled = false;
            }
            if (Dt.Rows[0][6].ToString() == "True")
            {
                btn[2].Enabled = true;
            }
            else
            {
                btn[2].Enabled = false;
            }
            if (Dt.Rows[0][7].ToString() == "True")
            {
                btn[3].Enabled = true;
            }
            else
            {
                btn[3].Enabled = false;
            }
            if (Dt.Rows[0][8].ToString() == "True")
            {
                btn[4].Enabled = true;
            }
            else
            {
                btn[4].Enabled = false;
            }
        }
    }
}
