using TomAndIO.Models.Dto;

namespace TomAndIO.Models.Page;

public class ProductOverviewPage
{
    public ProductOverviewPage(int pageNumber, int totalNumberOfPages, bool hasNextPage,
        bool hasPreviousPage, List<ProductOverviewDto> products)
    {
        PageNumber = pageNumber;
        TotalNumberOfPages = totalNumberOfPages;
        HasNextPage = hasNextPage;
        HasPreviousPage = hasPreviousPage;
        Products = products;
    }

    public int PageNumber { get; set; }

    public int TotalNumberOfPages { get; set; }

    public bool HasNextPage { get; set; }

    public bool HasPreviousPage { get; set; }

    public List<ProductOverviewDto> Products { get; set; }
}