using MBGestaoEscolar.Data.Context;
using MBGestaoEscolar.Entities;
using MBGestaoEscolar.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolar.Repository.Implementation
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly SQLServerDBContext _context;

        public AlunoRepository(SQLServerDBContext context)
        {
            _context = context;
        }

        public async Task<Aluno> ObterAlunoAsync(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task AdicionarAsync(Aluno aluno)
        {
            await _context.Alunos.AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarAsync(Aluno aluno)
        {
            var alunoExistente = await _context.Alunos.FindAsync(aluno.AlunoId);
            if (alunoExistente == null)
            {
                throw new KeyNotFoundException($"Aluno com ID {aluno.AlunoId} não encontrado.");
            }

            // Atualiza apenas as propriedades necessárias (preserva DataCadastro)
            alunoExistente.Matricula = aluno.Matricula;
            alunoExistente.Nome = aluno.Nome;
            alunoExistente.CPF = aluno.CPF;
            alunoExistente.Email = aluno.Email;
            alunoExistente.Telefone = aluno.Telefone;
            alunoExistente.DataNascimento = aluno.DataNascimento;
            alunoExistente.Endereco = aluno.Endereco;
            alunoExistente.StatusAluno = aluno.StatusAluno;
            // DataCadastro não é modificada

            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var alunoExcluir = await _context.Alunos.FindAsync(id);
            if (alunoExcluir != null)
            {
                _context.Alunos.Remove(alunoExcluir);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Aluno>> ListaAlunosAsync()
        {
            return await _context.Alunos.ToListAsync();
        }
    }
}
