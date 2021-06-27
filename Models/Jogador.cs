using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Times.Models{
    public class Jogador
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public int TimeId {get; set;}
        public Time time {get; set;}
    }
}