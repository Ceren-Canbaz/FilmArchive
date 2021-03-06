using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IFavoriteListService
	{
		IDataResult<List<FavoriteList>> GetUsersFavoriteList(int id);
		IResult Add(FavoriteList favoriteList);
		IResult Delete(FavoriteList favoriteList);
		IResult Update(FavoriteList favoriteList);
	}
}
