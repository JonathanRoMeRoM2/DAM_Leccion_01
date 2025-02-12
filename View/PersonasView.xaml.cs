using DAM_Leccion_01.ViewModel;

namespace DAM_Leccion_01.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		//InitializeComponent();
		BindingContext = new PersonasViewModel();
	}
}