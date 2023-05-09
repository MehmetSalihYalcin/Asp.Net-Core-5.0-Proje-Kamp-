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
	public class ContactManager:IContactServices
	{
		IContactDall _contactDall;

		public ContactManager(IContactDall contactDall)
		{
			_contactDall = contactDall;
		}

		public void ContactAdd(Contact contact)
		{
			_contactDall.Insert(contact);
		}
	}
}
