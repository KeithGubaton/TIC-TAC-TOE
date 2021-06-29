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
        T_Class game = new T_Class();
        public Form1()
        {
            InitializeComponent();
        }

        private void box_Click(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            if (game.Next)
                box.Text = "X";
            else
                box.Text = "O";

            game.Next = !game.Next;
            box.Enabled = false;
            game.Next_c++;

            hindi_ligwak();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void hindi_ligwak()
        {

            bool hindi_ligwak = false;

            //vertical

            if ((box1.Text == box4.Text) && (box4.Text == box7.Text) && (!box1.Enabled))
                hindi_ligwak = true;
            else if ((box2.Text == box5.Text) && (box5.Text == box8.Text) && (!box2.Enabled))
                hindi_ligwak = true;
            else if ((box3.Text == box6.Text) && (box6.Text == box9.Text) && (!box3.Enabled))
                hindi_ligwak = true;

            //horizontal
            if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && (!box1.Enabled))
                hindi_ligwak = true;
            else if ((box4.Text == box5.Text) && (box5.Text == box6.Text) && (!box4.Enabled))
                hindi_ligwak = true;
            else if ((box7.Text == box8.Text) && (box8.Text == box9.Text) && (!box7.Enabled))
                hindi_ligwak = true;

            //diagonal

            if ((box1.Text == box5.Text) && (box5.Text == box9.Text) && (!box1.Enabled))
                hindi_ligwak = true;
            else if ((box3.Text == box5.Text) && (box5.Text == box7.Text) && (!box7.Enabled))
                hindi_ligwak = true;

            if (hindi_ligwak)
            {
                disableBox();

                String panalo = "";
                if (game.Next)
                    panalo = "O";
                else
                    panalo = "X";

                MessageBox.Show(panalo + " ang panalo!");
            }
            else
            {
                if (game.Next_c == 9)
                    MessageBox.Show("Tabla");
            }
        }
        public void disableBox()
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
    }
}

