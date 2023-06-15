using ProfessorPontoMAUI.Model;
using SQLite;

namespace ProfessorPontoMAUI.Data
{
    public class SQliteData
    {
        readonly SQLiteAsyncConnection _conexaoBD;

        public UsuarioData UsuarioDataTable { get; set; }

        public SQliteData(string path)
        {
            _conexaoBD = new SQLiteAsyncConnection(path);

            _conexaoBD.CreateTableAsync<Usuario>().Wait();

            UsuarioDataTable = new UsuarioData(_conexaoBD);
        }
    }
}
