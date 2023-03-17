using BusinessLayer.Abstract;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ConCrete
{
    public class CategoryManager : ICategoryServicess
    {
        EfCategoryRepository efcategory;

        public CategoryManager()
        {
            efcategory = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efcategory.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efcategory.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
           efcategory.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return efcategory.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return efcategory.GetById(id);
        }
    }
}
