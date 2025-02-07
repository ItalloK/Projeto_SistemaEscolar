using Escola.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Interfaces
{
    public interface IMatricula
    {
        public bool MatricularAluno(Matricula m);
    }
}
