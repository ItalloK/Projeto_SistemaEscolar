using Escola.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Interfaces
{
    public interface IProfessor
    {
        public void CadProfessor(Professor p);
        public void DadosCadastro(Professor p);
        public Professor? BuscarProfessorPorCPF(string cpf);
    }
}
