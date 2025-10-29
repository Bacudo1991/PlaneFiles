using PlaneFiles.Core;

var textFile = new SimpleTextFile(".//data//data.txt");
var lines = textFile.ReadAllLines().ToList();
var opt = String.Empty;

do
{
    opt = Menu();
    switch (opt)
    {
        case "0":
            Console.WriteLine("::::::::::::::::::::::::::::::::");
            Console.WriteLine("::::::::::: GAME OVER ::::::::::");
            Console.WriteLine(": THANKS FOR USING THE PROGRAM :");
            Console.WriteLine(":::::::: HAVE A GOOD DAY :::::::");
            Console.WriteLine("::::::::::::::::::::::::::::::::");
            break;
        case "1":
            Console.WriteLine("Contenido del archivo:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);            
            }
            break;
        case "2":
            Console.Write("Ingrese una nueva linea de texto: ");
            var newLine = Console.ReadLine();
            if (!string.IsNullOrEmpty(newLine))
            {
                lines.Add(newLine);
                Console.WriteLine("Linea agregada.");            
            }
            break;
        case "3":
            textFile.WriteAllLines(lines.ToArray());
            Console.WriteLine("Archivo guardado.");
            break;
        default:
            Console.WriteLine("Opción no valida. Intente de nuevo.");
            break;    
    }

} while (opt != "0");
textFile.WriteAllLines(lines.ToArray());
Console.WriteLine("Archivo guardado");

string Menu()
{
    Console.WriteLine(":::::::::: MENÚ ::::::::::");
    Console.WriteLine();
    Console.WriteLine("1. Show File");
    Console.WriteLine("2. Add");
    Console.WriteLine("3. Save");
    Console.WriteLine("0. Exit");
    Console.Write("Escoge una opción: ");
    return Console.ReadLine() ?? string.Empty;
}