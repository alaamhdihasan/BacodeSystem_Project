using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace BacodeSystem.DAL
{
    class CRUD
    {
        DAL.DataAccessLayer dal = new DataAccessLayer();


        public DataTable ReadData(string StoredProceduerName)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.open();
            DataTable Dt = dal.SelectingData(StoredProceduerName, null);
            dal.close();

            return Dt;
        }

     

        public DataTable ReadDataSP(string procedurName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ProcedureName", SqlDbType.VarChar, 500);
            param[0].Value = procedurName;
            dal.open();
            DataTable Dt = dal.SelectingData("GP", param);
            dal.close();

            return Dt;
        }

        public DataTable ReadDataSP2(string TableName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TableName", SqlDbType.VarChar, 50);
            param[0].Value = TableName;
            dal.open();
            DataTable Dt = dal.SelectingData("SP2", param);
            dal.close();

            return Dt;
        }
        public DataTable ReadingData(List<Control> controls, string StroedProcedureName)
        {
            DataTable Dt = ReadDataSP(StroedProcedureName);
            SqlCommand insertCommand = new SqlCommand(StroedProcedureName, dal.sqlcon);
            SqlParameter[] param = new SqlParameter[Dt.Rows.Count];

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                param[i] = insertCommand.Parameters.AddWithValue(Dt.Rows[i][0].ToString()
                   , Dt.Rows[i][1].ToString());
                param[i].SqlDbType = SqlDbType.VarChar;
                param[i].Value = controls[i].Text;
            }
           
            dal.open();
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Connection = dal.sqlcon;
            insertCommand.ExecuteNonQuery();
            SqlDataAdapter Da = new SqlDataAdapter(insertCommand);
            DataTable Dtt = new DataTable();
            Da.Fill(Dtt);
            dal.close();
            return Dtt;
        }

       

        public void ExecuteData(List<Control> controls, string StroedProcedureName)
{
            DataTable Dt = ReadDataSP(StroedProcedureName);
            SqlCommand insertCommand = new SqlCommand(StroedProcedureName, dal.sqlcon);
            SqlParameter[] param = new SqlParameter[Dt.Rows.Count];

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                param[i] = insertCommand.Parameters.AddWithValue(Dt.Rows[i][0].ToString()
                   , Dt.Rows[i][1].ToString());
                param[i].SqlDbType = SqlDbType.VarChar;
                param[i].Value = controls[i].Text;
                
            }
            dal.open();
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Connection = dal.sqlcon;
            insertCommand.ExecuteNonQuery();
            dal.close();

        }
    }
}
