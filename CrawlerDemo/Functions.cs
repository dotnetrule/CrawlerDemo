using CrawlerDemo.Sites;
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
        public static async Task<List<IProduct>> startCrawlerasync(ISite site)
        {
            var url = site.Url;
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var products = new List<IProduct>();

            var divs = site.Filter(htmlDocument);
            //.DocumentNode.Descendants("li")
             //           .Where(x => x.GetAttributeValue("class", "").Equals("product-item--row js_item_root ")).ToList();
            foreach (var div in divs)
            {
                var product = site.CreateProduct(div);
                products.Add(product);
            }

            return await Task.FromResult(products);
            
        }
    }
}
