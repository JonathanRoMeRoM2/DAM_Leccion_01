using DAM_Leccion_01.Model;

namespace DAM_Leccion_01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Aqui se declara gloabal, en este caso una propieda del persona model
        private PersonaModel personaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        public void Ejecutar() {
            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Holaa";
            //txtNombre.Text = personaModel.Nombre;


            personaModel = new PersonaModel()
            {
                Nombre = "Jonathan Romero M",
            };

            BindingContext = personaModel;

            //txtNombre.Text = personaModel.Nombre;
            //Binding personaBinding = new Binding();

            //personaBinding.Source = personaModel; //Origen
            //personaBinding.Path = "Nombre"; //Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino

        }

        private void Acept_Clicked(object sender, EventArgs e)
        {
            personaModel.Nombre = "Jonathan";
            personaModel.Apellido = "Romero Molina";
            personaModel.Edad = "21";
        }
    }

}
