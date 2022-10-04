using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.CLS
{
    class CLS_CARFUELARCHIVE
    {
        GunaTextBox Arch_ID;
        GunaTextBox Arch_IDcon;
        GunaTextBox Arch_pathimage;
        GunaTextBox Arch_registername;
        GunaTextBox Arch_TimeAdding;
        GunaTextBox Arch_DateAdding;

        string CarsFuelArchieveTable = "CarFuelArchive";
        string CarsFuelArchieveGetter = "CarFuelArchieve_GetterAll";
        string CarsFuelArchieveGetter2 = "CarFuelArchieve_Getter";
        string CarsFuelArchieveSetter = "CarFuelArchieve_Setter";
        string CarsFuelArchieveUpdatter = "CarFuelArchieve_Updatter";
        string CarsFuelArchieveDeletter = "CarFuelArchieve_Deletter";
        string MaxFuelCarsArchieveID = "CarFuelArchieve_ID";

        public DataTable GettingData(List<Control> controls, ListView listView)
        {
            DAL.CRUD GettingData = new DAL.CRUD();
            DataTable Dt = GettingData.ReadingData(controls, CarsFuelArchieveGetter2);
            DataTable Dt2 = GettingData.ReadDataSP2(CarsFuelArchieveTable);


            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                imageList.Images.Add(Bitmap.FromFile(Dt.Rows[i][2].ToString()));
            }
            listView.Clear();
            listView.LargeImageList = imageList;
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                listView.Items.Add(Dt.Rows[i][2].ToString(), i);
            }
            listView.View = View.LargeIcon;
            return Dt;
        }

        public DataTable GetCarsArchieveID()
        {
            DAL.CRUD maxid = new DAL.CRUD();
            DataTable Dt = maxid.ReadData(MaxFuelCarsArchieveID);
            return Dt;
        }

        public void insertData(List<Control> controls)
        {
            DAL.CRUD insertdata = new DAL.CRUD();
            insertdata.ExecuteData(controls, CarsFuelArchieveSetter);
        }

        public void updateData(List<Control> controls)
        {
            DAL.CRUD updatedata = new DAL.CRUD();
            updatedata.ExecuteData(controls, CarsFuelArchieveUpdatter);
        }

        public void deleteData(List<Control> controls)
        {
            DAL.CRUD deleteData = new DAL.CRUD();
            deleteData.ExecuteData(controls, CarsFuelArchieveDeletter);
        }

        public List<Control> GetArray()
        {
            List<Control> controls = new List<Control>();
            controls.Add(Arch_ID);
            controls.Add(Arch_IDcon);
            controls.Add(Arch_pathimage);
            controls.Add(Arch_registername);
            controls.Add(Arch_TimeAdding);
            controls.Add(Arch_DateAdding);

            return controls;
        }
    }
}
