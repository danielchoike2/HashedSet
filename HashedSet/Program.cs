namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> videoGames = new HashSet<string>();
            videoGames.Add("Resident Evil");
            videoGames.Add("Resident Evil 2");
            videoGames.Add("Resident Evil 3");
            videoGames.Add("Resident Evil 4");
            videoGames.Add("Dead Space");

            HashSet<string> videoGamesRemakes = new HashSet<string>();
            videoGamesRemakes.Add("Resident Evil Remastered");
            videoGamesRemakes.Add("Resident Evil 2: Remastered");
            videoGamesRemakes.Add("Resident Evil 3: Remastered");
            videoGamesRemakes.Add("Resident Evil 4 : Remastered");
            videoGamesRemakes.Add("Dead Space Remastered");

            HashSet<string> videoGameSequels = new HashSet<string>();
            videoGameSequels.Add("Resident Evil 2 ");
            videoGameSequels.Add("Resident Evil 3");
            videoGameSequels.Add("The Last of Us 2");
            videoGameSequels.Add("Dark Cloud 2");
            videoGameSequels.Add("Final Fantasy 13");

            Console.WriteLine("Combined list of older games with remastered versions");
            videoGames.UnionWith(videoGamesRemakes);
            foreach (string videogame in videoGames)
            {
                Console.WriteLine(videogame);
            }
            Console.WriteLine();

            Console.WriteLine("Video games that are in both lists");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = videoGames;
            bothLists.IntersectWith(videoGamesRemakes);
            foreach (string language in bothLists)
            {
                Console.WriteLine(language);
            }
        }
    }
}
