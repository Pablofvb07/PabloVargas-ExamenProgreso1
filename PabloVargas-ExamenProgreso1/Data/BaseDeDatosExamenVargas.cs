using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PabloVargas_ExamenProgreso1.Models;

    public class BaseDeDatosExamenVargas : DbContext
    {
        public BaseDeDatosExamenVargas (DbContextOptions<BaseDeDatosExamenVargas> options)
            : base(options)
        {
        }

        public DbSet<PabloVargas_ExamenProgreso1.Models.Propietario> Propietario { get; set; } = default!;

public DbSet<PabloVargas_ExamenProgreso1.Models.Mascota> Mascota { get; set; } = default!;

public DbSet<PabloVargas_ExamenProgreso1.Models.Visita> Visita { get; set; } = default!;
    }
