using ProfessorPontoMAUI.Model;
using SQLite;

namespace ProfessorPontoMAUI.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexaoBD;

        public UsuarioData(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoBD = conexaoBD;
        }

        public Task<List<Usuario>> ListaUsuarios()
        {
            var lista = _conexaoBD.Table<Usuario>().ToListAsync();

            return lista;
        }

        public Task<Usuario> GetUsuario(string matricula, string senha)
        {
            var usuario = _conexaoBD
                .Table<Usuario>()
                .Where(x => x.Matricula == matricula && x.Senha == senha)
                .FirstOrDefaultAsync();

            return usuario;
        }

        public Task<Usuario> GetUsuario(Guid id)
        {
            var usuario = _conexaoBD
                .Table<Usuario>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return usuario;
        }

        public async Task<int> SalvarUsuario(Usuario usuario)
        {
            var usuarioIsSalvo = await GetUsuario(usuario.Id);

            if (usuarioIsSalvo == null)
            {
                return await _conexaoBD.InsertAsync(usuario);

            }
            else
            {
                return await _conexaoBD.UpdateAsync(usuario);

            }
        }

        public async Task<int> ExcluirUsuario(Guid id)
        {
            return await _conexaoBD.DeleteAsync(id);
        }




    }
}
