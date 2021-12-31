// See https://aka.ms/new-console-template for more information
using CrawlerDemo;
using CrawlerDemo.Sites;

Console.WriteLine("Hello, World!");

var products = await Functions.startCrawlerasync(new Bol());

if(products.Count > 0) { 
    foreach(var item in products)
    {
        Console.WriteLine(item.Name.Replace("\n",""));
    }

    Console.ReadLine();
}