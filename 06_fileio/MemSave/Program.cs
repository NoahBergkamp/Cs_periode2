namespace MemSave;

class Program
{
    string welkomstTekst = "hello world";

    string saveFile = "welkomState.txt";


    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
    private void Run()
    {
        bool bestaadDefile = File.Exists(saveFile);
        if(bestaadDefile == true)
        {

            Console.WriteLine("file exists");
            welkomstTekst = File.ReadAllText(saveFile);
        }
        Console.WriteLine(welkomstTekst);
    
        while(true)
        {
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("enter a text, then press enter");
            welkomstTekst = Console.ReadLine();
            if (welkomstTekst.Length > 0)
            {
            File.WriteAllText(saveFile, welkomstTekst);
            }
        }

    }
}
