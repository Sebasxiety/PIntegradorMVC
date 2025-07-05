using System.Collections.Generic;

namespace PIntegradorMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}
