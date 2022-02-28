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
	public class FavoriteListManager : IFavoriteListService
	{
		IFavoriteListDal _favoriteListDal;

		public FavoriteListManager(IFavoriteListDal favoriteListDal)
		{
			_favoriteListDal = favoriteListDal;
		}
		//yeni kullanıcı icin liste eklenecek
		public IResult Add(FavoriteList favoriteList)
		{
			_favoriteListDal.Add(favoriteList);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(FavoriteList favoriteList)
		{
			_favoriteListDal.Delete(favoriteList);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<FavoriteList>> GetUsersFavoriteList(int id)
		{
			return new SuccessDataResult<List<FavoriteList>>(_favoriteListDal.GetAll(u => u.UserId == id));
		}

		public IResult Update(FavoriteList favoriteList)
		{
			_favoriteListDal.Update(favoriteList);
			return new SuccessResult(Messages.Updated);
		}
	}
}
