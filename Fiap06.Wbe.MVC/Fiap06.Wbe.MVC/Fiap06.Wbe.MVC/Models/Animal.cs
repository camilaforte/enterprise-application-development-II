using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Wbe.MVC.Models
{
    [Table("T_ANIMAL")]
    public class Animal
    {
        [Column ("Id")]
        public int AnimalId { get; set; }
        [Column("Nome")]
        [Required]
        [MaxLength(100)]
        [MinLength(4)]
        public string Nome { get; set; }
        [Column("Raca")]

        public string Raca { get; set; }
        public bool Castrado { get; set; }
        public float Peso { get; set; }
    }
}