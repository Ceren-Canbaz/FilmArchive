using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IMovieTypeService
	{
		IDataResult<List<MovieType>> GetAll();
		IResult Add(MovieType movieType);
		IResult Update(MovieType movieType);
		IResult Delete(MovieType movieType);
	}
}
