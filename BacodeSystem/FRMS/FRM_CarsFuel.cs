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
    public partial class FRM_CarsFuel : Form
    {
        public FRM_CarsFuel()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CarsFuel_Load(object sender, EventArgs e)
        {
            try
            {
                CLS.CLS_CARSFUEL GettingData = new CLS.CLS_CARSFUEL();

                DataTable dataTable = GettingData.GettingData(GetArray());
                GettingData.DGVdesign(DGV_CarsFuel, dataTable);
                CLS.CLS_CARS car = new CLS.CLS_CARS();
                car.CarInfo(CarNo_cbo, Cartype_cbo);

                CLS.CLS_CARFUELARCHIVE ReadDataArch = new CLS.CLS_CARFUELARCHIVE();
                List<Control> controls2 = new List<Control>();
                controls2.Add(ID_txt);
                DataTable DtArch = ReadDataArch.GettingData(controls2, imgList);

                TextBox t1 = new TextBox();
                TextBox t2 = new TextBox();
                TextBox t3 = new TextBox();
                t1.Text = Properties.Settings.Default.UserName;
                t2.Text = Properties.Settings.Default.Password;
                t3.Text = "الوقود";
                List<Control> controls = new List<Control>();
                controls.Add(t1);
                controls.Add(t2);
                controls.Add(t3);
                CLS.CLS_USERS user = new CLS.CLS_USERS();
                user.FrmPreControl1(controls, GetArrayBtn());
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
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
            controls.Add(FuelDay_cbo);
            controls.Add(FuelDate_dte);
            controls.Add(FuelQuantity_txt);
            controls.Add(BillNo_txt);
            controls.Add(BillDate_dte);
            controls.Add(BillPrice_txt);
            controls.Add(RegisterName_txt);
            controls.Add(AddingTime_txt);
            controls.Add(AddingDate_txt);

            
            return controls;

        }

        public List<Control> GetArrayArch()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_imgID);
            controls.Add(txt_imgIDCon);
            controls.Add(txt_imgPath);
            controls.Add(txt_imgRegisterName);
            controls.Add(txt_imgAddingTime);
            controls.Add(txt_imgAddingDate);
            return controls;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                CLS.CLS_CARSFUEL MaxID = new CLS.CLS_CARSFUEL();
                DataTable DtMax = MaxID.GetCarsFuelID();
                List<Control> controls = GetArray();
                foreach (Control item in controls)
                {
                    item.Text = "";
                }
                controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();
                controls[9].Text = Properties.Settings.Default.UserName;
                controls[10].Text = DateTime.Now.ToString("HH:mm:ss tt");
                controls[11].Text = DateTime.Now.ToString("yyyy-MM-dd");
                CLS.CLS_CARSFUEL Insertdata = new CLS.CLS_CARSFUEL();
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
                CLS.CLS_CARSFUEL UpdateData = new CLS.CLS_CARSFUEL();
                UpdateData.updateData(GetArray());
                FRM_CarsFuel_Load(sender, e);
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
                
                CLS.CLS_CARSFUEL deleteData = new CLS.CLS_CARSFUEL();
                deleteData.deleteData(GetArray());
                FRM_CarsFuel_Load(sender, e);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CarNo_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                Cartype_cbo.Text = CarNo_cbo.SelectedValue.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void غلقالقائمةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (imgList.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = imgList.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    string text = imgList.Items[intselectedindex].Text;
                    Process p = new Process();
                    p.StartInfo.FileName = text;
                    p.StartInfo.Verb = "Print";
                    p.Start();
                }
            }
            catch (Exception ee) { MessageBox.Show(ee.Message.ToString()); }
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
                string newpath = Properties.Settings.Default.BillPath + x.Next().ToString() + Path.GetExtension(nameimage);
               


                img.Load(ofd.FileName);
                img.Image.Save(newpath);
                imgList.Items.Add(newpath);

                CLS.CLS_CARFUELARCHIVE arch = new CLS.CLS_CARFUELARCHIVE();
                DataTable dtid = arch.GetCarsArchieveID();

                txt_imgID.Text = dtid.Rows[0][0].ToString();
                txt_imgIDCon.Text = ID_txt.Text;
                txt_imgPath.Text = newpath;
                txt_imgRegisterName.Text = Properties.Settings.Default.UserName;
                txt_imgAddingTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
                txt_imgAddingDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                arch.insertData(GetArrayArch());
                List<Control> controls2 = new List<Control>();
                controls2.Add(ID_txt);
                DataTable DtArch = arch.GettingData(controls2, imgList);

            }
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
                string newpath = Properties.Settings.Default.BillPath + nameimage;
                img.Load(Itm);
                img.Image.Save(newpath);
                imgList.Items.Add(newpath);

                CLS.CLS_CARFUELARCHIVE arch = new CLS.CLS_CARFUELARCHIVE();
                DataTable dtid = arch.GetCarsArchieveID();

                txt_imgID.Text = dtid.Rows[0][0].ToString();
                txt_imgIDCon.Text = ID_txt.Text;
                txt_imgPath.Text = newpath;
                txt_imgRegisterName.Text = Properties.Settings.Default.UserName;
                txt_imgAddingTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
                txt_imgAddingDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                arch.insertData(GetArrayArch());
                List<Control> controls2 = new List<Control>();
                controls2.Add(ID_txt);
                DataTable DtArch = arch.GettingData(controls2, imgList);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DGV_CarsFuel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DGV_CarsFuel_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ImagePath_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void طباعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DpArchieveMenu2.Hide();
        }

        private void Bill_Image_Click(object sender, EventArgs e)
        {
            
        }

        private void Bill_Image_DoubleClick(object sender, EventArgs e)
        {
            try
            {               
                Process.Start(txt_imgPath.Text);
            }
            catch (Exception ee) { MessageBox.Show(ee.Message.ToString()); }
        }

        private void DP_DGV_Click(object sender, EventArgs e)
        {

        }

        private void imgList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try { 
            if (imgList.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = imgList.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                string text = imgList.Items[intselectedindex].Text;
                System.Diagnostics.Process.Start(text);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (DGV_CarsFuel.DataSource as DataTable).DefaultView.RowFilter = string.Format("[CarNO] like '%{0}%' OR [CarType] like '%{1}%' " +
                    "OR [BillNO] = '{2}'", search_txt.Text, search_txt.Text, search_txt.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAttachments_Click(object sender, EventArgs e)
        {
            if (DP_Arch.FloatForm == null)
                DP_Arch.Show();
            else DP_Arch.Hide();
        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {
            try { 
            CLS.CLS_CARFUELARCHIVE ReadDataArch = new CLS.CLS_CARFUELARCHIVE();
            List<Control> controls2 = new List<Control>();
            controls2.Add(ID_txt);
            DataTable DtArch = ReadDataArch.GettingData(controls2, imgList);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
            if (imgList.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = imgList.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                txt_imgPath.Text = imgList.Items[intselectedindex].Text;
                CLS.CLS_CARFUELARCHIVE DeleteDataArch = new CLS.CLS_CARFUELARCHIVE();
                List<Control> controlsDelete = new List<Control>();
                controlsDelete.Add(txt_imgPath);
                DeleteDataArch.deleteData(controlsDelete);

                List<Control> controls2 = new List<Control>();
                controls2.Add(ID_txt);
                DataTable DtArch = DeleteDataArch.GettingData(controls2, imgList);
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
