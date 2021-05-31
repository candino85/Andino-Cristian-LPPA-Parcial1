using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Andino_Cristian_LPPA_Parcial1.Shared.Models
{
    public class Afiliados : IdentityBase
    {
        [Required]
        [MaxLength(50)]
        public string NombreApellido { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string CUIT { get; set; }

    }
}