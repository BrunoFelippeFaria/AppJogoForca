namespace AppJogoForca;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		GerarTeclado();
	}

	private void GerarTeclado()
	{
		string[] teclas = [
			"Q", "W", "E", "R", "T", "Y", "U", "i", "O", "P",
			"A", "S", "D", "F", "G", "H", "J", "k", "L", "Ç",
			"Z", "X", "C", "V", "B", "N", "M"	
		];

		foreach (var tecla in teclas)
		{
			var btn = new Button
			{
				Text=tecla,
				WidthRequest=20,
				HeightRequest=20,
			    Margin = new Thickness(0,0,3,3)
			};

			tecladoFlex.Add(btn);
		}
	}
}
