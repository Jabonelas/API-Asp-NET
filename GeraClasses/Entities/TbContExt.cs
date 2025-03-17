using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContExt
{
    public int IdContExt { get; set; }

    public decimal? CeDeb { get; set; }

    public decimal? CeCred { get; set; }

    public DateTime CeDtCri { get; set; }

    public DateTime CeDtAlt { get; set; }

    public DateTime? CeDtAcs { get; set; }

    public decimal? CeCanc { get; set; }

    public decimal? CeConc { get; set; }

    public int? FkTbCont { get; set; }

    public virtual TbCont? FkTbContNavigation { get; set; }
}
