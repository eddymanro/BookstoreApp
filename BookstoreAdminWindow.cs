using MongoDB.Driver;
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
    public partial class BookstoreAdminWindow : Form
    {
        private ConnectToDb connection;
        public BookstoreAdminWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WelcomeWindow wlc = new WelcomeWindow();
            wlc.Show();
            this.Close();
        }

       
        private void addBtn_Click(object sender, EventArgs e)
        {

            IMongoCollection<BookstoreModel>  bookstorecollection = this.connection.getBookstoreCollection();

            BookstoreModel bookstore = new BookstoreModel { Username = usernameTextField.Text, 
                                                            Name = nameTextField.Text, 
                                                            City = cityTextField.Text, 
                                                            Password = passwordTextField.Text };

            bookstorecollection.InsertOne(bookstore);
        }
    }
}
