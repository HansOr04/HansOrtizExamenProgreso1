using System.ComponentModel.DataAnnotations;

namespace HansOrtizExamenProgreso1.Models
   
{
    public class HO_Producto
    {
        [Key]
        public int HO_ProductoId { get; set; }
        [Required]
        [StringLength(50)]
        public string? HO_ProductoName { get; set; }
        [Required]
        [StringLength(200)]
        public string? HO_ProductoDescripcion { get; set; }
        [Required]
        [Range(0.1, 1000)]
        public decimal? HO_Price { get; set; }
        [Required]
        
        public bool HO_Variantes { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? HO_CreateAt { get; set; }



    }
}
