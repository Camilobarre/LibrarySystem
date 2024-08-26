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
        public required string Name { get; set; }
        [Column("abbreviation")]
        public required string Abbreviation { get; set; }
        [Column("description")]
        public string? Description { get; set; }
    }
}