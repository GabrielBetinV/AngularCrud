using System.ComponentModel.DataAnnotations;

namespace FBTarjetaCreedito.Models
{
    public class TarjetaCredito
    {

        [Required]// El campo es Requerido
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }

        [Required]
        public string NumeroTarjeta { get; set; }

        [Required]
        public string FechaExpiracion { get; set; }

        [Required]
        public string Cvv { get; set; }


    }
}
