using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreApp
{
    public partial class BooksAdminWindow : Form
    {
        private string bookstoreName;
        public BooksAdminWindow(string bookstoreName)
        {
            InitializeComponent();
            this.bookstoreName = bookstoreName;
            this.labelTitle.Text = "Wellcome to " + bookstoreName + " bookstore!";
        }

        private void BooksAdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
