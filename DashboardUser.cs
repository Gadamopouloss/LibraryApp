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

namespace Library
{
    public partial class DashboardUser : Form
    {
        private string role;
        private int userId;

        public DashboardUser(string role, int userId)
        {
            InitializeComponent();
            this.role = role;
            this.userId = userId;
        }

        // Αν θες να έχεις πρόσβαση και από άλλα forms:
        public string UserRole => role;
        public int UserID => userId;


        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks abs = new ViewBooks(role, userId);
            abs.StartPosition = FormStartPosition.CenterParent;
            abs.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueUsers abs = new IssueUsers(userId);
            abs.StartPosition = FormStartPosition.CenterParent;
            abs.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
