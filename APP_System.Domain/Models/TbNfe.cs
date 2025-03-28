﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_nfe")]
[Index("FkTbMovimentacao", Name = "ifk_tb_movimentacao_tb_nfe")]
public partial class TbNfe
{
    [Key]
    [Column("id_nfe")]
    public int IdNfe { get; set; }

    [Column("nf_nfeServico", TypeName = "INT")]
    public int NfNfeServico { get; set; }

    [Column("nf_dtCri", TypeName = "DATETIME")]
    public DateTime NfDtCri { get; set; }

    [Column("nf_dtAlt", TypeName = "DATETIME")]
    public DateTime NfDtAlt { get; set; }

    [Column("nf_dtAcs", TypeName = "DATETIME")]
    public DateTime? NfDtAcs { get; set; }

    [Column("nf_desat", TypeName = "NUMERIC(1, 0)")]
    public int? NfDesat { get; set; }

    [Column("nf_prontoEnviar", TypeName = "NUMERIC(1, 0)")]
    public int? NfProntoEnviar { get; set; }

    [Column("nf_nfeNatOp", TypeName = "varchar(60)")]
    public string NfNfeNatOp { get; set; }

    [Column("nf_nfeTipoAmb", TypeName = "tinyint")]
    public byte NfNfeTipoAmb { get; set; }

    [Column("nf_nfeDtEmis", TypeName = "DATETIME")]
    public DateTime? NfNfeDtEmis { get; set; }

    [Column("nf_nfeDtAut", TypeName = "DATETIME")]
    public DateTime? NfNfeDtAut { get; set; }

    [Column("nf_nfeCfop", TypeName = "INT")]
    public int NfNfeCfop { get; set; }

    [Column("nf_nfeCst", TypeName = "smallint")]
    public short NfNfeCst { get; set; }

    [Column("nf_nfeCsosn", TypeName = "smallint")]
    public short NfNfeCsosn { get; set; }

    [Column("nf_nfeNumProtAut", TypeName = "varchar(15)")]
    public string NfNfeNumProtAut { get; set; }

    [Column("nf_nfeUf", TypeName = "tinyint")]
    public byte NfNfeUf { get; set; }

    [Column("nf_nfeCod", TypeName = "INT")]
    public int NfNfeCod { get; set; }

    [Column("nf_nfeChave", TypeName = "varchar(50)")]
    public string NfNfeChave { get; set; }

    [Column("nf_nfeVersao", TypeName = "NUMERIC(6, 3)")]
    public int? NfNfeVersao { get; set; }

    [Column("nf_nfeMod", TypeName = "tinyint")]
    public byte NfNfeMod { get; set; }

    [Column("nf_nfeTipoEmis", TypeName = "tinyint")]
    public byte NfNfeTipoEmis { get; set; }

    [Column("nf_nfeTipo", TypeName = "tinyint")]
    public byte NfNfeTipo { get; set; }

    [Column("nf_nfeSit", TypeName = "tinyint")]
    public byte NfNfeSit { get; set; }

    [Column("nf_nfeIdentLocDestOp", TypeName = "tinyint")]
    public byte NfNfeIdentLocDestOp { get; set; }

    [Column("nf_nfeCodMunFg", TypeName = "INT")]
    public int NfNfeCodMunFg { get; set; }

    [Column("nf_nfeTipoImpDanfe", TypeName = "tinyint")]
    public byte NfNfeTipoImpDanfe { get; set; }

    [Column("nf_nfeChaveDv", TypeName = "tinyint")]
    public byte? NfNfeChaveDv { get; set; }

    [Column("nf_nfeTipoDfe", TypeName = "tinyint")]
    public byte NfNfeTipoDfe { get; set; }

    [Column("nf_nfeFinEmis", TypeName = "tinyint")]
    public byte NfNfeFinEmis { get; set; }

    [Column("nf_nfeIndOpConsumFin", TypeName = "tinyint")]
    public byte NfNfeIndOpConsumFin { get; set; }

    [Column("nf_nfeIndPresCompEstMomOp", TypeName = "tinyint")]
    public byte NfNfeIndPresCompEstMomOp { get; set; }

    [Column("nf_nfeXmlArqAutPath", TypeName = "varchar(255)")]
    public string NfNfeXmlArqAutPath { get; set; }

    [Column("nf_nfeXmlAutBkp")]
    public string NfNfeXmlAutBkp { get; set; }

    [Column("nf_nfeIndInterm", TypeName = "INT")]
    public int NfNfeIndInterm { get; set; }

    [Column("nf_nfeProcEmis", TypeName = "tinyint")]
    public byte NfNfeProcEmis { get; set; }

    [Column("nf_nfeVerProcEmis", TypeName = "varchar(20)")]
    public string NfNfeVerProcEmis { get; set; }

    [Column("nf_nfeInfoCompl")]
    public string NfNfeInfoCompl { get; set; }

    [Column("nf_nfeBcIcms", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeBcIcms { get; set; }

    [Column("nf_nfeVlrTotIcms", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcms { get; set; }

    [Column("nf_nfeVlrIcmsDeson", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrIcmsDeson { get; set; }

    [Column("nf_nfeVlrTotIcmsFcp", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsFcp { get; set; }

    [Column("nf_nfeVlrTotIcmsInterUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsInterUfDest { get; set; }

    [Column("nf_nfeVlrTotIcmsInterUfRem", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsInterUfRem { get; set; }

    [Column("nf_nfeVlrTotFcp", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcp { get; set; }

    [Column("nf_nfeVlrBcIcmsSt", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrBcIcmsSt { get; set; }

    [Column("nf_nfeVlrTotIcmsSt", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsSt { get; set; }

    [Column("nf_nfeVlrTotFcpSt", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcpSt { get; set; }

    [Column("nf_nfeVlrTotFcpRetSt", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcpRetSt { get; set; }

    [Column("nf_nfeVlrTotProd", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotProd { get; set; }

    [Column("nf_vlrTotPag", TypeName = "NUMERIC(13, 2)")]
    public double? NfVlrTotPag { get; set; }

    [Column("nf_nfeVlrTotFrete", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFrete { get; set; }

    [Column("nf_nfeVlrTotSeg", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotSeg { get; set; }

    [Column("nf_nfeVlrTotDesc", TypeName = "NUMERIC(13, 2)")]
    public double? NfNfeVlrTotDesc { get; set; }

    [Column("nf_nfeVlrTotImpImp", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotImpImp { get; set; }

    [Column("nf_nfeVlrTotIpi", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIpi { get; set; }

    [Column("nf_nfeVlrTotIpiDevol", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIpiDevol { get; set; }

    [Column("nf_nfeVlrTotPis", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotPis { get; set; }

    [Column("nf_nfeVlrTotCofins", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotCofins { get; set; }

    [Column("nf_nfeVlrTotOutro", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotOutro { get; set; }

    [Column("nf_nfeVlrTotNF", TypeName = "NUMERIC(13, 2)")]
    public double? NfNfeVlrTotNf { get; set; }

    [Column("nf_nfeVlrTotTrib", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotTrib { get; set; }

    [Column("nf_nfeModFrete", TypeName = "tinyint")]
    public byte NfNfeModFrete { get; set; }

    [Column("nf_nfeCstat", TypeName = "smallint")]
    public short NfNfeCstat { get; set; }

    [Column("nf_nfeSerieProd", TypeName = "smallint")]
    public short NfNfeSerieProd { get; set; }

    [Column("nf_nfeSerieHom", TypeName = "smallint")]
    public short NfNfeSerieHom { get; set; }

    [Column("nf_nfeNumProd", TypeName = "INT")]
    public int NfNfeNumProd { get; set; }

    [Column("nf_nfeNumHom", TypeName = "INT")]
    public int NfNfeNumHom { get; set; }

    [Column("nf_nfeNum", TypeName = "INT")]
    public int NfNfeNum { get; set; }

    [Column("nf_nfeSerie", TypeName = "smallint")]
    public short NfNfeSerie { get; set; }

    [Column("nf_nfeSolTransm", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeSolTransm { get; set; }

    [Column("nf_nfeSolTransmDt", TypeName = "DATETIME")]
    public DateTime? NfNfeSolTransmDt { get; set; }

    [Column("nf_nfeTransmStatus", TypeName = "tinyint")]
    public byte NfNfeTransmStatus { get; set; }

    [Column("nf_nfeXmlAutErro", TypeName = "INT")]
    public int NfNfeXmlAutErro { get; set; }

    [Column("nf_nfeXmlCancErro", TypeName = "INT")]
    public int NfNfeXmlCancErro { get; set; }

    [Column("nf_nfeEnvSfz", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeEnvSfz { get; set; }

    [Column("nf_nfeTransmCorrigir")]
    public string NfNfeTransmCorrigir { get; set; }

    [Column("nf_nfeTransmLog")]
    public string NfNfeTransmLog { get; set; }

    [Column("nf_nfeDhRecbto")]
    public string NfNfeDhRecbto { get; set; }

    [Column("nf_nfeProcAutExHRes", TypeName = "INT")]
    public int NfNfeProcAutExHres { get; set; }

    [Column("nf_nfeProcAutExMsg")]
    public string NfNfeProcAutExMsg { get; set; }

    [Column("nf_nfeHaProtSfz", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeHaProtSfz { get; set; }

    [Column("nf_nfeRejSfz", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeRejSfz { get; set; }

    [Column("nf_nfeXmlEnv")]
    public string NfNfeXmlEnv { get; set; }

    [Column("nf_nfeXmlCorrigir")]
    public string NfNfeXmlCorrigir { get; set; }

    [Column("nf_nfeArqProcAutDist")]
    public string NfNfeArqProcAutDist { get; set; }

    [Column("nf_nfeCamArqProcAutDist", TypeName = "varchar(255)")]
    public string NfNfeCamArqProcAutDist { get; set; }

    [Column("nf_nfeNomeArqProcAutDist", TypeName = "varchar(255)")]
    public string NfNfeNomeArqProcAutDist { get; set; }

    [Column("nf_nfeXmlOrig")]
    public string NfNfeXmlOrig { get; set; }

    [Column("nf_nfeXmlAss")]
    public string NfNfeXmlAss { get; set; }

    [Column("nf_nfeXmlRetWs")]
    public string NfNfeXmlRetWs { get; set; }

    [Column("nf_nfeXmlProcRes")]
    public string NfNfeXmlProcRes { get; set; }

    [Column("nf_nfeXmlProcAutDist")]
    public string NfNfeXmlProcAutDist { get; set; }

    [Column("nf_nfeXmlEvtCancDist")]
    public string NfNfeXmlEvtCancDist { get; set; }

    [Column("nf_nfeTipoAmb_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTipoAmbImpXml { get; set; }

    [Column("nf_nfeDtEmis_ImpXml", TypeName = "DATETIME")]
    public DateTime? NfNfeDtEmisImpXml { get; set; }

    [Column("nf_nfeDtAut_ImpXml", TypeName = "DATETIME")]
    public DateTime? NfNfeDtAutImpXml { get; set; }

    [Column("nf_nfeCfop_ImpXml", TypeName = "INT")]
    public int NfNfeCfopImpXml { get; set; }

    [Column("nf_nfeCst_ImpXml", TypeName = "smallint")]
    public short NfNfeCstImpXml { get; set; }

    [Column("nf_nfeCsosn_ImpXml", TypeName = "smallint")]
    public short NfNfeCsosnImpXml { get; set; }

    [Column("nf_nfeNumProtAut_ImpXml", TypeName = "varchar(15)")]
    public string NfNfeNumProtAutImpXml { get; set; }

    [Column("nf_nfeUf_")]
    public int? NfNfeUf1 { get; set; }

    [Column("nf_nfeUf_ImpXml", TypeName = "tinyint")]
    public byte NfNfeUfImpXml { get; set; }

    [Column("nf_nfeCod_ImpXml", TypeName = "INT")]
    public int NfNfeCodImpXml { get; set; }

    [Column("nf_nfeChave_ImpXml", TypeName = "varchar(50)")]
    public string NfNfeChaveImpXml { get; set; }

    [Column("nf_nfeVersao_ImpXml", TypeName = "NUMERIC(6, 3)")]
    public int? NfNfeVersaoImpXml { get; set; }

    [Column("nf_nfeMod_ImpXml", TypeName = "tinyint")]
    public byte NfNfeModImpXml { get; set; }

    [Column("nf_nfeTipoEmis_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTipoEmisImpXml { get; set; }

    [Column("nf_nfeTipo_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTipoImpXml { get; set; }

    [Column("nf_nfeSit_ImpXml", TypeName = "tinyint")]
    public byte NfNfeSitImpXml { get; set; }

    [Column("nf_nfeIdentLocDestOp_ImpXml", TypeName = "tinyint")]
    public byte NfNfeIdentLocDestOpImpXml { get; set; }

    [Column("nf_nfeCodMunFg_")]
    public int? NfNfeCodMunFg1 { get; set; }

    [Column("nf_nfeCodMunFg_ImpXml", TypeName = "INT")]
    public int NfNfeCodMunFgImpXml { get; set; }

    [Column("nf_nfeTipoImpDanfe_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTipoImpDanfeImpXml { get; set; }

    [Column("nf_nfeChaveDv_ImpXml", TypeName = "tinyint")]
    public byte? NfNfeChaveDvImpXml { get; set; }

    [Column("nf_nfeTipoDfe_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTipoDfeImpXml { get; set; }

    [Column("nf_nfeFinEmis_ImpXml", TypeName = "tinyint")]
    public byte NfNfeFinEmisImpXml { get; set; }

    [Column("nf_nfeIndOpConsumFin_ImpXml", TypeName = "tinyint")]
    public byte NfNfeIndOpConsumFinImpXml { get; set; }

    [Column("nf_nfeIndPresCompEstMomOp_ImpXml", TypeName = "tinyint")]
    public byte NfNfeIndPresCompEstMomOpImpXml { get; set; }

    [Column("nf_nfeXmlArqAutPath_ImpXml", TypeName = "varchar(255)")]
    public string NfNfeXmlArqAutPathImpXml { get; set; }

    [Column("nf_nfeXmlAutBkp_ImpXml")]
    public string NfNfeXmlAutBkpImpXml { get; set; }

    [Column("nf_nfeIndInterm_ImpXml", TypeName = "INT")]
    public int NfNfeIndIntermImpXml { get; set; }

    [Column("nf_nfeProcEmis_ImpXml", TypeName = "tinyint")]
    public byte NfNfeProcEmisImpXml { get; set; }

    [Column("nf_nfeVerProcEmis_ImpXml", TypeName = "varchar(20)")]
    public string NfNfeVerProcEmisImpXml { get; set; }

    [Column("nf_nfeInfoCompl_ImpXml")]
    public string NfNfeInfoComplImpXml { get; set; }

    [Column("nf_nfeBcIcms_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeBcIcmsImpXml { get; set; }

    [Column("nf_nfeVlrTotIcms_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsImpXml { get; set; }

    [Column("nf_nfeVlrIcmsDeson_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrIcmsDesonImpXml { get; set; }

    [Column("nf_nfeVlrTotIcmsFcp_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsFcpImpXml { get; set; }

    [Column("nf_nfeVlrTotIcmsInterUfDest_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsInterUfDestImpXml { get; set; }

    [Column("nf_nfeVlrTotIcmsInterUfRem_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsInterUfRemImpXml { get; set; }

    [Column("nf_nfeVlrTotFcp_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcpImpXml { get; set; }

    [Column("nf_nfeVlrBcIcmsSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrBcIcmsStImpXml { get; set; }

    [Column("nf_nfeVlrTotIcmsSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIcmsStImpXml { get; set; }

    [Column("nf_nfeVlrTotFcpSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcpStImpXml { get; set; }

    [Column("nf_nfeVlrTotFcpRetSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFcpRetStImpXml { get; set; }

    [Column("nf_nfeVlrTotProd_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotProdImpXml { get; set; }

    [Column("nf_vlrTotPag_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfVlrTotPagImpXml { get; set; }

    [Column("nf_nfeVlrTotFrete_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotFreteImpXml { get; set; }

    [Column("nf_nfeVlrTotSeg_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotSegImpXml { get; set; }

    [Column("nf_nfeVlrTotDesc_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotDescImpXml { get; set; }

    [Column("nf_nfeVlrTotImpImp_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotImpImpImpXml { get; set; }

    [Column("nf_nfeVlrTotIpi_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIpiImpXml { get; set; }

    [Column("nf_nfeVlrTotIpiDevol_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotIpiDevolImpXml { get; set; }

    [Column("nf_nfeVlrTotPis_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotPisImpXml { get; set; }

    [Column("nf_nfeVlrTotCofins_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotCofinsImpXml { get; set; }

    [Column("nf_nfeVlrTotOutro_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotOutroImpXml { get; set; }

    [Column("nf_nfeVlrTotNF_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public double? NfNfeVlrTotNfImpXml { get; set; }

    [Column("nf_nfeVlrTotTrib_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTotTribImpXml { get; set; }

    [Column("nf_nfeModFrete_ImpXml", TypeName = "tinyint")]
    public byte NfNfeModFreteImpXml { get; set; }

    [Column("nf_nfeCstat_ImpXml", TypeName = "smallint")]
    public short NfNfeCstatImpXml { get; set; }

    [Column("nf_nfeSerieProd_ImpXml", TypeName = "smallint")]
    public short NfNfeSerieProdImpXml { get; set; }

    [Column("nf_nfeSerieHom_ImpXml", TypeName = "smallint")]
    public short NfNfeSerieHomImpXml { get; set; }

    [Column("nf_nfeNumProd_ImpXml", TypeName = "INT")]
    public int NfNfeNumProdImpXml { get; set; }

    [Column("nf_nfeNumHom_ImpXml", TypeName = "INT")]
    public int NfNfeNumHomImpXml { get; set; }

    [Column("nf_nfeNum_ImpXml", TypeName = "INT")]
    public int NfNfeNumImpXml { get; set; }

    [Column("nf_nfeSerie_ImpXml", TypeName = "smallint")]
    public short NfNfeSerieImpXml { get; set; }

    [Column("nf_nfeSolTransm_ImpXml", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeSolTransmImpXml { get; set; }

    [Column("nf_nfeSolTransmDt_ImpXml", TypeName = "DATETIME")]
    public DateTime? NfNfeSolTransmDtImpXml { get; set; }

    [Column("nf_nfeTransmStatus_ImpXml", TypeName = "tinyint")]
    public byte NfNfeTransmStatusImpXml { get; set; }

    [Column("nf_nfeXmlAutErro_ImpXml", TypeName = "INT")]
    public int NfNfeXmlAutErroImpXml { get; set; }

    [Column("nf_nfeXmlCancErro_ImpXml", TypeName = "INT")]
    public int NfNfeXmlCancErroImpXml { get; set; }

    [Column("nf_nfeEnvSfz_ImpXml", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeEnvSfzImpXml { get; set; }

    [Column("nf_nfeTransmCorrigir_ImpXml")]
    public string NfNfeTransmCorrigirImpXml { get; set; }

    [Column("nf_nfeTransmLog_ImpXml")]
    public string NfNfeTransmLogImpXml { get; set; }

    [Column("nf_nfeDhRecbto_ImpXml")]
    public string NfNfeDhRecbtoImpXml { get; set; }

    [Column("nf_nfeProcAutExHRes_ImpXml", TypeName = "INT")]
    public int NfNfeProcAutExHresImpXml { get; set; }

    [Column("nf_nfeProcAutExMsg_ImpXml")]
    public string NfNfeProcAutExMsgImpXml { get; set; }

    [Column("nf_nfeHaProtSfz_ImpXml", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeHaProtSfzImpXml { get; set; }

    [Column("nf_nfeRejSfz_ImpXml", TypeName = "NUMERIC(1, 0)")]
    public int? NfNfeRejSfzImpXml { get; set; }

    [Column("nf_nfeXmlEnv_ImpXml")]
    public string NfNfeXmlEnvImpXml { get; set; }

    [Column("nf_nfeXmlCorrigir_ImpXml")]
    public string NfNfeXmlCorrigirImpXml { get; set; }

    [Column("nf_nfeArqProcAutDist_ImpXml")]
    public string NfNfeArqProcAutDistImpXml { get; set; }

    [Column("nf_nfeCamArqProcAutDist_ImpXml", TypeName = "varchar(255)")]
    public string NfNfeCamArqProcAutDistImpXml { get; set; }

    [Column("nf_nfeNomeArqProcAutDist_ImpXml", TypeName = "varchar(255)")]
    public string NfNfeNomeArqProcAutDistImpXml { get; set; }

    [Column("nf_nfeXmlOrig_ImpXml")]
    public string NfNfeXmlOrigImpXml { get; set; }

    [Column("nf_nfeXmlAss_ImpXml")]
    public string NfNfeXmlAssImpXml { get; set; }

    [Column("nf_nfeXmlRetWs_ImpXml")]
    public string NfNfeXmlRetWsImpXml { get; set; }

    [Column("nf_nfeXmlProcRes_ImpXml")]
    public string NfNfeXmlProcResImpXml { get; set; }

    [Column("nf_nfeXmlProcAutDist_ImpXml")]
    public string NfNfeXmlProcAutDistImpXml { get; set; }

    [Column("nf_nfeXmlEvtCancDist_ImpXml")]
    public string NfNfeXmlEvtCancDistImpXml { get; set; }

    [Column("nf_nfeVlrTroco_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? NfNfeVlrTrocoImpXml { get; set; }

    [Column("nf_nfe1DhRecbto", TypeName = "DATETIME")]
    public DateTime? NfNfe1DhRecbto { get; set; }

    [Column("nf_nfe1CStat", TypeName = "INT")]
    public int? NfNfe1Cstat { get; set; }

    [Column("nf_nfe1XMotivo")]
    public string NfNfe1Xmotivo { get; set; }

    [Column("nf_nfe1RetornoWSString")]
    public string NfNfe1RetornoWsstring { get; set; }

    [Column("nf_nfe1WSXMLInnerText")]
    public string NfNfe1WsxmlinnerText { get; set; }

    [Column("nf_nfe1ConteudoXMLOriginalOuterXml")]
    public string NfNfe1ConteudoXmloriginalOuterXml { get; set; }

    [Column("nf_nfe1ResProtNFeInfProt0CStat", TypeName = "INT")]
    public int? NfNfe1ResProtNfeInfProt0Cstat { get; set; }

    [Column("nf_nfe1ResProtNFeInfProt0ChNFe")]
    public string NfNfe1ResProtNfeInfProt0ChNfe { get; set; }

    [Column("nf_nfe1ResProtNFeInfProt0XMotivo")]
    public string NfNfe1ResProtNfeInfProt0Xmotivo { get; set; }

    [Column("nf_nfe1ResProtNFeInfProt0NProt", TypeName = "varchar(30)")]
    public string NfNfe1ResProtNfeInfProt0Nprot { get; set; }

    [Column("nf_nfe1ResProtNFeInfProt0DhRecbto", TypeName = "DATETIME")]
    public DateTime? NfNfe1ResProtNfeInfProt0DhRecbto { get; set; }

    [Column("nf_nfe2ConteudoXMLOuterXml")]
    public string NfNfe2ConteudoXmlouterXml { get; set; }

    [Column("nf_nfe2RetornoWSString")]
    public string NfNfe2RetornoWsstring { get; set; }

    [Column("nf_nfe2RetornoWSXMLInnerText")]
    public string NfNfe2RetornoWsxmlinnerText { get; set; }

    [Column("nf_nfe2ResCStat", TypeName = "INT")]
    public int? NfNfe2ResCstat { get; set; }

    [Column("nf_nfe2ResDhRecbto", TypeName = "DATETIME")]
    public DateTime? NfNfe2ResDhRecbto { get; set; }

    [Column("nf_nfe2ResNRec")]
    public string NfNfe2ResNrec { get; set; }

    [Column("nf_nfe2ResProtNFeInfProt0CStat", TypeName = "INT")]
    public int? NfNfe2ResProtNfeInfProt0Cstat { get; set; }

    [Column("nf_nfe2ResProtNFeInfProt0ChNFe")]
    public string NfNfe2ResProtNfeInfProt0ChNfe { get; set; }

    [Column("nf_nfe2ResProtNFeInfProt0XMotivo")]
    public string NfNfe2ResProtNfeInfProt0Xmotivo { get; set; }

    [Column("nf_nfe2ResProtNFeInfProt0DhRecbto", TypeName = "DATETIME")]
    public DateTime? NfNfe2ResProtNfeInfProt0DhRecbto { get; set; }

    [Column("nf_nfeProcResultsXMLDist")]
    public string NfNfeProcResultsXmldist { get; set; }

    [Column("nf_nfeProdNumPulo", TypeName = "INT")]
    public int NfNfeProdNumPulo { get; set; }

    [Column("fk_tb_movimentacao")]
    public int? FkTbMovimentacao { get; set; }

    [ForeignKey("FkTbMovimentacao")]
    [InverseProperty("TbNfe")]
    public virtual TbMovimentacao FkTbMovimentacaoNavigation { get; set; }

    [InverseProperty("FkTbNfeNavigation")]
    public virtual ICollection<TbNfeEnviadaFilial> TbNfeEnviadaFilial { get; set; } = new List<TbNfeEnviadaFilial>();
}