using Microsoft.EntityFrameworkCore;
namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Conejo> Conejos {get;set;}
        public DbSet<Hospital> Hospitales {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<Perro> Perros {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Gato> Gatos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
         if (!optionBuilder.IsConfigured)
        {
            optionBuilder
            .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasa.Data");
            //.UseSqlServer("Data Source = (localdb)//192.168.1.1; Initial Catalog = HospiEnCasa.Data");
            //.UseSqlServer ("Server=(localdb)\MSSQLLocalDB;Integrated Security=true")
        }
    }

    }
}
