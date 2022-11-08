using Dz_6.JSONClasses;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.Unicode;

const string path = "./Content.json";

var jsonContent = File.ReadAllText(path);

var info = JsonSerializer.Deserialize<IReadOnlyCollection<ContentJSON>>(jsonContent);

foreach (var item in info)
{
    Console.WriteLine($"Id: {item?.PublishingHouseId}");
    Console.WriteLine($"Title: {item?.Title}");
    Console.WriteLine($"Pusblishing house ID: {item?.PublishingHouse?.Id}");
    Console.WriteLine($"Publishing house Name: {item?.PublishingHouse?.Name}");
    Console.WriteLine($"Publishing house Adress: {item?.PublishingHouse?.Adress}\n");
}

