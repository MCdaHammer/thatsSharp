namespace Movies
{
    class Program
    {
       public class RandomGenerator
        {
        public static void Main()
        {
            string[] services = { "Hulu", "Netflix", "Amazon", "Disney+", "HBO Max", "Peacock", "Paramount" };
            string[] genres = { "Comedy", "Horror", "Action", "Romantic-Comedy", "Romance", "Thriller", "Drama" };
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };


            Random randService = new Random();
            Random randGenre = new Random();
            Random randNumber = new Random();
            int serviceNumber = randService.Next(0, services.Length);
            int genreNumber = randGenre.Next(0, genres.Length);
            int numberNumber = randNumber.Next(0, numbers.Length);
            Console.WriteLine($"{services[serviceNumber]}, {genres[genreNumber]}, {numbers[numberNumber]}");
        }

        }
    }
}