﻿using Escola.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Core.Interfaces
{
    public interface ITurmas
    {
        public bool CadTurma(Turma t);
        public bool AttTurma(Turma t);
        public bool DelTurma(Turma t);
        public Turma PegarTurma();
        public List<Turma> PegarTurmas();
        public List<Aluno> PegarAlunosPorTurma(Turma t);
    }
}
