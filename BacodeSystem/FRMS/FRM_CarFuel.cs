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
    public partial class FRM_CarFeul : Form
    {
        public FRM_CarFeul()
        {
            InitializeComponent();
        }

       
        private void FRM_CarFuel_Load(object sender, EventArgs e)
        {
            try { 
            CLS.CLS_CarsCounters GettingData = new CLS.CLS_CarsCounters();

            DataTable dataTable = GettingData.GettingData(GetArray());
            GettingData.DGVdesign(DGV_CarsCounter, dataTable);

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
        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CarsCounters UpdateData = new CLS.CLS_CarsCounters();
                UpdateData.updateData(GetArray());
                FRM_CarFuel_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(ID_txt);
            controls.Add(CarNo_txt);
            controls.Add(CarType_cbo);
            controls.Add(Day_cbo);
            controls.Add(Date_Datetime);
            controls.Add(Counter_txt);
            controls.Add(counterReg_txt);
            controls.Add(TimeAdding_txt);
            controls.Add(DateAdding_txt);
            controls.Add(Advisor_cbo);
          

            return controls;

        }

        public List<Control> GetArrayBtn()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_new);
            controls.Add(btnSave);
            controls.Add(btnDelete);
            return controls;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "عملية اضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CarsCounters MaxID = new CLS.CLS_CarsCounters();
                DataTable DtMax = MaxID.GetCarsCounterID();
                List<Control> controls = GetArray();
                foreach (Control item in controls)
                {
                    item.Text = "";
                }
                controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();

                CLS.CLS_CarsCounters Insertdata = new CLS.CLS_CarsCounters();
                Insertdata.insertData(controls);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CarsCounters deleteData = new CLS.CLS_CarsCounters();
                deleteData.deleteData(GetArray());
                FRM_CarFuel_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
