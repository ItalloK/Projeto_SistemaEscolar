using Escola.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Interfaces
{
    public interface IResponsavel
    {
        public bool CadResponsavel(Responsavel r);
        public void DadosCadastro(Responsavel r);
        public bool VerificarResponsavel(Responsavel r);
        public Responsavel? PegarResponsavel(string cpf);
        public List<Responsavel> PegarResponsaveisPorAluno(Aluno a);
        public List<Responsavel> PegarTodosResponsaveis();
        public List<Aluno> PegarAlunosPorResponsavel(Responsavel r);
    }
}
