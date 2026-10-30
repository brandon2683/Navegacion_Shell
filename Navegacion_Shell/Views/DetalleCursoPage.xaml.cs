using Navegacion_Shell.Models;
using Navegacion_Shell.Services;

namespace Navegacion_Shell.Views;

[QueryProperty(nameof(CursoId), "id")]
public partial class DetalleCursoPage : ContentPage
{
    private int _cursoId;
    private Curso? _cursoActual;

    public int CursoId
    {
        get => _cursoId;
        set => _cursoId = value;
    }

    public DetalleCursoPage() => InitializeComponent();

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Se vuelve a leer del repositorio (datos actualizados tras editar)
        _cursoActual = CursoRepository.GetById(_cursoId);
        if (_cursoActual is null) return;

        NombreLabel.Text = _cursoActual.Nombre;
        DescripcionLabel.Text = _cursoActual.Descripcion;
        InstructorLabel.Text = $"Instructor: {_cursoActual.Instructor}";
    }

    // Navegación enviando el OBJETO COMPLETO con un diccionario
    private async void OnEditarClicked(object sender, EventArgs e)
    {
        if (_cursoActual is null) return;

        var parametros = new ShellNavigationQueryParameters
        {
            { "Curso", _cursoActual }
        };

        await Shell.Current.GoToAsync(nameof(EditarCursoPage), parametros);
    }
}