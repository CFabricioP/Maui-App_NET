namespace AppMovil.UTN.CP.Paginas;

public partial class Inicio : ContentPage
{
	public Inicio()
	{
		InitializeComponent();
	}
    private void btnProdcutos_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Producto());
    }

    private void btnCategorias_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new Categoria());

    }
}