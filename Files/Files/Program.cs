using System.Text.RegularExpressions;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] words = Regex.Replace(File.ReadAllText("C:\\Users\\nikit\\OneDrive\\Рабочий стол\\Programming\\C#\\Files\\eneida.txt").Replace("\r", "").Replace("\n", ""), @"[\p{P}-[.]]+", "").Split(' ');

Dictionary<string, int> sortedWords = new Dictionary<string, int>();
foreach (string word in words)
{
    if (word.Length >= 3 && word.Length <= 20)
    {
        string lowerWord = word.ToLower();
        if (sortedWords.ContainsKey(lowerWord)) sortedWords[lowerWord]++;
        else sortedWords[lowerWord] = 1;
    }
}

List<KeyValuePair<string, int>> wordsList = new List<KeyValuePair<string, int>>(sortedWords);

wordsList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
wordsList.Reverse();

int num = 1;
Console.WriteLine("+----+---------+-----------+\n| №  | Слово   | Кількість |\n+----+---------+-----------+");
foreach (KeyValuePair<string, int> pair in wordsList.Take(50)) { Console.WriteLine($"| {num.ToString().PadRight(2)} | {pair.Key.PadRight(7)} | {pair.Value.ToString().PadRight(9)} |"); num++; }
Console.WriteLine("+----+---------+-----------+");