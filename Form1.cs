using System.Data;
using Microsoft.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Clear();
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Clear();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c start https://www.instagram.com",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c start https://www.facebook.com",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c start https://www.youtube.com",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LgnBtn_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("❌ Please enter your username and password");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username=@username AND Password=@password", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())  
                    {
                        string role = reader["Role"].ToString();
                        int userId = Convert.ToInt32(reader["UserID"]); 

                        this.Hide();
                        if (role == "user")
                        {
                            DashboardUser dsu = new DashboardUser(role,userId); 
                            dsu.StartPosition = FormStartPosition.CenterParent;
                            dsu.Show();
                        }
                        else if (role == "Admin")
                        {
                            Dashboard dsa = new Dashboard();
                            dsa.StartPosition = FormStartPosition.CenterParent;
                            dsa.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid username or password");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("❌ Error connecting to database: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ An unexpected error occurred: " + ex.Message);
                }
            }

        }




        private void SgnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.Show();
        }

    }
}

