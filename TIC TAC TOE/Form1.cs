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
                box1.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box1.Text = "O";
            }
        }

        private void box2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box2.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box2.Text = "O";
            }
        }

        private void box3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box3.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box3.Text = "O";
            }
        }

        private void box4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box4.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box4.Text = "O";
            }
        }

        private void box5_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box5.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box5.Text = "O";
            }
        }

        private void box6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box6.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box6.Text = "O";
            }
        }

        private void box7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box7.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box7.Text = "O";
            }
        }

        private void box8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box8.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box8.Text = "O";
            }
        }

        private void box9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box9.Text = "X";
            }
            if (e.Button == MouseButtons.Right)
            {
                box9.Text = "O";
            }
        }
    }
}
