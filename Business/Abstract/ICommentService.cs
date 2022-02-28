using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICommentService
	{
		IDataResult<List<Comment>> GetForFilm(int id);
		IDataResult<List<Comment>> GetByUserId(int id);
		IDataResult<Comment> GetById(int id);
		IResult Add(Comment comment);
		IResult Update(Comment comment);
		IResult Delete(Comment comment);
	}
}
