using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BacodeSystem.FRMS
{
    public partial class FRM_Users : DevExpress.XtraEditors.XtraForm
    {
        CurrencyManager cm;
        DataTable Dtcm;
        public FRM_Users()
        {
            InitializeComponent();
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Users_Load(object sender, EventArgs e)
        {
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            user.GettingDataUserFrm(Forms_cbo);
            
            Dtcm = null;
            Dtcm = user.GettingDataUsers(GetArrayUser());
            cm = (CurrencyManager)this.BindingContext[Dtcm];

            List<Control> controls = new List<Control>();
            
            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            TextBox t3 = new TextBox();
            t1.Text = Properties.Settings.Default.UserName;
            t2.Text = Properties.Settings.Default.Password;
            t3.Text = "المستخدمين";
            List<Control> controlspre = new List<Control>();
            controlspre.Add(t1);
            controlspre.Add(t2);
            controlspre.Add(t3);
            CLS.CLS_USERS userpre = new CLS.CLS_USERS();
            userpre.FrmPreControl1(controlspre, GetArrayBtn1());
            userpre.FrmPreControl1(controlspre, GetArrayBtn2());
        }

        public List<Control> GetArrayUser()
        {
            List<Control> controls = new List<Control>();
            controls.Add(UserId_txt);
            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            controls.Add(RegisterName_txt);
            controls.Add(AddingTime_txt);
            controls.Add(AddingDate_txt);

            return controls;
        }
        public List<Control> GetArrayBtn1()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_new);
            controls.Add(btnSave);
            controls.Add(btnDelete);
            return controls;

        }

        public List<Control> GetArrayBtn2()
        {
            List<Control> controls = new List<Control>();
            controls.Add(NewPre_btn);
            controls.Add(SavePre_btn);
            controls.Add(DeletePre_btn);
            return controls;

        }
        public List<Control> GetArrayUserPer()
        {
            List<Control> controls = new List<Control>();
            controls.Add(PreId_txt);
            controls.Add(txtUser);
            controls.Add(txtPass);
            controls.Add(Forms_cbo);
            controls.Add(txtnew);
            controls.Add(txtadd);
            controls.Add(txtedit);
            controls.Add(txtdelete);
            controls.Add(txtprint);

            return controls;
        }

        public List<Control> GetArrayUserPer2()
        {
            List<Control> controls = new List<Control>();
            controls.Add(PreId_txt);
            controls.Add(txtUser);
            controls.Add(txtPass);
            controls.Add(Forms_cbo);
            controls.Add(New_chx);
            controls.Add(Add_chx);
            controls.Add(Edit_chx);
            controls.Add(Delete_chx);
            controls.Add(Print_chx);

            return controls;
        }

        public void index(int index)
        {
            cm.Position =index;
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            List<Control> controls = new List<Control>();

            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);
            txtUser.Text = UserName_txt.Text;
            txtPass.Text = Password_txt.Text;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int indx = cm.Position;
                    CLS.CLS_USERS MaxID = new CLS.CLS_USERS();
                    DataTable DtMax = MaxID.GetUsersID();
                    List<Control> controls = GetArrayUser();
                    foreach (Control item in controls)
                    {
                        item.Text = "";
                    }
                    controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();
                    controls[3].Text = Properties.Settings.Default.UserName;
                    controls[4].Text = DateTime.Now.ToString("HH:mm:ss tt");
                    controls[5].Text = DateTime.Now.ToString("yyyy-MM-dd");
                    CLS.CLS_USERS Insertdata = new CLS.CLS_USERS();
                    Insertdata.insertDataUsers(controls);
                    index(indx);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    CLS.CLS_USERS UpdateData = new CLS.CLS_USERS();
                    UpdateData.updateDataUsers(GetArrayUser());
                    FRM_Users_Load(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    CLS.CLS_USERS deleteData = new CLS.CLS_USERS();
                    deleteData.deleteDataUsers(GetArrayUser());
                    FRM_Users_Load(sender, e);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewPre_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int indx = cm.Position;
                    CLS.CLS_USERS MaxID = new CLS.CLS_USERS();
                    DataTable DtMax = MaxID.GetUserPermissionID();
                   
                    Forms_cbo.Text = null;
                    New_chx.Checked = false;
                    Add_chx.Checked = false;
                    Edit_chx.Checked = false;
                    Delete_chx.Checked = false;
                    Print_chx.Checked = false;
                    List<Control> controls = GetArrayUserPer();
                    controls[0].Text = (int.Parse(DtMax.Rows[0][0].ToString())).ToString();
                    
                    CLS.CLS_USERS Insertdata = new CLS.CLS_USERS();
                    Insertdata.insertDataUserPermission(controls);
                    FRM_Users_Load(sender, e);
                    index(indx);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SavePre_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int indx = cm.Position;
                    CLS.CLS_USERS UpdateData = new CLS.CLS_USERS();
                    UpdateData.updateDataUserPermission(GetArrayUserPer());
                    FRM_Users_Load(sender, e);
                    index(indx);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DeletePre_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int indx = cm.Position;
                    CLS.CLS_USERS deleteData = new CLS.CLS_USERS();
                    deleteData.deleteDataUserPermission(GetArrayUserPer());

                    FRM_Users_Load(sender, e);
                    index(indx);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            List<Control> controls = new List<Control>();

            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);
            txtUser.Text = UserName_txt.Text;
            txtPass.Text = Password_txt.Text;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            List<Control> controls = new List<Control>();

            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);
            txtUser.Text = UserName_txt.Text;
            txtPass.Text = Password_txt.Text;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            List<Control> controls = new List<Control>();

            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);
            txtUser.Text = UserName_txt.Text;
            txtPass.Text = Password_txt.Text;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            cm.Position = Dtcm.Rows.Count;
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            List<Control> controls = new List<Control>();

            controls.Add(UserName_txt);
            controls.Add(Password_txt);
            DataTable dt = user.GettingDataUserPermission(GetArrayUserPer2(), controls);
            user.DGVdesign(DGV_UserPre, dt);
            txtUser.Text = UserName_txt.Text;
            txtPass.Text = Password_txt.Text;
        }

        private void New_chx_CheckedChanged(object sender, EventArgs e)
        {
            if (New_chx.Checked == true)
                txtnew.Text = "1";
            else
                txtnew.Text = "0";
        }

        private void Add_chx_CheckedChanged(object sender, EventArgs e)
        {
            if (Add_chx.Checked == true)
                txtadd.Text = "1";
            else
                txtadd.Text = "0";
        }

        private void Edit_chx_CheckedChanged(object sender, EventArgs e)
        {
            if (Edit_chx.Checked == true)
                txtedit.Text = "1";
            else
                txtedit.Text = "0";
        }

        private void Delete_chx_CheckedChanged(object sender, EventArgs e)
        {
            if (Delete_chx.Checked == true)
                txtdelete.Text = "1";
            else
                txtdelete.Text = "0";
        }

        private void Print_chx_CheckedChanged(object sender, EventArgs e)
        {
            if (Print_chx.Checked == true)
                txtprint.Text = "1";
            else
                txtprint.Text = "0";
        }

        private void UserName_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnew_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DGV_UserPre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}