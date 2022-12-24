using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class BookshelfManager : IBookshelfService
	{
		IBookshelfDal _bookshelfDal;
		public BookshelfManager(IBookshelfDal bookshelfDal)
		{
			_bookshelfDal = bookshelfDal;
		}


		public IResult Add(Bookshelf bookshelf)
		{
			_bookshelfDal.Add(bookshelf);
			return new SuccessResult(Messages.BookshelfAdded);
		}

		public IResult Delete(Bookshelf bookshelf)
		{
			_bookshelfDal.Delete(bookshelf);
			return new SuccessResult(Messages.BookshelfDelete);
		}

		public IDataResult<List<Bookshelf>> GetAll()
		{
			return new SuccessDataResult<List<Bookshelf>>(_bookshelfDal.GetAll(), Messages.BookshelfListed);
		}

		public IResult Update(Bookshelf bookshelf)
		{
			_bookshelfDal.Update(bookshelf);
			return new SuccessResult(Messages.BookshelfUpdate);
		}
	}
}
