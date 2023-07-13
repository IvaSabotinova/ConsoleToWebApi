using ConsoleToWebApi.Models;

namespace ConsoleToWebApi.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}