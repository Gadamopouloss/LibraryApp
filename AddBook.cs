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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //save book
            string bookName = nametxt.Text;
            string authorName = autortxt.Text;
            string publisherName = publtxt.Text;
            string bookPrice = pricetxt.Text;
            string bookQuantity = quantxt.Text;
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");  
            string genre = GenBox.SelectedItem?.ToString() ?? string.Empty;
            
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(publisherName) || string.IsNullOrEmpty(bookPrice) || string.IsNullOrEmpty(bookQuantity))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string connString = "Data Source=192.168.200.12;Initial Catalog=LibraryApp;Persist Security Info=True;User ID=sa;Password=bi0616@;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Books 
                            (BookName, BookAuthor, BookPublication, BookPrice, BookQuantity, BookPurchaseDate, genre) 
                            VALUES 
                            (@BookName, @BookAuthor, @BookPublication, @BookPrice, @BookQuantity, @BookPurchaseDate, @Genre)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookName", bookName);
                        cmd.Parameters.AddWithValue("@BookAuthor", authorName);
                        cmd.Parameters.AddWithValue("@BookPublication", publisherName);
                        cmd.Parameters.AddWithValue("@BookPrice", bookPrice);
                        cmd.Parameters.AddWithValue("@BookQuantity", bookQuantity);
                        cmd.Parameters.AddWithValue("@BookPurchaseDate", date);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Book added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
