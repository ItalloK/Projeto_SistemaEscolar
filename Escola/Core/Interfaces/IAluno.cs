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
        public void DadosCadastro(Aluno a);
        public Aluno? BuscarAlunoPorCPF(string cpf);
    }
}
