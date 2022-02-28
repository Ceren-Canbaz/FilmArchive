using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
	public class FilmValidator:AbstractValidator<Film>
	{
		public FilmValidator()
		{
			RuleFor(f => f.Name.Length).NotEmpty();
		}
		
	}
}
