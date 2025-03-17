using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContSec
{
    public int IdContSec { get; set; }

    public DateTime CsDtCri { get; set; }

    public DateTime CsDtAlt { get; set; }

    public DateTime? CsDtAcs { get; set; }

    public string? CsDesc { get; set; }

    public decimal? CsCanc { get; set; }

    public decimal? CsConc { get; set; }

    public virtual ICollection<TbContExtSec> TbContExtSecs { get; set; } = new List<TbContExtSec>();
}
