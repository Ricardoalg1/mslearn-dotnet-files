using Newtonsoft.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region 
//Ejercicio COmpleto leer todos los valores en los distintos archivos json sumarlos y agregarlos en un nuevo archivo y carpeta 


var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

var salesFiles = FindFiles(storesDirectory);

var salesTotal = CalculateSalesTotal(salesFiles);

File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}

record SalesData(double Total);

#endregion



#region 

//Creacion de un directorio un archivo y escritura de un valor leido en un archivo a otro
/*
var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
var salesData = JsonConvert.DeserializeObject<salesTotal>(salesJson);
System.Console.WriteLine(salesData.Total);
System.Console.WriteLine(salesData.NumberStore);

var data = JsonConvert.DeserializeObject<salesTotal>(salesJson);
/* Para sobre escribir 
File.WriteAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());


//Para agregar 

File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{Environment.NewLine}{data.Total}");

class salesTotal
{
    public double Total { get; set; }
    public int NumberStore { get; set; }
}
*/
#endregion

#region
// Make a Directory 
/*
var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);
var salesFiles = FindFiles(storesDirectory);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

*/
#endregion



#region
/*
//Make a Directory
var path = Path.Combine(Directory.GetCurrentDirectory(), "stores", "208");

bool doesDirectoryExist = Directory.Exists(path);


if (doesDirectoryExist != false)
{
    System.Console.WriteLine("The directory exists!");
}
else
{
    Directory.CreateDirectory(path);
    System.Console.WriteLine("Doent exist!, created");
    File.WriteAllText(Path.Combine(path, "greeting.txt"), "Hello mama guevos!");
}




//Make a Directory
*/
#endregion



#region 
/*
var currentDirectory = Directory.GetCurrentDirectory();

var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesFiles = FindFiles(storesDirectory);

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}

IEnumerable<string> FindFiles(string folderName)
{

    List<string> salesfiles = new List<string>();
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesfiles.Add(file);
        }
    }
    return salesfiles;
}

System.Console.WriteLine("End Exercise 1");
*/
#endregion



#region
/*
/*var salesFiles = FindFiles("stores");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
} 

Console.WriteLine(Directory.GetCurrentDirectory());

string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
System.Console.WriteLine(docPath);

System.Console.WriteLine("Caracter especial de Directorios");
Console.WriteLine($"Folder{Path.DirectorySeparatorChar}Files");

//Make Path Flexible acording to S.O.

Console.WriteLine(Path.Combine("stores", "201")); // outputs: stores/201

// Determine then files' extension

Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json


// extract the complete information about files and folders 
string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more

/*
IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}
*/

#endregion