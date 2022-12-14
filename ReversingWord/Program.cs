

string Word = "Hello World";
string ReversedWord = string.Empty;
string[] SplittedWord = Word.Split(' ');
string result = string.Empty;
result = $"{Reversing(SplittedWord[0])} {Reversing(SplittedWord[1])}";

Console.WriteLine(result);


static string Reversing(string word)
{
    string ReversedWord = string.Empty;
    
    for (int i = word.Length - 1; i >= 0; i--)
    {
        ReversedWord += word[i];
    }
    return ReversedWord;
}


