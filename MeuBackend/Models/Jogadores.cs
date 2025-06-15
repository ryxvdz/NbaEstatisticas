using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuBackend.Models
{
    public class Jogadores
    {
        [Key]
        [Column("ID_JOGADORES")]
        public int IdJogadores { get; set; }

        [Column("NOME")]
        public string Nome { get; set; } = string.Empty;

        [Column("POSICAO")]
        public string Posicao { get; set; } = string.Empty;

        [Column("SALARIO")]
        public double Salario { get; set; }

        [Column("ID_TIMES")]
        public int IdTimes { get; set; }
    }
}