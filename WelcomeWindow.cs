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
            AdminLoginWindow adm = new AdminLoginWindow();
            adm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            ReservationWindow rsrv = new ReservationWindow();
            rsrv.Show();
        }

        private void bookStoreLoginBtn_Click(object sender, EventArgs e)
        {
            BookstoreLoginWindow blw = new BookstoreLoginWindow();
            blw.Show();
        }
    }
}