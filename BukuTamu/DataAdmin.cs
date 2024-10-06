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
    public partial class DataAdmin : Form
    {
        public DataAdmin()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pengguna back = new Pengguna();
            back.ShowDialog();
            this.Close();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            TambahAdmin Add = new TambahAdmin();
            Add.ShowDialog();
            this.Activate();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditAdmin Edit = new EditAdmin();
            Edit.ShowDialog();
            this.Activate();
        }
    }
}
