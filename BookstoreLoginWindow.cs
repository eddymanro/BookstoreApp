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
    public partial class BookstoreLoginWindow : Form
    {
        private ConnectToDb connection;
        private BookstoreModel bookstore;

        public BookstoreLoginWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
        }

        public bool userVerificationOK()
        {
            bool isVerified = false;

            if (usrTexfield.Text == "")
            {
                MessageBox.Show("Please enter a username", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passTexField.Text == "")
                {
                    MessageBox.Show("Please enter a password", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // check every bookstore username password pair
                    Program.populateArraylist(connection.getBookstoreCollection(), Program.getBookStoresList());
                    List<BookstoreModel> bookstoresList = Program.getBookStoresList();

                    foreach (BookstoreModel bookstore in bookstoresList)
                    {
                        if ((usrTexfield.Text == bookstore.Username) && (passTexField.Text == bookstore.Password))
                        {
                            isVerified = true;
                            this.bookstore = bookstore;
                            break;
                        }
                    }
                    // clear the static list
                    Program.clearList(Program.getBookStoresList());

                    if (!isVerified)
                    {
                        MessageBox.Show("You have entered an invalid username / password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        usrTexfield.Text = "";
                        passTexField.Text = "";
                    }
                }

            }
            return isVerified;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userVerificationOK())
            {               
                BooksAdminWindow bookadmwnd = new BooksAdminWindow(this.bookstore.Name);
                bookadmwnd.Show();
                this.Close();
            }
        }
    }
}
