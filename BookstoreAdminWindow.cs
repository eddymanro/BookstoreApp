using Amazon.Runtime.SharedInterfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
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
        private string idToDelete;

        public BookstoreAdminWindow()
        {
            InitializeComponent();
            connection = new ConnectToDb();
            fetchNewData();
        }

        public bool verifyInputs()
        {
            bool flag = true;

            if (bookstore.Username == "")
            {
                flag = false;
                MessageBox.Show("Username can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (bookstore.Name == "")
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
            IMongoCollection<BookstoreModel> bookstorecollection = this.connection.getBookstoreCollection();

            this.bookstore = new BookstoreModel
            {
                Username = usernameTextField.Text,
                Name = nameTextField.Text,
                City = cityTextField.Text,
                Password = passwordTextField.Text
            };

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
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the selected row?", "Remove ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                IMongoCollection<BookstoreModel> bookstorecollection = this.connection.getBookstoreCollection();
                // this querry deletes the selected row 
                bookstorecollection.DeleteOne(bksm => bksm.Id == idToDelete);
                removeData();
                fetchNewData();
                MessageBox.Show("Entry deleted succesfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridV_CurrentRowChanging(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                usernameTextField.Text = dataGridV.Rows[e.RowIndex].Cells[1].Value.ToString();
                nameTextField.Text = dataGridV.Rows[e.RowIndex].Cells[2].Value.ToString();
                cityTextField.Text = dataGridV.Rows[e.RowIndex].Cells[3].Value.ToString();
                passwordTextField.Text = dataGridV.Rows[e.RowIndex].Cells[4].Value.ToString();

                dataGridV.CurrentRow.Selected = true;
                this.idToDelete = dataGridV.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // create new object from text fields
            this.bookstore = new BookstoreModel
            {
                Username = usernameTextField.Text,
                Name = nameTextField.Text,
                City = cityTextField.Text,
                Password = passwordTextField.Text
            };

            var update = Builders<BookstoreModel>.Update.Set("Username", usernameTextField.Text)
                                                        .Set("Name", nameTextField.Text)
                                                        .Set("City", cityTextField.Text)
                                                        .Set("Password", passwordTextField.Text);

            IMongoCollection<BookstoreModel> bookstorecollection = this.connection.getBookstoreCollection();
            bookstorecollection.UpdateOne(bksm => bksm.Id == idToDelete,update);
            removeData();
            fetchNewData();

        }
    }
}
