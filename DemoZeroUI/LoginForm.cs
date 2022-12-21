using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoZeroUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagine Trying To Maximize lol","DemoZeroUI");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        string username = "test";
        string password = "1234";

        Main mainhitler = new Main();

        WebClient webclientsender = new WebClient();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == webclientsender.DownloadString("https://raw.githubusercontent.com/0xFXDE/DemoZeroUI/main/Username"))
            {
                if (textBox2.Text == webclientsender.DownloadString("https://raw.githubusercontent.com/0xFXDE/DemoZeroUI/main/password"))
                {
                    mainhitler.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password, imagine not knowing ur password lmfao...", "DemoZeroUI");
                }
            }
            //sexy ass authentication that everyone should use right right
            else if (textBox1.Text == username && textBox2.Text == password)
            {
                mainhitler.Show();
            }
            else
            {
                MessageBox.Show("Hitler coming for your ass", "DemoZeroUI");
            }

        }
    }
}
