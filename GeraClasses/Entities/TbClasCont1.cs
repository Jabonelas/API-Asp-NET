using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbClasCont1
{
    public int IdClasCont1 { get; set; }

    public DateTime Cc1DtCri { get; set; }

    public DateTime Cc1DtAlt { get; set; }

    public DateTime? Cc1DtAcs { get; set; }

    public decimal? Cc1Desat { get; set; }

    public string? Cc1Desc { get; set; }

    public decimal? Cc1Saida { get; set; }

    public int? FkTbRede { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }
}
