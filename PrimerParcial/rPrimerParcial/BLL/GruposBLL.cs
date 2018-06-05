using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rPrimerParcial.Entidades;


namespace rPrimerParcial.BLL
{
    public class GruposBLL
    { 
     
        public static bool Guardar(Grupos grupos)
        {
            bool paso = false;
 
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Grupos.Add(grupos) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Editar(Grupos grupos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(grupos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Grupos grupos= contexto.Grupos.Find(id);

                contexto.Grupos.Remove(grupos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

    }
}
