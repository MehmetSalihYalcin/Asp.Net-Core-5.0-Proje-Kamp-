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
	public class BlogManager : IBlogServices
	{
		IBlogDall _blogDall;

		public BlogManager(IBlogDall blogDall)
		{
			_blogDall = blogDall;
		}

		public void TAdd(Blog t)
		{
			_blogDall.Insert(t);
		}

		public void TDelete(Blog t)
		{
			 _blogDall.Delete(t);
		}

		public void TUpdate(Blog blog)
		{
			_blogDall.Update(blog);
		}

		public List<Blog> TGetAll()
		{
			return _blogDall.GetAll();
		}
        public List<Blog> GetAllCategoryByWriter(int id)
        {
            return _blogDall.GetListWithCategoryByWriter(id);
        }

        public Blog TGetById(int id)
		{
			return _blogDall.GetById(id);
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDall.GetAll(x => x.Writer_ID == id);
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogDall.GetAll().Take(3).ToList();
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
