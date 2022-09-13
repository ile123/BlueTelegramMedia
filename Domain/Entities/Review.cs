using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public int ReviewerId { get; set; }

        public int Rating { get; set; }
        public string FilmReview { get; set; } = string.Empty;
    }
}
