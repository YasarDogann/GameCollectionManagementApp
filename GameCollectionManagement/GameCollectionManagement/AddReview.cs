using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameCollectionManagement.Services;
using GameCollectionManagement.Models;

namespace GameCollectionManagement
{
    public partial class AddReview : UserControl
    {
        private readonly IReviewService _reviewService;
        private readonly User _user;
        private readonly IGameService _gameService;
        private readonly ReviewList _reviewList; 
        public AddReview(User user, ReviewList reviewList)
        {
            InitializeComponent();
            _user = user;
            _gameService = new GameService();
            _reviewService = new ReviewService();

            var games = _gameService.GetAll();
            cbGames.DataSource = games;
            cbGames.DisplayMember = "Name";
            cbGames.ValueMember = "Id";
            _reviewList = reviewList;
        }
        public AddReview(User user)
        {
            InitializeComponent();
            _user = user;
            _gameService = new GameService();
            _reviewService = new ReviewService();

            var games = _gameService.GetAll();
            cbGames.DataSource = games;
            cbGames.DisplayMember = "Name";
            cbGames.ValueMember = "Id";
        }

        private void InitializeComponent()
        {
            cbGames = new ComboBox();
            nudRating = new NumericUpDown();
            txtReview = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            ((ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(150, 43);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(304, 28);
            cbGames.TabIndex = 0;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(150, 94);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(304, 27);
            nudRating.TabIndex = 1;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtReview
            // 
            txtReview.Location = new Point(150, 141);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(304, 203);
            txtReview.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Oyun :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Reyting : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 144);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Yorum :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddReview
            // 
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(cbGames);
            Name = "AddReview";
            Size = new Size(501, 403);
            ((ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cbGames;
        private NumericUpDown nudRating;
        private TextBox txtReview;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValideInput())
            {
                try
                {
                    Game selectedGame = cbGames.SelectedItem as Game;

                    if (selectedGame == null)
                    {
                        MessageBox.Show("Sistemsel bir hata oluştu");
                    }

                    Review review = new Review()
                    {
                        Rating = (int)nudRating.Value,
                        ReviewText = txtReview.Text.Trim(),
                        UserId = _user.Id,
                        GameId = selectedGame.Id
                    };
                    _reviewService.Add(review);

                    MessageBox.Show("Yorumunuz eklendi");

                    if(_reviewList is not null)
                    {
                        _reviewList.LoadReviews();
                        ((Form)Parent.Parent).Close();
                    }

                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearInputs()
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedItem = null;
                }
                else if (ctrl is NumericUpDown)
                {
                    ((NumericUpDown)ctrl).Value = nudRating.Minimum;
                }
            }
        }

        private bool ValideInput()
        {
            if (cbGames.SelectedItem == null)
            {
                MessageBox.Show("Oyun seçmelisiniz");
                return false;
            }
            if (nudRating.Value < 1 || nudRating.Value > 5)
            {
                MessageBox.Show("Reyting aralığı 1 ile 5 arasında olmalıdır");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                MessageBox.Show("Yorum girmelisiniz");
                return false;
            }
            return true;
        }
    }
}
