using System.Collections.Generic;

namespace RazorPagesMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    }
}
