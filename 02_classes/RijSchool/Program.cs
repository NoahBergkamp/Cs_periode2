namespace RijSchool;

    internal class Program
{
    static void Main(string[] args)

    

    {
        Program program = new Program();
        program.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken ="AA824H",
            kilometerstand= 20567,
            merk= "volkswagen",
        };

        Auto auto2 =new Auto()
        {
            automaat = false,
            kenteken ="KU786G",
            kilometerstand = 65739,
            merk = "volvo",
        };

        Rijleraar rijleraar = new Rijleraar()
        {
            leeftijd = 30,
            naam = "john",
            zzp = false,
        };

        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijleraar = rijleraar,
            tijd = 1130,
        };

                LesUur lesUur2 = new LesUur()
        {
            auto = auto2,
            rijleraar = rijleraar,
            tijd = 1330,
        };

        lesPakket lesPakket = new lesPakket()
        {
            urenGekocht = 10,
            urenVerbruikt = 0,
            examenPogingen = 0,
            automaat = true,
        };

        TheorieTest theorieTest = new TheorieTest()
        {
            aantalFouten = 0,
            gehaald = false,
            afnameDatum = DateTime.Now,
        };

        RijTest rijTest = new RijTest()
        {
            gehaald = false,
            afnameDatum = DateTime.Now,
        };

        Student student = new Student()
        {
            lespakket = lesPakket,
            theorieTest = theorieTest,
            rijTest = rijTest,
            leraar = rijleraar
        };

        Dag dag = new Dag()
        {
            Student2 = student,
            lesuren = new LesUur[]{lesUur}
            

        };


    }

}
