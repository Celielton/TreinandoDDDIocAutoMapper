﻿using Academico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Data.Mapping
{
    public class ProfessorMap : EntityTypeConfiguration<Professor>
    {
        public ProfessorMap()
        {
            HasKey(i => i.Id);

        }
    }
}
