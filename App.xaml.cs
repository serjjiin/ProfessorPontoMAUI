using ProfessorPontoMAUI.Data;
using ProfessorPontoMAUI.Model;
using ProfessorPontoMAUI.Pages;

namespace ProfessorPontoMAUI;

public partial class App : Application
{

    static SQliteData _bancoDados;

    public static SQliteData BancoDados
    {
        get
        {
            if (_bancoDados == null)
            {
                _bancoDados = new SQliteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dados.db"));

            }
            return _bancoDados;
        }
    }

    public static Usuario Usuario { get; set; }

    public App()
    {
        InitializeComponent();

        MainPage = new LoginPage();
    }
}
