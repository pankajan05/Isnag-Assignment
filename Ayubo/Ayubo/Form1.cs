﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayubo
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            package.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VehicleType vehicletype = new VehicleType();
            vehicletype.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hire hire = new Hire();
            hire.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
            this.Hide();
        }
    }
}
