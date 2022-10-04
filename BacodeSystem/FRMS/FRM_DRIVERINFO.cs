using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.FRMS
{
    public partial class FRM_DRIVERINFO : Form
    {
        public FRM_DRIVERINFO()
        {
            InitializeComponent();
        }

        private void FRM_DRIVERINFO_Load(object sender, EventArgs e)
        {
            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            TextBox t3 = new TextBox();
            t1.Text = Properties.Settings.Default.UserName;
            t2.Text = Properties.Settings.Default.Password;
            t3.Text = "بيانات السواق";
            List<Control> controls = new List<Control>();
            controls.Add(t1);
            controls.Add(t2);
            controls.Add(t3);
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            user.FrmPreControl1(controls, GetArrayBtn());
        }

        public List<Control> GetArrayBtn()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Btn_New);
            controls.Add(Btn_Save);
            controls.Add(Btn_Delete);
            return controls;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try { 
            CLS.CLS_DRIVERS LoadingData = new CLS.CLS_DRIVERS();
            DataTable Dt= LoadingData.GettingData(GetArray());
            LoadingData.DGVdesign(DGV_Drivers, Dt);

            CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
            dept.GetDepartments(Driver_Depart);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Driver_ID);
            controls.Add(Driver_Name);
            controls.Add(Driver_Depart);
            controls.Add(Driver_Division);
            controls.Add(Driver_Identitify);
            controls.Add(Driver_Barcode);         
            return controls;

        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_DRIVERS MaxID = new CLS.CLS_DRIVERS();
                DataTable DtMax = MaxID.GetDriverID();
                List<Control> controls = GetArray();
                foreach (Control item in controls)
                {
                    item.Text = "";
                }

                controls[0].Text = int.Parse(DtMax.Rows[0][0].ToString()).ToString();
                CLS.CLS_DRIVERS Insertdata = new CLS.CLS_DRIVERS();
                Insertdata.insertData(controls);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_DRIVERS UpdateData = new CLS.CLS_DRIVERS();
                UpdateData.updateData(GetArray());
                DataTable Dt = UpdateData.GettingData(GetArray());
                UpdateData.DGVdesign(DGV_Drivers, Dt);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_DRIVERS DeleteData = new CLS.CLS_DRIVERS();
                DeleteData.deleteData(GetArray());
                DataTable Dt = DeleteData.GettingData(GetArray());
                DeleteData.DGVdesign(DGV_Drivers, Dt);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Driver_Barcode_TextChanged(object sender, EventArgs e)
        {
            BarcodeLabel.Text = Driver_Barcode.Text;
        }

        private void Btn_Barcode_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Driver_ID");
            dt.Columns.Add("Driver_Name");
            dt.Columns.Add("Driver_Depart");
            dt.Columns.Add("Driver_Division");
            dt.Columns.Add("Driver_Identitify");
            dt.Columns.Add("Driver_Barcode");
            dt.Rows.Add(new Object[]{
                Driver_ID.Text,
                Driver_Name.Text,
                Driver_Depart.Text,
                Driver_Division.Text,
                Driver_Identitify.Text,
                Driver_Barcode.Text
           });

            RPTS.RP_Barcode rpbar = new RPTS.RP_Barcode(dt);
            RPTS.Report frm = new RPTS.Report();
            frm.documentViewer1.DocumentSource = rpbar;
            frm.ShowDialog();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Driver_Barcode.Text = RandomNumber(1000, 9999).ToString();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (DGV_Drivers.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Driver_Name] like '%{0}%' OR [Driver_Identitfy] like '%{1}%' ", searchtxt.Text, searchtxt.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
