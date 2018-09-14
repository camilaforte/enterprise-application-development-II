using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Wbe.MVC.Models
{
    public class Produto
    {
        [Column("AnimalID")]
        public int ProdutoId { get; set; }
        [Required]
        public string Nome { get; set; }
        public double Preco { get; set; }

    }
}