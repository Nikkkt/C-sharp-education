static int CountFiles(string path)
{
    int count = 0;
    string[] files = Directory.GetFiles(path);
    count += files.Length;

    string[] subdirectories = Directory.GetDirectories(path);
    foreach (string subdirectory in subdirectories) count += CountFiles(subdirectory);

    return count;
}

string path = @"C:\Program Files (x86)\Microsoft Visual Studio";
int fileCount = CountFiles(path);
Console.WriteLine(fileCount);