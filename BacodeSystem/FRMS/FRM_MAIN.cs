using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace BacodeSystem.FRMS
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
            HideSubMenu();
            Hidentabpages(tab_main);
            
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        public List<Control> GetArrayUser()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_backup);
            controls.Add(btn_recovery);
            controls.Add(btn_setting);
            controls.Add(btn_users);
            controls.Add(btn_Departments);
            controls.Add(btn_Places);
            controls.Add(btn_MovementType);
            controls.Add(btn_DriverInfo);
            controls.Add(btn_BarcodeGeneration);
            controls.Add(btn_Customer);
            controls.Add(btn_carsinfo);
            controls.Add(btn_carbarcode);
            controls.Add(btn_carCounters);
            controls.Add(btn_carFeul);
            controls.Add(btn_carAccidents);
            controls.Add(btn_CarReport);          
            controls.Add(btn_MovementReport);
            controls.Add(btn_Control);
            controls.Add(btn_UserCarMove);
            return controls;
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            t1.Text = Properties.Settings.Default.UserName;
            t2.Text = Properties.Settings.Default.Password;

            List<Control> controls = new List<Control>();
            controls.Add(t1);
            controls.Add(t2);

            CLS.CLS_USERS user = new CLS.CLS_USERS();
            user.FrmPre(controls, GetArrayUser());

            if (btn_carbarcode.Enabled == true)
                Speedbtn_CarMovement.Enabled = true;
            if (btn_UserCarMove.Enabled == true)
                Speedbtn_UserCarMove.Enabled = true;
            if (btn_carsinfo.Enabled == true)
                Speedbtn_CarInfo.Enabled = true;
            if (btn_CarReport.Enabled == true)
                Speedbtn_CarReports.Enabled = true;
            if (btn_Control.Enabled == true)
                Speedbtn_Control.Enabled = true;
            if (btn_MovementReport.Enabled == true)
                Speedbtn_MovementsReport.Enabled = true;
            
        }

        private void TM_PN_Main_Tick(object sender, EventArgs e)
        {
          
        }

        private void btn_controlmenu_Click(object sender, EventArgs e)
        {  
            if (PN_Main.Width == 50)
                for (int i = 50; i < 250; i += 5)
                    PN_Main.Width += 5;
            else
                for (int i = 250; i > 50; i -= 5)
                    PN_Main.Width -= 5;
        }
        private void btn_main_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PN_btnmain);  
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            FRM_Backup s = new FRM_Backup("backup");
            s.Show();
        }

        private void btn_recovery_Click(object sender, EventArgs e)
        {
            FRM_Backup s = new FRM_Backup("recovery");
            s.Show();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            FRM_Setting s = new FRM_Setting();
            s.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            FRM_Users user = new FRM_Users();
            user.Show();
        }

        private void btn_Dataentry_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PN_btndataentry);
        }

        private void btn_Departments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_ENTRYDATA(btn_Departments.Text),tab_main,tab_EntryData.Name,tab_addingform);

        }

        private void btn_Places_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_ENTRYDATA(btn_Places.Text), tab_main, tab_EntryData.Name, tab_addingform);
        }

        private void btn_MovementType_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_ENTRYDATA(btn_MovementType.Text), tab_main, tab_EntryData.Name, tab_addingform);
        }

        private void btn_DriverInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_DRIVERINFO(), tab_main, tab_EntryData.Name, tab_addingform);
        }

        private void btn_BarcodeGeneration_Click(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
           FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.Show();
        }

        //==============================================================================================
        //=== This for Hiding Submenu for every menus.....
        private void HideSubMenu()
        {
            if (PN_btnmain.Visible == true) { PN_btnmain.Visible = false; PN_btnmain.Height = 1; }
            if (PN_btndataentry.Visible == true) { PN_btndataentry.Visible = false;PN_btndataentry.Height = 1; }
            if (PN_btnCarsMovements.Visible == true) { PN_btnCarsMovements.Visible = false;PN_btnCarsMovements.Height = 1; }
            if (PN_Report.Visible == true) { PN_Report.Visible = false; PN_Report.Height = 1; }
        }
        //==============================================================================================
        //== This for Show sub menu....
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
                int items = submenu.Controls.Count;
                for (int i = 0; i < items*50; i+=5)
                    submenu.Height += 5;
            }
            else
            {
                int items = submenu.Controls.Count;
                for (int i = items * 50; i > 1; i-=5)
                    submenu.Height -= 5;
                submenu.Visible = false;
            }

        }
        //=============================================================================================
        private void btn_CarsMovements_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PN_btnCarsMovements);
        }

        private void btn_carsinfo_Click(object sender, EventArgs e)
        {
            FRM_CARSINFORMATIONS frm = new FRM_CARSINFORMATIONS();
            frm.ShowDialog();
        }

        private void btn_carbarcode_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FRM_CarsMovements(),tab_main,tab_Carmovements.Name);
        }

        private void btn_carCounters_Click(object sender, EventArgs e)
        {
            FRM_Counters frm = new FRM_Counters();
            frm.ShowDialog();
        }

        private void btn_carFeul_Click(object sender, EventArgs e)
        {
            FRM_CarsFuel frm = new FRM_CarsFuel();
            frm.ShowDialog();
        }

        private void btn_carAccidents_Click(object sender, EventArgs e)
        {
            FRM_CarsAccident frm = new FRM_CarsAccident();
            frm.ShowDialog();
        }

        private void PN_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PN_Report);
        }
        //=================================================================================




        private Form ActiveForm = null;
        private Form ActiveForm2 = null;
        private void OpenChildForm(Form childForm,DevExpress.XtraTab.XtraTabControl tab_page,string nameofpage)
        {

           if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point(300, 125);
          

            foreach (XtraTabPage  page in tab_page.TabPages)
            {
               if(page.Name == nameofpage.ToString())
                { 
                    page.Controls.Add(childForm);
                    page.Tag = childForm;                 
                    page.PageVisible = true;
                    page.Show();
 
                } 
            }
            
            childForm.BringToFront();
            childForm.Show();
                     
        }
        private void OpenChildForm(Form childForm, DevExpress.XtraTab.XtraTabControl tab_page, string nameofpage
            ,TableLayoutPanel tab_layout)
        {

            if (ActiveForm2 != null)
                ActiveForm2.Close();
            ActiveForm2 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            foreach (XtraTabPage page in tab_page.TabPages)
            {
                if (page.Name == nameofpage.ToString())
                {
                   
                    page.Controls.Add(tab_layout);
                    tab_layout.Controls.Add(childForm, 1, 1);
                    tab_layout.Tag = childForm;
                    page.PageVisible = true;
                    page.Show();
                }
            }

            childForm.BringToFront();
            childForm.Show();

        }
        private void Hidentabpages(XtraTabControl tab_main_pages)
        {
            foreach (XtraTabPage page in tab_main_pages.TabPages)
                for (int i = 1; i < tab_main_pages.TabPages.Count; i++)
                    tab_main_pages.TabPages[i].PageVisible = false;
        }

        private void tab_main_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            (arg.Page as XtraTabPage).PageVisible = false;
        }

        private void btn_CarReport_Click(object sender, EventArgs e)
        {
            FRM_CarReport frm = new FRM_CarReport();
            frm.ShowDialog();
        }

        private void btn_MovementReport_Click(object sender, EventArgs e)
        {
            FRM_MovementsReport f = new FRM_MovementsReport();
                f.ShowDialog();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Frm_Control f = new Frm_Control();
            f.ShowDialog();
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            FRM_UserCarMovements f = new FRM_UserCarMovements();
            f.ShowDialog();
        }

        private void gunaAdvenceButton1_Click_2(object sender, EventArgs e)
        {
            Frm_Control f = new Frm_Control();
            f.ShowDialog();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FRM_CarsMovements(), tab_main, tab_Carmovements.Name);
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            FRM_UserCarMovements f = new FRM_UserCarMovements();
            f.ShowDialog();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            FRM_CarReport frm = new FRM_CarReport();
            frm.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FRM_MovementsReport f = new FRM_MovementsReport();
            f.ShowDialog();
        }

        private void Speedbtn_CarInfo_Click(object sender, EventArgs e)
        {
            FRM_CARSINFORMATIONS frm = new FRM_CARSINFORMATIONS();
            frm.ShowDialog();
        }
    }
}
