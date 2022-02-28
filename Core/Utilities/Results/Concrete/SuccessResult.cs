using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
	public class SuccessResult:Result
	{
		//base'e true döndürür basarili oldugunu bildirir, ve mesajı da yollar
		public SuccessResult(string message):base(true,message)
		{

		}
		//yalnizca basarili oldugu bilgisini yollar
		public SuccessResult():base(true)
		{
				
		}
	}
}
