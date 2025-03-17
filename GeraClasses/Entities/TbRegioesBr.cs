using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbRegioesBr
{
    public int IdRegioesBr { get; set; }

    public int? RbDesat { get; set; }

    public byte? RbId { get; set; }

    public string? RbSigla { get; set; }

    public string? RbNome { get; set; }

    public int? FkTbPais { get; set; }

    public virtual TbPai? FkTbPaisNavigation { get; set; }

    public virtual ICollection<TbEstadosBr> TbEstadosBrs { get; set; } = new List<TbEstadosBr>();
}
