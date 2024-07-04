using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceDataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int num = -100;
            string name = "300";

            //name = num;

            name = num.ToString();
            name = 400.ToString();


        }
    }
}
