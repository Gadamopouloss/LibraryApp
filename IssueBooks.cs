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

namespace Library
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadusersToGrid();
            LoadBooksToGrid();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadusersToGrid()
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
        private void LoadBooksToGrid()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM Books WHERE BookQuantity > 0";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);


                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                    dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 8); // or any font and size you like
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void buttonRefre_Click(object sender, EventArgs e)
        {
            string filter = FiltTxt.Text.Trim();
            string FilMethod = FilterBox.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(filter) || string.IsNullOrEmpty(FilMethod))
            {
                MessageBox.Show("Please enter a filter and select a filter method.");
                return;
            }

            // Μετατροπή επιλογής σε όνομα στήλης
            string columnName = FilMethod switch
            {
                "Book Publication" => "BookPublication",
                "Author Name" => "AuthorName",
                "Genre" => "Genre",
                _ => null
            };

            if (columnName == null)
            {
                MessageBox.Show("Invalid filter method selected.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = $"SELECT * FROM Books WHERE {columnName} LIKE @filter";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

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



        private void buttonRefre_Click_1(object sender, EventArgs e)
        {
            string filter = FiltTxt.Text.Trim();
            string FilMethod = FilterBox.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(filter) || string.IsNullOrEmpty(FilMethod))
            {
                MessageBox.Show("Please enter a filter and select a filter method.");
                return;
            }

            // Μετατροπή επιλογής σε όνομα στήλης
            string columnName = FilMethod switch
            {
                "Book Publication" => "BookPublication",
                "Author Name" => "AuthorName",
                "Genre" => "Genre",
                _ => null
            };

            if (columnName == null)
            {
                MessageBox.Show("Invalid filter method selected.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = $"SELECT * FROM Books WHERE {columnName} LIKE @filter";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string Book = BookTxt.Text.Trim();

            if (Book == "")
            {
                MessageBox.Show("Please enter a search Book's name.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM Books WHERE BookName LIKE @BookName";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookName", "%" + Book + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        int IdStudent;
        int IdBook;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdStudent = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdBook = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void buttonLoan_Click(object sender, EventArgs e)
        {
            if (IdStudent == 0 || IdBook == 0)
            {
                MessageBox.Show("Please select a user and a book.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT BookQuantity FROM Books WHERE Id = @IdBook";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdBook", IdBook);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Book not found.");
                            return;
                        }

                        int quantity = (int)result;

                        if (quantity <= 0)
                        {
                            MessageBox.Show("This book is out of stock.");
                            return;
                        }
                    }

                    string updateQuery = "UPDATE Books SET BookQuantity = BookQuantity - 1 WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", IdBook);
                        cmd.ExecuteNonQuery();
                    }

                    string insertQuery = "INSERT INTO Loans (UserId, BookId, LoanDate, ReturnDate) VALUES (@IdStudent, @IdBook, @LoanDate, @Rdate)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@IdStudent", IdStudent);
                        insertCmd.Parameters.AddWithValue("@IdBook", IdBook);
                        insertCmd.Parameters.AddWithValue("@LoanDate", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@Rdate", RetDate.Value.Date);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Loan successful!");
                            IdStudent = 0;
                            IdBook = 0;
                        }
                        else
                        {
                            MessageBox.Show("Failed to record the loan.");
                        }
                    }

                    LoadBooksToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}



