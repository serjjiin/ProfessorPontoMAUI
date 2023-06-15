using ProfessorPontoMAUI.Model;

namespace ProfessorPontoMAUI.Pages;

public partial class EditaUsuario : ContentPage
{

    Usuario _usuario;

    public EditaUsuario()
    {
        InitializeComponent();
        _usuario = new Usuario();

        this.BindingContext = _usuario;
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_usuario.Matricula)
            && string.IsNullOrWhiteSpace(_usuario.Senha))
        {
            await DisplayAlert("Atenção", "Preencha todas as informações", "Fechar");
            return;
        }

        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await Navigation.PopAsync();
        }
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}