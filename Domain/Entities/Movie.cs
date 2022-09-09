using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Writers { get; set; } = string.Empty;
        public string Actors { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;
        public String Genre { get; set; }
        [JsonIgnore]
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
