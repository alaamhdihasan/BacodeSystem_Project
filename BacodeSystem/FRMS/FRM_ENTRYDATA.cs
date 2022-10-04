using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace BacodeSystem.FRMS
{
    public partial class FRM_ENTRYDATA : Form
    {
        string _lb;
        public FRM_ENTRYDATA(string Lb)
        {
            InitializeComponent();
            _lb = Lb;
        }

        private void FRM_ENTRYDATA_Load(object sender, EventArgs e)
        {

            Lb_name.Text = _lb.ToString();

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            TextBox t3 = new TextBox();
            t1.Text = Properties.Settings.Default.UserName;
            t2.Text = Properties.Settings.Default.Password;
            t3.Text = Lb_name.Text;
            List<Control> controls = new List<Control>();
            controls.Add(t1);
            controls.Add(t2);
            controls.Add(t3);
            CLS.CLS_USERS user = new CLS.CLS_USERS();
            user.FrmPreControl1(controls, GetArrayBtn());

            switch (_lb)
            {
                case "اقسام العتبة":
                case "مدن و اماكن":
                    txt_TypeBeneficiary.Visible = false;
                    txt_TypeCustomer.Visible = false;
                    txt_TypeDistenation.Visible = false;

                    lbl_TypeBeneficiary.Visible = false;
                    lbl_TypeCustomer.Visible = false;
                    lbl_TypeDistenation.Visible = false;
                    break;
                case "حالة الحركة":
                    txt_TypeBeneficiary.Visible = true;
                    txt_TypeCustomer.Visible = true;
                    txt_TypeDistenation.Visible = true;

                    lbl_TypeBeneficiary.Visible = true;
                    lbl_TypeCustomer.Visible = true;
                    lbl_TypeDistenation.Visible = true;
                    break;
            }
        }
        public List<Control> GetArrayBtn()
        {
            List<Control> controls = new List<Control>();
            controls.Add(btn_Add);
            controls.Add(btn_Save);
            controls.Add(btn_Delete);
            return controls;

        }


        private void btnexitapplication_Click(object sender, EventArgs e)
        { 
            this.Close();           
        }
        private void closeform(XtraTabControl tab_main,string namepage)
        {
            
        }

        private void btn_Loading_Click(object sender, EventArgs e)
        {
            try { 
            switch (_lb)
            {
                case "اقسام العتبة":
                    CLS.CLS_DEPARTMENTS ReadingDataDepart = new CLS.CLS_DEPARTMENTS();
                    DataTable DtDep = ReadingDataDepart.GettingData(Arraycontrol());
                    ReadingDataDepart.DGVdesign(DGV_Entry, DtDep);

                    break;
                case "مدن و اماكن":
                    CLS.CLS_DISTENATION ReadingDataDistenation = new CLS.CLS_DISTENATION();
                    DataTable DtDis = ReadingDataDistenation.GettingData(Arraycontrol());
                    ReadingDataDistenation.DGVdesign(DGV_Entry, DtDis);

                    break;
                case "حالة الحركة":
                    CLS.CLS_THETYPE ReadingDataType = new CLS.CLS_THETYPE();
                    DataTable DtType = ReadingDataType.GettingData(ArraycontrolType());
                    ReadingDataType.DGVdesign(DGV_Entry, DtType);
                    break;

            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public  List<Control> Arraycontrol()
        {
            List<Control> controls = new List<Control>();
            controls.Add(IDtxt);
            controls.Add(Nametxt);
           
            return controls;
        }

        public List<Control> ArraycontrolType()
        {
            List<Control> controls = new List<Control>();
            controls.Add(IDtxt);
            controls.Add(Nametxt);
            controls.Add(txt_TypeDistenation);
            controls.Add(txt_TypeBeneficiary);
            controls.Add(txt_TypeCustomer);

            return controls;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد تاكيد عملية الاضافة", "اضافة جديد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                switch (_lb)
                {
                    case "اقسام العتبة":

                        CLS.CLS_DEPARTMENTS InsertDataDepart = new CLS.CLS_DEPARTMENTS();
                        DataTable DtMaxDep = InsertDataDepart.GetDepartmentID();
                        List<Control> controlsDep = Arraycontrol();
                        foreach (Control item in controlsDep)
                        {
                            item.Text = "";
                        }
                        IDtxt.Text = DtMaxDep.Rows[0][0].ToString();
                        InsertDataDepart.insertData(Arraycontrol());

                        break;
                    case "مدن و اماكن":
                        CLS.CLS_DISTENATION InsertDistenation = new CLS.CLS_DISTENATION();
                        DataTable DtMaxDis = InsertDistenation.GetDistenationID();
                        List<Control> controlsDis = Arraycontrol();
                        foreach (Control item in controlsDis)
                        {
                            item.Text = "";
                        }
                        IDtxt.Text = DtMaxDis.Rows[0][0].ToString();
                        InsertDistenation.insertData(Arraycontrol());


                        break;
                    case "حالة الحركة":
                        CLS.CLS_THETYPE InsertDataType = new CLS.CLS_THETYPE();
                        DataTable DtMaxType = InsertDataType.GetTheTypeID();
                        List<Control> controlsType = ArraycontrolType();
                        foreach (Control item in controlsType)
                        {
                            item.Text = "";
                        }
                        IDtxt.Text = DtMaxType.Rows[0][0].ToString();
                        InsertDataType.insertData(ArraycontrolType());

                        break;

                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحفظ", "عملية حفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                switch (_lb)
                {
                    case "اقسام العتبة":

                        CLS.CLS_DEPARTMENTS UpdateDataDepart = new CLS.CLS_DEPARTMENTS();
                        UpdateDataDepart.updateData(Arraycontrol());
                        DataTable DtDep = UpdateDataDepart.GettingData(Arraycontrol());
                        UpdateDataDepart.DGVdesign(DGV_Entry, DtDep);

                        break;
                    case "مدن و اماكن":
                        CLS.CLS_DISTENATION UpdatetDistenation = new CLS.CLS_DISTENATION();
                        UpdatetDistenation.updateData(Arraycontrol());
                        DataTable DtDis = UpdatetDistenation.GettingData(Arraycontrol());
                        UpdatetDistenation.DGVdesign(DGV_Entry, DtDis);

                        break;
                    case "حالة الحركة":
                        CLS.CLS_THETYPE UpdateDataType = new CLS.CLS_THETYPE();
                        UpdateDataType.updateData(ArraycontrolType());
                        DataTable DtType = UpdateDataType.GettingData(ArraycontrolType());
                        UpdateDataType.DGVdesign(DGV_Entry, DtType);
                        break;

                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try { 
            DialogResult dr = MessageBox.Show("هل تريد بالتاكيد عملية الحذف", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                switch (_lb)
                {
                    case "اقسام العتبة":

                        CLS.CLS_DEPARTMENTS DeleteDataDepart = new CLS.CLS_DEPARTMENTS();
                        DeleteDataDepart.deleteData(Arraycontrol());
                        DataTable DtDep = DeleteDataDepart.GettingData(Arraycontrol());
                        DeleteDataDepart.DGVdesign(DGV_Entry, DtDep);

                        break;
                    case "مدن و اماكن":
                        CLS.CLS_DISTENATION DeleteDistenation = new CLS.CLS_DISTENATION();
                        DeleteDistenation.deleteData(Arraycontrol());
                        DataTable DtDis = DeleteDistenation.GettingData(Arraycontrol());
                        DeleteDistenation.DGVdesign(DGV_Entry, DtDis);

                        break;
                    case "حالة الحركة":

                        CLS.CLS_THETYPE DeleteDataType = new CLS.CLS_THETYPE();
                        DeleteDataType.deleteData(ArraycontrolType());
                        DataTable DtType = DeleteDataType.GettingData(ArraycontrolType());
                        DeleteDataType.DGVdesign(DGV_Entry, DtType);
                        break;
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
      
    }
}
