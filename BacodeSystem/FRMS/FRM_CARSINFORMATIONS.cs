using DevExpress.XtraBars.Docking;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwainLib;

namespace BacodeSystem.FRMS
{
    public partial class FRM_CARSINFORMATIONS : Form
    {
        CurrencyManager cm;
        DataTable Dtcm;
        public FRM_CARSINFORMATIONS()
        {
            InitializeComponent();
            DM1.ForceInitialize();
            DP_Archieve.Hide();
            DP_DGV.Hide();
        }

        public List<Control> GetArrayBtn()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_CarNew);
            controls.Add(Btn_CarAdd);
            controls.Add(Btn_CarSave);
            controls.Add(Btn_CarDelete);
            return controls;

        }

        private void FRM_CARSINFORMATIONS_Load(object sender, EventArgs e)
        {
            
            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            TextBox t3 = new TextBox();
            t1.Text = Properties.Settings.Default.UserName;
            t2.Text = Properties.Settings.Default.Password;
            t3.Text = "بيانات العجلات";
            List<Control> controls = new List<Control>();
            controls.Add(t1);
            controls.Add(t2);
            controls.Add(t3);
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            user.FrmPreControl2(controls, GetArrayBtn());
          
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Loading_Click(object sender, EventArgs e)
        {
            try {
                
                
                CLS.CLS_CARS ReadData = new CLS.CLS_CARS();
                DataTable Dt = ReadData.GettingData(GetArray());
                ReadData.DGVdesign(Car_DGV, Dt);
                Dtcm = null;
                Dtcm = Dt;
                cm = (CurrencyManager)this.BindingContext[Dtcm];
                ReadData.CarBrands(Car_Companycbo);
                ReadData.CarTypes(Car_Typecbo);
                ReadData.Cardivision(Car_Divisioncbo);
                ReadData.CarTranName(Car_LineNamecbo);
                CLS.CLS_DEPARTMENTS dept = new CLS.CLS_DEPARTMENTS();
                dept.GetDepartments(Car_DepartMenentcbo);
                dept.GetDepartments(Car_Benefitcbo);
                CLS.CLS_DISTENATION place = new CLS.CLS_DISTENATION();
                place.GetPlaces(Car_Distenationcbo);
                //CLS.CLS_THETYPE type = new CLS.CLS_THETYPE();
                //type.Gettype(Car_WorkTypecbo);
          

                if (Car_imagetxt.Text != null && Car_imagetxt.Text != "")
                    Car_Image.Load(Car_imagetxt.Text);

                CLS.CLS_CARARCHIEVE ReadDataArch = new CLS.CLS_CARARCHIEVE();
                List<Control> controls2 = new List<Control>();
                controls2.Add(Car_Notxt);
                DataTable DtArch = ReadDataArch.GettingData(controls2, Arch_imagesList);
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Cars_IDtxt);
            controls.Add(Car_DocNOtxt);
            controls.Add(Car_Notxt);
            controls.Add(Car_Typecbo);
            controls.Add(Car_Companycbo);
            controls.Add(Car_FuelTypecbo);
            controls.Add(Car_EngineSizetxt);
            controls.Add(Car_CylinderCounttxt);
            controls.Add(Car_Powertxt);
            controls.Add(Car_PassengerNum);
            controls.Add(Car_TyreMesuretxt);
            controls.Add(Car_DircountNum);
            controls.Add(Car_Shasiytxt);
            controls.Add(Car_IDNo);
            controls.Add(Car_IDproductDate);
            controls.Add(Car_IDexpireDate);
            controls.Add(Car_Cardtxt);
            controls.Add(Car_Colortxt);
            controls.Add(Car_Modeltxt);
            controls.Add(Car_Metertxt);
            controls.Add(Car_Dictancetxt);
            controls.Add(Car_WorkHourstxt);
            controls.Add(Car_DepartMenentcbo);
            controls.Add(Car_Divisioncbo);
            controls.Add(Car_LineNamecbo);
            controls.Add(Car_Benefitcbo);
            controls.Add(Car_Distenationcbo);
            controls.Add(Car_WorkTypecbo);
            controls.Add(Car_Registertxt);
            controls.Add(Car_AddingTimetxt);
            controls.Add(Car_AddingDatetxt);
            controls.Add(Car_CarBarcodetxt);
            controls.Add(Car_imagetxt);           

            return controls;
        }

        public List<Control> GetArrayArch()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Arch_ID);
            controls.Add(Arch_IdCon);
            controls.Add(Arch_CarNo);
            controls.Add(Arch_pathimage);
            controls.Add(Arch_registername);
            controls.Add(Arch_TimeAdding);
            controls.Add(Arch_DateAdding);

            return controls;
        }

        private void Btn_CarAdd_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "عملية اضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                    Car_Registertxt.Text = Properties.Settings.Default.UserName;
                    Car_AddingTimetxt.Text = DateTime.Now.ToString("hh:mm tt");
                    Car_AddingDatetxt.Text = DateTime.Now.ToString("yyyy/MM/dd");
                    int index = cm.Position;
                    CLS.CLS_CARS AddingData = new CLS.CLS_CARS();
                    DataTable DtMaxID = AddingData.GetCarsID();

                    List<Control> controls = GetArray();

                    controls[0].Text = (int.Parse(DtMaxID.Rows[0][0].ToString())).ToString();
                    AddingData.insertData(GetArray());
                    Btn_Loading_Click(sender, e);
                    cm.Position = index;
                    MessageBox.Show("تم الاضافة");
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_CarSave_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية التعديل", "عملية تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                    Car_Registertxt.Text = Properties.Settings.Default.UserName;
                    Car_AddingTimetxt.Text = DateTime.Now.ToString("hh:mm tt");
                    Car_AddingDatetxt.Text = DateTime.Now.ToString("yyyy/MM/dd");
                    int index = cm.Position;
                    CLS.CLS_CARS Updatedata = new CLS.CLS_CARS();
                    Updatedata.updateData(GetArray());
                    Btn_Loading_Click(sender, e);
                    cm.Position = index;
                    MessageBox.Show("تم التعديل");
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Btn_CarDelete_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CARS DeleteData = new CLS.CLS_CARS();
                DeleteData.deleteData(GetArray());
                Btn_Loading_Click(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (DP_DGV.FloatForm == null)
                DP_DGV.Show();
            else DP_DGV.Hide();
            if (DP_Archieve.FloatForm == null)
                DP_Archieve.Show();
            else DP_Archieve.Hide();
          
        }

        private void غلقالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void غلقالقائمةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void Cars_IDtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void غلقالقائمةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DP_Archieve.Hide();
        }

        private void غلقالقائمةToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            DP_DGV.Hide();
        }

        private void btn_CarNew_Click(object sender, EventArgs e)
        {
            try { 
            CLS.CLS_CARS car = new CLS.CLS_CARS();
            DataTable dt = car.GetCarsID();
         
            List<Control> controls = GetArray();
            foreach (Control item in controls)
            {
                item.Text = "";
            }
            Cars_IDtxt.Text = dt.Rows[0][0].ToString();
            Car_Registertxt.Text = Properties.Settings.Default.UserName;
            Car_AddingTimetxt.Text = DateTime.Now.ToString("HH:mm:ss tt");
            Car_AddingDatetxt.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void سنكرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            var b = TwainOperations.ScanImages();
            foreach (var Itm in b)
            {
                string pathimage = Itm;
                string nameimage = System.IO.Path.GetFileName(pathimage);
                string newpath = Properties.Settings.Default.CarArchivePath + nameimage;
                Archive_img.Load(Itm);
                Archive_img.Image.Save(newpath);
                Arch_imagesList.Items.Add(newpath);

                CLS.CLS_CARARCHIEVE arch = new CLS.CLS_CARARCHIEVE();
                DataTable dtid = arch.GetCarsArchieveID();

                Arch_ID.Text = dtid.Rows[0][0].ToString();
                Arch_IdCon.Text = Car_Notxt.Text;
                Arch_CarNo.Text = Car_Notxt.Text;
                Arch_pathimage.Text = newpath;
                Arch_registername.Text = Properties.Settings.Default.UserName;
                Arch_TimeAdding.Text = DateTime.Now.ToString("HH:mm:ss tt");
                Arch_DateAdding.Text = DateTime.Now.ToString("yyyy-MM-dd");

                arch.insertData(GetArrayArch());
                List<Control> controls2 = new List<Control>();
                controls2.Add(Car_Notxt);
                DataTable DtArch = arch.GettingData(controls2, Arch_imagesList);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void حاسبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "select an images|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathimage = ofd.FileName;
                string nameimage = Path.GetFileName(pathimage);
                Random x = new Random();
                string newpath = Properties.Settings.Default.CarArchivePath + x.Next().ToString() + Path.GetExtension(nameimage);
                

               

                Archive_img.Load(ofd.FileName);
                Archive_img.Image.Save(newpath);
                Arch_imagesList.Items.Add(newpath);

                CLS.CLS_CARARCHIEVE arch = new CLS.CLS_CARARCHIEVE();
                DataTable dtid = arch.GetCarsArchieveID();
                
                Arch_ID.Text = dtid.Rows[0][0].ToString();
                Arch_IdCon.Text = Car_Notxt.Text;
                Arch_CarNo.Text = Car_Notxt.Text;
                Arch_pathimage.Text = newpath;
                Arch_registername.Text = Properties.Settings.Default.UserName;
                Arch_TimeAdding.Text= DateTime.Now.ToString("HH:mm:ss tt");
                Arch_DateAdding.Text= DateTime.Now.ToString("yyyy-MM-dd");

                arch.insertData(GetArrayArch());
                List<Control> controls2 = new List<Control>();
                controls2.Add(Car_Notxt);
                DataTable DtArch = arch.GettingData(controls2, Arch_imagesList);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CarImageMenu2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Car_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Car_Typecbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void تحميلمنالحاسبةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try 
            { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "select an images|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string pathimage = ofd.FileName;
                string nameimage = Path.GetFileName(pathimage);
                Random x = new Random();
                string newpath = Properties.Settings.Default.CarArchivePath + x.Next().ToString() + Path.GetExtension(nameimage);
                
                Car_Image.Load(ofd.FileName);
                Car_Image.Image.Save(newpath);
                Car_imagetxt.Text = newpath;
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void تحميلمنالسكنرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            var b = TwainOperations.ScanImages();
            foreach (var Itm in b)
            {
                string pathimage = Itm;
                string nameimage = System.IO.Path.GetFileName(pathimage);
                string newpath = Properties.Settings.Default.CarArchivePath + nameimage;
                Car_Image.Load(Itm);
                Car_Image.Image.Save(newpath);
                Car_imagetxt.Text = newpath;
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            Process p = new Process();
            p.StartInfo.FileName = Car_imagetxt.Text;
            p.StartInfo.Verb = "Print";
            p.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void طباعةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try { 
            if (Arch_imagesList.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = Arch_imagesList.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string text = Arch_imagesList.Items[intselectedindex].Text;
                Process p = new Process();
                p.StartInfo.FileName = text;
                p.StartInfo.Verb = "Print";
                p.Start();
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Car_Image_DoubleClick(object sender, EventArgs e)
        {
            try { 
            Process.Start(Car_imagetxt.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Arch_imagesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try { 
            if (Arch_imagesList.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = Arch_imagesList.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string text = Arch_imagesList.Items[intselectedindex].Text;
                System.Diagnostics.Process.Start(text);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void DP_Archieve_Click(object sender, EventArgs e)
        {

        }

        private void Btn_BarcodeGeneration_Click(object sender, EventArgs e)
        {
            Car_CarBarcodetxt.Text = RandomNumber(1000, 9999).ToString();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void Car_CarBarcodetxt_TextChanged(object sender, EventArgs e)
        {
            Car_LabelBarcode.Text = Car_CarBarcodetxt.Text;
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            if (Arch_imagesList.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = Arch_imagesList.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                Arch_pathimage.Text = Arch_imagesList.Items[intselectedindex].Text;
                CLS.CLS_CARARCHIEVE DeleteDataArch = new CLS.CLS_CARARCHIEVE();
                List<Control> controlsDelete = new List<Control>();
                controlsDelete.Add(Arch_pathimage);
                DeleteDataArch.deleteData(controlsDelete);

                List<Control> controls2 = new List<Control>();
                controls2.Add(Car_Notxt);
                DataTable DtArch = DeleteDataArch.GettingData(controls2, Arch_imagesList);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
           
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            cm.Position = Dtcm.Rows.Count;
           
        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Car_imagetxt_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (Car_imagetxt.Text != null && Car_imagetxt.Text != "")
                Car_Image.Load(Car_imagetxt.Text);
                else
                {
                    Car_Image.Image = Properties.Resources.car;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Searchingtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Car_DGV.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNO] like '%{0}%' OR [ShasyNo] like '%{1}%' OR [CarType] like '%{2}%' OR [TheBrand] like '%{3}%' ", Searchingtxt.Text, Searchingtxt.Text, Searchingtxt.Text, Searchingtxt.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Btn_PrintBarcode_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Car_DocNOtxt");
            dt.Columns.Add("Car_Notxt");
            dt.Columns.Add("Car_Typecbo");
            dt.Columns.Add("Car_Companycbo");
            dt.Columns.Add("Car_FuelTypecbo");
            dt.Columns.Add("Car_CarBarcodetxt");
            dt.Rows.Add(new Object[]{
                Car_DocNOtxt.Text,
                Car_Notxt.Text,
                Car_Typecbo.Text,
                Car_Companycbo.Text,
                Car_FuelTypecbo.Text,
                Car_CarBarcodetxt.Text
           });

            RPTS.RP_Barcode rpbar = new RPTS.RP_Barcode(dt);
            RPTS.Report frm = new RPTS.Report();
            frm.documentViewer1.DocumentSource = rpbar;
            frm.ShowDialog();
        }

        private void btn_PrintDoc_Click(object sender, EventArgs e)
        {
            List<Control> controls13 = new List<Control>();
            controls13.Add(Car_Notxt);
            CLS.CLS_CARS print = new CLS.CLS_CARS();
            DataTable dt = print.GET_Car_GetterByCarNo(controls13);
            DS.DSCars dss = new DS.DSCars();
            dss.Tables["Car_GetterByCarNo"].Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dss.Tables["Car_GetterByCarNo"].Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4], dt.Rows[i][5], 
                    dt.Rows[i][6], dt.Rows[i][7], dt.Rows[i][8], dt.Rows[i][9], dt.Rows[i][10], dt.Rows[i][11], dt.Rows[i][12],
                     dt.Rows[i][13], dt.Rows[i][14], dt.Rows[i][15], dt.Rows[i][16], dt.Rows[i][17], dt.Rows[i][18], dt.Rows[i][19],
                      dt.Rows[i][20], dt.Rows[i][21], dt.Rows[i][22], dt.Rows[i][23], dt.Rows[i][24], dt.Rows[i][25], dt.Rows[i][26]);
            }
            RPTS.RP_CarInformation info = new RPTS.RP_CarInformation();
            info.Parameters["User"].Value = Properties.Settings.Default.UserName;
            info.Parameters["Date"].Value = DateTime.Now.ToString("dd/MM/yyyy");
            info.RequestParameters = false;
            info.DataSource = dss;
            RPTS.Report frm = new RPTS.Report();
            frm.documentViewer1.DocumentSource = info;
            frm.ShowDialog();
        }

        private void Car_Notxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CLS.CLS_CARARCHIEVE ReadDataArch = new CLS.CLS_CARARCHIEVE();
                List<Control> controls2 = new List<Control>();
                controls2.Add(Car_Notxt);
                DataTable DtArch = ReadDataArch.GettingData(controls2, Arch_imagesList);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
