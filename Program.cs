


static string Reversing(string word)
{
    string ReversedWord = string.Empty;

    for (int i = word.Length - 1; i >= 0; i--)
    {
        ReversedWord += word[i];
    }
    return ReversedWord;
}

string word = Console.ReadLine();
string ReversedWord = string.Empty;
string[] SplittedWord = word.Split(' ');

for (int i = 0; i < SplittedWord.Length; i++)
{
    
    ReversedWord += Reversing(SplittedWord[i])+' ';
}
Console.WriteLine(ReversedWord);
