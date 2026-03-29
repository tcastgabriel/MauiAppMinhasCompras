using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    try
                    {
                        string path = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                            "banco_sqlite_compras.db3"
                        );

                        _db = new SQLiteDatabaseHelper(path);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao criar banco: " + ex.Message);
                    }
                }

                return _db;
            }
        }

        public App()
        {
            InitializeComponent();

            try
            {
                MainPage = new NavigationPage(new Views.ListaProduto());
            }
            catch (Exception ex)
            {
                MainPage = new ContentPage
                {
                    Content = new Label
                    {
                        Text = ex.ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                };
            }
        }
    }
}