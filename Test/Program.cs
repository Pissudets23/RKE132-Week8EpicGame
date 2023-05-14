string path = @"C:\Users\Desktop\Data\";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines($"{path} + {fileName}");

foreach (string hero in lines)
{
    Console.WriteLine(hero);
}