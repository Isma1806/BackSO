using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvestigacionSO.Api.models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("id")] 
        public int Id { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
    }
}