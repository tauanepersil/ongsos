using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Castracao
    {
        public int CastracaoID { get; set; }
        public int AnimalID { get; set; }
        public int VeterinarioID { get; set; }
        public DateTime DataProcedimento { get; set; }

        public Animal Animal { get; set; }
        public Veterinario Veterinario { get; set; }

    }
}
