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

            //int num = -100;
            //string name = "300";

            ////name = num;

            //name = num.ToString();
            //name = 400.ToString();

            ////num = name;

            //num = int.Parse(name);
            //num = int.Parse("200");
            //num = int.Parse("abc");

            var name = "Jongho";
            var num = 1000;
            var one_char = 'A';
            float flt = 5654316532133.687f;
            var db = 6532132141865154165151555d;

            jongho_box.Text += name.GetType();
            jongho_box.Text += "\r\n";
            jongho_box.Text += num.GetType();
            jongho_box.Text += "\r\n";
            jongho_box.Text += one_char.GetType();
            jongho_box.Text += "\r\n";
            jongho_box.Text += flt.GetType();
            jongho_box.Text += "\r\n";
            jongho_box.Text += db.GetType();

           
           
            jongho_box.Text += "\r\n";

            AddVoid(1,2);

            name = num.ToString();
            name = 400.ToString();

        }

        void AddVoid(int x, int y)
        {
            int a = x;
            int b = y;
            int result = a + b;
            jongho_box.Text = result.ToString();
        }

       

    }
}
