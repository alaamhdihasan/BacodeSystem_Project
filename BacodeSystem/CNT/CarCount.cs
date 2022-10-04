using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacodeSystem.CNT
{
    public partial class CarCount : UserControl
    {
        public CarCount(string car, string count)
        {
            InitializeComponent();
            lbl_Car.Text = car;
            lbl_count.Text = count;
        }
    }
}
