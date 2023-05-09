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
	public class WriterManager : WriterServices
	{
		IWriterDall _writer;

		public WriterManager(IWriterDall writer)
		{
			_writer = writer;
		}

		public void WriterAdd(Writer writer)
		{
			_writer.Insert(writer);
		}
	}
}
