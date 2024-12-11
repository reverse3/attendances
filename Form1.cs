using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;

namespace Attendance
{
	public partial class Form1 : Form

	{
		public DataGridViewRow row = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void panelback_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=grandby_db";
				MySqlConnection con = new MySqlConnection();
				con.ConnectionString = connstring;
				con.Open();

				string sql = "Select * from grandby_db.Attendance";
				MySqlCommand cmd2 = new MySqlCommand(sql, con);
				MySqlDataReader dr = cmd2.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(dr);
				dataGridView1.DataSource = dt;
				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message); 
				Console.WriteLine(ex.ToString()); 
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string connstring = "server=localhost;uid=root;database=grandby_db";
				MySqlConnection con = new MySqlConnection();
				con.ConnectionString = connstring;
				con.Open();


				string sqlInsert = "INSERT INTO `attendance` (`AttendanceID`,`Name`, `Status`, `Date`) VALUES ('"+textBox1.Text+"','"+textBox3.Text+"', '"+textBox2.Text+"', '"+DTPICK1.Value+"');";
				MySqlCommand cmd = new MySqlCommand(sqlInsert, con);
				int value = cmd.ExecuteNonQuery();
				if (value > 0)
				{
					MessageBox.Show("Success!");

					string sql = "SELECT * FROM attendance;";
					MySqlCommand cmd1 = new MySqlCommand(sql, con);
					MySqlDataReader dr = cmd1.ExecuteReader();
					DataTable dt1 = new DataTable();
					dt1.Load(dr);
					dataGridView1.DataSource = dt1;
					con.Close();
				}
				else
				{
					MessageBox.Show("Error!");
				}

				
			}
			catch (Exception) 
			{
				
			}
		}

		private void datatbl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Form1_Shown(object sender, EventArgs e)
		{

			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=grandby_db";
				MySqlConnection con = new MySqlConnection();
				con.ConnectionString = connstring;
				con.Open();
				

				string sql = "SELECT * FROM attendance;";
				MySqlCommand cmd = new MySqlCommand(sql, con);
				MySqlDataReader dr = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(dr);
				dataGridView1.DataSource= dt;
				con.Close() ;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message); 
				Console.WriteLine(ex.ToString()); 
			}

		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void label4_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				string connstring = "server=localhost;uid=root;pwd=;database=grandby_db";
				MySqlConnection con = new MySqlConnection();
				con.ConnectionString = connstring;
				con.Open();

				string sqlUpdate = "UPDATE `attendance` SET `AttendanceID`='" + textBox1.Text + "',`Name`='" + textBox3.Text + "',`Status`='" + textBox2.Text + "',`Date`='" + DTPICK1.Value + "' WHERE `AttendanceID` =" + textBox1.Text + ";";
				MySqlCommand cmd1 = new MySqlCommand(sqlUpdate, con);

				int val = cmd1.ExecuteNonQuery();

				if (val > 0)
				{
					MessageBox.Show("Success!");
					
				}
				else
				{
					MessageBox.Show("Error!");
				}
				string sql = "SELECT * FROM attendance;";
				MySqlCommand cmd2 = new MySqlCommand(sql, con);
				MySqlDataReader dr = cmd2.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(dr);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception)
			{
				
			}
		}   

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				row = this.dataGridView1.Rows[e.RowIndex];
				textBox1.Text = row.Cells["AttendanceID"].Value.ToString();
				textBox3.Text = row.Cells["Name"].Value.ToString();
				textBox2.Text = row.Cells["Status"].Value.ToString();


			}
		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}
		
		private void button4_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();

			form3.Show();
            this.Hide();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
