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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }
    }
}
