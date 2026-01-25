namespace _02_readlines;

class Program
{
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?"
        };
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }
        internal void Vraag1()
        {
            
            Console.WriteLine("How long do you think you'd survive in a zombie apocolypse");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Ik kan opzeminst 1 uur overleven");
        }
        
        internal void Run()
        {
            
            Console.WriteLine("dit is de start van mij programma");
            Console.WriteLine("we gaan een vraag stellen");
            Vraag1();
            
        }  
        
          internal void Vraag2()
        {
            
            Console.WriteLine("What is beter Friet of Patat");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Dat is overduidelijk Friet");
        }


                        internal void Vraag3()
        {
            
            Console.WriteLine("wat is de meest gesproken taal in de wereld");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Dat is manderijn");
        }
        
        internal string Vraag7()
        {   
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

        return(antwoord);
        }

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            Random rnd = new();
            int random = rnd.Next(vragen.Length);
            // gebruik Random
            
            return GetVraag(random);
        }

        


}

    
        



