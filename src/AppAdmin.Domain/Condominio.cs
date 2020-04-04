//using

namespace AppAdmin.Domain {
    public class Condominio
    {
        public int CondominioId { get; set; }
        public string Nome { get; set; }
        public int AdministradoraId { get; set; }
        public Administradora Administradora { get; set; }
    }
}
