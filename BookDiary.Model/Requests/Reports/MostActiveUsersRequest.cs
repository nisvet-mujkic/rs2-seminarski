﻿using System;

namespace BookDiary.Model.Requests.Reports
{
    public class MostActiveUsersRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? GenreId { get; set; }
    }
}
