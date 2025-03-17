using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacaoPagamento
{
    public int IdMovimentacaoPagamento { get; set; }

    public DateTime MpgDtCri { get; set; }

    public DateTime MpgDtAlt { get; set; }

    public DateTime? MpgDtAcs { get; set; }

    public int? MpgCanc { get; set; }

    public short MpgNumPag { get; set; }

    public int? MpgParcs { get; set; }

    public int? MpgNfeVlrPag { get; set; }

    public byte MpgNfeTipoIntegr { get; set; }

    public byte MpgNfeTipoBand { get; set; }

    public string? MpgNfeNumAut { get; set; }

    public double? MpgNfeVlrTroco { get; set; }

    public double? MpgNfeVlrMov { get; set; }

    public int? FkTbMovimentacao { get; set; }

    public int? FkTbSubFormaPagamento { get; set; }

    public virtual TbMovimentacao? FkTbMovimentacaoNavigation { get; set; }

    public virtual TbSubFormaPagamento? FkTbSubFormaPagamentoNavigation { get; set; }

    public virtual ICollection<TbMovimentacaoPagamentoParcela> TbMovimentacaoPagamentoParcelas { get; set; } = new List<TbMovimentacaoPagamentoParcela>();
}
