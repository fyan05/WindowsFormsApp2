using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public string usernama;
        public Form2(string nama)
        {
            InitializeComponent();
            usernama = nama;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(usernama); // Cek apakah nama dari database muncul
            label1.Text = "Selamat datang, " + usernama;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
