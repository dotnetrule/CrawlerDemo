using HtmlAgilityPack;

namespace Crawler.Core.Models
{
    public class Bol : ISite
    {
        public string Url => "https://www.bol.com/nl/nl/l/gaming-muizen/18212/";

        public Func<HtmlDocument, List<HtmlNode>> Filter => x=> x.DocumentNode.Descendants("li").Where(x => x.GetAttributeValue("class", "").Equals("product-item--row js_item_root ")).ToList();

        public Func<HtmlNode?, IProduct> CreateProduct => x => new Product
        {
            Name = x.Descendants("div").Where(x => x.GetAttributeValue("class", "").Equals("product-title--inline"))?.FirstOrDefault()?.InnerText,
            Link = x.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault()?.Value,
            Description = x.Descendants("meta").Where(x => x.GetAttributeValue("itemprop", "").Equals("price"))?.FirstOrDefault()?.GetAttributeValue("content", ""),
        };

    }
}
