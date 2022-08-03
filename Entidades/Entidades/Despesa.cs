using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("TB_DESPESA")]
    public class Despesa
    {
        [Column("DESPESA_ID")]
        public int Id { get; set; }

        [Column("DESPESA_DESCRICAO")]
        [MaxLength(255)]
        [Required()]
        public string Descricao { get; set; }

        [Column("DESPESA_VALOR")]
        [Required()]
        public double Valor { get; set; }

        [Column("DESPESA_DATA")]
        [Required()]
        public DateTime Data { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
