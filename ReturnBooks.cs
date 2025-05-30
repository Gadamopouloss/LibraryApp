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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadBooksToGrid1();
            LoadBooksToGrid2();
            LoadBooksToGrid3();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LoadBooksToGrid1()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = @"
        SELECT 
            U.Username,
            B.BookName,
            B.BookAuthor,
            L.LoanDate,
            L.ReturnDate,
            L.LoanID,
            B.ID AS BookID
        FROM Loans L
        INNER JOIN Users U ON L.UserID = U.UserID
        INNER JOIN Books B ON L.BookID = B.ID
        WHERE L.DueDate IS NULL AND L.ReturnDate > GETDATE()";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
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


        private void LoadBooksToGrid2()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = @"
        SELECT 
            U.Username,
            B.BookName,
            B.BookAuthor,
            L.LoanDate,
            L.ReturnDate,
            L.DueDate
        FROM Loans L
        INNER JOIN Users U ON L.UserID = U.UserID
        INNER JOIN Books B ON L.BookID = B.ID
        WHERE L.DueDate IS NULL AND L.ReturnDate < GETDATE()
    ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView2.DataSource = dt;
                    dataGridView2.Columns["DueDate"].Visible = false;
                    dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                    dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Σφάλμα: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = UserTx.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a username to search.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = @"
    SELECT 
        U.Username,
        B.BookName,
        B.BookAuthor,
        L.LoanDate,
        L.ReturnDate
    FROM Loans L
    INNER JOIN Users U ON L.UserID = U.UserID
    INNER JOIN Books B ON L.BookID = B.ID
    WHERE L.DueDate IS NULL AND L.ReturnDate > GETDATE()
      AND U.Username LIKE @Username
    ";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", "%" + searchText + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    dataGridView1.DataSource = dt;

                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadBooksToGrid3()
        {
            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = @"
        SELECT 
            U.Username,
            B.BookName,
            B.BookAuthor,
            L.LoanDate,
            L.ReturnDate,
            L.LoanID
        FROM Loans L
        INNER JOIN Users U ON L.UserID = U.UserID
        INNER JOIN Books B ON L.BookID = B.ID
        WHERE L.DueDate IS NOT NULL";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView3.DataSource = dt;
                    dataGridView3.Columns["LoanID"].Visible = false;

                    dataGridView3.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                    dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BookBt_Click(object sender, EventArgs e)
        {
            string searchText = BookTx.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a book name to search.");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            string query = @"
    SELECT 
        U.Username,
        B.BookName,
        B.BookAuthor,
        L.LoanDate,
        L.ReturnDate
    FROM Loans L
    INNER JOIN Users U ON L.UserID = U.UserID
    INNER JOIN Books B ON L.BookID = B.ID
    WHERE L.DueDate IS NULL AND L.ReturnDate > GETDATE()
      AND B.BookName LIKE @BookName
    ";

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

                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 8);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        int loanid = 0;
        int bookid = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loanid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["LoanID"].Value);
            bookid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BookID"].Value);
        }


        private void RetuBtn_Click(object sender, EventArgs e)
        {
            if (loanid == 0)
            {
                MessageBox.Show("Please select a loan record to return.");
                return;
            }

            DateTime rdate = ReturnDate.Value;

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string updateLoanQuery = "UPDATE Loans SET DueDate = @DueDate WHERE LoanID = @LoanID";
                    using (SqlCommand cmd1 = new SqlCommand(updateLoanQuery, conn))
                    {
                        cmd1.Parameters.AddWithValue("@DueDate", rdate);
                        cmd1.Parameters.AddWithValue("@LoanID", loanid);
                        cmd1.ExecuteNonQuery();
                    }

                    string updateBookQuery = "UPDATE Books SET BookQuantity = BookQuantity + 1 WHERE ID = @ID";
                    using (SqlCommand cmd2 = new SqlCommand(updateBookQuery, conn))
                    {
                        cmd2.Parameters.AddWithValue("@ID", bookid);
                        cmd2.ExecuteNonQuery();
                    }

                    MessageBox.Show("Return processed successfully.");

                    LoadBooksToGrid1();
                    LoadBooksToGrid3();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}




