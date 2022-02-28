using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IPointService
	{
		decimal CalculationofPoints(Point point,int pointcount);
		IResult Add(Point point);
		IResult Update(Point point);
		IResult Delete(Point point);
	}
}
