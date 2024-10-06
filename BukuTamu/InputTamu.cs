using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace BukuTamu
{
    public partial class InputTamu : Form
    {
        private static readonly string EncryptionKey = "kartika"; 
        private string fotoKtpPath = string.Empty; 

        public InputTamu()
        {
            InitializeComponent();
        }

        
        public class Pengunjung
        {
            public int id { get; set; }
            public DateTime Tanggal { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Alamat { get; set; }
            public string Kelamin { get; set; }
            public string NomorHP { get; set; }
            public string Pekerjaan { get; set; }
            public string Keperluan { get; set; }
            public string Keterangan { get; set; }
            public string FotoPath { get; set; } 
        }

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Role { get; set; }
        }

        public class RootObject
        {
            public List<Pengunjung> pengunjung { get; set; }
            public List<User> users { get; set; } 
        }

        
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.All(char.IsDigit);
        }

        
        private RootObject LoadDataFromJson()
        {
            string filePath = "users.json"; 

            if (!File.Exists(filePath))
            {
                
                File.WriteAllText(filePath, JsonConvert.SerializeObject(new RootObject
                {
                    pengunjung = new List<Pengunjung>(),
                    users = new List<User>()
                }));
            }

            // baca file JSON
            string json = File.ReadAllText(filePath);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(json);

            return data;
        }

        // menyimpan data ke JSON
        private void SaveDataToJson(RootObject rootData)
        {
            string filePath = "users.json";
            File.WriteAllText(filePath, JsonConvert.SerializeObject(rootData, Formatting.Indented));
        }

        // enkripsi
        private string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // validasi input
            if (string.IsNullOrWhiteSpace(IntNama.Text) ||
                string.IsNullOrWhiteSpace(IntAlamat.Text) ||
                string.IsNullOrWhiteSpace(IntKelamin.Text) ||
                string.IsNullOrWhiteSpace(IntHp.Text) ||
                string.IsNullOrWhiteSpace(IntKeperluan.Text) ||
                string.IsNullOrWhiteSpace(IntKeterangan.Text))
            {
                MessageBox.Show(" Harap isi semua data yang wajib!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validasi format No HP
            if (!IsValidPhoneNumber(IntHp.Text))
            {
                MessageBox.Show("Nomor HP harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validasi format Email
            if (!IsValidEmail(IntEmail.Text))
            {
                MessageBox.Show("Format email tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RootObject rootData = LoadDataFromJson();

            // tambahkan data baru ke pengunjung
            Pengunjung newPengunjung = new Pengunjung
            {
                id = rootData.pengunjung.Count > 0 ? rootData.pengunjung.Max(p => p.id) + 1 : 1, // id
                Tanggal = IntTanggal.Value,
                Nama = IntNama.Text,
                Email = Encrypt(IntEmail.Text),
                Alamat = Encrypt(IntAlamat.Text),
                Kelamin = IntKelamin.Text,
                NomorHP = Encrypt(IntHp.Text),
                Pekerjaan = IntPekerjaan.Text,
                Keperluan = Encrypt(IntKeperluan.Text),
                Keterangan = Encrypt(IntKeterangan.Text),
                FotoPath = fotoKtpPath 
            };

            rootData.pengunjung.Add(newPengunjung);

            SaveDataToJson(rootData);

            // posisi foto
            if (!string.IsNullOrEmpty(fotoKtpPath))
            {
                string targetFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Picture");
                if (!Directory.Exists(targetFolderPath))
                {
                    Directory.CreateDirectory(targetFolderPath);
                }

                string targetFilePath = Path.Combine(targetFolderPath, Path.GetFileName(fotoKtpPath));
                File.Move(fotoKtpPath, targetFilePath);
                newPengunjung.FotoPath = targetFilePath; // update path foto
            }

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            AmbilFoto formAmbilFoto = new AmbilFoto();
            if (formAmbilFoto.ShowDialog() == DialogResult.OK)
            {
                fotoKtpPath = formAmbilFoto.SavedFilePath;
                IntFoto.Text = fotoKtpPath; 
            }
            this.Activate();
        }

        private void ClearForm()
        {
            IntNama.Clear();
            IntAlamat.Clear();
            IntKelamin.SelectedIndex = -1;
            IntHp.Clear();
            IntPekerjaan.Clear();
            IntKeperluan.Clear();
            IntKeterangan.Clear();
            IntEmail.Clear();
            IntFoto.Clear();
            fotoKtpPath = string.Empty;
        }

        private void BtnBersih_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnLihat_Click(object sender, EventArgs e)
        {
            Lihat LihatFoto = new Lihat();
            LihatFoto.ShowDialog();
            this.Activate();
        }

        private void BtnMasuk_Click(object sender, EventArgs e)
        {
            //form Login
            this.Hide();
            Login f2 = new Login();
            f2.ShowDialog();
            this.Close();
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnPilih_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Pilih Foto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoKtpPath = openFileDialog.FileName;
                IntFoto.Text = fotoKtpPath;
            }
        }
    }
}