using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido.")]
        [MaxLength(60, ErrorMessage = "Nombre debe tener maximo 60 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descricion es requerida.")]
        [MaxLength(100, ErrorMessage = "Descripcion debe tener maximo 100 caracteres.")]
        public string Descripcion {  get; set; }

        public bool Estado { get; set;  }
    }
}
