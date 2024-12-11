using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                string connstring = "Server=localhost;Database=granby_db;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    // SQL query to check if the user exists
                    string sqlLogin = "SELECT TeacherID, Name FROM user_account WHERE Username = @Username AND Password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(sqlLogin, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Text);
                        cmd.Parameters.AddWithValue("@Password", password.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())  // If the user is found
                            {
                                int teacherID = Convert.ToInt32(reader["TeacherID"]);
                                string teacherName = reader["Name"].ToString();

                                // Hide the login form
                                this.Hide();

                                // Open Form2 and pass the TeacherID and TeacherName
                                Form2 f2 = new Form2(teacherID, teacherName);
                                f2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid login credentials!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();


            this.Hide();
        }
    }
}
