namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> lib = new Library<Media>();
            lib.MediaList.Add(new Media() { Author = "Author1", Title = "Title1", YearPublished = 1997, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author2", Title = "Title2", YearPublished = 1972, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author2", Title = "Title3", YearPublished = 2018, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author3", Title = "Title4", YearPublished = 2018, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author3", Title = "Title5", YearPublished = 1905, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author4", Title = "Title6", YearPublished = 2006, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author5", Title = "Title7", YearPublished = 2007, IsAvailable = false });
           
            lib.PrintAll();
        }
    }
}
