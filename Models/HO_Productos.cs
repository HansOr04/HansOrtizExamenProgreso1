using System.ComponentModel.DataAnnotations;

namespace HansOrtizExamenProgreso1.Models
   
{
    public class HO_Productos
    {
        [Key]
        public int HO_ProductosID;
        [Required]
        [StringLength(50)]
        public string? HO_ProductoName;
        [Required]
        [StringLength(200)]
        public string? HO_ProductoDescripcion;
        [Required]
        [Range(0.1, 1000)]
        public decimal? HO_Price;
        [Required]
        public bool HO_Variantes;
        [Required]
        [DataType(DataType.Date)]
        public DateTime? HO_CreateAt;


        
    }
}
