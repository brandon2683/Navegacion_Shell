using Navegacion_Shell.Models;
using Navegacion_Shell.Services;

namespace Navegacion_Shell.Views;

public partial class CursosPage : ContentPage
{
    public CursosPage()
    {
        InitializeComponent();
        CursosCollectionView.ItemsSource = CursoRepository.Cursos;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        // Refresca por si los datos cambiaron al regresar de Editar
        CursosCollectionView.ItemsSource = null;
        CursosCollectionView.ItemsSource = CursoRepository.Cursos;
    }

    // Navegación con QUERY STRING (solo el Id)
    private async void OnVerCursoClicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.CommandParameter is Curso curso)
        {
            await Shell.Current.GoToAsync($"{nameof(DetalleCursoPage)}?id={curso.Id}");
        }
    }
}