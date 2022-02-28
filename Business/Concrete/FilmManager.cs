using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class FilmManager:IFilmService
	{
		IFilmDal _filmDal;

		public FilmManager(IFilmDal filmDal)
		{
			_filmDal = filmDal;
		}

		public IResult Add(Film film)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Film film)
		{
			throw new NotImplementedException();
		}

		public IDataResult<List<Film>> GetAll()
		{
			return new SuccessDataResult<List<Film>>(_filmDal.GetAll());
		}

		public IDataResult<List<Film>> GetAllByCategory(int id)
		{
			throw new NotImplementedException();
		}

		public IDataResult<Film> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Film film)
		{
			throw new NotImplementedException();
		}
	}
}
