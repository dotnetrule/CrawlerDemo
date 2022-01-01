namespace Crawler.Core.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        string Description { get; set; }
        int ProductId { get; set; }
        string Link { get; set; }
    }
}