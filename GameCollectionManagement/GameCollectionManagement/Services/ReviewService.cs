using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class ReviewService : IReviewService
    {
        private readonly ReviewRepository _reviewRepository;
        private readonly UserRepository _userRepository;
        private readonly GameRepository _gameRepository;


        public ReviewService()
        {
            _reviewRepository = new ReviewRepository();
            _userRepository = new UserRepository();
            _gameRepository = new GameRepository();
        }
        public void Add(Review review)
        {
            if (review.UserId <= 0) throw new ArgumentException("Geçersiz kullanıcı");
            if (review.GameId <= 0) throw new ArgumentException("Geçersiz oyun");
            if (review.Rating < 1 || review.Rating > 5) throw new ArgumentException("Değerlendirme 1 ile 5 arasında olmalıdır");
            if (string.IsNullOrWhiteSpace(review.ReviewText)) throw new ArgumentException("Yorum boş olamaz");
            var user = _userRepository.GetById(review.UserId);
            if (user is null) throw new ArgumentException("Geçersiz kullanıcı");

            var game = _gameRepository.GetById(review.GameId);
            if (game is null) throw new ArgumentException("Geçersiz oyun");

            _reviewRepository.Add(review);
        }

        public void Delete(int id)
        {
            if (id <= 0) throw new ArgumentException("Geçersiz yorum");
            var review = GetById(id);

            if (review is not null) _reviewRepository.Delete(id);
        }

        public void DeleteByRole(int reviewId, string role, int userId)
        {
            _reviewRepository.DeleteByRole (reviewId, role, userId);
        }

        public List<Review> GetAll()
        {
            return _reviewRepository.GetAll();
        }

        public List<Review> GetAllByRole(string role, int userId)
        {
            return _reviewRepository.GetAllByRole(role, userId);
        }

        public List<Review> GetAllWithDetails()
        {
            return _reviewRepository.GetAllWithDetails();
        }

        public Review GetById(int id)
        {
            return _reviewRepository.GetById(id);
        }

        public Review GetByIdWithDetails(int id)
        {
            return _reviewRepository.GetByIdWithDetails(id);
        }

        public void Update(Review review)
        {
            if (review.Id <= 0)
                throw new ArgumentException("Geçersiz yorum");

            if (review.UserId <= 0) 
                throw new ArgumentException("Geçersiz kullanıcı");

            if (review.GameId <= 0)
                throw new ArgumentException("Geçersiz oyun");

            if (review.Rating < 1 || review.Rating > 5) 
                throw new ArgumentException("Değerlendirme 1 ile 5 arasında olmalıdır");

            if (string.IsNullOrWhiteSpace(review.ReviewText)) 
                throw new ArgumentException("Yorum boş olamaz");

            var currentReview = GetById(review.Id);
            if (currentReview is null)
                throw new ArgumentException("Geçersiz yorum");

            var user = _userRepository.GetById(review.UserId);
            if (user is null) throw new ArgumentException("Geçersiz kullanıcı");

            var game = _gameRepository.GetById(review.GameId);
            if (game is null) throw new ArgumentException("Geçersiz oyun");

            _reviewRepository.Update(review);
        }
    }
}
