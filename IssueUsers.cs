using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class IssueUsers : Form
    {
        private int userId;

        public IssueUsers(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.Load += IssueUsers_Load;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;


            LoadUserLoans();
        }

        private void IssueUsers_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string selectQuery = "SELECT UserName, Email, Password FROM Users WHERE UserID = @UserID";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxuser.Text = reader["UserName"].ToString();
                                textBoxmail.Text = reader["Email"].ToString();
                                textBoxpass.Text = reader["Password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
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

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string updateQuery = "UPDATE Users SET UserName = @UserName, Email = @Email, Password = @Password WHERE UserID = @UserID";

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
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("✅ User updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("❌ Update failed. No rows affected.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ReturnDate" && e.Value != null && e.Value != DBNull.Value)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime returnDate))
                {
                    DateTime today = DateTime.Today;

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    if (returnDate < today)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }



        private void LoadUserLoans()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = @"
SELECT 
    U.Username,
    B.BookName,
    B.BookAuthor,
    L.LoanDate,
    L.ReturnDate,
    L.DueDate,
    L.LoanID
FROM Loans L
INNER JOIN Users U ON L.UserID = U.UserID
INNER JOIN Books B ON L.BookID = B.ID
WHERE L.UserID = @UserID AND L.DueDate IS NULL";


            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@UserID", userId);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    if (dataGridView1.Columns.Contains("LoanID"))
                        dataGridView1.Columns["LoanID"].Visible = false;

                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);
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
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you returned the book?",
                    "Confirm Return",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string bookName = dataGridView1.Rows[e.RowIndex].Cells["BookName"].Value.ToString();

                    int bookId = -1;
                    string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        try
                        {
                            conn.Open();

                            // Step 1: Get Book ID
                            string getBookIdQuery = "SELECT ID FROM Books WHERE BookName = @BookName";
                            using (SqlCommand cmd = new SqlCommand(getBookIdQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@BookName", bookName);
                                object resultObj = cmd.ExecuteScalar();
                                if (resultObj != null)
                                {
                                    bookId = Convert.ToInt32(resultObj);
                                }
                                else
                                {
                                    MessageBox.Show("Book not found.");
                                    return;
                                }
                            }

                            // Step 2: Update Loan DueDate
                            string updateLoanQuery = @"
UPDATE Loans 
SET DueDate = @Today 
WHERE UserID = @UserID AND BookID = @BookID";

                            using (SqlCommand cmd = new SqlCommand(updateLoanQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@Today", DateTime.Now.Date);
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.Parameters.AddWithValue("@BookID", bookId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    MessageBox.Show("❌ No loan found for this book.");
                                    return;
                                }
                            }

                            string updateQuantityQuery = @"
UPDATE Books 
SET BookQuantity = BookQuantity + 1 
WHERE ID = @BookID";

                            using (SqlCommand cmd = new SqlCommand(updateQuantityQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@BookID", bookId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show(" Book returned and quantity updated.");

                            LoadUserLoans(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
