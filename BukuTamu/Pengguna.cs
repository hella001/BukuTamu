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
    public partial class Pengguna : Form
    {
        public Pengguna()
        {
            InitializeComponent();
        }

        private void BtnDetailAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataAdmin f2 = new DataAdmin();
            f2.ShowDialog();
            this.Close();
        }

        private void BtnDetailUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUser f2 = new DataUser();
            f2.ShowDialog();
            this.Close();
        }
    }
}
