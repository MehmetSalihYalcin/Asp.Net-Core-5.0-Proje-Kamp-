using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogServicess
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> GetAllBlog();
		Blog GetBlogById(int id);
		List<Blog> GetListWithCategory();
		List<Blog> GetBlogListByWriter(int id);
	}
}
