using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbPai
{
    public int IdPais { get; set; }

    public int? PsDesat { get; set; }

    public short? PsId { get; set; }

    public string? PsSigla { get; set; }

    public string? PsNome { get; set; }

    public int? PsCanc { get; set; }

    public int? FkTbUnidadeMonetaria { get; set; }

    public virtual TbUnidadeMonetarium? FkTbUnidadeMonetariaNavigation { get; set; }

    public virtual ICollection<TbRegioesBr> TbRegioesBrs { get; set; } = new List<TbRegioesBr>();
}
