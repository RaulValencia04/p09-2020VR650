using System;
using Microsoft.EntityFrameworkCore;


namespace p09_2020VR650.Models
{
	public class EquipoContext: DbContext { 

		public EquipoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Estados_equipo> estados_equipo { get; set; }
        public DbSet<TipoEquipos> tipo_equipo { get; set; }
        public DbSet<Equipos> equipos { get; set; }


    }
}

