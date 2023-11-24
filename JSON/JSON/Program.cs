using Newtonsoft.Json;
using JSON;

SuperHero hero = new SuperHero
{
    Name = "Invisible Sharpshooter",
    Age = 34,
    IsEvil = false
};

hero.superpower.abilities = new string[] 
{
    "sharp eye",
    "invisibility",
    "telekinesis",
    "acid generation",
    "sonic scream",
    "resurrection",
    "time manipulation"
};

hero.superpower.isUnique = true;

string json = JsonConvert.SerializeObject(hero, Formatting.Indented);

File.WriteAllText(@"C:\1\superhero.json", json);
Console.WriteLine("Object written to file");