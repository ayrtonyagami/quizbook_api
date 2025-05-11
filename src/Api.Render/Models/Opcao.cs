using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api.Render.Models
{
    [Table("opcoes")]
    public class Opcao
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("texto")]
        public string Texto { get; set; }

        [Column("correta")]
        public bool Correta { get; set; }

        [Column("pergunta_id")]
        public int PerguntaId { get; set; }

        [JsonIgnore]
        public Pergunta Pergunta { get; set; }
    }

}
