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
	public class MovieTypeManager : IMovieTypeService
	{
		IMovieTypeDal _movieTypeDal;

		public MovieTypeManager(IMovieTypeDal movieTypeDal)
		{
			_movieTypeDal = movieTypeDal;
		}

		public IResult Add(MovieType movieType)
		{
			_movieTypeDal.Add(movieType);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(MovieType movieType)
		{
			_movieTypeDal.Delete(movieType);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<MovieType>> GetAll()
		{
			return new SuccessDataResult<List<MovieType>>(_movieTypeDal.GetAll());
		}

		public IResult Update(MovieType movieType)
		{
			_movieTypeDal.Update(movieType);
			return new SuccessResult(Messages.Updated);
		}
	}
}
