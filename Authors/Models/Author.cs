namespace Authors.Models
{
    public class Author
    {
        public required Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime BornDate { get; set; }
        public DateTime DieDate { get; set; } = DateTime.MinValue;
        public string Bio { get; set; } = string.Empty;
    }
}
