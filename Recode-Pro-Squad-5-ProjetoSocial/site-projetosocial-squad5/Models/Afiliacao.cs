using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetosocial_squad5.Models
{
    public class Afiliacao
    {

        [Key]
        public int id_afiliacao {get;set;}
        
        [Required]
        public string codigo_produtoServico {get;set;}

        public int FK_id_afiliada { get; set; }
        public virtual Afiliada Afiliada {get;set;}

        public int FK_id_produtoServico  { get; set; }
        public virtual ProdutoServico ProdutoServico {get;set;}
    }
}