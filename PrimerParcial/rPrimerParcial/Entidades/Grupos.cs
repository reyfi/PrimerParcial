﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace rPrimerParcial.Entidades
{
    public class Grupos
    {

        public int GrupoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int Grupo { get; set; }
        public int integrantes { get; set; }


        public Grupos()
        {
            GrupoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Cantidad = 0;
            Grupo = 0;
            integrantes = 0;
        }

    }
}
