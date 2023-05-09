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
	public class AboutManager:IAboutServices
	{
		IAboutDall _aboutDal;

		public AboutManager(IAboutDall aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public List<About> TGetAll()
		{
			return _aboutDal.GetAll();
		}

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
