using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrate;

namespace BusinessLayer.Abstract
{
	public interface IBlogServices  : IGenericServices<Blog>
    {
        List<Blog> GetListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
    }
}
