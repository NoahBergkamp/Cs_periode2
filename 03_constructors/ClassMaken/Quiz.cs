class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] IngevuldeAntwoorden;
    internal Quiz(int aantalVragen)
    {
        
        vragen = new QuizVraag[aantalVragen];
        IngevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];

    }
    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }
    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
            vragen[index] = quizVraag;
            quizVraag.vraag = "wat is de omtrek van de aarde";
            quizVraag.antwoord = "ongeveer 40.000km";

        }
}