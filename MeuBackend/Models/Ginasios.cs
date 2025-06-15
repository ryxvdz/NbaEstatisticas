using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuBackend.Models
{
    public class Ginasios
    {
        [Key]
        [Column("ID_GINASIO")]
        public int IdGinasio { get; set; }

        [Column("CIDADE")]
        public string Cidade { get; set; } = string.Empty;

        [Column("LOTACAO")]
        public int Lotacao { get; set; }

        [Column("LOGO")]
        public string Logo { get; set; } = string.Empty;

        [Column("MANAGER")]
        public string Manager { get; set; } = string.Empty;

        [Column("MASCOTE")]
        public string Mascote { get; set; } = string.Empty;
    }
}