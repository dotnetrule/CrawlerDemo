using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlerDemo.Sites
{
    internal class Bol : ISite
    {
        public string Url => "https://www.bol.com/nl/nl/l/gaming-muizen/18212/";

        public Func<HtmlDocument, List<HtmlNode>> Filter => x=> x.DocumentNode.Descendants("li").Where(x => x.GetAttributeValue("class", "").Equals("product-item--row js_item_root ")).ToList();
    }
}
