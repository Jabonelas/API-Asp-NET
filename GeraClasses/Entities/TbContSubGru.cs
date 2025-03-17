using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContSubGru
{
    public int IdContSubGru { get; set; }

    public DateTime CsgDtCri { get; set; }

    public DateTime CsgDtAlt { get; set; }

    public DateTime? CsgDtAcs { get; set; }

    public string? CsgDesc { get; set; }

    public decimal? CsgCanc { get; set; }

    public decimal? CsgConc { get; set; }

    public int? FkTbContGru { get; set; }

    public virtual TbContGru? FkTbContGruNavigation { get; set; }

    public virtual ICollection<TbContExtSubGru> TbContExtSubGrus { get; set; } = new List<TbContExtSubGru>();

    public virtual ICollection<TbCont> TbConts { get; set; } = new List<TbCont>();
}
