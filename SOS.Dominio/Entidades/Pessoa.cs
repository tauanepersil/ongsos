using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Pessoa
    {
        public string CPF { get; set; }
        public string NomeCompleto { get; set; }
        public int? EnderecoID { get; set; }
        public string TelefoneCelular { get; set; }
        public string? TelefoneFixo { get; set; }

        public Endereco? Endereco { get; set; }
    }
}
