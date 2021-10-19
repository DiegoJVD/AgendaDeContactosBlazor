using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_de_Contactos.Models
{
    public class Contactos
    {
        [Key]
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }




    }
}
