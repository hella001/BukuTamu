using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class Lihat : Form
    {
        private string fotoPath;

        public Lihat(string fotoPath)
        {
            InitializeComponent();
            this.fotoPath = fotoPath;

            TampilkanFoto();
        }

        private void TampilkanFoto()
        {
            try
            {
                if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                {
                    // muat gambar
                    Foto.Image = Image.FromFile(fotoPath);
                    Foto.SizeMode = PictureBoxSizeMode.Zoom;
                    Foto.Refresh();
                }
                else
                {
                    MessageBox.Show("Foto tidak ditemukan atau path tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat foto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // melepaskan resource gambar
            if (Foto.Image != null)
            {
                Foto.Image.Dispose();
                Foto.Image = null;    
            }

            this.Close(); 
        }
    }
}
