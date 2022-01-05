using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetosocial_squad5.Models
{
    public class ProdutoServico
    {
        [Key]
        public int id_produtoServico {get;set;}
       
        [Required]
        public string codigo_produtoServico {get;set;}

        [Required(ErrorMessage = "Selecione se é produto ou serviço")]
        public string tipo_produtoServico {get;set;}

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o nome do seu produto ou serviço")]
        public string nome_produtoServico {get;set;}

        [StringLength(510)]
        public string descricao_produtoServico {get;set;}

        [Required(ErrorMessage = "Digite o preço do seu produto")]
        public decimal preco_produtoServico {get;set;}

        [StringLength(100)]
        [Required(ErrorMessage = "Digite o nome do seu negócio")]
        public string nomeNegocio_autonoma {get;set;}

        public int FK_id_autonoma  { get; set; }
        public virtual Autonoma id_autonoma {get;set;}

    }
}