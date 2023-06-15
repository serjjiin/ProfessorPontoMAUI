namespace ProfessorPontoMAUI.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string matricula = txtMatricula.Text;
        string senha = txtSenha.Text;

        if(!string.IsNullOrWhiteSpace(matricula) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario  = await App.BancoDados.UsuarioDataTable.GetUsuario(matricula, senha);

            if(usuario == null )
            {
                await DisplayAlert("Atenção", "Matricula ou senha inválidos", "Fechar");
                return;
            }

            App.Usuario = usuario;

            await Navigation.PushAsync(new HomePrincipalPage());
        }

    }

    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
         await Navigation.PushAsync(new EditaUsuario());

    }
}