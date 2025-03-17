using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbNfeEnviadaFilial
{
    public int IdNfeEnviadaFilial { get; set; }

    public DateTime NefDtCri { get; set; }

    public DateTime NefDtAlt { get; set; }

    public DateTime? NefDtAcs { get; set; }

    public decimal? NefDesat { get; set; }

    public int? FkTbPdv { get; set; }

    public int? FkTbNfe { get; set; }

    public virtual TbNfe? FkTbNfeNavigation { get; set; }

    public virtual TbPdv? FkTbPdvNavigation { get; set; }
}
