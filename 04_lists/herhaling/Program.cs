namespace herhaling;

class Program
{

        double[] prijzen = new double []{ 0.99 , 2.66 , 5.35 , 2.99};
        string[] artiekelen = {"bread" , "potato's" , "meat" , "candy"};

        Formulier[] Formulieren = new Formulier[2];
        
    static void Main(string[] args)
    {

        Program program = new Program();
        program.run();
        


    }
    internal void run()
    {
    Formulieren[0] = new Formulier()
        {
            Feedback = "prijzig maar lekker",
            Sterren = 5
        };

    Formulieren[1] = new Formulier()
        {
            Feedback = "erg duur",
            Sterren = 2
        };

    


    for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
            
        }
    
    foreach(Formulier formulier in Formulieren)
        {
            Console.WriteLine(formulier.Feedback);
            Console.WriteLine(formulier.Sterren);
        }


    }


    
}
