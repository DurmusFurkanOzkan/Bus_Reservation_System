using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bus_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Bus Reservation System;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Admin where Account_number=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", txt_account_number.Text);
            command.Parameters.AddWithValue("@p2", txt_password.Text);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
