using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Models
{
    public class CoolBlue : ISite
    {
        public string Url => "https://www.coolblue.nl/gaming-headsets/logitech-g/";

        public Func<HtmlDocument, List<HtmlNode>> Filter => x=> x.DocumentNode.Descendants("div")
        .Where(x => x.GetAttributeValue("class", "").Equals("product-grid__card")).ToList();

        public Func<HtmlNode?, IProduct> CreateProduct => throw new NotImplementedException();
    }
}
