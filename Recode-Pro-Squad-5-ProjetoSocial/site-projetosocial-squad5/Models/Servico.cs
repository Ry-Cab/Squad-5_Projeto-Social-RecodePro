using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetosocial_squad5.Models
{
    public class Servico
    {
        [Key]
        public int id_servico {get;set;}

        [StringLength(60)]
        [Required(ErrorMessage = "Digite o nome do serviço")]
        public string nome_servico {get;set;}

        [StringLength(510)]
        public string descricao_servico {get;set;}

        [Required(ErrorMessage = "Digite o preço do produto")]
        public float preco_produto {get;set;}

        public int FK_id_cadastro  { get; set; }
        public virtual Cadastro id_cadastro {get;set;}

        public int FK_nome_negocio  { get; set; }
        public virtual Cadastro nomeNegocio_cadastro {get;set;}
        
        
    }
}