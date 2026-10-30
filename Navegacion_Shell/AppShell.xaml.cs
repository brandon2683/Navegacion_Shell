using Navegacion_Shell.Views;
namespace Navegacion_Shell;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas para navegación programática
        Routing.RegisterRoute(nameof(DetalleCursoPage), typeof(DetalleCursoPage));
        Routing.RegisterRoute(nameof(EditarCursoPage), typeof(EditarCursoPage));
    }

    private async void OnSalirClicked(object sender, EventArgs e)
    {
        bool ok = await DisplayAlert("Salir", "¿Deseas salir de la aplicación?", "Sí", "No");
        if (ok)
            Application.Current?.Quit();   // .NET 8+ (en Windows/Android cierra la app)
    }
}
