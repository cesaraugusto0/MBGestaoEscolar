using System.Text;
using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Interfaces;

namespace MBGestaoEscolar.Services.Implementations
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        
        public async Task AdicionarAsync(Curso curso)
        {
            if (string.IsNullOrEmpty(curso.Nome))
            {
                throw new ArgumentNullException("O nome é obrigatório!");
            }

            curso.Codigo = GerarCodigo();
            await _cursoRepository.AdicionarAsync(curso);
        }

        public Task AtualizarAsync(Curso curso)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Curso>> ListaCursosAsync()
        {
            return await _cursoRepository.ListaCursosAsync();
        }

        public Task<Curso> ObterCursoAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        public static string GerarCodigo()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var codigo = new StringBuilder();
        
            for (int i = 0; i < 6; i++)
            {
                codigo.Append(caracteres[random.Next(caracteres.Length)]);
            }
        
            return codigo.ToString();
        }
    }
}
