using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IFilmService
	{
		IDataResult<List<Film>> GetAll(); //data ve islem sonucu döndürülecek
		IDataResult<List<Film>> GetAllByCategory(int id); //kategoriye göre getirecek
		IDataResult<Film> GetById(int id);
		IResult Add(Film film);
		IResult Update(Film film);
		IResult Delete(Film film);
	}
}
