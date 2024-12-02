namespace Blazor_EF_CRUD.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int ReleaseYear { get; set; }
    }
}
