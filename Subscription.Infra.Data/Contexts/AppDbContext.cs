using Microsoft.EntityFrameworkCore;
using Subscription.Infra.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription.Infra.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) //Passando as configurações
            : base(options)                                         //para a classe base (DbContext)
        {
        }
        //Sobrescrever um método para configurar os mapeamentos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PlanoConfiguration());
            modelBuilder.ApplyConfiguration(new AssinaturaConfiguration());

        }
    }
}
