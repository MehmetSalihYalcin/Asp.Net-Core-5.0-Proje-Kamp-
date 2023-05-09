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
	public class NewLetterManager : INewLetterServices
	{
		INewLetterDall _newLetter;

		public NewLetterManager(INewLetterDall newLetter)
		{
			_newLetter = newLetter;
		}

		public void NewLetterAdd(NewsLetter newsLetter)
		{
			_newLetter.Insert(newsLetter);
		}
	}
}
