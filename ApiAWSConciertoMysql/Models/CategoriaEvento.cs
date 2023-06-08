using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiAWSConciertoMysql.Models
{
    [Table("categoriaevento")]
    public class CategoriaEvento
    {
        [Key]
        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }

    }
}
