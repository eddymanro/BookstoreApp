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
        private BookstoreModel bookstore;

        public bool verifyInputs() 
        {
            bool flag = true;

            if (bookstore.Username == "")
            {
                flag = false;
                MessageBox.Show("Username can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            } else if (bookstore.Name == "")
            {
                flag = false;
                MessageBox.Show("Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bookstore.City == "")
            {
                flag = false;
                MessageBox.Show("City can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bookstore.Password == "")
            {
                flag = false;
                MessageBox.Show("Password can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
            return flag;
        }

        public BookstoreAdminWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
            fetchNewData();
        }

        public void fetchNewData() 
        {            
            Program.populateArraylist(connection.getBookstoreCollection(), Program.getBookStoresList());
            List<BookstoreModel> localList = Program.getBookStoresList();
            dataGridV.DataSource = localList;          
        }

        public void removeData() 
        {
            Program.clearList(Program.getBookStoresList());            
            dataGridV.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            removeData();               
            this.Close();
        }
               
        private void addBtn_Click(object sender, EventArgs e)
        {
            IMongoCollection<BookstoreModel>  bookstorecollection = this.connection.getBookstoreCollection();

            this.bookstore = new BookstoreModel { Username = usernameTextField.Text, 
                                                            Name = nameTextField.Text, 
                                                            City = cityTextField.Text, 
                                                            Password = passwordTextField.Text };
           
            if (verifyInputs()) 
            {                
                bookstorecollection.InsertOne(bookstore);
                MessageBox.Show("Succesfull added new Bookstore information", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                removeData();               
                fetchNewData();             
            }

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            //int indexRow = e.RowIndex;
            //DataGridViewRow row = dataGridV.Rows[indexRow];
            //string idToDelete = row.Cells[0].Value.ToString();
            //Console.WriteLine(idToDelete);

            //string idToDelete = dataGridV.row;
            //string idToDelete =  ;
            //db.yourCollectionName.remove({ _id: yourObjectId});
        }

        private void dataGridV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridV.Rows[indexRow];
            usernameTextField.Text = row.Cells[0].Value.ToString();            
        }
    }
}
