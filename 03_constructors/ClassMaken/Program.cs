namespace ForHerhaling;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

    }
    
    private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("","");
            Quiz quiz = new Quiz(10);
            quiz.VoegVraagToeOpIndex(0, quizVraag);

            Console.WriteLine(quizvraag)
            
        }
}
