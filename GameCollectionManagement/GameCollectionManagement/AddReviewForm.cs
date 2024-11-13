using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = GameCollectionManagement.Models.User;

namespace GameCollectionManagement
{
    public partial class AddReviewForm : Form
    {
        private readonly IReviewService _reviewService;
        private readonly User _user;
        private readonly ReviewList _reviewList;
        public AddReviewForm(User user, ReviewList reviewList)
        {
            InitializeComponent();
            _user = user;
            _reviewService = new ReviewService();
            _reviewList = reviewList;
        }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {
            AddReview review = new AddReview(_user,_reviewList);
            panelContainer.Controls.Add(review);
        }
    }
}
