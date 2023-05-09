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
    public class CategoryManager : ICategoryServices
    {
        ICategoryDall _catagoryDal; // ICategoryDall dan nesne türet 

        public CategoryManager(ICategoryDall catagoryDal) // parametreli constract
        {
            _catagoryDal = catagoryDal; // birbirine eşitle
        }

        public void TAdd(Category t)
        {
            _catagoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _catagoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _catagoryDal.Update(t);
        }

        public List<Category> TGetAll()
        {
            return _catagoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _catagoryDal.GetById(id);
        }
    }
}
