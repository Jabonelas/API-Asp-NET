using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbFormaPagamento
{
    public int IdFormaPagamento { get; set; }

    public DateTime FpDtCri { get; set; }

    public DateTime FpDtAlt { get; set; }

    public DateTime? FpDtAcs { get; set; }

    public int? FpDesat { get; set; }

    public string? FpDesc { get; set; }

    public short FpOrdExib { get; set; }

    public string? FpAtalhoTecl { get; set; }

    public string? FpTaxaDesc { get; set; }

    public DateTime? FpTaxaData { get; set; }

    public int? FpTaxa0 { get; set; }

    public double? FpTaxa1 { get; set; }

    public double? FpTaxa2 { get; set; }

    public double? FpTaxa3 { get; set; }

    public double? FpTaxa4 { get; set; }

    public double? FpTaxa5 { get; set; }

    public double? FpTaxa6 { get; set; }

    public double? FpTaxa7 { get; set; }

    public double? FpTaxa8 { get; set; }

    public double? FpTaxa9 { get; set; }

    public double? FpTaxa10 { get; set; }

    public double? FpTaxa11 { get; set; }

    public double? FpTaxa12 { get; set; }

    public double? FpVlrMin { get; set; }

    public double? FpVlrMax { get; set; }

    public short FpParcMin { get; set; }

    public short FpParcMax { get; set; }

    public short FpIntParcBase { get; set; }

    public int FpNfeIndPag { get; set; }

    public int FpNfeTipoPag { get; set; }

    public byte FpNfeTipoIntegr { get; set; }

    public int? FpCanc { get; set; }

    public int? FkTbRede { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }

    public virtual ICollection<TbSubFormaPagamento> TbSubFormaPagamentos { get; set; } = new List<TbSubFormaPagamento>();
}
