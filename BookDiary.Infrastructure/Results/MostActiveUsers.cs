using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookDiary.Infrastructure.Results
{
    [NotMapped]
    public class MostActiveUsers
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public int TotalReadBookCount { get; set; }
        public int TotalPagesRead { get; set; }

    }
}
