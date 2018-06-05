using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace rPrimerParcial.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupos { get; set; };

        public Contexto() : base("ConStr")
        {

        }
    }
}
