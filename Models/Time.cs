using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Times.Models{
    public class Time
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Abrev {get; set;}
        public string Cidade {get; set;}

        public ICollection<Jogador> Jogadores {get;set;}
    }
}