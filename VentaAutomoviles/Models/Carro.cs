using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VentaAutomoviles.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Cilindrada { get; set; }

        public string Marca { get; set; }

        public int Pasajeros { get; set; }

        public string Extras { get; set; }

        public string Rtv { get; set; }

        public string Marchamo { get; set; }
    }
}
