namespace _03_removeInLoop;

class Program


{



    List<Pickup> pickups = new List<Pickup>();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
    }


        internal void run()
        {
        for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0
                };
                pickups.Add(pickup);
            }


        //foreach(Pickup pickup in pickups)
        //    {
        //        if( pickups.x == 4)
        //        {
        //            pickups.Remove(pickup);
        //        }
        //    }

            for (int i = pickups.Count-1; i >=0; i--)
            {

                Pickup pickup = pickups[i];
                if( pickup.x == 4)
                {
                    pickups.Remove(pickup);
                    Console.WriteLine($"{i} : Picked up");
                }
                else
                {
                    Console.WriteLine($"{i} : still here");
                }
            }



        }
}

