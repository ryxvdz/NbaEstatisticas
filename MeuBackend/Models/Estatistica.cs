using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeuBackend.Models
{
    public class Estatistica
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Valor { get; set; }
    }
}