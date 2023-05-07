namespace GuessTheWord;

public static class GameHelpers
{
    public static bool CheckLetter(char letter, string targetWord)
    {
        return targetWord.Contains(letter, StringComparison.InvariantCultureIgnoreCase);
    }

    public static IEnumerable<char> TargetLetters(string targetWord)
    {
        return targetWord
            .Except(" ")
            .Distinct();
    }

    public static bool AllLettersFound(string targetWord, IEnumerable<char> foundLetters)
    {
        return TargetLetters(targetWord)
            .All(foundLetters.Contains);
    }
}