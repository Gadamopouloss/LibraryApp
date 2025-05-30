using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Design;

namespace Library
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadBooksToGrid();
        }

        private void LoadBooksToGrid()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM Users WHERE Role LIKE 'user'";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8); // or any font and size you like
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        int userId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxuser.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxpass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxrole.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

        }

        private void SearBTN_Click(object sender, EventArgs e)
        {
            string searchText = UserTxt.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM Users WHERE UserName LIKE @UserName";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBoxuser.Text.Trim();
            string email = textBoxmail.Text.Trim();
            string password = textBoxpass.Text.Trim();
            string role = textBoxrole.Text.Trim();



            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string updateQuery = "UPDATE Users SET UserName = @UserName, Email = @Email," +
                " Password = @Password, Role = @Role WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@UserID", userId);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.");
                            LoadBooksToGrid(); // Refresh grid
                        }
                        else
                        {
                            MessageBox.Show("Update failed. No rows affected.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (userId == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
                string deleteQuery = "DELETE FROM Users WHERE UserID = @UserID";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", userId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                                LoadBooksToGrid(); // Refresh the DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Delete failed. No rows affected.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}



