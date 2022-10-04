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
    class CLS_RPCARMOVEMENT
    {

        public DataTable GET_RPCM_(string StoredName, List<Control> controls)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, StoredName);

            return Dt;
        }

        public DataTable GET_RPCM_(string StoredName)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadData(StoredName);

            return Dt;
        }

        public void DGVdesign(GunaDataGridView DGV, DataTable data, string StoredName)
        {
            DGV.DataSource = data;

            for (int i = 0; i < data.Columns.Count; i++)
            {
                switch (data.Columns[i].ColumnName)
                {
                    case "CarNO":
                        DGV.Columns[i].HeaderText = "رقم العجلة";
                        break;
                    case "CarType":
                        DGV.Columns[i].HeaderText = "نوع العجلة";
                        break;
                    case "GoingTimeDate":
                        DGV.Columns[i].HeaderText = "وقت وتاريخ الخروج";
                        break;
                    case "DriverName1":
                        DGV.Columns[i].HeaderText = "اسم السائق";
                        break;
                    case "CommingTimeDate":
                        DGV.Columns[i].HeaderText = "وقت وتاريخ العودة";
                        break;
                    case "DriverName2":
                        DGV.Columns[i].HeaderText = "اسم السائق";
                        break;
                    case "TheType":
                        DGV.Columns[i].HeaderText = "الحالة";
                        break;
                    case "CustomerName":
                        DGV.Columns[i].HeaderText = "المستفيد";
                        break;
                    case "TheBeneficiary":
                        DGV.Columns[i].HeaderText = "الجهة المستفيدة";
                        break;
                    case "Distenation":
                        DGV.Columns[i].HeaderText = "الجهة المقصودة";
                        break;
                    case "Notice":
                        DGV.Columns[i].HeaderText = "ملاحظات";
                        break;
                    case "TransCount":
                        DGV.Columns[i].HeaderText = "عدد النقلات";
                        break;
                    case "TypeWater":
                        DGV.Columns[i].HeaderText = "نوع الماء";
                        break;
                    case "cnt":
                        DGV.Columns[i].HeaderText = "عدد";
                        break;
                }
            }
        }

        public void DGVdesignDept(GunaDataGridView DGV, DataTable data, string StoredName)
        {
            DGV.DataSource = data;

            for (int i = 0; i < data.Columns.Count; i++)
            {
                switch (data.Columns[i].ColumnName)
                {
                    case "CarNO":
                        DGV.Columns[i].HeaderText = "رقم العجلة";
                        break;
                    case "CarType":
                        DGV.Columns[i].HeaderText = "نوع العجلة";
                        break;
                    case "GoingTimeDate":
                        DGV.Columns[i].HeaderText = "وقت وتاريخ الخروج";
                        break;
                    case "DriverName1":
                        DGV.Columns[i].HeaderText = "اسم السائق";
                        break;
                    case "CommingTimeDate":
                        DGV.Columns[i].HeaderText = "وقت وتاريخ الدخول";
                        break;
                    case "DriverName2":
                        DGV.Columns[i].HeaderText = "اسم السائق";
                        break;
                    case "TheType":
                        DGV.Columns[i].HeaderText = "الحالة";
                        break;
                    case "CustomerName":
                        DGV.Columns[i].HeaderText = "المستفيد";
                        break;
                    case "TheBeneficiary":
                        DGV.Columns[i].HeaderText = "الجهة المستفيدة";
                        break;
                    case "Distenation":
                        DGV.Columns[i].HeaderText = "الجهة المقصودة";
                        break;
                    case "Notice":
                        DGV.Columns[i].HeaderText = "ملاحظات";
                        break;
                    case "TransCount":
                        DGV.Columns[i].HeaderText = "عدد النقلات";
                        break;
                    case "TypeWater":
                        DGV.Columns[i].HeaderText = "نوع الماء";
                        break;
                    case "cnt":
                        DGV.Columns[i].HeaderText = "عدد";
                        break;
                }
            }
        }
        public string[] getnamear(string[] s)
        {
            string[] res = new string[s.Length-1];
            for (int i = 1; i < s.Length; i++)
            {
                switch (s[i])
                {
                   
                    case "[CarNO]":
                        res[i-1] = "رقم العجلة";
                        break;
                    case "[CarType]":
                        res[i-1] = "نوع العجلة";
                        break;
                    case "[GoingTimeDate]":
                        res[i-1] = "وقت وتاريخ الخروج";
                        break;
                    case "[DriverName1]":
                        res[i-1] = "اسم السائق";
                        break;
                    case "[CommingTimeDate]":
                        res[i-1] = "وقت وتاريخ العودة";
                        break;
                    case "[DriverName2]":
                        res[i-1] = "اسم السائق";
                        break;
                    case "[TheType]":
                        res[i-1] = "الحالة";
                        break;
                    case "[CustomerName]":
                        res[i-1] = "المستفيد";
                        break;
                    case "[TheBeneficiary]":
                        res[i-1] = "الجهة المستفيدة";
                        break;
                    case "[Distenation]":
                        res[i-1] = "الجهة المقصودة";
                        break;
                    case "[Notice]":
                        res[i-1] = "ملاحظات";
                        break;
                    case "[TransCount]":
                        res[i-1] = "عدد النقلات";
                        break;
                    case "[TypeWater]":
                        res[i-1] = "نوع الماء";
                        break;
                    case "[cnt]":
                        res[i-1] = "عدد";
                        break;
                }
            }
            return res;
        }

        public string[] getnamearDept(string[] s)
        {
            string[] res = new string[s.Length - 1];
            for (int i = 1; i < s.Length; i++)
            {
                switch (s[i])
                {

                    case "[CarNO]":
                        res[i - 1] = "رقم العجلة";
                        break;
                    case "[CarType]":
                        res[i - 1] = "نوع العجلة";
                        break;
                    case "[GoingTimeDate]":
                        res[i - 1] = "وقت وتاريخ الخروج";
                        break;
                    case "[DriverName1]":
                        res[i - 1] = "اسم السائق";
                        break;
                    case "[CommingTimeDate]":
                        res[i - 1] = "وقت وتاريخ الدخول";
                        break;
                    case "[DriverName2]":
                        res[i - 1] = "اسم السائق";
                        break;
                    case "[TheType]":
                        res[i - 1] = "الحالة";
                        break;
                    case "[CustomerName]":
                        res[i - 1] = "المستفيد";
                        break;
                    case "[TheBeneficiary]":
                        res[i - 1] = "الجهة المستفيدة";
                        break;
                    case "[Distenation]":
                        res[i - 1] = "الجهة المقصودة";
                        break;
                    case "[Notice]":
                        res[i - 1] = "ملاحظات";
                        break;
                    case "[TransCount]":
                        res[i - 1] = "عدد النقلات";
                        break;
                    case "[TypeWater]":
                        res[i - 1] = "نوع الماء";
                        break;
                    case "[cnt]":
                        res[i - 1] = "عدد";
                        break;
                }
            }
            return res;
        }
    }
}
