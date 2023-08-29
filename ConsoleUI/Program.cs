


using System.Text;
using TypingGameLibrary;

WordParsing wordParser = new WordParsing();
string wordsPath = "C:\\src\\git-projects\\TypeGameApp\\TypingGameLibrary\\Words.txt";
//string word = wordParser.ParseWords(wordsPath);
//Console.WriteLine(word);
//StringToChars();

int Score = 0;
int Errors = 0;
CompareKeyPress(wordParser.ParseWords(wordsPath));
Console.WriteLine($"\nYour score is {Score} and you have {Errors} errors.");


List<char> GetCharacters()
{
    List<char> characters = new List<char>();
    
    for (int i = 97; i<123; i++)
    {
        characters.Add((char)i);
    }
    return characters;
}
void StringToChars()
{
    List<Char> letters = new List<Char>();

    string words = wordParser.ParseWords(wordsPath);
    var wordSplit = words.Split("");
    foreach (var word in wordSplit)
    {
        //Console.WriteLine(word);
        foreach (var letter in word)
        {
            letters.Add(letter);
        }
    }

    bool openLoop = false;
    do
    {
        foreach (var letter in letters)
        {
            if (GetCharacters().Contains(letter))
            {
                Console.Write(letter);
            }
            else
            {
                Console.WriteLine();
            }
        }
    } while (openLoop);

}



// Compare char with button pressed
void CompareKeyPress(string word)
{
    Console.WriteLine(word);

    foreach (var letter in word)
    {
        Console.Write(letter);
        if (Console.ReadKey(true).KeyChar == letter)
        {
            Score += 1;
        }
        else {
            Console.Write(Console.ReadKey(true).KeyChar);
            Errors += 1; 
        }
    }
}

