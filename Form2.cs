﻿using System;
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
    public partial class Form2 : Form
    {
        private int TeacherID;
        private string TeacherName;

        public Form2(int teacherID, string teacherName)
        {
            InitializeComponent();
            timerDateAndTime.Start();
            TeacherID = teacherID;
            TeacherName = teacherName;

            // Display the welcome message
            lblWelcome.Text = $"Welcome, {TeacherName}!";
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSection fadd = new FormAddSection();
            fadd.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration student = new StudentRegistration();
            student.Show();
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance atten = new attendance();
            atten.Show();
        }
    }
}
