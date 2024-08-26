using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    [Table("document_types")] //Aca se pone el nombre de la tabla DB
    public class DocumentType
    {
        [Key] //Esta es la llave primaria
        [Column("id")]
        public int Id { get; set; }
        [Column("name")] //Asi se ponen las columnas en la tabla
        [MaxLength(50, ErrorMessage = "The Name field must be less than {50} character.")] //Condiciones de máximos caracteres
        public required string Name { get; set; }
        [Column("abbreviation")]
        [MinLength(2, ErrorMessage = "The Abbreviation field must be more than {2} character.")] //Condiciones de mínimos caracteres
        [MaxLength(10, ErrorMessage = "The Abbreviation field must be less than {10} character.")]
        public required string Abbreviation { get; set; }
        [Column("description")]
        [MaxLength(500, ErrorMessage = "The Description field must be less than {500} character.")]
        public string? Description { get; set; }
    }
}