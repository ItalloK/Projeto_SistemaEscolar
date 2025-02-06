using Escola.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Matricula
    {
        public Aluno? aluno { get; set; }
        public Turma? turma { get; set; }

        public Matricula() { }

        public Matricula(Aluno? aluno, Turma? turma)
        {
            this.aluno = aluno;
            this.turma = turma;
        }
    }
}
