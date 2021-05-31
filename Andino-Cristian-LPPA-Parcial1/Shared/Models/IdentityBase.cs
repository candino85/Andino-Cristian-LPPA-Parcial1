using System.ComponentModel.DataAnnotations;

namespace Andino_Cristian_LPPA_Parcial1.Shared.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}