using AppMovil.UTN.CP.Paginas;

namespace AppMovil.UTN.CP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Inicio());
        }
    }
}
