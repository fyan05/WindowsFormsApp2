using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!");
                return;
            }

            using (SqlConnection con = connection.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM users WHERE nama = @nama AND Password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nama", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nama = reader["nama"].ToString();
                        Form2 f2 = new Form2(nama);
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password salah!");
                        textBox2.Clear();
                        textBox2.Focus();
                    }
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        public void ProsesLogin()
        {
            
        }
    }
}
    
