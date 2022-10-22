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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-48MHJFV;Initial Catalog=Bus Reservation System;Integrated Security=True");
        
        bool flag = false;

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bus_Reservation_SystemDataSet.Voyage' table. You can move, or remove it, as needed.
            this.voyageTableAdapter.Fill(this.bus_Reservation_SystemDataSet.Voyage);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            connection.Open();
            int count = 0;
            int count2 = 0;
            SqlCommand command1 = new SqlCommand("Select * from Passenger", connection);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                if (!dr1[3].ToString().Equals(msk_national_number.Text))
                {
                    count++;
                }
                count2++;
            }
            if(count!=count2-1)
            {
                MessageBox.Show("You are not signed in Bus Reservation System! Please Sign in", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
                return;
            }
            connection.Close();

            connection.Open();
            SqlCommand command = new SqlCommand("Select seat1,seat2,seat3,seat4,seat5,seat6,seat7,seat8,seat9,seat10,seat11 from Voyage where ID=@p1",connection);
            command.Parameters.AddWithValue("@p1", txt_voyage_id.Text);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                if (dr[0].ToString().Equals("True"))
                {
                    seat1.Enabled = false;
                }
                else
                {
                    seat1.Enabled = true;
                }
                if (dr[1].ToString().Equals("True"))
                {
                    seat2.Enabled = false;
                }
                else
                {
                    seat2.Enabled = true;
                }
                if (dr[2].ToString().Equals("True"))
                {
                    seat3.Enabled = false;
                }
                else
                {
                    seat3.Enabled = true;
                }
                if (dr[3].ToString().Equals("True"))
                {
                    seat4.Enabled = false;
                }
                else
                {
                    seat4.Enabled = true;
                }
                if (dr[4].ToString().Equals("True"))
                {
                    seat5.Enabled = false;
                }
                else
                {
                    seat5.Enabled = true;
                }
                if (dr[5].ToString().Equals("True"))
                {
                    seat6.Enabled = false;
                }
                else
                {
                    seat6.Enabled = true;
                }
                if (dr[6].ToString().Equals("True"))
                {
                    seat7.Enabled = false;
                }
                else
                {
                    seat7.Enabled = true;
                }
                if (dr[7].ToString().Equals("True"))
                {
                    seat8.Enabled = false;
                }
                else
                {
                    seat8.Enabled = true;
                }
                if (dr[8].ToString().Equals("True"))
                {
                    seat9.Enabled = false;
                }
                else
                {
                    seat9.Enabled = true;
                }
                if (dr[9].ToString().Equals("True"))
                {
                    seat10.Enabled = false;
                }
                else
                {
                    seat10.Enabled = true;
                }
                if (dr[10].ToString().Equals("True"))
                {
                    seat11.Enabled = false;
                }
                else
                {
                    seat11.Enabled = true;
                }
            }
            Seats.Visible = true;
            connection.Close();
            flag = true;
        }

        

        private void seat8_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 8);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat8=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat8.Enabled = false;
            }

        }

        private void seat2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 2);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat2=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat2.Enabled = false;
            }
        }

        private void seat3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 3);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat3=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat3.Enabled = false;
            }
        }
        private void seat4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 2);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat2=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat2.Enabled = false;
            }
        }
        private void seat5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 5);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat5=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat5.Enabled = false;
            }
        }

        private void seat6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 6);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat6=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat6.Enabled = false;
            }
        }

        private void seat7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 7);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat7=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat7.Enabled = false;
            }
        }

        private void seat1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 1);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat1=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat1.Enabled = false;
            }
        }

        private void seat9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 9);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat9=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat9.Enabled = false;
            }
        }

        private void seat10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 10);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat10=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat10.Enabled = false;
            }
        }

        private void seat11_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Shall we get a reservation for this seat?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("insert into Reservation (Voyage_Number,Seat_Number,National_Identity_Number) values(@p1,@p2,@p3)", connection);
                command1.Parameters.AddWithValue("@p1", int.Parse(txt_voyage_id.Text));
                command1.Parameters.AddWithValue("@p2", 11);
                command1.Parameters.AddWithValue("@p3", msk_national_number.Text);
                command1.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand("Update Voyage set seat11=@p1 where ID=@p2", connection);
                command.Parameters.AddWithValue("@p1", "True");
                command.Parameters.AddWithValue("@p2", int.Parse(txt_voyage_id.Text));
                command.ExecuteNonQuery();
                connection.Close();
                seat11.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txt_voyage_id.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            
        }
        
        private void txt_voyage_id_TextChanged(object sender, EventArgs e)
        {   if(flag)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select seat1,seat2,seat3,seat4,seat5,seat6,seat7,seat8,seat9,seat10,seat11 from Voyage where ID=@p1", connection);
                command.Parameters.AddWithValue("@p1", txt_voyage_id.Text);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString().Equals("True"))
                    {
                        seat1.Enabled = false;
                    }
                    else
                    {
                        seat1.Enabled = true;
                    }
                    if (dr[1].ToString().Equals("True"))
                    {
                        seat2.Enabled = false;
                    }
                    else
                    {
                        seat2.Enabled = true;
                    }
                    if (dr[2].ToString().Equals("True"))
                    {
                        seat3.Enabled = false;
                    }
                    else
                    {
                        seat3.Enabled = true;
                    }
                    if (dr[3].ToString().Equals("True"))
                    {
                        seat4.Enabled = false;
                    }
                    else
                    {
                        seat4.Enabled = true;
                    }
                    if (dr[4].ToString().Equals("True"))
                    {
                        seat5.Enabled = false;
                    }
                    else
                    {
                        seat5.Enabled = true;
                    }
                    if (dr[5].ToString().Equals("True"))
                    {
                        seat6.Enabled = false;
                    }
                    else
                    {
                        seat6.Enabled = true;
                    }
                    if (dr[6].ToString().Equals("True"))
                    {
                        seat7.Enabled = false;
                    }
                    else
                    {
                        seat7.Enabled = true;
                    }
                    if (dr[7].ToString().Equals("True"))
                    {
                        seat8.Enabled = false;
                    }
                    else
                    {
                        seat8.Enabled = true;
                    }
                    if (dr[8].ToString().Equals("True"))
                    {
                        seat9.Enabled = false;
                    }
                    else
                    {
                        seat9.Enabled = true;
                    }
                    if (dr[9].ToString().Equals("True"))
                    {
                        seat10.Enabled = false;
                    }
                    else
                    {
                        seat10.Enabled = true;
                    }
                    if (dr[10].ToString().Equals("True"))
                    {
                        seat11.Enabled = false;
                    }
                    else
                    {
                        seat11.Enabled = true;
                    }
                }
                Seats.Visible = true;
                connection.Close();
            }
            
        }
    }
}
