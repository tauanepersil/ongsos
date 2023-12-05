using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Veterinario: Pessoa
    {
        public int VeterinarioID { get; set; }
        public string CRMV { get; set; }

    }
}
