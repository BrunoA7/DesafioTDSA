using System.ComponentModel.DataAnnotations;

namespace ClienteCrud.web.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int CLI_ID { get; set; }
        public string CLI_NOME { get; set; }
        public DateTime CLI_DATANASCIMENTO { get; set; }
        public bool CLI_ATIVO { get; set; }

    }
}
