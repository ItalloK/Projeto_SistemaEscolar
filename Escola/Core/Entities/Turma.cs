using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Entities
{
    public class Turma
    {
        public int id { get; set; }
        public string tipo { get; set; } = string.Empty;
        public string turno { get; set; } = string.Empty;
        public string serie { get; set; } = string.Empty;
        public int maxAlunos { get; set; }
        public int quantidadeAlunos { get; set; }


        public Turma() { }

        public Turma(string tipo, string turno, string serie, int maxAlunos)
        {
            this.tipo = tipo;
            this.turno = turno;
            this.serie = serie;
            this.maxAlunos = maxAlunos;
        }
    }
}
