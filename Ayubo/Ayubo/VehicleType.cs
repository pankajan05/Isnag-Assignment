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
    public partial class VehicleType : Form
    {

        MySqlConnection con;
        int Id;

        public VehicleType()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (txtVehicleType.Text == String.Empty || txtTariff.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "INSERT INTO vehicletype (VehicleType, Tariff) VALUES (@type, @amount)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", txtVehicleType.Text);
                cmd.Parameters.AddWithValue("@amount", txtTariff.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New VehicleType Added successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (txtTariff.Text == String.Empty || txtVehicleType.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "UPDATE vehicletype SET VehicleType = @type, Tariff = @amount WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", txtVehicleType.Text);
                cmd.Parameters.AddWithValue("@amount", txtTariff.Text);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("VehicleType Updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id.Equals(null) || Id == 0)
            {
                MessageBox.Show("Id not selectd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "DELETE FROM vehicleType WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Type Deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void VehicleTypeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)VehicleTypeDataGridView.SelectedRows[0].Cells[2].Value;
            txtVehicleType.Text = VehicleTypeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtTariff.Text = VehicleTypeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }


        private void load()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT * FROM vehicletype";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                VehicleTypeDataGridView.DataSource = dt;


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
            txtTariff.Clear();
            txtVehicleType.Clear();
            Id = 0;
        }




        private void VehicleType_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=Ayubo;");
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clear();
        }
    }
}
