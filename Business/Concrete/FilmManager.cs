using Business.Abstract;
using Business.Constants;
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
			_filmDal.Add(film);
			return new SuccessResult(Messages.FilmsAdded);
		}

		public IResult Delete(Film film)
		{
			_filmDal.Delete(film);
			return new SuccessResult(Messages.FilmsDeleted);
		}

		public IDataResult<List<Film>> GetAll()
		{
			return new SuccessDataResult<List<Film>>(_filmDal.GetAll());
		}

		public IDataResult<List<Film>> GetAllByCategory(int id)
		{
			return new SuccessDataResult<List<Film>>(_filmDal.GetAll(f=>f.TypeId==id),Messages.FilmsListed);
		}

		public IDataResult<Film> GetById(int id)
		{
			return new SuccessDataResult<Film>(_filmDal.Get(f => f.Id == id));
		}

		public IResult Update(Film film)
		{
			_filmDal.Update(film);
			return new SuccessResult(Messages.FilmsUpdated);
		}
	}
}
