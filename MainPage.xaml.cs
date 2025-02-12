using DAM_Leccion_01.Model;
using DAM_Leccion_01.ViewModel;

namespace DAM_Leccion_01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Aqui se declara gloabal, en este caso una propieda del persona model

        MainPageViewModel mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void Acept_Clicked(object sender, EventArgs e){
        
        }
    }
        //View tiene que ser plantillas MAUI cuando hablamos de la vista
}
