using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido.")]
        [MaxLength(60, ErrorMessage = "El nombre puede contener maximo 60 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido.")]
        [MaxLength(100, ErrorMessage = "El nombre puede contener maximo 100 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado es requerido.")]
        public bool Estado { get; set; }
    }
}
