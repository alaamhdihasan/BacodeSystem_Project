using System;
using System.Collections;
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
    public partial class FRM_CUSTOMERS : Form
    {
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
        }

        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {
            try { 
            CLS.CLS_CUSTOMERS GettingData = new CLS.CLS_CUSTOMERS();

            DataTable dataTable = GettingData.GettingData(GetArray());
            GettingData.DGVdesign(DGV_Customers, dataTable);

            CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
            dept.GetDepartments(CustomerDepart_cbo);
            CLS.CLS_DISTENATION place = new CLS.CLS_DISTENATION();
            place.GetPlaces(CustomerPlace_cbo);
            CLS.CLS_THETYPE type = new CLS.CLS_THETYPE();
            type.Gettype(CustomerType_cbo);

                TextBox t1 = new TextBox();
                TextBox t2 = new TextBox();
                TextBox t3 = new TextBox();
                t1.Text = Properties.Settings.Default.UserName;
                t2.Text = Properties.Settings.Default.Password;
                t3.Text = "المستفيدين";
                List<Control> controls = new List<Control>();
                controls.Add(t1);
                controls.Add(t2);
                controls.Add(t3);
                CLS.CLS_USERS user = new CLS.CLS_USERS();
                user.FrmPreControl1(controls, GetArrayBtn());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Control> GetArrayBtn()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_new);
            controls.Add(btnSave);
            controls.Add(btnDelete);
            return controls;

        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CUSTOMERS UpdateData = new CLS.CLS_CUSTOMERS();
                UpdateData.updateData(GetArray());
                FRM_CUSTOMERS_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(CustomerID_txt);
            controls.Add(CustomerName_txt);
            controls.Add(CustomerPlace_cbo);
            controls.Add(CustomerDepart_cbo);
            controls.Add(CustomerType_cbo);
            controls.Add(CustomerJob_cbo);
            controls.Add(CustomerReg_txt);

            return controls;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CUSTOMERS MaxID = new CLS.CLS_CUSTOMERS();
                DataTable DtMax = MaxID.GetCustomerID();
                List<Control> controls = GetArray();
                foreach (Control item in controls)
                {
                    item.Text = "";
                }
                controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();
                controls[6].Text = Properties.Settings.Default.UserName;

                CLS.CLS_CUSTOMERS Insertdata = new CLS.CLS_CUSTOMERS();
                Insertdata.insertData(controls);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CUSTOMERS deleteData = new CLS.CLS_CUSTOMERS();
                deleteData.deleteData(GetArray());
                FRM_CUSTOMERS_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
