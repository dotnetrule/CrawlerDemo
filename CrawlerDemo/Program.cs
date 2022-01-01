// See https://aka.ms/new-console-template for more information
using Crawler.Core.Models;

Console.WriteLine("Hello, World!");

var products = await Crawler.Core.Functions.startCrawlerasync(new Bol());

if(products.Count > 0) { 
    foreach(var item in products)
    {
        Console.WriteLine($"{item.Name.Replace("\n","")} ${item.Description}");
        Console.WriteLine($"{item.Link}");

    }

    Console.ReadLine();
}