using HBRDemoApp.Models;
using HBRDemoApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HBRDemoApp.Modules
{
    public class ProductModule
    {
        public ProductModule()
        {

        }

        public async Task<List<ProductModel>> GetProducts()
        {
            return await ProductService.GetProducts(); ;
        }

        public async Task<ProductModel> GetProduct(int id)
        {
            return await ProductService.GetProduct(id); ;
        }

        public async Task<bool> CreateOrUpdateProduct(int id, string name, string description, decimal value, string category)
        {
            bool created = false;
            var categoryData = await CategoryService.GetCategoryByName(category);
            if (id == 0)
            {
                var product = await ProductService.GetProduct(id);

                if (product != null)
                {
                    product.Name = name;
                    product.Description = description;
                    product.Value = value;
                    product.Category = categoryData;

                    created = await ProductService.UpdateProduct(id, product);
                }
            }
            else
            {
                if (categoryData != null)
                {
                    var newProduct = new ProductModel
                    {
                        Name = name,
                        Description = description,
                        Value = value,
                        Category = categoryData
                    };
                    created = await ProductService.CreateProduct(newProduct);
                }
            }
            return created;
        }

        public async Task<bool> DeleteProduct(int id)
        {          
            return await ProductService.DeleteProduct(id);
        }
    }
}
