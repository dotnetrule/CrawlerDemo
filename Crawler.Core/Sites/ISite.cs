using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Models
{
    public interface ISite
    {
        string Url { get; }
        Func<HtmlDocument, List<HtmlNode>> Filter { get; }
        Func<HtmlNode?, IProduct> CreateProduct { get; }

    }
}
