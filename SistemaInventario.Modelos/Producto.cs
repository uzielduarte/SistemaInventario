using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numero de serie es requerido.")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "Descricion es requerido.")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio es requerido.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Precio deber ser mayor que cero.")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Costo es requerido.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Costo debe ser mayor que cero.")]
        public double Costo { get; set; }
        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "Estado es requerido.")]
        public bool Estado { get; set; }

        // Foreign keys
        [Required(ErrorMessage = "Categoria es requerido.")]
        public int CategoriaId { get; set; }

        // Navegacion a otros modelos
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Marca es requerido.")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        public int? PadreId { get; set; }

        [ForeignKey("PadreId")]
        public Producto Padre { get; set; }
    }
}
