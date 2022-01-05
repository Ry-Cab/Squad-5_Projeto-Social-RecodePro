using System;
using site_projetosocial_squad5.Models;
using Microsoft.EntityFrameworkCore;

namespace site_projetosocial_squad5.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base (options){

        }

    
        public DbSet<Autonoma> Autonoma {get;set;}

        public DbSet<Afiliada> Afiliada {get;set;}

        public DbSet<ProdutoServico> ProdutoServico{get;set;}

        public DbSet<Afiliacao> Afiliacao {get;set;}

         }
}
