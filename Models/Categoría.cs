using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_.Models
{
    [Table("Categoría")]
    public class Categoría
    {
        [Key]
       
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

    }
}