namespace GuessTheWord;

public static class Films
{
    private static readonly List<string> _answerList = new()
    {
        "Mission Impossible",
        "The Matrix",
        "Terminator",
        "Star Trek",
        "Star Wars",
        "The Lord of the Rings",
        "The Hobbit",
        "Harry Potter",
        "The Avengers",
        "The Lion King",
        "Alien",
        "Men in Black",
        "Galaxy Quest",
        "Ghostbusters",
        "Back to the Future",
        "Indiana Jones",
        "Spiderman",
        "Superman",
        "Wonder Woman"

    };
    
    public static string Random()
    {
        return _answerList[new Random().Next(0, _answerList.Count)].ToUpper();
    }
}