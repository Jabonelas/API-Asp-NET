using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacaoCaixa
{
    public int IdMovimentacaoCaixa { get; set; }

    public decimal? McCanc { get; set; }

    public int? FkTbMovimentacao { get; set; }

    public virtual TbMovimentacao? FkTbMovimentacaoNavigation { get; set; }
}
