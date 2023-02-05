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
        private const string ADMIN_USERNAME = "admin";
        private const string ADMIN_PASSWORD = "pass";
        public BookstoreLoginWindow()
        {
            InitializeComponent();
        }

        public bool verificationIsOk()
        {
            bool credentialsOK = false;

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
                    if ((usrTexfield.Text == ADMIN_USERNAME) && (passTexField.Text == ADMIN_PASSWORD))
                    {
                        credentialsOK = true;
                    }
                    else
                    {
                        MessageBox.Show("You have entered an invalid username / password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        usrTexfield.Text = "";
                        passTexField.Text = "";
                    }
                }

            }
            return credentialsOK;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (verificationIsOk())
            {
                BookstoreAdminWindow badm = new BookstoreAdminWindow();
                this.Close();
                badm.Show();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
