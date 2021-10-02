using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinariaSJ.Models
{
    public class Veterinaria
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Raza { get; set; }

        public int Edad { get; set; }

        public string Motivo { get; set; }

        public int Peso { get; set; }
    }
}
