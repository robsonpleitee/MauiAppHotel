
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List <Quarto> lista_quartos=new List <Quarto>

        {
            new Quarto ()
            {

                
                Descricao="Suite Super Luxo",
                ValorDiariaAdulto=110.0,
                ValorDiariaCriança=55.0
            }
            ,
             new Quarto ()
            {


                Descricao="Suite Luxo",
                ValorDiariaAdulto=80.0,
                ValorDiariaCriança=40.0
            },

              new Quarto ()
            {

                Descricao="Suite Single",
                ValorDiariaAdulto=50.0,
                ValorDiariaCriança=25.0
            },

               new Quarto ()
            {

                Descricao="Suite Crise",
                ValorDiariaAdulto=25.0,
                ValorDiariaCriança=12.5
            }

        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
           
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window =base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 800;
            return window;
        }
    }
}
