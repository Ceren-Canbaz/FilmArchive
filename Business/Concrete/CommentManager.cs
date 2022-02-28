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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public IResult Add(Comment comment)
		{
			_commentDal.Add(comment);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Comment comment)
		{
			_commentDal.Delete(comment);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<Comment> GetById(int id)
		{
			return new SuccessDataResult<Comment>(_commentDal.Get(c => c.Id == id));
		}

		public IDataResult<List<Comment>> GetByUserId(int id)
		{
			return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(c => c.UserId == id));
		}

		public IDataResult<List<Comment>> GetForFilm(int id)
		{
			return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(c => c.FilmId == id));
		}

		public IResult Update(Comment comment)
		{
			_commentDal.Update(comment);
			return new SuccessResult(Messages.Updated);
		}
	}
}
