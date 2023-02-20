using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_OOP_KTA22V
{
    public partial class Form_2023_01_26 : Form
    {
        int w, h;
        int x1, y1, x2, y2;
        Image pic = null;
        public Form_2023_01_26()
        {
            InitializeComponent();
            w = AN_pic1.Width;
            h = AN_pic1.Height;
        }

        private void AN_Open_Click(object sender, EventArgs e)
        {
            AN_openFileDialog.Filter = "Image files|*.jpg;*.png;*.BMP|All files|*.*";
            AN_openFileDialog.FileName = "";
            AN_openFileDialog.ShowDialog();
            string fn = AN_openFileDialog.FileName;
            AN_Frame1.Text = fn;
            pic = Image.FromFile(fn);
            AN_pic1.Image = pic;
        }

        private void AN_rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            AN_pic1.Width = w;
            AN_pic1.Height = h;
            AN_pic1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void AN_rbtn2_CheckedChanged(object sender, EventArgs e)
        {

            AN_pic1.Width = w;
            AN_pic1.Height = h;
            AN_pic1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AN_rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            AN_pic1.SizeMode = PictureBoxSizeMode.AutoSize;
        }



        private void AN_rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            AN_pic1.Width = w;
            AN_pic1.Height = h;
            AN_pic1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void AN_rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            AN_pic1.Width = w;
            AN_pic1.Height = h;
            AN_pic1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        

        private void AN_pic1_Click(object sender, EventArgs e)
        {

        }

        private void AN_pic1_MouseDown(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left" || pic == null) return;
            Point p = AN_Koordinaty(e.X, e.Y);
            x1 = x2 = p.X;
            y1 = y2 = p.Y;
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
        }
        private void AN_pic1_MouseMove(object sender, MouseEventArgs e)
        {
            string t = e.Button.ToString();
            if (t != "Left" || pic == null) return;
            Point p = AN_Koordinaty(e.X, e.Y);
            x2 = p.X;
            y2 = p.Y;
            label2.Text = e.X.ToString();
            label3.Text = e.Y.ToString();
            AN_Draw_Rectangle(Color.Red, 3);

        }
        private void AN_Draw_Rectangle(Color c, int tol)  // tol-tolshina
        {
            Bitmap bm = new Bitmap(pic);
            Graphics gr = Graphics.FromImage(bm);
            Pen pencil = new Pen (c, tol);
            int x0 = Math.Min(x1, x2);
            int y0= Math.Min(y1, y2);
            int dx = Math.Abs (x2 - x1);
            int dy = Math.Abs(y2 - y1);
            gr.DrawRectangle(pencil, x0, y0, dx, dy);
            AN_pic1.Image = bm;
             

        }
        private void AN_pic1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private Point AN_Koordinaty(int x, int y)
        {
            Point pp = new Point(0, 0);
            if (AN_rbtn1.Checked || AN_rbtn3.Checked)
            {
                pp.X = x;
                pp.Y = y;
            }
            else if (AN_rbtn4.Checked)
            {
                int dx = (AN_pic1.Width - pic.Width) / 2;
                int dy = (AN_pic1.Height - pic.Height) / 2;
                pp.X = x - dx;
                pp.Y = y - dy;
            }
            else if (AN_rbtn2.Checked)
            {
                float kx = (float)pic.Width / AN_pic1.Width;
                float ky = (float)pic.Height / AN_pic1.Height;

                pp.X = (int)(x * kx);
                pp.Y = (int)(y * ky);
            }
            else if (AN_rbtn5.Checked)
            {
                pp.X = x;
                pp.Y = y;
            }

                return pp;
        }
    }
}
