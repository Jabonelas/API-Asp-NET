using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbSubFormaPagamento
{
    public int IdSubFormaPagamento { get; set; }

    public DateTime SfpDtCri { get; set; }

    public DateTime SfpDtAlt { get; set; }

    public DateTime? SfpDtAcs { get; set; }

    public int? SfpDesat { get; set; }

    public string? SfpDesc { get; set; }

    public short SfpOrdExib { get; set; }

    public string? SfpAtalhoTecl { get; set; }

    public short SfpIntParc { get; set; }

    public byte SfpNfeTipoBand { get; set; }

    public int? FkTbFormaPagamento { get; set; }

    public virtual TbFormaPagamento? FkTbFormaPagamentoNavigation { get; set; }

    public virtual ICollection<TbMovimentacaoPagamentoParcela> TbMovimentacaoPagamentoParcelas { get; set; } = new List<TbMovimentacaoPagamentoParcela>();

    public virtual ICollection<TbMovimentacaoPagamento> TbMovimentacaoPagamentos { get; set; } = new List<TbMovimentacaoPagamento>();
}
