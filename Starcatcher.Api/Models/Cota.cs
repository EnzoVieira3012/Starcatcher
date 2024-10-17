using System;

namespace Starcatcher.Api.Models
{
    public class Cota
    {
        public int Id { get; set; }
        public int ConsorcioId { get; set; }
        public int NumeroCota { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
    }
}