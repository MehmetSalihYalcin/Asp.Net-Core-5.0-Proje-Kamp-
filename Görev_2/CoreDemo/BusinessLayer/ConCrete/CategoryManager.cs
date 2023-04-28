using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        ICategoryDall _catagoryDal; // ICategoryDall dan nesne türet 

        public CategoryManager(ICategoryDall catagoryDal) // parametreli constract
        {
            _catagoryDal = catagoryDal; // birbirine eşitle
        }

        public void CategoryAdd(Category category)
        {
            _catagoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _catagoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _catagoryDal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return _catagoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _catagoryDal.GetById(id);
        }
    }
}
