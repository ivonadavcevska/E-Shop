using E_Shop.Models;

namespace E_Shop.ViewModels
{
    public class ProductPaginationViewModel
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public List<string> Colors { get; set; }

        public List<string> CheckedColors { get; set; }
        
    }
}
