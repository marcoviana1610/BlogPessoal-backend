using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Model
{
    public class TopicModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
    }
}
