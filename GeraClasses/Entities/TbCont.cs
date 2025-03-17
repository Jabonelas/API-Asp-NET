using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbCont
{
    public int IdCont { get; set; }

    public string? CtDesc { get; set; }

    public decimal? CtSaldo { get; set; }

    public DateTime CtDtCri { get; set; }

    public DateTime CtDAlt { get; set; }

    public DateTime? CtDtAcs { get; set; }

    public decimal? CtCanc { get; set; }

    public decimal? CtConc { get; set; }

    public int? FkTbAtor { get; set; }

    public int? FkTbContSubGru { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual TbContSubGru? FkTbContSubGruNavigation { get; set; }

    public virtual ICollection<TbContExt> TbContExts { get; set; } = new List<TbContExt>();
}
