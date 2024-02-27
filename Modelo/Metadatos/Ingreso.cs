using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Metadatos
{
    //[MetadataType(typeof(IngresoMetadato))]
    internal class IngresoMetadato
    {
        [Required]
        public System.DateTime fceh { get; set; }
        [Required]
        public int nueroSala { get; set; }
        [Required]
        public int numeroCama { get; set; }
        [Required]
        public string diagnostico { get; set; }
        [Required]
        public long medicoId { get; set; }
        [Required]
        public long pacienteId { get; set; }

    }
}
