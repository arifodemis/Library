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
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public IResult Add(Category category)
		{
			_categoryDal.Add(category);
			return new SuccessResult(Messages.CategoryAdded);
		}

		public IResult Delete(Category category)
		{
			_categoryDal.Delete(category);
			return new SuccessResult(Messages.CategoryDelete);
		}

		public IDataResult<List<Category>> GetAll()
		{
			return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
		}

		public IResult Update(Category category)
		{
			_categoryDal.Update(category);
			return new SuccessResult(Messages.CategoryUpdate);
		}
	}
}
