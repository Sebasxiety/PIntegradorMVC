using System;

namespace PIntegradorMVC.Models
{
    public class OrdenServicio
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int DispositivoId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
