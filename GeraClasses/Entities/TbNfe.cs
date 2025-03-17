using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbNfe
{
    public int IdNfe { get; set; }

    public int NfNfeServico { get; set; }

    public DateTime NfDtCri { get; set; }

    public DateTime NfDtAlt { get; set; }

    public DateTime? NfDtAcs { get; set; }

    public int? NfDesat { get; set; }

    public int? NfProntoEnviar { get; set; }

    public string? NfNfeNatOp { get; set; }

    public byte NfNfeTipoAmb { get; set; }

    public DateTime? NfNfeDtEmis { get; set; }

    public DateTime? NfNfeDtAut { get; set; }

    public int NfNfeCfop { get; set; }

    public short NfNfeCst { get; set; }

    public short NfNfeCsosn { get; set; }

    public string? NfNfeNumProtAut { get; set; }

    public byte NfNfeUf { get; set; }

    public int NfNfeCod { get; set; }

    public string? NfNfeChave { get; set; }

    public int? NfNfeVersao { get; set; }

    public byte NfNfeMod { get; set; }

    public byte NfNfeTipoEmis { get; set; }

    public byte NfNfeTipo { get; set; }

    public byte NfNfeSit { get; set; }

    public byte NfNfeIdentLocDestOp { get; set; }

    public int NfNfeCodMunFg { get; set; }

    public byte NfNfeTipoImpDanfe { get; set; }

    public byte? NfNfeChaveDv { get; set; }

    public byte NfNfeTipoDfe { get; set; }

    public byte NfNfeFinEmis { get; set; }

    public byte NfNfeIndOpConsumFin { get; set; }

    public byte NfNfeIndPresCompEstMomOp { get; set; }

    public string? NfNfeXmlArqAutPath { get; set; }

    public string? NfNfeXmlAutBkp { get; set; }

    public int NfNfeIndInterm { get; set; }

    public byte NfNfeProcEmis { get; set; }

    public string? NfNfeVerProcEmis { get; set; }

    public string? NfNfeInfoCompl { get; set; }

    public int? NfNfeBcIcms { get; set; }

    public int? NfNfeVlrTotIcms { get; set; }

    public int? NfNfeVlrIcmsDeson { get; set; }

    public int? NfNfeVlrTotIcmsFcp { get; set; }

    public int? NfNfeVlrTotIcmsInterUfDest { get; set; }

    public int? NfNfeVlrTotIcmsInterUfRem { get; set; }

    public int? NfNfeVlrTotFcp { get; set; }

    public int? NfNfeVlrBcIcmsSt { get; set; }

    public int? NfNfeVlrTotIcmsSt { get; set; }

    public int? NfNfeVlrTotFcpSt { get; set; }

    public int? NfNfeVlrTotFcpRetSt { get; set; }

    public int? NfNfeVlrTotProd { get; set; }

    public double? NfVlrTotPag { get; set; }

    public int? NfNfeVlrTotFrete { get; set; }

    public int? NfNfeVlrTotSeg { get; set; }

    public double? NfNfeVlrTotDesc { get; set; }

    public int? NfNfeVlrTotImpImp { get; set; }

    public int? NfNfeVlrTotIpi { get; set; }

    public int? NfNfeVlrTotIpiDevol { get; set; }

    public int? NfNfeVlrTotPis { get; set; }

    public int? NfNfeVlrTotCofins { get; set; }

    public int? NfNfeVlrTotOutro { get; set; }

    public double? NfNfeVlrTotNf { get; set; }

    public int? NfNfeVlrTotTrib { get; set; }

    public byte NfNfeModFrete { get; set; }

    public short NfNfeCstat { get; set; }

    public short NfNfeSerieProd { get; set; }

    public short NfNfeSerieHom { get; set; }

    public int NfNfeNumProd { get; set; }

    public int NfNfeNumHom { get; set; }

    public int NfNfeNum { get; set; }

    public short NfNfeSerie { get; set; }

    public int? NfNfeSolTransm { get; set; }

    public DateTime? NfNfeSolTransmDt { get; set; }

    public byte NfNfeTransmStatus { get; set; }

    public int NfNfeXmlAutErro { get; set; }

    public int NfNfeXmlCancErro { get; set; }

    public int? NfNfeEnvSfz { get; set; }

    public string? NfNfeTransmCorrigir { get; set; }

    public string? NfNfeTransmLog { get; set; }

    public string? NfNfeDhRecbto { get; set; }

    public int NfNfeProcAutExHres { get; set; }

    public string? NfNfeProcAutExMsg { get; set; }

    public int? NfNfeHaProtSfz { get; set; }

    public int? NfNfeRejSfz { get; set; }

    public string? NfNfeXmlEnv { get; set; }

    public string? NfNfeXmlCorrigir { get; set; }

    public string? NfNfeArqProcAutDist { get; set; }

    public string? NfNfeCamArqProcAutDist { get; set; }

    public string? NfNfeNomeArqProcAutDist { get; set; }

    public string? NfNfeXmlOrig { get; set; }

    public string? NfNfeXmlAss { get; set; }

    public string? NfNfeXmlRetWs { get; set; }

    public string? NfNfeXmlProcRes { get; set; }

    public string? NfNfeXmlProcAutDist { get; set; }

    public string? NfNfeXmlEvtCancDist { get; set; }

    public byte NfNfeTipoAmbImpXml { get; set; }

    public DateTime? NfNfeDtEmisImpXml { get; set; }

    public DateTime? NfNfeDtAutImpXml { get; set; }

    public int NfNfeCfopImpXml { get; set; }

    public short NfNfeCstImpXml { get; set; }

    public short NfNfeCsosnImpXml { get; set; }

    public string? NfNfeNumProtAutImpXml { get; set; }

    public int? NfNfeUf1 { get; set; }

    public byte NfNfeUfImpXml { get; set; }

    public int NfNfeCodImpXml { get; set; }

    public string? NfNfeChaveImpXml { get; set; }

    public int? NfNfeVersaoImpXml { get; set; }

    public byte NfNfeModImpXml { get; set; }

    public byte NfNfeTipoEmisImpXml { get; set; }

    public byte NfNfeTipoImpXml { get; set; }

    public byte NfNfeSitImpXml { get; set; }

    public byte NfNfeIdentLocDestOpImpXml { get; set; }

    public int? NfNfeCodMunFg1 { get; set; }

    public int NfNfeCodMunFgImpXml { get; set; }

    public byte NfNfeTipoImpDanfeImpXml { get; set; }

    public byte? NfNfeChaveDvImpXml { get; set; }

    public byte NfNfeTipoDfeImpXml { get; set; }

    public byte NfNfeFinEmisImpXml { get; set; }

    public byte NfNfeIndOpConsumFinImpXml { get; set; }

    public byte NfNfeIndPresCompEstMomOpImpXml { get; set; }

    public string? NfNfeXmlArqAutPathImpXml { get; set; }

    public string? NfNfeXmlAutBkpImpXml { get; set; }

    public int NfNfeIndIntermImpXml { get; set; }

    public byte NfNfeProcEmisImpXml { get; set; }

    public string? NfNfeVerProcEmisImpXml { get; set; }

    public string? NfNfeInfoComplImpXml { get; set; }

    public int? NfNfeBcIcmsImpXml { get; set; }

    public int? NfNfeVlrTotIcmsImpXml { get; set; }

    public int? NfNfeVlrIcmsDesonImpXml { get; set; }

    public int? NfNfeVlrTotIcmsFcpImpXml { get; set; }

    public int? NfNfeVlrTotIcmsInterUfDestImpXml { get; set; }

    public int? NfNfeVlrTotIcmsInterUfRemImpXml { get; set; }

    public int? NfNfeVlrTotFcpImpXml { get; set; }

    public int? NfNfeVlrBcIcmsStImpXml { get; set; }

    public int? NfNfeVlrTotIcmsStImpXml { get; set; }

    public int? NfNfeVlrTotFcpStImpXml { get; set; }

    public int? NfNfeVlrTotFcpRetStImpXml { get; set; }

    public int? NfNfeVlrTotProdImpXml { get; set; }

    public int? NfVlrTotPagImpXml { get; set; }

    public int? NfNfeVlrTotFreteImpXml { get; set; }

    public int? NfNfeVlrTotSegImpXml { get; set; }

    public int? NfNfeVlrTotDescImpXml { get; set; }

    public int? NfNfeVlrTotImpImpImpXml { get; set; }

    public int? NfNfeVlrTotIpiImpXml { get; set; }

    public int? NfNfeVlrTotIpiDevolImpXml { get; set; }

    public int? NfNfeVlrTotPisImpXml { get; set; }

    public int? NfNfeVlrTotCofinsImpXml { get; set; }

    public int? NfNfeVlrTotOutroImpXml { get; set; }

    public double? NfNfeVlrTotNfImpXml { get; set; }

    public int? NfNfeVlrTotTribImpXml { get; set; }

    public byte NfNfeModFreteImpXml { get; set; }

    public short NfNfeCstatImpXml { get; set; }

    public short NfNfeSerieProdImpXml { get; set; }

    public short NfNfeSerieHomImpXml { get; set; }

    public int NfNfeNumProdImpXml { get; set; }

    public int NfNfeNumHomImpXml { get; set; }

    public int NfNfeNumImpXml { get; set; }

    public short NfNfeSerieImpXml { get; set; }

    public int? NfNfeSolTransmImpXml { get; set; }

    public DateTime? NfNfeSolTransmDtImpXml { get; set; }

    public byte NfNfeTransmStatusImpXml { get; set; }

    public int NfNfeXmlAutErroImpXml { get; set; }

    public int NfNfeXmlCancErroImpXml { get; set; }

    public int? NfNfeEnvSfzImpXml { get; set; }

    public string? NfNfeTransmCorrigirImpXml { get; set; }

    public string? NfNfeTransmLogImpXml { get; set; }

    public string? NfNfeDhRecbtoImpXml { get; set; }

    public int NfNfeProcAutExHresImpXml { get; set; }

    public string? NfNfeProcAutExMsgImpXml { get; set; }

    public int? NfNfeHaProtSfzImpXml { get; set; }

    public int? NfNfeRejSfzImpXml { get; set; }

    public string? NfNfeXmlEnvImpXml { get; set; }

    public string? NfNfeXmlCorrigirImpXml { get; set; }

    public string? NfNfeArqProcAutDistImpXml { get; set; }

    public string? NfNfeCamArqProcAutDistImpXml { get; set; }

    public string? NfNfeNomeArqProcAutDistImpXml { get; set; }

    public string? NfNfeXmlOrigImpXml { get; set; }

    public string? NfNfeXmlAssImpXml { get; set; }

    public string? NfNfeXmlRetWsImpXml { get; set; }

    public string? NfNfeXmlProcResImpXml { get; set; }

    public string? NfNfeXmlProcAutDistImpXml { get; set; }

    public string? NfNfeXmlEvtCancDistImpXml { get; set; }

    public int? NfNfeVlrTrocoImpXml { get; set; }

    public DateTime? NfNfe1DhRecbto { get; set; }

    public int? NfNfe1Cstat { get; set; }

    public string? NfNfe1Xmotivo { get; set; }

    public string? NfNfe1RetornoWsstring { get; set; }

    public string? NfNfe1WsxmlinnerText { get; set; }

    public string? NfNfe1ConteudoXmloriginalOuterXml { get; set; }

    public int? NfNfe1ResProtNfeInfProt0Cstat { get; set; }

    public string? NfNfe1ResProtNfeInfProt0ChNfe { get; set; }

    public string? NfNfe1ResProtNfeInfProt0Xmotivo { get; set; }

    public string? NfNfe1ResProtNfeInfProt0Nprot { get; set; }

    public DateTime? NfNfe1ResProtNfeInfProt0DhRecbto { get; set; }

    public string? NfNfe2ConteudoXmlouterXml { get; set; }

    public string? NfNfe2RetornoWsstring { get; set; }

    public string? NfNfe2RetornoWsxmlinnerText { get; set; }

    public int? NfNfe2ResCstat { get; set; }

    public DateTime? NfNfe2ResDhRecbto { get; set; }

    public string? NfNfe2ResNrec { get; set; }

    public int? NfNfe2ResProtNfeInfProt0Cstat { get; set; }

    public string? NfNfe2ResProtNfeInfProt0ChNfe { get; set; }

    public string? NfNfe2ResProtNfeInfProt0Xmotivo { get; set; }

    public DateTime? NfNfe2ResProtNfeInfProt0DhRecbto { get; set; }

    public string? NfNfeProcResultsXmldist { get; set; }

    public int NfNfeProdNumPulo { get; set; }

    public int? FkTbMovimentacao { get; set; }

    public virtual TbMovimentacao? FkTbMovimentacaoNavigation { get; set; }

    public virtual ICollection<TbNfeEnviadaFilial> TbNfeEnviadaFilials { get; set; } = new List<TbNfeEnviadaFilial>();
}
