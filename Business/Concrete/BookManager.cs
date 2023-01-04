using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class BookManager : IBookService
	{
		IBookDal _bookDal;
		public BookManager(IBookDal bookDal)
		{
			_bookDal = bookDal;
		}	

		public IResult Add(Book book)
		{
			_bookDal.Add(book);
			return new SuccessResult(Messages.BookAdded);	
		}

		public IResult Delete(Book book)
		{
			_bookDal.Delete(book);
			return new SuccessResult(Messages.BookDelete);
		}

		public IDataResult<List<Book>> GetAll()
		{
			return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.BookListed);
		}

		public IResult Update(Book book)
		{
			_bookDal.Update(book);
			return new SuccessResult(Messages.BookUpdate);
		}
	}
}
