﻿using Business.Abstract;
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
	public class AuthorManager : IAuthorService
	{
		IAuthorDal _authorDal;
		public AuthorManager(IAuthorDal authorDal)
		{
			_authorDal = authorDal;
		}

		public IResult Add(Author author)
		{
			_authorDal.Add(author);
			return new SuccessResult(Messages.AuthorAdded);
		}

		public IResult Delete(Author author)
		{
			_authorDal.Delete(author);
			return new SuccessResult(Messages.AuthorDelete);
		}

		public IDataResult<List<Author>> GetAll()
		{
			return new SuccessDataResult<List<Author>>(_authorDal.GetAll(), Messages.AuthorListed);
		}

		public IResult Update(Author author)
		{
			_authorDal.Update(author);
			return new SuccessResult(Messages.AuthorUpdate);
		}
	}
}
