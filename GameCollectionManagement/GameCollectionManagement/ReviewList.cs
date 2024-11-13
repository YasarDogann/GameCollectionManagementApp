using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GameCollectionManagement
{
    public partial class ReviewList : UserControl
    {
        private readonly User _user;
        private readonly IReviewService _reviewService;
        public ReviewList(User user)
        {
            InitializeComponent();
            _user = user;
            _reviewService = new ReviewService();
        }

        public void LoadReviews()
        {
            dgvReviews.DataSource = _reviewService.GetAllByRole(_user.Role, _user.Id);
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count > 0)
            {
                int id = (int)dgvReviews.SelectedRows[0].Cells["Id"].Value;
                EditReview form = new EditReview(id, this);

                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count > 0)
            {
                int id = (int)dgvReviews.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show($"{id} nolu yorumu silmek istediğinizden emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _reviewService.DeleteByRole(id, _user.Role, _user.Id);
                        LoadReviews();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddReviewForm form = new AddReviewForm(_user,this);
            form.ShowDialog();
        }
    }
}
