namespace exercise.wwwapi.ViewModel
{
    public class BookPut
    {  
        public int Id { get; }
        public string? Title { get; set; }
        public int? NumPages { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
    }
}
