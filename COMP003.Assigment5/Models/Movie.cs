namespace COMP003.Assigment5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
