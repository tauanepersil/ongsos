namespace SOS.WEBAPP.Models
{
    public class UsuarioViewModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool ManterConectado { get; set; } = true;

        public bool Autenticado()
        {
            return Usuario == "tauane" && Senha == "123";
        }


    }
}
