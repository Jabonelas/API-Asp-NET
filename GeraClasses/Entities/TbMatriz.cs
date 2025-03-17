using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMatriz
{
    public int IdMatriz { get; set; }

    public string? MtCnpj { get; set; }

    public string? MtNomeFant { get; set; }

    public string? MtRazSoc { get; set; }

    public DateTime MtDtCri { get; set; }

    public DateTime MtDtAlt { get; set; }

    public DateTime? MtDtAcs { get; set; }

    public short MtHrAbertLj { get; set; }

    public short MtHrFchLj { get; set; }

    public int? MtEfetuaTestesEletro { get; set; }

    public int? MtDesat { get; set; }

    public byte MtPersTim { get; set; }

    public int? FkTbRede { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }

    public virtual ICollection<TbAtor> TbAtors { get; set; } = new List<TbAtor>();
}
