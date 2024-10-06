using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using OfficeOpenXml; 
using OfficeOpenXml.Style;
using System.Drawing;

namespace BukuTamu
{
    public partial class Admin : Form
    {
        private static readonly string EncryptionKey = "kartika"; 

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
            public string FotoPath { get; set; }  
        }

        public class RootObject
        {
            public List<Pengunjung> pengunjung { get; set; }
        }

        private List<Pengunjung> LoadPengunjungFromJson()
        {
            string filePath = "users.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(new RootObject { pengunjung = new List<Pengunjung>() }));
            }

            string json = File.ReadAllText(filePath);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(json);

            // dekripsi data sebelum mengembalikannya
            foreach (var pengunjung in data.pengunjung)
            {
                pengunjung.Email = TryDecrypt(pengunjung.Email);
                pengunjung.Alamat = TryDecrypt(pengunjung.Alamat);
                pengunjung.NomorHP = TryDecrypt(pengunjung.NomorHP);
                pengunjung.Keperluan = TryDecrypt(pengunjung.Keperluan);
                pengunjung.Keterangan = TryDecrypt(pengunjung.Keterangan);
            }

            return data.pengunjung;
        }

        // validitas Base-64
        private string TryDecrypt(string cipherText)
        {
            try
            {
                if (IsBase64String(cipherText))
                {
                    return Decrypt(cipherText);
                }
                else
                {
                    return cipherText; 
                }
            }
            catch (Exception)
            {
                return cipherText; 
            }
        }

        // fungsi dekripsi
        private string Decrypt(string cipherText)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        // memeriksa apakah string adalah Base-64 yang valid
        private bool IsBase64String(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String) || base64String.Length % 4 != 0
                || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
        private void LoadPengunjungData()
        {
            List<Pengunjung> pengunjungList = LoadPengunjungFromJson();

            
            GridTamu.Columns.Clear();

            // kolom foto
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Foto";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 80;
            GridTamu.Columns.Add(imgCol);

            
            GridTamu.DataSource = new BindingSource() { DataSource = pengunjungList };

            // lebar kolom gambar
            if (GridTamu.Columns["FotoPath"] != null)
            {
                GridTamu.Columns["FotoPath"].Visible = false;
            }

            
            foreach (DataGridViewRow row in GridTamu.Rows)
            {
                if (row.Cells["FotoPath"].Value != null)
                {
                    string fotoPath = row.Cells["FotoPath"].Value.ToString();
                    if (File.Exists(fotoPath))
                    {
                        try
                        {
                            Image img = Image.FromFile(fotoPath);
                            row.Cells[0].Value = img;
                        }
                        catch (Exception ex)
                        {
                            
                            Console.WriteLine($"Error loading image: {ex.Message}");
                        }
                    }
                    else
                    {
                        
                        Console.WriteLine($"File not found: {fotoPath}");
                    }
                }
            }

            // sesuaikan lebar kolom lainnya
            foreach (DataGridViewColumn column in GridTamu.Columns)
            {
                if (column.Name != "Foto")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }

            
            UpdateJumlahTamu(pengunjungList.Count);
        }

        
        private void UpdateJumlahTamu(int totalTamu)
        {
            JmlTamu.Text = $"{totalTamu} Orang";
        }

        // mengekspor data Excel
        private void BtnEksport_Click(object sender, EventArgs e)
        {
            // licenseContext non-komersial
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Simpan File Excel";
            saveFileDialog.FileName = "DataPengunjung.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Pengunjung");

                        
                        worksheet.Cells[1, 1].Value = "Tanggal";
                        worksheet.Cells[1, 2].Value = "Nama";
                        worksheet.Cells[1, 3].Value = "Email";
                        worksheet.Cells[1, 4].Value = "Alamat";
                        worksheet.Cells[1, 5].Value = "Kelamin";
                        worksheet.Cells[1, 6].Value = "Nomor HP";
                        worksheet.Cells[1, 7].Value = "Pekerjaan";
                        worksheet.Cells[1, 8].Value = "Keperluan";
                        worksheet.Cells[1, 9].Value = "Keterangan";
                        worksheet.Cells[1, 10].Value = "Foto";

                        // tambahkan data dari GridTamu ke worksheet
                        for (int i = 0; i < GridTamu.Rows.Count; i++)
                        {
                            worksheet.Cells[i + 2, 1].Value = GridTamu.Rows[i].Cells["Tanggal"].Value?.ToString();
                            worksheet.Cells[i + 2, 2].Value = GridTamu.Rows[i].Cells["Nama"].Value?.ToString();
                            worksheet.Cells[i + 2, 3].Value = GridTamu.Rows[i].Cells["Email"].Value?.ToString();
                            worksheet.Cells[i + 2, 4].Value = GridTamu.Rows[i].Cells["Alamat"].Value?.ToString();
                            worksheet.Cells[i + 2, 5].Value = GridTamu.Rows[i].Cells["Kelamin"].Value?.ToString();
                            worksheet.Cells[i + 2, 6].Value = GridTamu.Rows[i].Cells["NomorHP"].Value?.ToString();
                            worksheet.Cells[i + 2, 7].Value = GridTamu.Rows[i].Cells["Pekerjaan"].Value?.ToString();
                            worksheet.Cells[i + 2, 8].Value = GridTamu.Rows[i].Cells["Keperluan"].Value?.ToString();
                            worksheet.Cells[i + 2, 9].Value = GridTamu.Rows[i].Cells["Keterangan"].Value?.ToString();

                            
                            string fotoPath = GridTamu.Rows[i].Cells["FotoPath"].Value?.ToString();
                            if (!string.IsNullOrEmpty(fotoPath) && File.Exists(fotoPath))
                            {
                                var picture = worksheet.Drawings.AddPicture($"FotoPengunjung{i + 2}", new FileInfo(fotoPath));
                                picture.SetPosition(i + 1, 0, 9, 0); 
                                picture.SetSize(50, 50); 
                            }
                        }

                        // menyesuaikan lebar kolom
                        for (int col = 1; col <= 9; col++)
                        {
                            worksheet.Column(col).AutoFit();
                        }

                        // simpan file Excel
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fi);

                        MessageBox.Show("Data berhasil dieksport ke Excel.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GridTamu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditData Edit = new EditData();
            Edit.ShowDialog();
            this.Activate();
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
            LoadPengunjungData();
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
