using System.Text.Json;


var options = new JsonSerializerOptions
{
    WriteIndented = true,
    IndentCharacter = '\t',
    IndentSize = 2,
};

var json1 = JsonSerializer.Serialize(new { Value = 1 }, options);
var json2 = JsonSerializer.Serialize(new { Value = 1 }, JsonSerializerOptions.Web);

Console.WriteLine(json1);
Console.WriteLine();
Console.WriteLine(json2);

Console.ReadKey();