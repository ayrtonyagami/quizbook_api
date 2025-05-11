using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Render.Models
{
    [Table("perguntas")]
    public class Pergunta
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("texto")]
        public string Texto { get; set; }

        [Column("ordem")]
        public int Ordem { get; set; }

        [Column("quiz_id")]
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public List<Opcao> Opcoes { get; set; }
    }

}
