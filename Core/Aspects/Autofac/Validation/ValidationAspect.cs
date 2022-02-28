using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
	
	public class ValidationAspect:MethodInterception
	{
		private Type _validatorType;
		public ValidationAspect(Type validatorType)
		{
			if (!typeof(IValidator).IsAssignableFrom(validatorType))
			{
				throw new System.Exception("This is not a validation class");
			}
			_validatorType = validatorType;
		}
		protected override void OnBefore(IInvocation invocation) //invocationda method bilgileri var 
		{
			var validator = (IValidator)Activator.CreateInstance(_validatorType);//reflection
			var entityType = _validatorType.BaseType.GetGenericArguments()[0];
			//entities eklenen ürünün bilgilerini tutuyor.
			//girilen bilgiler entity bilgileriyle uyusuyor mu kontrolu sanirim 
			var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
			foreach (var entity in entities)
			{
				ValidationTool.Validate(validator, entity);
			}
		}
	}
}
