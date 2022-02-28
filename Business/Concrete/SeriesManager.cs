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
	public class SeriesManager : ISeriesService
	{
		ISeriesDal _seriesDal;

		public SeriesManager(ISeriesDal seriesDal)
		{
			_seriesDal = seriesDal;
		}

		
		public IResult Add(Series series)
		{
			_seriesDal.Add(series);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Series series)
		{
			_seriesDal.Delete(series);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<Series>> GetAll()
		{
			return new SuccessDataResult<List<Series>>(_seriesDal.GetAll());
		}

		public IDataResult<List<Series>> GetAllByCategory(int id)
		{
			return new SuccessDataResult<List<Series>>(_seriesDal.GetAll(s => s.TypeId == id));
		}

		public IDataResult<Series> GetById(int id)
		{
			return new SuccessDataResult<Series>(_seriesDal.Get(s => s.Id == id));
		}

		public IResult Update(Series series)
		{
			_seriesDal.Update(series);
			return new SuccessResult(Messages.Updated);
		}
	}
}
