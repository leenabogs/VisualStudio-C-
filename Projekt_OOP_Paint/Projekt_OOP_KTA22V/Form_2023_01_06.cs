using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_OOP_KTA22V
{
    public partial class Form_2023_01_06 : Form
    {
        
        public Form_2023_01_06()
        {
            InitializeComponent();
            AN_lbl1.Text = "Start";
        }

        private void AN_txt1_TextChanged(object sender, EventArgs e)
        {
            string t = AN_txt1.Text;
            string tt = "";
            for (int i=0; i<t.Length; i++)
            {
                string s = t[i].ToString();
                if (i % 2 == 0)
                    tt = tt + s.ToUpper();
                else
                    tt = tt + s.ToLower();
            }
            AN_lbl1.Text = tt;

            tt = "";
            for (int i = 0; i < t.Length; i++)
            {
                string s = t[i].ToString();
                tt = s+tt;
            }
            AN_lbl2.Text = tt;

        }
    }
}
