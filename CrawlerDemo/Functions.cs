using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerDemo
{
    internal class Functions
    {
        public static async Task startCrawlerasync()
        {
            var url = "https://www.nu.nl/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var products = new List<Product>();

            var divs = htmlDocument.DocumentNode.Descendants("li")
                        .Where(x => x.GetAttributeValue("class", "").Equals("list__item list__item--text")).ToList();
            foreach (var div in divs)
            {
                var product = new Product
                {
                    Name = div.Descendants("span").FirstOrDefault().InnerText,
                    Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value
                };
                products.Add(product);
            }

            
        }
    }
}
