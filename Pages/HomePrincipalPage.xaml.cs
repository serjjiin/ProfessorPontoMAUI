namespace ProfessorPontoMAUI.Pages;

public partial class HomePrincipalPage : TabbedPage
{
	public HomePrincipalPage()
	{
		InitializeComponent();

		var pagina1 = new ListaFeedPage()
		{
			Title = "Feed",
			IconImageSource = ""
		};
		
		var pagina2 = new ExibirUsuarioPage()
		{
			Title = "Exibir Usu�rio",
			IconImageSource = ""
		};

		var pagina3 = new BuscaUsuarioPage()
		{
			Title = "Buscar Usu�rio",
			IconImageSource = ""
		};

		//Adicionando Paginas
		this.Children.Add( pagina1);
		this.Children.Add( pagina2);
		this.Children.Add( pagina3);
	}
}