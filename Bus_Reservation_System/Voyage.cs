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
    public partial class Voyage : Form
    {
        public Voyage()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Bus Reservation System;Integrated Security=True");
        private void button15_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Voyage (Departure_point,Destination,Date,Time,Driver,Price) values(@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", txt_departure.Text);
            command.Parameters.AddWithValue("@p2", txt_destination.Text);
            command.Parameters.AddWithValue("@p3", msk_date.Text);
            command.Parameters.AddWithValue("@p4", msk_time.Text);
            command.Parameters.AddWithValue("@p5", cmb_driver.SelectedValue);
            command.Parameters.AddWithValue("@p6", int.Parse(txt_price.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Voyage Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Voyage_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Driver", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add(
            "FullName",
            typeof(string),
            "Name + ' ' + Surname");
            cmb_driver.ValueMember = "ID";
            cmb_driver.DisplayMember = "FullName";
            cmb_driver.DataSource = dt;
        }
    }
}
