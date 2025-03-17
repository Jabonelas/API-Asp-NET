using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbClasCont2
{
    public int IdClasCont2 { get; set; }

    public int? Cc2ClasCont1 { get; set; }

    public DateTime Cc2DtCri { get; set; }

    public DateTime Cc2DtAlt { get; set; }

    public DateTime? Cc2DtAcs { get; set; }

    public decimal? Cc2Desat { get; set; }

    public string? Cc2Desc { get; set; }

    public int? FkTbPdv { get; set; }

    public virtual TbPdv? FkTbPdvNavigation { get; set; }

    public virtual ICollection<TbMovimentacao> TbMovimentacaos { get; set; } = new List<TbMovimentacao>();
}
