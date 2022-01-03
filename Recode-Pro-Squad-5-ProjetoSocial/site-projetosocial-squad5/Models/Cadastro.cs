using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetosocial_squad5.Models
{
    public class Cadastro
    {
        [Key]
        public int id_cadastro {get;set;}

        [StringLength(75)]
        [Required(ErrorMessage = "Digite o seu nome completo")]
        public string nome_cadatro {get;set;}

        [StringLength(10)]
        [Required(ErrorMessage = "Digite a sua idade")]
        public string idade_cadastro {get;set;}

        [StringLength(255)]
        [Required(ErrorMessage = "Digite o seu melhor E-mail")]
        public string email_cadastro {get;set;}

        [StringLength(255)]
        [Required(ErrorMessage = "Digite o seu endereço")]
        public string endereco_cadastro {get; set;}

        [StringLength(9)]
        [Required(ErrorMessage = "Digite o seu CEP")]
        public string cep_cadastro {get;set;}

        [StringLength(50)]
        [Required(ErrorMessage = "Digite o seu bairro")]
        public string bairro_cadastro {get;set;}

        [StringLength(50)]
        [Required(ErrorMessage = "Digite a sua cidade")]
        public string cidade_cadastro {get;set;}

        [StringLength(20)]
        [Required(ErrorMessage = "Digite o seu número de contato")]
        public string telefone_cadastro {get;set;}

        [StringLength(100)]
        [Required(ErrorMessage = "Digite o nome do seu negócio")]
        public string nomeNegocio_cadastro {get;set;}

        [StringLength(20)]
        [Required(ErrorMessage = "Digite o número de contato do seu negócio")]
        public string telefoneNegocio_cadastro {get;set;}

        [StringLength(50)]
        [Required(ErrorMessage = "Digite o tipo do seu negócio")]
        public string categoriaNegocio_cadastro {get;set;}
    }
}