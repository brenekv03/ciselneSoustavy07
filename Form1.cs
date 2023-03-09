using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciselneSoustavy07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
        }
        static private string BinToHex(string bin)
        {
            int kolikChybi = bin.Length % 4;
            if (kolikChybi == 1) bin = "000" + bin;
            else if (kolikChybi == 2) bin = "00" + bin;
            else if (kolikChybi == 3) bin = "0" + bin;
            for(int i =0;i<bin.Length;i+=4)
            {

            }
        }
    }
}
