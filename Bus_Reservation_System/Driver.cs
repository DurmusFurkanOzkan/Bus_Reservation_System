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
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Bus Reservation System;Integrated Security=True");
        private void button14_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand command = new SqlCommand("insert into Driver (Name,Surname,National_Identity_Number,Telephone_Number,Mail_Address) values(@p1,@p2,@p3,@p4,@p5)", connection);
            command.Parameters.AddWithValue("@p1", txt_name.Text);
            command.Parameters.AddWithValue("@p2", txt_surname.Text);
            command.Parameters.AddWithValue("@p3", msk_national_id.Text);
            command.Parameters.AddWithValue("@p4", msk_telephone.Text);
            command.Parameters.AddWithValue("@p5", txt_mail_address.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Driver Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
