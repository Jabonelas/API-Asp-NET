using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContExtGru
{
    public int IdContExtGru { get; set; }

    public decimal? CegDeb { get; set; }

    public decimal? CegCred { get; set; }

    public DateTime CegDtCri { get; set; }

    public DateTime CegDtAlt { get; set; }

    public DateTime? CegDtAcs { get; set; }

    public decimal? CegCanc { get; set; }

    public decimal? CegConc { get; set; }

    public int? FkTbContGru { get; set; }

    public virtual TbContGru? FkTbContGruNavigation { get; set; }
}
