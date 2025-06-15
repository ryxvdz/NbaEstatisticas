using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuBackend.Models
{
    public class Times
    {
        [Key]
        [Column("ID_TIMES")]
        public int IdTimes { get; set; }

        [Column("NOME_DA_EQUIPE")]
        public string NomeDaEquipe { get; set; } = string.Empty;

        [Column("COACH")]
        public string Coach { get; set; } = string.Empty;

        [Column("CONFERENCIA")]
        public string Conferencia { get; set; } = string.Empty;
    }
}