using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Contactos.Models
{
    public class ModeloPersona
    {
        //creamos estructura de los datos
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}