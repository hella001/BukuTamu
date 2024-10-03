using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadPengunjungData();  
        }

        
        public class Pengunjung
        {
            public DateTime Tanggal { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Alamat { get; set; }
            public string Kelamin { get; set; }
            public string NomorHP { get; set; }
            public string Pekerjaan { get; set; }
            public string Keperluan { get; set; }
            public string Keterangan { get; set; }
        }

        
        public class RootObject
        {
            public List<Pengunjung> pengunjung { get; set; }
        }

        // membaca data JSON
        private List<Pengunjung> LoadPengunjungFromJson()
        {
            string filePath = "users.json";  

            if (!File.Exists(filePath))
            {
                
                File.WriteAllText(filePath, JsonConvert.SerializeObject(new RootObject { pengunjung = new List<Pengunjung>() }));
            }

            
            string json = File.ReadAllText(filePath);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(json);

            
            return data.pengunjung;
        }

        
        private void LoadPengunjungData()
        {
            List<Pengunjung> pengunjungList = LoadPengunjungFromJson();  

            
            GridTamu.DataSource = pengunjungList;
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pengguna f2 = new Pengguna();
            f2.ShowDialog();
            this.Close();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEksport_Click(object sender, EventArgs e)
        {
            
        }

        private void GridTamu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
