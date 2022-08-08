using HBRDemoApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HBRDemoApp.Services
{
    public class CategoryService
    {
        public static async Task<List<CategoryModel>> GetCategories()
        {
            CategoryModel model = new CategoryModel();

            return await CategoryService.GetCategories();
        }

        public static async Task<CategoryModel> GetCategory(int id)
        {

            CategoryModel model = new CategoryModel();
            return model;
        }

        public static async Task<CategoryModel> GetCategoryByName(string name)
        {

            CategoryModel model = new CategoryModel();
            return model;
        }

        public static async Task<CategoryModel> CreateCategory(CategoryModel category)
        {

            CategoryModel model = new CategoryModel();
            return model;
        }

        public static async Task<CategoryModel> UpdateCategory(int id, CategoryModel category)
        {

            CategoryModel model = new CategoryModel();
            return model;
        }
        public static async Task<bool> DeleteCategory(int id)
        {

            CategoryModel model = new CategoryModel();
            bool deleted = true;
            return deleted;
        }
    }
}
