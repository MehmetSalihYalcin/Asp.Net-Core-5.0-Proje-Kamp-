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
	public class CityManager : ICitiyServices
	{
		ICityDall _cityDall;

		public CityManager(ICityDall cityDall)
		{
			_cityDall = cityDall;
		}

		public List<City> GetAllCitys()
		{
		  return	_cityDall.GetAll();
		}
	}
}
