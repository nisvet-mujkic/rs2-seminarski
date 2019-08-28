using AutoMapper;
using BookDiary.API.IService;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class RecommendationService : IRecommendationService
    {
        private readonly BookDiaryContext _context;
        private readonly IMapper _mapper;

        Dictionary<int, double> userBooksReviews = new Dictionary<int, double>();
        Dictionary<string, double> userBooksReviewsBySubjects = new Dictionary<string, double>();

        public RecommendationService(BookDiaryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Book>> Recommend(int userId)
        {
            var recommendedGenreId = await GetRecommendedGenreId(userId);
            var recommendedSubject = await GetRecommendedSubject(userId);

            var entities = await _context.Books.Include(x => x.Author).Include(x => x.Genre)
                                               .Where(x => (x.GenreId == recommendedGenreId || recommendedGenreId == 0) || 
                                                     (x.Subject.Contains(recommendedSubject) || recommendedSubject == string.Empty))
                                               .OrderByDescending(x => x.YearPublished)
                                               .Take(10)
                                               .ToListAsync();

            return _mapper.Map<List<Model.Models.Book>>(entities);
        }

        private async Task<int> GetRecommendedGenreId(int userId)
        {
            var genres = await _context.Genres.ToListAsync();

            if (_context.Reviews.Where(x => x.UserBook.UserId == userId).Count() == 0)
            {
                return 0;
            }

            genres.ForEach(genre =>
            {
                userBooksReviews.Add(genre.Id, GetNumberOfReviewsByGenreIdAndUserId(genre.Id, userId, 4));
            });

            var recommendedGenreId = 0;
            double similarity = 0;

            foreach (var userBookReview in userBooksReviews)
            {
                double tempSimilarity = Distance.EuclideanSimilarity(
                    new ReviewPoint()
                    {
                        GenreId = userBookReview.Key,
                        NumberOfReviews = userBookReview.Value
                    },
                    new ReviewPoint()
                    {
                        GenreId = userBookReview.Key,
                        NumberOfReviews = int.MaxValue
                    });

                if (tempSimilarity > similarity)
                {
                    similarity = tempSimilarity;
                    recommendedGenreId = userBookReview.Key;
                }
            }

            return recommendedGenreId;
        }

        private async Task<string> GetRecommendedSubject(int userId)
        {
            var subjects = await GetAllSubjects();

            if (_context.Reviews.Where(x => x.UserBook.UserId == userId).Count() == 0)
                return string.Empty;

            subjects.ForEach(subject =>
            {
                userBooksReviewsBySubjects.Add(subject, GetNumberOfReviewsBySubjectAndUserId(subject, userId, rating: 4));
            });

            var recommendedTag = string.Empty;
            double similarity = 0;

            foreach (var userBookReview in userBooksReviewsBySubjects)
            {
                double tempSimilarity = Distance.EuclideanSimilarity(
                   new ReviewPoint()
                   {
                       GenreId = 0,
                       NumberOfReviews = userBookReview.Value
                   },
                   new ReviewPoint()
                   {
                       GenreId = 0,
                       NumberOfReviews = int.MaxValue
                   });

                if (tempSimilarity > similarity)
                {
                    similarity = tempSimilarity;
                    recommendedTag = userBookReview.Key;
                }
            }

            return recommendedTag;  
        }

        private int GetNumberOfReviewsByGenreIdAndUserId(int genreId, int userId, int rating)
        {
            return _context.Reviews.Where(x => x.UserBook.UserId == userId && x.UserBook.Book.GenreId == genreId && x.Rating >= rating).Count();
        }

        private int GetNumberOfReviewsBySubjectAndUserId(string subject, int userId, int rating)
        {
            return _context.Reviews
                           .AsQueryable()
                           .AsNoTracking()
                           .Where(x => x.UserBook.Book.Subject.Contains(subject) && x.UserBook.UserId == userId && x.Rating >= rating)
                           .Count();
        }

        private async Task<List<string>> GetAllSubjects()
        {
            var subjectsFromEntities = await _context.Books.Select(book => book.Subject).ToListAsync();
            var subjectsList = new List<string>();

            foreach (var subjects in subjectsFromEntities)
            {
                foreach (var subject in subjects.Split(","))
                {
                    if(!subjectsList.Contains(subject.Replace(" ", string.Empty).ToLower()))
                    {
                        var subjectToAdd = subject.Replace(" ", string.Empty).ToLower();
                        subjectsList.Add(subjectToAdd);
                    }
                }
            }

            return subjectsList;
        }
    }

    public class Distance
    {
        public static double Euclidean(ReviewPoint p1, ReviewPoint p2)
        {
            return Math.Sqrt(Math.Pow(p1.GenreId - p2.GenreId, 2) + Math.Pow(p1.NumberOfReviews - p2.NumberOfReviews, 2));
        }

        public static double EuclideanSimilarity(ReviewPoint p1, ReviewPoint p2)
        {
            return 1 / (1 + Euclidean(p1, p2));
        }
    }

    public class ReviewPoint
    {
        public int GenreId { get; set; }
        public double NumberOfReviews { get; set; }
    }
}
