using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Windows.Forms;


using UserModel = BukuTamu.Login.User;

namespace BukuTamu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            public List<object> pengunjung { get; set; }  // Pengunjung tidak digunakan dalam login
            public List<UserModel> users { get; set; }    // Data user untuk login
        }

        // membaca data user dari file JSON
        private List<UserModel> LoadUsersFromJson()
        {
            string filePath = "users.json";

            if (!File.Exists(filePath))
            {
                // buat file json jika tidak ada
                File.WriteAllText(filePath, JsonConvert.SerializeObject(new RootObject { users = new List<UserModel>() }));
            }

            
            string json = File.ReadAllText(filePath);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(json);

            
            return data.users;
        }

        // menambahkan user ke file JSON
        private void AddUserToJson(UserModel newUser)
        {
            string filePath = "users.json";
            RootObject data = new RootObject();

            // load data JSON
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                data = JsonConvert.DeserializeObject<RootObject>(json);
            }

            
            newUser.Id = data.users.Count > 0 ? data.users.Max(u => u.Id) + 1 : 1; 
            data.users.Add(newUser);

            // data ke file JSON
            File.WriteAllText(filePath, JsonConvert.SerializeObject(data, Formatting.Indented));
        }

       
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = IntUsername.Text; 
            string password = IntPassword.Text; 

            // load data
            List<UserModel> users = LoadUsersFromJson();

            // verifikasi
            UserModel loginUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (loginUser != null)
            {
                
                MessageBox.Show($"Login berhasil!\nSelamat datang, {loginUser.Name}.\nEmail: {loginUser.Email}");

                // Periksa role
                if (loginUser.Role == "admin")
                {
                    
                    this.Hide();
                    Admin f2 = new Admin();
                    f2.ShowDialog();
                    this.Close();
                }
                else if (loginUser.Role == "user")
                {
                    
                    this.Hide();
                    UserForm f3 = new UserForm();
                    f3.ShowDialog();
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Role tidak dikenali!");
                }
            }
            else
            {
                
                MessageBox.Show("Username atau password salah!");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputTamu f2 = new InputTamu();
            f2.ShowDialog();
            this.Close();
        }
    }
}
