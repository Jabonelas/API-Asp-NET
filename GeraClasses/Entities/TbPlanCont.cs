using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbPlanCont
{
    public int IdPlanCont { get; set; }

    public string? PcDesc { get; set; }

    public DateTime PcDtCri { get; set; }

    public DateTime PcDtAlt { get; set; }

    public DateTime? PcDtAcs { get; set; }

    public decimal? PcDesat { get; set; }

    public decimal? PcCanc { get; set; }
}
