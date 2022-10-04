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
    public partial class FRM_CarsAccident : Form
    {
        public FRM_CarsAccident()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CarsAccident_Load(object sender, EventArgs e)
        {
            try { 
                CLS.CLS_CARSACCIDENT GettingData = new CLS.CLS_CARSACCIDENT();

                DataTable dataTable = GettingData.GettingData(GetArray());
                GettingData.DGVdesign(DGV_CarsCounter, dataTable);

                CLS.CLS_CARS car = new CLS.CLS_CARS();
                car.CarInfo(CarNo_cbo, Cartype_cbo);

                CLS.CLS_DRIVERS driver = new CLS.CLS_DRIVERS();
                driver.GetDriverName(DriveName_cbo);

                TextBox t1 = new TextBox();
                TextBox t2 = new TextBox();
                TextBox t3 = new TextBox();
                t1.Text = Properties.Settings.Default.UserName;
                t2.Text = Properties.Settings.Default.Password;
                t3.Text = "الحوادث";
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

        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(ID_txt);
            controls.Add(CarNo_cbo);
            controls.Add(Cartype_cbo);
            controls.Add(Day_cbo);
            controls.Add(Date_Datetime);
            controls.Add(Notic_txt);
            controls.Add(RegisterName_txt);
            controls.Add(TimeAdding_txt);
            controls.Add(DateAdding_txt);
            controls.Add(DriveName_cbo);
            return controls;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CARSACCIDENT MaxID = new CLS.CLS_CARSACCIDENT();
                DataTable DtMax = MaxID.GetCarsAccidentID();
                List<Control> controls = GetArray();
                foreach (Control item in controls)
                {
                    item.Text = "";
                }
                controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();
                controls[6].Text = Properties.Settings.Default.UserName;
                controls[7].Text = DateTime.Now.ToString("HH:mm:ss tt");
                controls[8].Text = DateTime.Now.ToString("yyyy-MM-dd");
                CLS.CLS_CARSACCIDENT Insertdata = new CLS.CLS_CARSACCIDENT();
                Insertdata.insertData(controls);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CARSACCIDENT UpdateData = new CLS.CLS_CARSACCIDENT();
                UpdateData.updateData(GetArray());
                FRM_CarsAccident_Load(sender, e);
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
                CLS.CLS_CARSACCIDENT deleteData = new CLS.CLS_CARSACCIDENT();
                deleteData.deleteData(GetArray());
                FRM_CarsAccident_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Notic_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
