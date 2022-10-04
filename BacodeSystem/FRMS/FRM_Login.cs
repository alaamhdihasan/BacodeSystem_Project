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
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txt_UserName);
            controls.Add(txt_Password);

            return controls;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "admin" && txt_Password.Text == "4321")
            {
                FRM_Setting s = new FRM_Setting();
                s.Show();
            }
            else
            {
                CLS.CLS_USERS user = new CLS.CLS_USERS();
                DataTable dt = user.GettingDataUserLogin(GetArray());

                if (dt.Rows.Count > 0)
                {
                    Properties.Settings.Default.UserName = txt_UserName.Text;
                    Properties.Settings.Default.Password = txt_Password.Text;
                    Properties.Settings.Default.Save();

                    FRM_MAIN main = new FRM_MAIN();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("هذا المستخدم او كلمة المرور خطأ يرجى التحقق مرة اخرى", "خطأ اسم المستخدم او كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_UserName.Focus();
                }
            }
        }
    }
}
