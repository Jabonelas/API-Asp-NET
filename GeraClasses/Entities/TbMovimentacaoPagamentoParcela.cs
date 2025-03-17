using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacaoPagamentoParcela
{
    public int IdMovimentacaoPagamentoParcela { get; set; }

    public DateTime MppDtCri { get; set; }

    public DateTime MppDtAlt { get; set; }

    public DateTime? MppDtAcs { get; set; }

    public short MppNumParc { get; set; }

    public short MppQtdParc { get; set; }

    public decimal? MppVlrCli { get; set; }

    public decimal? MppTaxaParc { get; set; }

    public decimal? MppVlrRec { get; set; }

    public DateTime MppDtVenc { get; set; }

    public decimal? MppCanc { get; set; }

    public int? FkTbMovimentacaoPagamento { get; set; }

    public int? FkTbSubFormaPagamento { get; set; }

    public virtual TbMovimentacaoPagamento? FkTbMovimentacaoPagamentoNavigation { get; set; }

    public virtual TbSubFormaPagamento? FkTbSubFormaPagamentoNavigation { get; set; }
}
