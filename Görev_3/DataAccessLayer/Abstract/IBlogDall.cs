using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDall : IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory(); // sadece bloklara  özel olduğundan burada tanımlandı
        List<Blog> GetListWithCategoryByWriter(int id); // sadece bloklara  özel olduğundan burada tanımlandı
    }
}
