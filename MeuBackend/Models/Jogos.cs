using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuBackend.Models
{
    public class Jogos
    {
        [Key]
        [Column("ID_JOGOS")]
        public int IdJogos { get; set; }

        [Column("RODADA")]
        public string Rodada { get; set; } = string.Empty;

        [Column("DATA_HORA")]
        public DateTime? DataHora { get; set; }

        [Column("ID_GINASIO")]
        public int IdGinasio { get; set; }

        [Column("ID_TIME_CASA")]
        public int IdTimeCasa { get; set; }

        [Column("ID_TIME_VISITANTE")]
        public int IdTimeVisitante { get; set; }

        [Column("PONTUACAO_CASA")]
        public int? PontuacaoCasa { get; set; }

        [Column("PONTUACAO_VISITANTE")]
        public int? PontuacaoVisitante { get; set; }
    }
}