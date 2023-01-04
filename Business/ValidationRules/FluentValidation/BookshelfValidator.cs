using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
	public class BookshelfValidator : AbstractValidator<Bookshelf>
	{
		public BookshelfValidator()
		{
			RuleFor(b => b.ShelfCode).NotEmpty();
		}	
	}
}
