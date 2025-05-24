using MBGestaoEscolar.Data.Context;
using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolar.Repository.Implementation
{
    public class InstrutorRepository : IInstrutorRepository
    {
        private readonly SQLServerDBContext _context;

        public InstrutorRepository(SQLServerDBContext context)
        {
            _context = context;
        }

        public async Task<Instrutor> ObterInstrutorAsync(int id)
        {
            return await _context.Instrutores.FindAsync(id);
        }

        public async Task AdicionarAsync(Instrutor aluno)
        {
            await _context.Instrutores.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Instrutor aluno)
        {
            var alunoExistente = await _context.Instrutores.FindAsync(aluno.InstrutorId);
            if (alunoExistente == null)
            {
                throw new KeyNotFoundException($"Instrutor com ID {aluno.InstrutorId} não encontrado.");
            }

            // Atualiza apenas as propriedades necessárias (preserva DataCadastro)
            alunoExistente.Nome = aluno.Nome;
            alunoExistente.CPF = aluno.CPF;
            alunoExistente.Email = aluno.Email;
            alunoExistente.Telefone = aluno.Telefone;
            alunoExistente.FormacaoAcademica = aluno.FormacaoAcademica;
            alunoExistente.Especialidade = aluno.Especialidade;
            alunoExistente.ValorHoraAula = aluno.ValorHoraAula;
            alunoExistente.StatusInstrutor = aluno.StatusInstrutor;
            // DataCadastro não é modificada

            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var alunoExcluir = await _context.Instrutores.FindAsync(id);
            if (alunoExcluir != null)
            {
                _context.Instrutores.Remove(alunoExcluir);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Instrutor>> ListaInstrutoresAsync()
        {
            return await _context.Instrutores.ToListAsync();
        }
    }
}
