using Escola.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Interfaces
{
    public interface IAluno
    {
        public bool CadAluno(Aluno a);
        public bool CadAlunoComResponsavel(Aluno a, Responsavel r);
        public void DadosCadastro(Aluno a);
        public Aluno? BuscarAlunoPorCPF(string cpf);
        public List<Aluno> PegarTodosAlunos();
    }
}
