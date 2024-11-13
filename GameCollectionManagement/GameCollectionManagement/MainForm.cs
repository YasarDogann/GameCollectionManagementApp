using GameCollectionManagement.Models;

namespace GameCollectionManagement
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;

            tsslUserName.Text = _user.UserName;
        }

        private void kullanýcýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddControl(UserControl control)
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(control);
        }

        private void newGameTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddGame());
        }

        private void gameListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new GameList());
        }

        private void registerTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddUser());
        }

        private void userListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new UserList());
        }

        private void addReviewTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new AddReview(_user));
        }

        private void reviewListTsmi_Click(object sender, EventArgs e)
        {
            AddControl(new ReviewList(_user));
        }
    }
}
