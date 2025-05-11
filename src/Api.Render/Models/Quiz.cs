using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Render.Models
{
    [Table("quizzes")]
    public class Quiz
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }


        [Column("descricao")]
        public string Descricao { get; set; }

        public List<Pergunta> Perguntas { get; set; }
    }

}
