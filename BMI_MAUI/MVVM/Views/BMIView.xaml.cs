using BMI_MAUI.MVVM.ViewModels;

namespace BMI_MAUI;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}
