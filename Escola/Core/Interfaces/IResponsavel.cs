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
        public bool ResponsavelParaAluno(Responsavel r, Aluno a);
        public Responsavel? PegarResponsavel(string cpf);
    }
}
