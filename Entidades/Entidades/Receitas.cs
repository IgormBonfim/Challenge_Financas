using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("TB_RECEITA")]
    public class Receitas
    {
        [Column("RECEITA_ID")]
        public int Id { get; set; }
        [Column("RECEITA_DESCRICAO")]
        [MaxLength(255)]
        [Required()]
        public string Descricao { get; set; }
        [Column("RECEITA_VALOR")]
        [Required()]
        public double Valor { get; set; }
        [Column("RECEITA_DATA")]
        [Required()]
        public DateTime Data { get; set; }
    }
}
