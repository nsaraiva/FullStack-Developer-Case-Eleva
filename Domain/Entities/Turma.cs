using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entities
{

    [Table("Turmas")]
    public class Turma : BaseEntity
    {
        public string Nome { get; set; }
        public string Serie { get; set; }
        public string Nivel { get; set; }
        public int QuantidadeAlunos { get; set; }
        [ForeignKey("EscolaId")]
        public long EscolaId { get; set; }
    }
}
