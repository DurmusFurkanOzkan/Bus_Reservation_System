using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Reservation_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "Add Passenger";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "Add Driver";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "Add Voyage";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Text = "Make Reservation";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Passenger psg = new Passenger();
            psg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Driver drv = new Driver();
            drv.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Voyage vyg = new Voyage();
            vyg.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Reservation rst = new Reservation();
            rst.Show();
        }
    }
}
