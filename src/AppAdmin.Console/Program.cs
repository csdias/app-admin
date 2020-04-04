using System.Linq;
using AppAdmin.Domain;
using AppAdmin.Data;
using System;

namespace AppAdmin.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppAdminContext())
            {
                // Create
                System.Console.WriteLine("Inserting a new administradora");
                db.Add(new Administradora { Nome = "Athos" });
                db.SaveChanges();

                // Read
                System.Console.WriteLine("Querying for an administradora");
                var administradora = db.Administradoras
                    .OrderBy(a => a.AdministradoraId)
                    .First();

                // Update
                System.Console.WriteLine("Updating the administradora and adding a condominio");
                administradora.Nome = "Athos Administradora de Bens e Condomínios";
                administradora.Condominios.Add(
                    new Condominio
                    {
                        Nome = "Edifício Santa Rosa",
                    });
                db.SaveChanges();

                // Delete
                System.Console.WriteLine("Delete the condomínio");
                //db.Remove(administradora);
                db.SaveChanges();
            }
        }
    }
}
