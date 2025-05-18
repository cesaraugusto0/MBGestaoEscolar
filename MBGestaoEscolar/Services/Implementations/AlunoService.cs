using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using MBGestaoEscolar.Services.Interfaces;

namespace MBGestaoEscolar.Services.Implementations
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task AdicionarAsync(Aluno aluno)
        {
            if (string.IsNullOrEmpty(aluno.Nome))
            {
                throw new ArgumentNullException("O nome é obrigatório!");
            }
            await _alunoRepository.AdicionarAsync(aluno);
        }

        public async Task AtualizarAsync(Aluno aluno)
        {
            // TODO verificar se usuario existe
            await _alunoRepository.AtualizarAsync(aluno);
        }

        public async Task ExcluirAsync(int id)
        {
            await _alunoRepository.ExcluirAsync(id);
        }

        public async Task<IEnumerable<Aluno>> ListaAlunosAsync()
        {
            return await _alunoRepository.ListaAlunosAsync();
        }

        public async Task<Aluno> ObterAlunoAsync(int id)
        {
            var aluno = await _alunoRepository.ObterAlunoAsync(id);
            if (aluno == null)
            {
                throw new KeyNotFoundException($"O aluno com id {id} não foi localizado");
            }
            return aluno;
        }   
    }
}
