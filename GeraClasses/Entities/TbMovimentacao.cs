using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacao
{
    public int IdMovimentacao { get; set; }

    public byte MvNfeTipoAmb { get; set; }

    public DateTime MvDtCri { get; set; }

    public DateTime MvDtAlt { get; set; }

    public DateTime? MvDtAcs { get; set; }

    public long MvQtdItens { get; set; }

    public long MvNumSeq { get; set; }

    public int? MvCanc { get; set; }

    public int? MvConc { get; set; }

    public int? MvQuit { get; set; }

    public short MvMovTipo { get; set; }

    public long MvCodSeqAbertFechCx { get; set; }

    public int? MvMovAbertCx { get; set; }

    public int? MvCxAberto { get; set; }

    public int? MvNfeEnfilGer { get; set; }

    public string? MvNfeNatOp { get; set; }

    public int? MvNfeVlrTotProd { get; set; }

    public int? MvNfeVlrTotNf { get; set; }

    public double? MvNfeVlrTotDesc { get; set; }

    public int? MvNfeVlrIcmsDeson { get; set; }

    public int? MvNfeVlrTotIcmsSt { get; set; }

    public int? MvNfeVlrTotFcpRetSt { get; set; }

    public int? MvNfeVlrTotFrete { get; set; }

    public int? MvNfeVlrTotSeg { get; set; }

    public int? MvNfeVlrTotOutro { get; set; }

    public int? MvNfeVlrTotImpImp { get; set; }

    public int? MvNfeVlrTotIpi { get; set; }

    public int? MvNfeVlrTotIpiDevol { get; set; }

    public double? MvNfeVlrTroco { get; set; }

    public int? MvNfeBcIcms { get; set; }

    public int? MvNfeVlrBcIcmsSt { get; set; }

    public int? MvNfeVlrTotTrib { get; set; }

    public string? MvNfeChave { get; set; }

    public int? MvNfeVlrTotCofins { get; set; }

    public int? MvNfeVlrTotFcp { get; set; }

    public int? MvNfeVlrTotFcpSt { get; set; }

    public int? MvNfeVlrTotIcms { get; set; }

    public double? MvNfeVlrTotPis { get; set; }

    public byte MvNfeIdentLocDestOp { get; set; }

    public byte MvNfeMod { get; set; }

    public byte MvNfeIndOpConsumFin { get; set; }

    public byte MvNfeFinEmis { get; set; }

    public int MvNfeIndInterm { get; set; }

    public byte MvNfeIndPresCompEstMomOp { get; set; }

    public byte MvNfeTipo { get; set; }

    public byte MvNfeTipoImpDanfe { get; set; }

    public string? MvNfeCfop { get; set; }

    public byte MvNfeProcEmis { get; set; }

    public string? MvNfeVerProcEmis { get; set; }

    public byte MvNfeModFrete { get; set; }

    public DateTime? MvNfeDtEmis { get; set; }

    public byte MvNfeTipoEmis { get; set; }

    public byte MvNfeTipoDfe { get; set; }

    public string? MvNfeXmlProcRes { get; set; }

    public int? MvVlrTotPag { get; set; }

    public string? MvCpfTmp { get; set; }

    public int? FkTbClasCont2 { get; set; }

    public int? FkTbJornada { get; set; }

    public int? FkTbAtorAtend { get; set; }

    public int? FkTbAtorDest { get; set; }

    public int? FkTbAtorEmit { get; set; }

    public virtual TbAtor? FkTbAtorAtendNavigation { get; set; }

    public virtual TbAtor? FkTbAtorDestNavigation { get; set; }

    public virtual TbAtor? FkTbAtorEmitNavigation { get; set; }

    public virtual TbClasCont2? FkTbClasCont2Navigation { get; set; }

    public virtual TbJornadum? FkTbJornadaNavigation { get; set; }

    public virtual ICollection<TbMovimentacaoCaixa> TbMovimentacaoCaixas { get; set; } = new List<TbMovimentacaoCaixa>();

    public virtual ICollection<TbMovimentacaoImpressao> TbMovimentacaoImpressaos { get; set; } = new List<TbMovimentacaoImpressao>();

    public virtual ICollection<TbMovimentacaoPagamento> TbMovimentacaoPagamentos { get; set; } = new List<TbMovimentacaoPagamento>();

    public virtual ICollection<TbMovimentacaoProduto> TbMovimentacaoProdutos { get; set; } = new List<TbMovimentacaoProduto>();

    public virtual ICollection<TbNfe> TbNves { get; set; } = new List<TbNfe>();
}
