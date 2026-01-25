namespace Schrijven;

using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }


    private void Run()
    {
            string file = "mijntekst.txt";

            File.WriteAllText(file, "testing 123");

            string[] haiku = new string[]
            {
                "The old pond,",
                "a frog jumps in,",
                "sound of water."
            };


            string regelsFile = "mijnregels.txt";
            File.WriteAllLines(regelsFile, haiku);

            FavoriteGame[] games = new FavoriteGame[]
            {
                new FavoriteGame(){ Name = "Zelda Botw", Platform="Switch"},
                new FavoriteGame(){ Name = "Hollow Knight", Platform="PC"},
                new FavoriteGame(){ Name = "MineCraft", Platform="PC"}
            };

            string text = JsonSerializer.Serialize(games);
            Console.WriteLine(text);
            File.WriteAllText("games.json", text);

            FavoriteGame[] loaded = JsonSerializer.Deserialize<FavoriteGame[]>(File.ReadAllText("games.json"));

        foreach(FavoriteGame g in loaded)
        {
            Console.WriteLine($"game {g.Name} on {g.Platform}");
        }
    }
}