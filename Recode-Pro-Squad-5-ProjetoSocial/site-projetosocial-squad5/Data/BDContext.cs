using System;
using site_projetosocial_squad5.Models;
using Microsoft.EntityFrameworkCore;

namespace site_projetosocial_squad5.Data
{
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base (options){

        }

        public DbSet<Produto> Produtos{get;set;}

        public DbSet<Servico> Servicos {get;set;}

        public DbSet<site_projetosocial_squad5.Models.Cadastro> Cadastro { get; set; }
    }
}