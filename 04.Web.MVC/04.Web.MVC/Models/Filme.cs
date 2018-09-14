using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04.Web.MVC.Models
{
    public class Filme
    {
        //atributos com metodos getters and setters
        //devem ser os mesmos nomes do NAME da pagina view
        public String nome { get; set; }
        public DateTime dataLancamento { get; set; }
        public String genero { get; set; }
        public bool legendado { get; set; }

        //construtor
        public Filme()
        {

        }

        //metodo


    }
}