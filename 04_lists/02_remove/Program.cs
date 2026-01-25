namespace _02_remove;

class Program
{
    static void Main(string[] args)
    {
        List<double>Reviews = new List <double>(){9.99 , 4.68 , 34.29 , 12.2};
        Reviews.Remove(34.29);
        Reviews.RemoveAt(1);


        for (int i = 0; i < Reviews.Count; i++)
        {
            Console.WriteLine(Reviews[i]);
        }
    }
}
