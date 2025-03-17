using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacaoImpressao
{
    public int IdMovimentacaoImpressao { get; set; }

    public DateTime MiDtCri { get; set; }

    public DateTime MiDtAlt { get; set; }

    public DateTime? MiDtAcs { get; set; }

    public byte MiTipo { get; set; }

    public byte[]? MiPdf { get; set; }

    public decimal? MiDcanc { get; set; }

    public int? FkTbMovimentacao { get; set; }

    public virtual TbMovimentacao? FkTbMovimentacaoNavigation { get; set; }
}
