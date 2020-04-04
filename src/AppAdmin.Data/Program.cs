using System;
using System.Linq;

namespace AppZelador.Data
{
    class Program
    {
       static void Main()
        {
            using (var db = new AppAdminContext())
            {
                // Create
                Console.WriteLine("Inserting a new administradora");
                db.Add(new Administradora { Nome = "Athos" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for an administradora");
                var administradora = db.Administradoras
                    .OrderBy(a => a.AdministradoraId)
                    .First();

                // Update
                Console.WriteLine("Updating the administradora and adding a condominio");
                administradora.Nome = "Athos Administradora de Bens e Condomínios";
                administradora.Condominios.Add(
                    new Condominio
                    {
                        Nome = "Edifício Santa Rosa",
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the condomínio");
                db.Remove(administradora);
                db.SaveChanges();
            }
        }        
    }
}
