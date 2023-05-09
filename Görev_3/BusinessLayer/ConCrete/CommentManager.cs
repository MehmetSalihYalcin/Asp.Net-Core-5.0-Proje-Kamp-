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
	public class CommentManager : ICommentServices
	{
		ICommentDall _comment;

		public CommentManager(ICommentDall comment)
		{
			_comment = comment;
		}

		public void CommentAdd(Comment comment)
		{
			_comment.Insert(comment);
		}

		public List<Comment> GetAllComment(int id)
		{
			return _comment.GetAll(x => x.Blog_ID == id);
		}
	}
}
