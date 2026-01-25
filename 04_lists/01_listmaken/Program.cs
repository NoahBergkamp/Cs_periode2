namespace _01_listmaken;

class Program
{
    
    string[] Caracters = {"Pac-man", "Samus" , "Crash Bandicoot", "Spyro The Dragon", "Donkey kong", "mario", "luigi", "Astro", "solid Snake", "Master Chief", "Kratos", "sonic the Hedgehog", "Link" };
    

    static void Main(string[] args)
    {
        
        

        Program program = new Program();
        program.run();

    }

    internal void run()
    {  
        List<string>characterList = new List<string>();
        characterList.Add("Radiance");
        



    for (int i = 0; i < Caracters.Length; i++)
        {
            characterList.Add(Caracters[i]);
        }

    for (int I = 0; I < characterList.Count; I++)
        {
           Console.WriteLine(characterList[I]);
        }

    foreach(string Caracters in characterList)
    {
         
        Console.WriteLine(Caracters);
    }

    }
}
