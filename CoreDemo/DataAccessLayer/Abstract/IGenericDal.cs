using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class  // classa ait bütün değerleri kullan T değeri gelen veri
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll(); // bütün listeyi listele
        T GetById(int id);
    }
}
