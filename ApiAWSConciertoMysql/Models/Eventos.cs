using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAWSConciertoMysql.Models
{
    [Table("eventos")]
    public class Eventos
    {
        [Key]
        [Column("IDEVENTO")]
        public int IdEvento { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("ARTISTA")]
        public string Artista { get; set; }
        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
