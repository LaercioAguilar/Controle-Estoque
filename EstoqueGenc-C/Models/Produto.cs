using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.Models
{
    
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Código do Produto")]
        public int Id { get; set; }

        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }


        [Display(Name = "Quantidade de Produtos")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Valor do Produto")]
        [Column(TypeName = "decimal(10,2) ")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
    }
}
