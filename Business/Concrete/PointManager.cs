using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class PointManager : IPointService
	{
		IPointDal _pointDal;

		public PointManager(IPointDal pointDal)
		{
			_pointDal = pointDal;
		}

		public IResult Add(Point point)
		{
			throw new NotImplementedException();
		}

		public decimal CalculationofPoints(Point point, int pointcount)
		{
			throw new NotImplementedException();
		}

		public IResult Delete(Point point)
		{
			throw new NotImplementedException();
		}

		public IResult Update(Point point)
		{
			throw new NotImplementedException();
		}
	}
}
