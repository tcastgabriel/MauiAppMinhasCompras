namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());

		}catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Views.NovoProduto());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}