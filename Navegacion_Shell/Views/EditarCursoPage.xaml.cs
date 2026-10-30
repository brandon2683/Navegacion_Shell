using Navegacion_Shell.Models;
namespace Navegacion_Shell.Views;

public partial class EditarCursoPage : ContentPage, IQueryAttributable
{
    private Curso? _curso;

    public EditarCursoPage() => InitializeComponent();

    // Recibe el diccionario con el objeto completo
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("Curso", out var obj) && obj is Curso curso)
        {
            _curso = curso;
            NombreEntry.Text = curso.Nombre;
            DescripcionEntry.Text = curso.Descripcion;
            InstructorEntry.Text = curso.Instructor;
        }
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        if (_curso is null) return;

        // Modificación directa del objeto (referencia compartida con la lista)
        _curso.Nombre = NombreEntry.Text ?? string.Empty;
        _curso.Descripcion = DescripcionEntry.Text ?? string.Empty;
        _curso.Instructor = InstructorEntry.Text ?? string.Empty;

        // Regresa a DetalleCursoPage con ".."
        await Shell.Current.GoToAsync("..");
    }

    private async void OnCancelarClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync("..");
}