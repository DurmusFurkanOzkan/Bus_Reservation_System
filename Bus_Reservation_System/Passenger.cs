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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Bus Reservation System;Integrated Security=True");
        private void button13_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Passenger (Name,Surname,National_Identity_Number,Telephone_Number,Gender,Mail_Address) values(@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txt_name.Text);
            command.Parameters.AddWithValue("@p2", txt_surname.Text);
            command.Parameters.AddWithValue("@p3", msk_national_id.Text);
            command.Parameters.AddWithValue("@p4", msk_telephone_number.Text);
            command.Parameters.AddWithValue("@p5", cmb_gender.Text);
            command.Parameters.AddWithValue("@p6", txt_mail_address.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Passenger Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
