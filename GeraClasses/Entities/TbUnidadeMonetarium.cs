using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbUnidadeMonetarium
{
    public int IdUnidadeMonetaria { get; set; }

    public short? UnId { get; set; }

    public string? UnSigla { get; set; }

    public string? UnNome { get; set; }

    public int? UnInter { get; set; }

    public int? UnCambio { get; set; }

    public double? UnCambioDt { get; set; }

    public int? UnCanc { get; set; }

    public virtual ICollection<TbPai> TbPais { get; set; } = new List<TbPai>();
}
