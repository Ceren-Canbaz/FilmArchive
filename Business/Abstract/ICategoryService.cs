using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICategoryService
	{
		IDataResult<List<Category>> GetAll();
		IResult Add(Category category);
		IResult Update(Category category);
		IResult Delete(Category category);
	}
}
