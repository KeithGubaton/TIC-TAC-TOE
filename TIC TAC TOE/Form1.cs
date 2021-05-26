using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void box1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               object a = box1.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
               object a = box1.Text = "O";
            }
        }

        private void box2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object b = box2.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object b = box2.Text = "O";
            }
        }

        private void box3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object c = box3.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object c = box3.Text = "O";
            }
        }

        private void box4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object d = box4.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object d = box4.Text = "O";
            }
        }

        private void box5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object r = box5.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object r = box5.Text = "O";
            }
        }

        private void box6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object f = box6.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object f = box6.Text = "O";
            }
        }

        private void box7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                object g = box7.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                object g = box7.Text = "O";
            }
        }

        private void box8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               object h = box8.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
               object h = box8.Text = "O";
            }
        }

        private void box9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               object i = box9.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
               object i = box9.Text = "O";
            }
        }

        //paano ako gagawa ng case by case huhuhuhuhu

        
        //private void panalo()
            //horizontal
            

        
    }
}
