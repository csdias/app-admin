using System.Collections.Generic;

namespace AppZelador.Domain {
    public class Administradora
    {
        public int AdministradoraId { get; set; }
        public string Nome { get; set; }

        public List<Condominio> Condominios { get; } = new List<Condominio>();
    }
}
