using System;
using System.ComponentModel.DataAnnotations;

namespace site_projetoSocial_squad5.Models
{
    public class Cadastro
    {
        [Key]
        [Required]
        public int id_cadastro {get;set;}

        [Stringlength(75)]
        [Required]
        public string nome_cadatro {get;set;}

        [Stringlength(10)]
        [Required]
        public string idade_cadastro {get;set;}

        [Stringlength(255)]
        [Required]
        public string email_cadastro {get;set;}

        [Stringlength(255)]
        [Required]
        public string endereco_cadastro {get; set;}

        [Stringlength(9)]
        [Required]
        public string cep_cadastro {get;set;}

        [Stringlength(50)]
        [Required]
        public string bairro_cadastro {get;set;}

        [Stringlength(50)]
        [Required]
        public string cidade_cadastro {get;set;}

        [Stringlength(20)]
        [Required]
        public string telefone_cadastro {get;set;}

        [StringLength(100)]
        [Required]
        public string nomeNegocio_cadastro {get;set;}

        [Stringlength(20)]
        [Required]
        public string telefoneNegocio_cadastro {get;set;}

        [Stringlength(50)]
        [Required]
        public string categoriaNegocio_cadastro {get;set;}
    }
}