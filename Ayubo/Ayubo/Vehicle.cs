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
    public partial class Vehicle : Form
    {


        MySqlConnection con;
        int Id;

        public Vehicle()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty || comboBoxVehicleType.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "INSERT INTO vehicle (VehicleNo, VehicleType) VALUES (@no, @type)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@no", txtVehicleNo.Text);
                cmd.Parameters.AddWithValue("@type", comboBoxVehicleType.SelectedItem.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Vehicle Added successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }

        }


        


        private void load()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT * FROM vehicle";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                VehicleDataGridView.DataSource = dt;


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


        private void clear()
        {
            txtVehicleNo.Clear();
            Id = 0;
        }




        private void FillCombo()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT VehicleType FROM vehicletype";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    comboBoxVehicleType.Items.Add(reader.GetString("VehicleType"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            if (txtVehicleNo.Text == String.Empty || comboBoxVehicleType.SelectedItem.ToString() == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "UPDATE vehicle SET VehicleType = @type WHERE VehicleNo = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", comboBoxVehicleType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (Id.Equals(null) || Id == 0)
            {
                MessageBox.Show("Id not selectd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "DELETE FROM vehicle WHERE VehicleNo = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void VehicleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)VehicleDataGridView.SelectedRows[0].Cells[0].Value;
            txtVehicleNo.Text = VehicleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxVehicleType.SelectedItem = VehicleDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            this.con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=Ayubo;");
            load();
            FillCombo();
        }
    }
}

