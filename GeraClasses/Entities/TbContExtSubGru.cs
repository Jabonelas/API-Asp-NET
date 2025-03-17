using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbContExtSubGru
{
    public int IdContExtSubGru { get; set; }

    public decimal? CesgDeb { get; set; }

    public decimal? CesgCred { get; set; }

    public DateTime CesgDtCri { get; set; }

    public DateTime CesgDtAlt { get; set; }

    public DateTime? CesgDtAcs { get; set; }

    public decimal? CesgCanc { get; set; }

    public decimal? CesgConc { get; set; }

    public int? FkTbContSubGru { get; set; }

    public virtual TbContSubGru? FkTbContSubGruNavigation { get; set; }
}
