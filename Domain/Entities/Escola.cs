using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Escolas")]
    public class Escola : BaseEntity
    {
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Turma> Turmas { get; set; }
    }
}
