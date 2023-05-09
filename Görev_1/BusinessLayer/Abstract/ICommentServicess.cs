using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentServicess
	{
		void CommentAdd(Comment comment);

		//void BlogDelete(Blog blog);
		//void BlogUpdate(Blog blog);

		List<Comment> GetAllComment(int id);

		//Blog GetBlogById(int id);
		//List<Blog> GetListWithCategory();
	}
}
