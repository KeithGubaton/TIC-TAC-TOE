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
        //bool hatdog = true;
        //int hatdog_c = 0;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        //gusto ko gumawa ng button or function na makakapag-disable ng button 
        // once na maclick siya kelangan right button muna bago mag left ulit
        
        private void box1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box1.Text = "X";
                if ((box1.Text == "X"))
                {
                    box1.Enabled = false;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                box1.Text = "O";
                if ((box1.Text == "O"))
                {
                    box1.Enabled = false;
                }
            }
            
        }
      
        private void box2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                box2.Text = "X";
                if ((box2.Text == "X"))
                {
                    box2.Enabled = false;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                box2.Text = "O";
                if ((box2.Text == "O"))
                {
                    box2.Enabled = false;
                }
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
            box3.Enabled = false;

            //hindi_ligwak();
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
            box4.Enabled = false;
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
            box5.Enabled = false;
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
            box6.Enabled = false;

            //hindi_ligwak();
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
            box7.Enabled = false;
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
            box8.Enabled = false;
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
            box9.Enabled = false;
            //hindi_ligwak();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       

        //private void hindi_ligwak()
        //{
            // MALI TO HUHU
           // bool hindi_ligwak = false;


            //diagonal 

            //if ((box1.Text == box5.Text) && (box5.Text == box9.Text))
            //    hindi_ligwak = true;
            //if ((box3.Text == box5.Text) && (box5.Text == box7.Text))
            //   hindi_ligwak = true;

            //if (hindi_ligwak)
            //    MessageBox.Show("Yehey!");
           

            //vertical

            //if ((box1.Text == box4.Text) && (box4.Text == box7.Text))
            //    hindi_ligwak = true;
            //if ((box2.Text == box5.Text) && (box5.Text == box8.Text))
            //    hindi_ligwak = true;
            //if ((box3.Text == box6.Text) && (box6.Text == box9.Text))
            //   hindi_ligwak = true;

            //if (hindi_ligwak)
            //    MessageBox.Show("Yehey!");
            

            //horizontal
            //if ((box1.Text == box2.Text) && (box2.Text == box3.Text))
            //    hindi_ligwak = true;
            //if ((box4.Text == box5.Text) && (box5.Text == box6.Text))
            //    hindi_ligwak = true;
            //if ((box7.Text == box8.Text) && (box8.Text == box9.Text))
            //    hindi_ligwak = true;

            //if (hindi_ligwak)
            //   MessageBox.Show("Yehey!");
            
        }
        //paano ako gagawa ng case by case huhuhuhuhu


        //private void panalo()
        //horizontal

        //



    //}

        
    
}
