using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public int TutorID { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public decimal Peso { get; set; }

        public int EspecieID { get; set; }

        public  Especie Especie { get; set;}
        public  Tutor Tutor { get; set;}
    }
}
