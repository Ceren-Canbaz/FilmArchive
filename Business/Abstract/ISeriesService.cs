using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ISeriesService
	{
		IDataResult<List<Series>> GetAll();
		IDataResult<List<Series>> GetAllByCategory(int id); 
		IDataResult<Series> GetById(int id);
		IResult Add(Series series);
		IResult Update(Series series);
		IResult Delete(Series series);
	}
}
