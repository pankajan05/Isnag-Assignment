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
    public partial class Hire : Form
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=Ayubo;");
        Calculation calculator = new Calculation();
        String type;
        public Hire()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void CalculateDayCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxStartingdate.Text == String.Empty || textBoxEndingDate.Text == String.Empty || textBoxStartKm.Text == String.Empty || textBoxEndKm.Text == String.Empty || Packagetype.SelectedItem.ToString() == String.Empty || VehicleNo.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                type = "day tour";
                Dictionary<string, double> d = new Dictionary<string, double>();
                d = this.calculator.day_tour_calculation(int.Parse(VehicleNo.SelectedItem.ToString()), Packagetype.SelectedItem.ToString(), double.Parse(textBoxStartingdate.Text), double.Parse(textBoxEndingDate.Text), int.Parse(textBoxStartKm.Text), int.Parse(textBoxEndKm.Text));
                l_amount.Text = d["base_hire_charge"].ToString() + " + " + d["extra_km_charge"].ToString() +" + "+ d["waiting_charge"].ToString();
            }
        }

        private void buttonLongCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxStartingdate.Text == String.Empty || textBoxEndingDate.Text == String.Empty || textBoxStartKm.Text == String.Empty || textBoxEndKm.Text == String.Empty || Packagetype.SelectedItem.ToString() == String.Empty || VehicleNo.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                type = "long tour";
                Dictionary<string, double> d = new Dictionary<string, double>();
                d = this.calculator.long_tour_calculation(int.Parse(VehicleNo.SelectedItem.ToString()), Packagetype.SelectedItem.ToString(), int.Parse(textBoxStartingdate.Text), int.Parse(textBoxEndingDate.Text), int.Parse(textBoxStartKm.Text), int.Parse(textBoxEndKm.Text));
                l_amount.Text = d["base_hire_charge"].ToString() +" + "+ d["extra_km_charge"].ToString() +" + "+ d["overnight_stay_charge"].ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.clearinput();
        }

        private void clearinput()
        {
            l_amount.Text = "0.00";
            textBoxStartingdate.Clear();
            textBoxEndingDate.Clear();
            textBoxEndKm.Clear();
            textBoxStartKm.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (textBoxStartingdate.Text == String.Empty || textBoxEndingDate.Text == String.Empty || textBoxStartKm.Text == String.Empty || textBoxEndKm.Text == String.Empty || Packagetype.SelectedItem.ToString() == String.Empty || VehicleNo.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "INSERT INTO hire (VehicleNo,Package, StartingDate, EndingDate, StartingKm, EndingKm, Type,Amount) VALUES (@no, @package, @sdate,@edate,@skm,@ekm,@type, @amount)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@amount", l_amount.Text);
                cmd.Parameters.AddWithValue("@no", int.Parse(VehicleNo.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@package", Packagetype.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@sdate", int.Parse(textBoxStartingdate.Text));
                cmd.Parameters.AddWithValue("@edate", int.Parse(textBoxEndingDate.Text));
                cmd.Parameters.AddWithValue("@skm", int.Parse(textBoxStartKm.Text));
                cmd.Parameters.AddWithValue("@ekm", int.Parse(textBoxEndKm.Text));
                cmd.Parameters.AddWithValue("@type", type);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Calculated Hire Added successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clearinput();
            }
        }

        private void Hire_Load(object sender, EventArgs e)
        {
            FillCombo();
            load();
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

            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT package_Name FROM package";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Packagetype.Items.Add(reader.GetString("package_Name"));
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
                String sql = "SELECT * FROM hire";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                HireGridView.DataSource = dt;


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
