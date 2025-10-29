using PlaneFiles.Core;

var textFile = new SimpleTextFile("data.txt");
var linesReaded = textFile.ReadAllLines();

foreach (var line in linesReaded)
{
    Console.WriteLine(line);
}