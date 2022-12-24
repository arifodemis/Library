using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IBookshelfService
	{
		IDataResult<List<Bookshelf>> GetAll();
		IResult Add(Bookshelf bookshelf);
		IResult Update(Bookshelf bookshelf);
		IResult Delete(Bookshelf bookshelf);
	}
}
