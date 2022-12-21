using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoZeroUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //defin ur bools here
        bool Z1Menu = true;


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Slidemation.Start();
        }

        private void Slidemation_Tick(object sender, EventArgs e)
        {
            if (Z1Menu)
            {
                Z1.Width -= 5;
                Z1.Left -= 5;
                Z1.Width -= 5;
                if (Z1.Width <= 0)
                {

                    Slidemation.Stop();
                    Z1Menu = false; //false is closed
                }
            }
            else if (!Z1Menu)
            {
                Z1.Width += 5;
                Z1.Left += 5;
                Z1.Width += 5;
                if (Z1.Width >= 558)
                {
                    Slidemation.Stop();
                    Z1Menu = true; //true open
                }
            }
         

        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("make this yourself, use the demo above.","ZeroDemoUI");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("make this yourself, use the demo above.", "ZeroDemoUI");
        }
    }
}
