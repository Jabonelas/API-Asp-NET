using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMovimentacaoProduto
{
    public int IdMovimentacaoProduto { get; set; }

    public string? MpDesc { get; set; }

    public string? MpDescCurta { get; set; }

    public string? MpNfeIpiCnpjProd { get; set; }

    public string? MpNfeNcmImpXml { get; set; }

    public int? MpVlrFreteImpXml { get; set; }

    public int? MpMovProOrig { get; set; }

    public DateTime MpDtCri { get; set; }

    public DateTime MpDtAlt { get; set; }

    public DateTime? MpDtAcs { get; set; }

    public short MpNfeCfopImpXml { get; set; }

    public short MpNumItem { get; set; }

    public int? MpCanc { get; set; }

    public byte MpNfePisCofinsReg { get; set; }

    public int? MpPisCofinsIncidencia { get; set; }

    public long MpCodRef { get; set; }

    public int? MpQtdCom { get; set; }

    public string? MpObs { get; set; }

    public int? MpQtdDevolvida { get; set; }

    public int? MpQtdDevolver { get; set; }

    public byte MpUnMedCom { get; set; }

    public string? MpUnMedComImpXml { get; set; }

    public int? MpVlrUnCom { get; set; }

    public string? MpEan { get; set; }

    public int? MpVlrProdTot { get; set; }

    public int? MpVlrProdTotImpXml { get; set; }

    public int? MpVlrFrete { get; set; }

    public int? MpVlrSeg { get; set; }

    public string? MpTipoDesc { get; set; }

    public int? MpVlrDesc { get; set; }

    public int? MpVlrOutro { get; set; }

    public string? MpCest { get; set; }

    public int MpNfeCfop { get; set; }

    public byte MpNfeIndValProdTotNfe { get; set; }

    public byte MpNfeProdOrigem { get; set; }

    public short MpNfeCst { get; set; }

    public byte MpNfeModBc { get; set; }

    public int? MpNfeVlrBcIcms { get; set; }

    public int? MpNfeVlrBcIcmsImpXml { get; set; }

    public int? MpNfeAliqIcms { get; set; }

    public int? MpNfeVlrTotIcms { get; set; }

    public int? MpNfeVlrTotIcmsImpXml { get; set; }

    public int? MpNfeVlrBcFcp { get; set; }

    public int? MpNfeVlrBcFcpImpXml { get; set; }

    public int? MpNfePercFcp { get; set; }

    public int? MpNfeVlrFcp { get; set; }

    public int MpNfeModBcSt { get; set; }

    public int? MpNfePercMvaSt { get; set; }

    public int? MpNfePercRedBcIcms { get; set; }

    public int? MpNfePercRedBcIcmsSt { get; set; }

    public int? MpNfeVlrBcIcmsSt { get; set; }

    public int? MpNfeVlrBcIcmsStImpXml { get; set; }

    public int? MpNfeAliqIcmsSt { get; set; }

    public int? MpNfeVlrIcmsSt { get; set; }

    public int? MpNfeVlrIcmsStImpXml { get; set; }

    public int? MpNfeVlrBcFcpRetSt { get; set; }

    public int? MpNfePercFcpRetSt { get; set; }

    public int? MpNfeVlrFcpRetSt { get; set; }

    public int? MpNfeVlrIcmsDeson { get; set; }

    public int? MpNfeVlrIcmsDesonImpXml { get; set; }

    public byte MpNfeMotDesonIcms { get; set; }

    public int? MpNfeVlrIcmsOp { get; set; }

    public int? MpNfeVlrIcmsOpImpXml { get; set; }

    public int? MpNfePercDif { get; set; }

    public int? MpNfeVlrIcmsDif { get; set; }

    public int? MpNfeVlrIcmsDifImpXml { get; set; }

    public int? MpNfeVlrBcIcmsStRet { get; set; }

    public int? MpNfePercAliqSuportada { get; set; }

    public int? MpNfeVlrIcmsPropSubst { get; set; }

    public int? MpNfeVlrIcmsStRet { get; set; }

    public int? MpNfeBcFcpRetAnt { get; set; }

    public int? MpNfePercFcpRetAntSt { get; set; }

    public int? MpNfePercRedBcEfet { get; set; }

    public int? MpNfeVlrBcEfet { get; set; }

    public int? MpNfePercAliqIcmsEfet { get; set; }

    public int? MpNfeVlrIcmsEfet { get; set; }

    public short MpNfeCsosn { get; set; }

    public int? MpNfePercAliqCredSn { get; set; }

    public int? MpNfeVlrCredIcmsSn { get; set; }

    public string? MpNfeIpiCselo { get; set; }

    public int MpNfeIpiQselo { get; set; }

    public string? MpNfeIpicEnq { get; set; }

    public byte MpNfeIpiTribCst { get; set; }

    public int? MpNfeIpiTribXml1VlrBc { get; set; }

    public int? MpNfeIpiTribXml1VlrBcImpXml { get; set; }

    public int? MpNfeIpiTribXml1PercIpi { get; set; }

    public int? MpNfeIpiTribXml2qUnid { get; set; }

    public int? MpNfeIpiTribXml2VlrUnit { get; set; }

    public int? MpNfeIpiTribXml2VlrIpi { get; set; }

    public int? MpNfeIpiTribXml2VlrIpiImpXml { get; set; }

    public byte MpNfeIpiIpintCst { get; set; }

    public int? MpNfeImpImpVlrBc { get; set; }

    public int? MpNfeImpImpVlrDespAdu { get; set; }

    public int? MpNfeImpImpVlr { get; set; }

    public int? MpNfeImpImpVlrIof { get; set; }

    public int? MpNfeVlrBcIcmsUfDest { get; set; }

    public int? MpNfeVlrBcIcmsUfDestImpXml { get; set; }

    public int? MpNfeVlrBcFcpUfDest { get; set; }

    public int? MpNfeVlrBcFcpUfDestImpXml { get; set; }

    public int? MpNfePercFcpUfDest { get; set; }

    public int? MpNfeAliqIcmsUfDest { get; set; }

    public int? MpNfeAliqIcmsInterUfDest { get; set; }

    public int? MpNfePercIcmsPartUfDest { get; set; }

    public int? MpNfeVlrFcpUfDest { get; set; }

    public int? MpNfeVlrIcmsUfDest { get; set; }

    public int? MpNfeVlrIcmsUfDestImpXml { get; set; }

    public int? MpNfeVlrIcmsUfRemet { get; set; }

    public int? MpNfeVlrIcmsUfRemetImpXml { get; set; }

    public byte MpNfePisCofinsCst { get; set; }

    public int? MpNfePisAliqVlrBc { get; set; }

    public int? MpNfePisAliqVlrBcImpXml { get; set; }

    public int? MpNfePisAliq { get; set; }

    public int? MpNfePisAliqImpXml { get; set; }

    public int? MpNfePisAliqVlr { get; set; }

    public int? MpNfePisAliqVlrImpXml { get; set; }

    public int? MpNfePisQtdeBcProd { get; set; }

    public int? MpNfePisQtdeAliqProd { get; set; }

    public int? MpNfePisQtdeVlr { get; set; }

    public int? MpNfePisQtdeVlrImpXml { get; set; }

    public int? MpNfePisOutrBcVlr { get; set; }

    public int? MpNfePisOutrBcVlrImpXml { get; set; }

    public int? MpNfePisOutrAliq { get; set; }

    public int? MpNfePisOutrAliqImpXml { get; set; }

    public int? MpNfePisOutrVlr { get; set; }

    public int? MpNfePisOutrVlrImpXml { get; set; }

    public int? MpNfePisVlrBcSt { get; set; }

    public int? MpNfePisVlrBcStImpXml { get; set; }

    public int? MpNfePisAliqSt { get; set; }

    public int? MpNfePisQtdeBcProdSt { get; set; }

    public int? MpNfePisQtdeBcProdStImpXml { get; set; }

    public int? MpNfePisAliqProdSt { get; set; }

    public int? MpNfePisVlrSt { get; set; }

    public int? MpNfePisVlrStImpXml { get; set; }

    public int? MpNfeCofinsAliqVlrBc { get; set; }

    public int? MpNfeCofinsAliqVlrBcImpXml { get; set; }

    public int? MpNfeCofinsAliq { get; set; }

    public int? MpNfeCofinsAliqImpXml { get; set; }

    public int? MpNfeCofinsAliqVlr { get; set; }

    public int? MpNfeCofinsAliqVlrImpXml { get; set; }

    public int? MpNfeCofinsQtdeBcProd { get; set; }

    public int? MpNfeCofinsQtdeBcProdImpXml { get; set; }

    public int? MpNfeCofinsQtdeAliqProd { get; set; }

    public int? MpNfeCofinsQtdeVlr { get; set; }

    public int? MpNfeCofinsQtdeVlrImpXml { get; set; }

    public int? MpNfeCofinsOutrBcVlr { get; set; }

    public int? MpNfeCofinsOutrBcVlrImpXml { get; set; }

    public int? MpNfeCofinsOutrAliq { get; set; }

    public int? MpNfeCofinsOutrAliqImpXml { get; set; }

    public int? MpNfeCofinsOutrBcProd { get; set; }

    public int? MpNfeCofinsOutrBcProdImpXml { get; set; }

    public int? MpNfeCofinsOutrAliqProd { get; set; }

    public int? MpNfeCofinsOutrVlr { get; set; }

    public int? MpNfeCofinsOutrVlrImpXml { get; set; }

    public int? MpNfeCofinsVlrBcSt { get; set; }

    public int? MpNfeCofinsVlrBcStImpXml { get; set; }

    public int? MpNfeCofinsAliqSt { get; set; }

    public int? MpNfeCofinsQtdeBcProdSt { get; set; }

    public int? MpNfeCofinsQtdeBcProdStImpXml { get; set; }

    public int? MpNfeCofinsAliqProdSt { get; set; }

    public int? MpNfeCofinsVlrSt { get; set; }

    public int? MpNfeCofinsVlrStImpXml { get; set; }

    public int? MpQtdAud { get; set; }

    public int? FkTbMovimentacao { get; set; }

    public int? FkTbNcm { get; set; }

    public int? FkTbAtorAtend { get; set; }

    public int? FkTbProduto { get; set; }

    public virtual TbAtor? FkTbAtorAtendNavigation { get; set; }

    public virtual TbMovimentacao? FkTbMovimentacaoNavigation { get; set; }

    public virtual TbProduto? FkTbProdutoNavigation { get; set; }
}
