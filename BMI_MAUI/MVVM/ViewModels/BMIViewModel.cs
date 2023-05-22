using System;
namespace BMI_MAUI.MVVM.ViewModels
{
	public class BMIViewModel
	{
		public Models.BMI BMI { get; set; }

		public BMIViewModel()
		{
			BMI = new Models.BMI();
			BMI.Height = 180;
			BMI.Weight = 77;
		}
	}
}

