namespace _04_linq;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        List<Mob> mobs = new List<Mob>()
        {
            new Mob(){name="orc"},
            new Mob(){name="goblin"},
            new Mob(){name="sceleton"}
        };
        Random rng = new Random();

        for (int i = 0; i<100; i++) 
        {
            foreach(Mob m in mobs)
            {
                int getal = rng.Next(100);
                if(getal < 30)
                {
                    m.TakeDamage(1);
                }
            }
        }
        List<Mob> defeated = mobs.Where(mob => mob.isDead).ToList();

        foreach (Mob mob in defeated)
        {
           Console.WriteLine("mob was defeated" + mob.name);
        }


    }
}
