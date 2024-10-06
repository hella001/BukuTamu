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
    public partial class DataUser : Form
    {
        public DataUser()
        {
            InitializeComponent();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            TambahUser Add = new TambahUser();
            Add.ShowDialog();
            this.Activate();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditUser Edit = new EditUser();
            Edit.ShowDialog();
            this.Activate();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pengguna back = new Pengguna();
            back.ShowDialog();
            this.Close();
        }
    }
}
