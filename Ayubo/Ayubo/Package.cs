using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ayubo
{
    public partial class Package : Form
    {
        MySqlConnection con;
        int Id;

        public Package()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Package_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1234;database=Ayubo;");
            load();

        }

        private void load()
        {
            try
            {
                con.Open();
                Console.WriteLine("Myslq Connected Successfully");
                String sql = "SELECT * FROM package";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                PacageDataGridView.DataSource = dt;


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
            if (txtPackageName.Text == String.Empty || txtPackageAmount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "INSERT INTO package (Package_Name, Package_Price) VALUES (@name, @amount)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtPackageName.Text);
                cmd.Parameters.AddWithValue("@amount", txtPackageAmount.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Package Added successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void clear()
        {
            txtPackageAmount.Clear();
            txtPackageName.Clear();
            Id = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void PacageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)PacageDataGridView.SelectedRows[0].Cells[2].Value;
            txtPackageName.Text = PacageDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtPackageAmount.Text = PacageDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (txtPackageName.Text == String.Empty || txtPackageAmount.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Details", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "UPDATE package SET Package_Name = @name, Package_Price = @amount WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", txtPackageName.Text);
                cmd.Parameters.AddWithValue("@amount", txtPackageAmount.Text);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package Updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Id.Equals(null) || Id ==0)
            {
                MessageBox.Show("Id not selectd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String sql = "DELETE FROM package WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package Deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }

        }

        
    }
}
