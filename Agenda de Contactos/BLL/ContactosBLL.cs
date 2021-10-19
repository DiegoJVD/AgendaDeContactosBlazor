using Agenda_de_Contactos.DAL;
using Agenda_de_Contactos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Contactos.BLL
{
    public class ContactosBLL
    {
        public static bool Guardar(Contactos contacto)
        {
            if (!Existe(contacto.ContactoId))
            {
                return Insertar(contacto);
            }
            else
            {
                return Modificar(contacto);
            }
        }

        public static bool Insertar(Contactos contactos)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Contactos.Add(contactos);
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }

        public static bool Modificar(Contactos contactos)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Entry(contactos).State = EntityState.Modified;
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }

        public static bool Eliminar(int Id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                var contactos = context.Contactos.Find(Id);

                if(contactos != null)
                {
                    context.Contactos.Remove(contactos);
                    found = context.SaveChanges() > 0;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

            return found;
        }

        public static Contactos Buscar(int Id)
        {
            Contexto context = new Contexto();
            Contactos contactos;

            try
            {
                contactos = context.Contactos.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

            return contactos;
        }

        public static bool Existe(int id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                found = context.Contactos.Any(p => p.ContactoId == id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;

        }

        public static List<Contactos> GetList()
        {
            Contexto context = new Contexto();
            List<Contactos> list = new List<Contactos>();
            try
            {
                list = context.Contactos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                context.Dispose();
            }

            return list;
        }
    }
}
