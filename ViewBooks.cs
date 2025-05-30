using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewBooks : Form
    {

        private string role;
        private int userId;

        public ViewBooks(string role, int userId)
        {
            InitializeComponent();
            this.role = role;
            this.userId = userId;
            this.Load += FrmMain_Load;
            string roleLower = role.ToLower();

             if (roleLower == "user")
            {
                label4.Visible = true;
                RetDate.Visible = true;
            }
            

        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadBooksToGrid();
            LoadBooksToGrid2();
           

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
        private void LoadBooksToGrid2()
        {
            //the books with no stock
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";
            string query = "SELECT * FROM Books WHERE BookQuantity = 0";

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
                    dataGridView2.DefaultCellStyle.ForeColor = Color.Gray;

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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchTx.Text.Trim();

            if (searchText == "")
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
                        cmd.Parameters.AddWithValue("@BookName", "%" + searchText + "%");

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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ανάγνωση Book ID
            if (!int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[0]?.Value?.ToString(), out int IdBook))
            {
                MessageBox.Show("❌ Could not determine the selected book ID.");
                return;
            }

            // Έλεγχος επιστροφής ημερομηνίας
            DateTime returnDate;
            if (RetDate is DateTimePicker)
            {
                returnDate = ((DateTimePicker)RetDate).Value;
            }
            else
            {
                MessageBox.Show("❌ Invalid return date control.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Έλεγχος διαθεσιμότητας
                    string checkQuery = "SELECT BookQuantity FROM Books WHERE Id = @IdBook";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdBook", IdBook);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("❌ Book not found.");
                            return;
                        }

                        int quantity = Convert.ToInt32(result);
                        if (quantity <= 0)
                        {
                            MessageBox.Show("⚠️ This book is out of stock.");
                            return;
                        }
                    }
                    // Πάρε το όνομα του βιβλίου
                    string bookName = dataGridView1.Rows[e.RowIndex].Cells["BookName"]?.Value?.ToString() ?? "this book";

                    DialogResult confirmResult = MessageBox.Show(
                        $"Are you sure you want to loan this book: '{bookName}'?",
                        "Confirm Loan",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirmResult != DialogResult.Yes)
                    {
                        return; // σταμάτα αν όχι
                    }

                    // Μείωση ποσότητας
                    string updateQuery = "UPDATE Books SET BookQuantity = BookQuantity - 1 WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", IdBook);
                        cmd.ExecuteNonQuery();
                    }

                    // Καταχώρηση δανεισμού
                    string insertQuery = "INSERT INTO Loans (UserId, BookId, LoanDate, ReturnDate) VALUES (@IdStudent, @IdBook, @LoanDate, @Rdate)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@IdStudent", userId);  // ΠΡΟΣΟΧΗ: userId πρέπει να είναι integer property του form
                        insertCmd.Parameters.AddWithValue("@IdBook", IdBook);
                        insertCmd.Parameters.AddWithValue("@LoanDate", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@Rdate", returnDate);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("✅ Loan successful!");
                        }
                        else
                        {
                            MessageBox.Show("❌ Failed to record the loan.");
                        }
                    }

                    // Επαναφόρτωση βιβλίων
                    LoadBooksToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }


    }
}