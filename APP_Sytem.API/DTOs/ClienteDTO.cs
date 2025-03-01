using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APP_Sytem.API.DTOs
{
    public class ClienteDTO
    {
        [Key]
        [Column("id_ator")]
        public int IdAtor { get; set; }

        [Column("at_cnpj", TypeName = "varchar(18)")]
        public string AtCnpj { get; set; }

        [Column("at_cpf", TypeName = "varchar(14)")]
        public string AtCpf { get; set; }

        [Column("at_rgRne", TypeName = "varchar(20)")]
        public string AtRgRne { get; set; }

        [Column("at_razSoc", TypeName = "varchar(60)")]
        public string AtRazSoc { get; set; }

        [Column("at_nomeFant", TypeName = "varchar(60)")]
        public string AtNomeFant { get; set; }
    }
}