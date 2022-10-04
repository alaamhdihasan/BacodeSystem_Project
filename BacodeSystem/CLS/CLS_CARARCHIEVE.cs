using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI.WinForms;

namespace BacodeSystem.CLS
{
    class CLS_CARARCHIEVE
    {
        GunaTextBox Arch_ID;
        GunaTextBox Arch_IDcon;
        GunaTextBox Arch_CarNo;
        GunaTextBox Arch_pathimage;
        GunaTextBox Arch_registername;
        GunaTextBox Arch_TimeAdding;
        GunaTextBox Arch_DateAdding;

        string CarsArchieveTable = "CarArchieve";
        string CarsArchieveGetter = "CarArchieve_Getter";
        string CarsArchieveGetter2 = "CarArchieve_Getter2";
        string CarsArchieveSetter = "CarArchieve_Setter";
        string CarsArchieveUpdatter = "CarArchieve_Updatter";
        string CarsArchieveDeletter = "CarArchieve_Deletter";
        string MaxCarsArchieveID = "CarArchieve_ID";



        public DataTable GettingData(List<Control> controls,ListView listView)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls,CarsArchieveGetter2);
            DataTable Dt2 = GettingData.ReadDataSP2(CarsArchieveTable);
            

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                imageList.Images.Add(Bitmap.FromFile(Dt.Rows[i][3].ToString()));
            }
            listView.Clear();
            listView.LargeImageList = imageList;
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                listView.Items.Add(Dt.Rows[i][3].ToString(), i);
            }
            listView.View = View.LargeIcon;
            return Dt;

        }
        public DataTable GetCarsArchieveID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxCarsArchieveID);
            return Dt;

        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarsArchieveSetter);

        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarsArchieveUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarsArchieveDeletter);
        }

        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Arch_ID);
            controls.Add(Arch_IDcon);
            controls.Add(Arch_CarNo);
            controls.Add(Arch_pathimage);
            controls.Add(Arch_registername);
            controls.Add(Arch_TimeAdding);
            controls.Add(Arch_DateAdding); 

            return controls;

        }


    }
}
