using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_WEB.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int id { get; set; }

        [Column("descricao")]
        [Display(Name = "Descrição")]
        public string? descricao { get; set; }

        [Column("concluida")]
        [Display(Name = "Concluída")]
        public bool concluida { get; set; }
    }
}
