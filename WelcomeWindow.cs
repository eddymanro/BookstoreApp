namespace BookstoreApp
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeWindow_Load_1(object sender, EventArgs e)
        {

        }

        private void bookstoreBtn_Click(object sender, EventArgs e)
        {
            BookstoreAdminWindow badm = new BookstoreAdminWindow();
            badm.Show();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}