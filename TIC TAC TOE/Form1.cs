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
        bool next = true;
        int next_c = 0;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        //gusto ko gumawa ng button or function na makakapag-disable ng button 
        //once na maclick siya kelangan right button muna bago mag left ulit
        //button click nalang huh
        

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      
        private void box_Click(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            if (next)
                box.Text = "X";
            else
                box.Text = "O";

            next = !next;
            box.Enabled = false;
            next_c++;
            hindi_ligwak();
        }





        private void hindi_ligwak()
        {
        // MALI TO HUHU
         bool hindi_ligwak = false;



        //vertical

        if ((box1.Text == box4.Text) && (box4.Text == box7.Text) && (!box1.Enabled))
            hindi_ligwak = true;
        if ((box2.Text == box5.Text) && (box5.Text == box8.Text) && (!box2.Enabled))
            hindi_ligwak = true;
        if ((box3.Text == box6.Text) && (box6.Text == box9.Text) && (!box3.Enabled))
            hindi_ligwak = true;

         //if (hindi_ligwak)
            //  MessageBox.Show("Yehey!");

            //diagonal 

            if ((box1.Text == box5.Text) && (box5.Text == box9.Text) && (!box1.Enabled))
                hindi_ligwak = true;
            if ((box3.Text == box5.Text) && (box5.Text == box7.Text) && (!box7.Enabled))
                hindi_ligwak = true;

            //if (hindi_ligwak)
            //  MessageBox.Show("Yehey!");


            //horizontal
            if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && (!box1.Enabled))
            hindi_ligwak = true;
        if ((box4.Text == box5.Text) && (box5.Text == box6.Text) && (!box4.Enabled))
            hindi_ligwak = true;
        if ((box7.Text == box8.Text) && (box8.Text == box9.Text) && (!box7.Enabled))
            hindi_ligwak = true;

        //if (hindi_ligwak)
              //  MessageBox.Show("Yehey!");



            if (hindi_ligwak)
            {
                disableBox();

                string panalo = "";
                if (next)
                    panalo = "O";
                else
                    panalo = "X";

                MessageBox.Show(panalo + " ang panalo!");
            }
          //  else
            {
                if(next_c == 9)
                    MessageBox.Show("Tabla");
            }

       
    }
        private void disableBox()
        {   
            try
            {
                foreach (Control c in Controls)
                {
                    Button box = (Button)c;
                    box.Enabled = false;
                }
            }
            catch { }
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



    }

        
    
}
