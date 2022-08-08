using HBRDemoApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HBRDemoApp.Services
{
    internal class ProductService
    {
        public static async Task<List<ProductModel>> GetProducts() { 
            ProductModel model = new ProductModel();
            
            return await ProductService.GetProducts();
        }

        public static async Task<ProductModel> GetProduct(int id)
        {

            ProductModel model = new ProductModel();
            return  model;
        }

        public static async Task<bool> CreateProduct(ProductModel product)
        {

            ProductModel model = new ProductModel();
            return true;
        }

        public static async Task<bool> UpdateProduct(int id,ProductModel product)
        {

            ProductModel model = new ProductModel();
            return true;
        }
        public static async Task<bool> DeleteProduct(int id)
        {

            ProductModel model = new ProductModel();
            bool deleted = true;
            return deleted;
        }

    }
}
