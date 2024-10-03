using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class InputTamu : Form
    {
        public InputTamu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMasuk_Click(object sender, EventArgs e)
        {
            //form Login
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }
    }
}
