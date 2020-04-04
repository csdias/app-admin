//using

namespace AppZelador.Domain {
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public Condominio Condominio { get; set; }

        public int TipoUsuario { get; set; }
    }

}