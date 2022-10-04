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
    public partial class FRM_Backup : Form
    {
        string ActionName;
        public FRM_Backup(string ActionName)
        {
            InitializeComponent();
            this.ActionName = ActionName;
        }

        private void FRM_Backup_Load(object sender, EventArgs e)
        {
            if (ActionName == "backup")
                btnBackup.Text = "انشاء نسخة احتياطة";
            else if (ActionName == "recovery")
                btnBackup.Text = "استرجاع قاعدة البيانات";
        }

        private void btnexitapplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPathSave.Text == string.Empty)
                {
                    MessageBox.Show("يرجى تحديد المسار");
                }
                else
                {
                    if (ActionName == "backup")
                    {
                        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                        dal.createBackup(txtPathSave.Text);
                        MessageBox.Show("تم انشاء نسخة احتايطة لقاعدة البيانات");
                    }
                    else if (ActionName == "recovery")
                    {
                        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
                        dal.Restore(txtPathSave.Text);
                        MessageBox.Show("تم استرجاع قاعدة البيانات");
                    }
                    btnBackup.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPathSave.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }
    }
}
