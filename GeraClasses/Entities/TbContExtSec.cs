using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContExtSec
{
    public int IdContExtSec { get; set; }

    public decimal? CesDeb { get; set; }

    public decimal? CesCred { get; set; }

    public DateTime CesDtCri { get; set; }

    public DateTime CesDtAlt { get; set; }

    public DateTime? CesDtAcs { get; set; }

    public decimal? CesCanc { get; set; }

    public decimal? CesConc { get; set; }

    public int? FkTbContSec { get; set; }

    public virtual TbContSec? FkTbContSecNavigation { get; set; }
}
