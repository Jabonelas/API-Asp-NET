using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContGru
{
    public int IdContGru { get; set; }

    public int? CgContSec { get; set; }

    public DateTime CgDtCri { get; set; }

    public DateTime CgDtAlt { get; set; }

    public DateTime? CgDtAcs { get; set; }

    public string? CgDesc { get; set; }

    public decimal? CgCanc { get; set; }

    public decimal? CgConc { get; set; }

    public virtual ICollection<TbContExtGru> TbContExtGrus { get; set; } = new List<TbContExtGru>();

    public virtual ICollection<TbContSubGru> TbContSubGrus { get; set; } = new List<TbContSubGru>();
}
