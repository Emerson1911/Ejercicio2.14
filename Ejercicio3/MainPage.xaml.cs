namespace Ejercicio3;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void resolver_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(datoa.Text)&& !string.IsNullOrEmpty(datob.Text))
		{
			var dato1 = Convert.ToDouble(datoa.Text);
			var dato2 = Convert.ToDouble(datob.Text);
			double resul = Math.Pow(dato1 + dato2, 2) / 2;
			resultado.Text =Convert.ToString(resul);
			 
		}
		else
		{
			DisplayAlert("Eror", "Introduzca el numero faltante ciego", "Adoptado;)");
		}
    }
}

