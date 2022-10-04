using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.FRMS
{
    public partial class FRM_Setting : Form
    {
        public FRM_Setting()
        {
            InitializeComponent();
            try
            {
                ServerIP_cbo.Text = Properties.Settings.Default.ServerIP.ToString();
                txt_DPUserName.Text = Properties.Settings.Default.DBUserName.ToString();
                txt_DBPassword.Text = Properties.Settings.Default.DBPassword.ToString();
                txt_DBName.Text = Properties.Settings.Default.DBName.ToString();
                txt_CarArchPath.Text = Properties.Settings.Default.CarArchivePath.ToString();
                txt_BarcodePath.Text = Properties.Settings.Default.BarcodeArchPath.ToString();
                txt_FuelArchPath.Text = Properties.Settings.Default.BillPath.ToString();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Setting_Load(object sender, EventArgs e)
        {
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                string d = servers.Rows[i]["ServerName"].ToString();
                string ip = Dns.GetHostByName(d).AddressList[0].ToString();
                ServerIP_cbo.Properties.Items.Add(ip);
              
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.ServerIP = ServerIP_cbo.Text;
            Properties.Settings.Default.DBUserName = txt_DPUserName.Text;
            Properties.Settings.Default.DBPassword = txt_DBPassword.Text;
            Properties.Settings.Default.DBName = txt_DBName.Text;
            Properties.Settings.Default.CarArchivePath = txt_CarArchPath.Text;
            Properties.Settings.Default.BarcodeArchPath = txt_BarcodePath.Text;
            Properties.Settings.Default.BillPath = txt_FuelArchPath.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ");
        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List_DB.Items.Clear();

            SqlConnection sqlcon = new SqlConnection(@"Data Source=" + ServerIP_cbo.Text + ";initial Catalog=master; persist Security info=True; user id=" + txt_DPUserName.Text + ";password=" +txt_DBPassword.Text + "");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Name from sys.databases", sqlcon);
            SqlDataReader Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                List_DB.Items.Add(Dr[0].ToString());

            }
            sqlcon.Close();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void List_DB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_DBName.Text = List_DB.SelectedItem.ToString();
        }
    }
}
