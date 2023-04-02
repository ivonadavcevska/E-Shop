using E_Shop.Data;
using E_Shop.Models;
using E_Shop.ViewModels;

namespace E_Shop.Services
{
    public class ProductsService : ProductsServiceInterface
    {

        //private readonly StubData _stubDataContext;

        private readonly AppDbContext _context;

        public ProductsService(AppDbContext appDbContext)
        {
            _context= appDbContext;
        }

        public IEnumerable<Product> getAllProducts()
        {
            return _context.Products.OrderBy(p=>p.Name);
        }

        public Product getProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public ProductPaginationViewModel getProductsBySearch(string search, int page = 1)
        {
            if (string.IsNullOrEmpty(search))
                return CreateProductPaginationViewModel_Helper(getAllProducts(), page);

            else
            {
                var searchedProducts = getAllProducts().Where(p =>
                    p.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.Brand.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.Color.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    p.Price.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                
                    return CreateProductPaginationViewModel_Helper(searchedProducts, page);
            }
        }



        public ProductPaginationViewModel getProductsByFilter(List<string> colors, int page = 1)
        {


            if (colors.Count == 0)
                return CreateProductPaginationViewModel_Helper(getAllProducts(), page);


            var searchedProducts = getAllProducts().Where(p => colors.Contains(p.Color));
            return CreateProductPaginationViewModel_Helper(searchedProducts, page, colors);
            
        }



        private ProductPaginationViewModel CreateProductPaginationViewModel_Helper(IEnumerable<Product> products, int page, List<string> colors = null)
        {
            int pageSize = 2;
            int totalCount = products.Count();
            int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var pagedProducts = products.Skip((page - 1) * pageSize).Take(pageSize);

            var x = products.Select(p => p.Color).Distinct().ToList();
            
            var selectedColors = new List<String>();
            if (colors != null)
                selectedColors = colors;

            return new ProductPaginationViewModel
            {
                CurrentPage = page,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages,
                Products = pagedProducts,
                SelectedColors = selectedColors,
                Colors = x
            };

        }


        public void addNewProduct(Product product) 
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }

        public void deleteProduct(int id)
        {
            var productForDelete = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (productForDelete != null)
            {
                _context.Products.Remove(productForDelete);
                _context.SaveChanges();
            }
            else
                throw new ArgumentException("Bad ID! Product with:" + id.ToString() + " does not exsist!");
        }
    }
}
