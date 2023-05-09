using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ConCrete
{
	public class BlogManager : IBlogServicess
	{
		IBlogDall _blogDall;

		public BlogManager(IBlogDall blogDall)
		{
			_blogDall = blogDall;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAllBlog()
		{
			return _blogDall.GetAll();
		}

		public Blog GetBlogById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDall.GetAll(x => x.Writer_ID == id);
		}

		public List<Blog> GetByIDBlog(int id)
		{
			return _blogDall.GetAll(x => x.Blog_ID == id).ToList();
		}

        public List<Blog> GetListWithCategory()
        {
			return _blogDall.GetListWithCategory();
        }
    }
}
