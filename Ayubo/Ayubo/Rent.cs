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

namespace Ayubo
{
    public partial class Rent : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=Ayubo;");
        Calculation calculator;
        public Rent()
        {
            InitializeComponent();
            this.calculator = new Calculation();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            load();
            FillCombo();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (textBoxStartingdate.Text == String.Empty || EndingDate.Text == String.Empty || VehicleNo.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtRent.Text = this.calculator.rent_calculation(int.Parse(VehicleNo.SelectedItem.ToString()), int.Parse(textBoxStartingdate.Text), int.Parse(EndingDate.Text), checkBoxDriver.Checked).ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.Clearall();
        }

        private void Clearall()
        {
            txtRent.Clear();
            textBoxStartingdate.Clear();
            EndingDate.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            if (textBoxStartingdate.Text == String.Empty || EndingDate.Text == String.Empty || VehicleNo.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double amount = this.calculator.rent_calculation(int.Parse(VehicleNo.SelectedItem.ToString()), int.Parse(textBoxStartingdate.Text), int.Parse(EndingDate.Text), checkBoxDriver.Checked);
                txtRent.Text = amount.ToString();
                String sql = "INSERT INTO rent (VehicleNo, StartingDate, EndingDate, Driver,CalculatedRent) VALUES (@no, @sdate,@edate,@driver,@rent)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@rent", amount);
                cmd.Parameters.AddWithValue("@no", int.Parse(VehicleNo.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@sdate", int.Parse(textBoxStartingdate.Text));
                cmd.Parameters.AddWithValue("@edate", int.Parse(EndingDate.Text));
                cmd.Parameters.AddWithValue("@driver", checkBoxDriver.Checked);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Calculated Rent Added successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                Clearall();
            }
        }

        private void FillCombo()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT VehicleNo FROM vehicle";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VehicleNo.Items.Add(reader.GetString("VehicleNo"));
                }


            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void load()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT * FROM rent";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                RentGridView.DataSource = dt;


            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }


}
