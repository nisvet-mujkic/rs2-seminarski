using BookDiary.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDiary.API.Helpers.Recommendation
{
    public class Recommendation
    {
        private readonly Dictionary<int, double> userBookReviews = new Dictionary<int, double>();
        private readonly Dictionary<string, double> userBookReviewsByGenre = new Dictionary<string, double>();

    }
}
