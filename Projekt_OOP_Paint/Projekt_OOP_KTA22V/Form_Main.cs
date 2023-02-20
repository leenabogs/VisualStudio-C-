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
    public partial class Form_Main : Form
    {
        Form F1 = new Form_2023_01_06();
        Form F2 = new Form_2023_01_26();

        public Form_Main()
        {
            InitializeComponent();
        }

        private void AN_btn1_Click(object sender, EventArgs e)
        {
            F1= new Form_2023_01_06();
            F1.Visible = true;
            AN_btn1.Enabled = false;
            F1.Activate();
        }

        private void AN_btn2_Click(object sender, EventArgs e)
        {
            if (F2.Visible==false)
            {
                F2 = new Form_2023_01_26();
                F2.Visible = true;
            }            
            F2.Activate();
        }
    }
}
