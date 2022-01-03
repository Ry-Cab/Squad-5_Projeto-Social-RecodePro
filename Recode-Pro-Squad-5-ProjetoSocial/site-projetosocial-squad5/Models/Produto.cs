using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetosocial_squad5.Models
{
    public class Produto
    {
        [Key]
        public int id_produto {get;set;}

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o nome do seu produto")]
        public string nome_produto {get;set;}

        [StringLength(510)]
        public string descricao_produto {get;set;}

        [Required(ErrorMessage = "Digite o preço do seu produto")]
        public decimal preco_produto {get;set;}

       
        public int FK_id_cadastro  { get; set; }
        public virtual Cadastro id_cadastro {get;set;}

        public int FK_nome_negocio  { get; set; }
        public virtual Cadastro nomeNegocio_cadastro {get;set;}
        
    }
}