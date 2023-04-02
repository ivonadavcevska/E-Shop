using E_Shop.Models;
using E_Shop.ViewModels;

namespace E_Shop.Services
{
    public interface ProductsServiceInterface
    {
        IEnumerable<Product> getAllProducts();

        Product getProductById(int id);

        ProductPaginationViewModel getProductsBySearch(string search, int page);
        ProductPaginationViewModel getProductsByFilter(List<string> colors, int page);

        void addNewProduct(Product product);
        void deleteProduct(int id);
    }
}
