﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_movimentacao_produto")]
[Index("FkTbAtorAtend", Name = "ifk_tb_atorAtend_tb_movimentacao_produto")]
[Index("FkTbMovimentacao", Name = "ifk_tb_movimentacao_tb_movimentacao_produto")]
[Index("FkTbProduto", Name = "ifk_tb_produto_tb_movimentacao_produto")]
public partial class TbMovimentacaoProduto
{
    [Key]
    [Column("id_movimentacao_produto")]
    public int IdMovimentacaoProduto { get; set; }

    [Column("mp_desc", TypeName = "varchar(120)")]
    public string MpDesc { get; set; }

    [Column("mp_descCurta", TypeName = "varchar(25)")]
    public string MpDescCurta { get; set; }

    [Column("mp_nfeIpiCnpjProd", TypeName = "varchar(18)")]
    public string MpNfeIpiCnpjProd { get; set; }

    [Column("mp_nfeNcm_ImpXml", TypeName = "varchar(8)")]
    public string MpNfeNcmImpXml { get; set; }

    [Column("mp_vlrFrete_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrFreteImpXml { get; set; }

    [Column("mp_movProOrig")]
    public int? MpMovProOrig { get; set; }

    [Column("mp_dtCri", TypeName = "DATETIME")]
    public DateTime MpDtCri { get; set; }

    [Column("mp_dtAlt", TypeName = "DATETIME")]
    public DateTime MpDtAlt { get; set; }

    [Column("mp_dtAcs", TypeName = "DATETIME")]
    public DateTime? MpDtAcs { get; set; }

    [Column("mp_nfeCfop_ImpXml", TypeName = "smallint")]
    public short MpNfeCfopImpXml { get; set; }

    [Column("mp_numItem", TypeName = "smallint")]
    public short MpNumItem { get; set; }

    [Column("mp_canc", TypeName = "NUMERIC(1, 0)")]
    public int? MpCanc { get; set; }

    [Column("mp_nfePisCofinsReg", TypeName = "tinyint")]
    public byte MpNfePisCofinsReg { get; set; }

    [Column("mp_pisCofinsIncidencia", TypeName = "NUMERIC(1, 0)")]
    public int? MpPisCofinsIncidencia { get; set; }

    [Column("mp_codRef", TypeName = "bigint")]
    public long MpCodRef { get; set; }

    [Column("mp_qtdCom", TypeName = "NUMERIC(13, 3)")]
    public int? MpQtdCom { get; set; }

    [Column("mp_obs")]
    public string MpObs { get; set; }

    [Column("mp_qtdDevolvida", TypeName = "NUMERIC(13, 3)")]
    public int? MpQtdDevolvida { get; set; }

    [Column("mp_qtdDevolver", TypeName = "NUMERIC(13, 3)")]
    public int? MpQtdDevolver { get; set; }

    [Column("mp_unMedCom", TypeName = "tinyint")]
    public byte MpUnMedCom { get; set; }

    [Column("mp_unMedCom_ImpXml", TypeName = "varchar(10)")]
    public string MpUnMedComImpXml { get; set; }

    [Column("mp_vlrUnCom", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrUnCom { get; set; }

    [Column("mp_ean", TypeName = "varchar(15)")]
    public string MpEan { get; set; }

    [Column("mp_vlrProdTot", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrProdTot { get; set; }

    [Column("mp_vlrProdTot_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrProdTotImpXml { get; set; }

    [Column("mp_vlrFrete", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrFrete { get; set; }

    [Column("mp_vlrSeg", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrSeg { get; set; }

    [Column("mp_tipoDesc", TypeName = "nchar(1)")]
    public string MpTipoDesc { get; set; }

    [Column("mp_vlrDesc", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrDesc { get; set; }

    [Column("mp_vlrOutro", TypeName = "NUMERIC(13, 2)")]
    public int? MpVlrOutro { get; set; }

    [Column("mp_cest", TypeName = "varchar(7)")]
    public string MpCest { get; set; }

    [Column("mp_nfeCfop", TypeName = "INT")]
    public int MpNfeCfop { get; set; }

    [Column("mp_nfeIndValProdTotNfe", TypeName = "tinyint")]
    public byte MpNfeIndValProdTotNfe { get; set; }

    [Column("mp_nfeProdOrigem", TypeName = "tinyint")]
    public byte MpNfeProdOrigem { get; set; }

    [Column("mp_nfeCst", TypeName = "smallint")]
    public short MpNfeCst { get; set; }

    [Column("mp_nfeModBc", TypeName = "tinyint")]
    public byte MpNfeModBc { get; set; }

    [Column("mp_nfeVlrBcIcms", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcms { get; set; }

    [Column("mp_nfeVlrBcIcms_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsImpXml { get; set; }

    [Column("mp_nfeAliqIcms", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfeAliqIcms { get; set; }

    [Column("mp_nfeVlrTotIcms", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrTotIcms { get; set; }

    [Column("mp_nfeVlrTotIcms_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrTotIcmsImpXml { get; set; }

    [Column("mp_nfeVlrBcFcp", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcFcp { get; set; }

    [Column("mp_nfeVlrBcFcp_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcFcpImpXml { get; set; }

    [Column("mp_nfePercFcp", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercFcp { get; set; }

    [Column("mp_nfeVlrFcp", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrFcp { get; set; }

    [Column("mp_nfeModBcSt", TypeName = "INT")]
    public int MpNfeModBcSt { get; set; }

    [Column("mp_nfePercMvaSt", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercMvaSt { get; set; }

    [Column("mp_nfePercRedBcIcms", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercRedBcIcms { get; set; }

    [Column("mp_nfePercRedBcIcmsSt", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercRedBcIcmsSt { get; set; }

    [Column("mp_nfeVlrBcIcmsSt", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsSt { get; set; }

    [Column("mp_nfeVlrBcIcmsSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsStImpXml { get; set; }

    [Column("mp_nfeAliqIcmsSt", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfeAliqIcmsSt { get; set; }

    [Column("mp_nfeVlrIcmsSt", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsSt { get; set; }

    [Column("mp_nfeVlrIcmsSt_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsStImpXml { get; set; }

    [Column("mp_nfeVlrBcFcpRetSt", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcFcpRetSt { get; set; }

    [Column("mp_nfePercFcpRetSt", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercFcpRetSt { get; set; }

    [Column("mp_nfeVlrFcpRetSt", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrFcpRetSt { get; set; }

    [Column("mp_nfeVlrIcmsDeson", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsDeson { get; set; }

    [Column("mp_nfeVlrIcmsDeson_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsDesonImpXml { get; set; }

    [Column("mp_nfeMotDesonIcms", TypeName = "tinyint")]
    public byte MpNfeMotDesonIcms { get; set; }

    [Column("mp_nfeVlrIcmsOp", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsOp { get; set; }

    [Column("mp_nfeVlrIcmsOp_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsOpImpXml { get; set; }

    [Column("mp_nfePercDif", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercDif { get; set; }

    [Column("mp_nfeVlrIcmsDif", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsDif { get; set; }

    [Column("mp_nfeVlrIcmsDif_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsDifImpXml { get; set; }

    [Column("mp_nfeVlrBcIcmsStRet", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsStRet { get; set; }

    [Column("mp_nfePercAliqSuportada", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercAliqSuportada { get; set; }

    [Column("mp_nfeVlrIcmsPropSubst", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsPropSubst { get; set; }

    [Column("mp_nfeVlrIcmsStRet", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsStRet { get; set; }

    [Column("mp_nfeBcFcpRetAnt", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeBcFcpRetAnt { get; set; }

    [Column("mp_nfePercFcpRetAntSt", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercFcpRetAntSt { get; set; }

    [Column("mp_nfePercRedBcEfet", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercRedBcEfet { get; set; }

    [Column("mp_nfeVlrBcEfet", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcEfet { get; set; }

    [Column("mp_nfePercAliqIcmsEfet", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercAliqIcmsEfet { get; set; }

    [Column("mp_nfeVlrIcmsEfet", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsEfet { get; set; }

    [Column("mp_nfeCsosn", TypeName = "smallint")]
    public short MpNfeCsosn { get; set; }

    [Column("mp_nfePercAliqCredSn", TypeName = "NUMERIC(6, 3)")]
    public int? MpNfePercAliqCredSn { get; set; }

    [Column("mp_nfeVlrCredIcmsSn", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrCredIcmsSn { get; set; }

    [Column("mp_nfeIpiCSelo", TypeName = "varchar(60)")]
    public string MpNfeIpiCselo { get; set; }

    [Column("mp_nfeIpiQSelo", TypeName = "INT")]
    public int MpNfeIpiQselo { get; set; }

    [Column("mp_nfeIpicEnq", TypeName = "varchar(3)")]
    public string MpNfeIpicEnq { get; set; }

    [Column("mp_nfeIpiTribCst", TypeName = "tinyint")]
    public byte MpNfeIpiTribCst { get; set; }

    [Column("mp_nfeIpiTribXml1VlrBC", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml1VlrBc { get; set; }

    [Column("mp_nfeIpiTribXml1VlrBC_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml1VlrBcImpXml { get; set; }

    [Column("mp_nfeIpiTribXml1PercIPI", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml1PercIpi { get; set; }

    [Column("mp_nfeIpiTribXml2qUnid", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml2qUnid { get; set; }

    [Column("mp_nfeIpiTribXml2VlrUnit", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml2VlrUnit { get; set; }

    [Column("mp_nfeIpiTribXml2VlrIpi", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml2VlrIpi { get; set; }

    [Column("mp_nfeIpiTribXml2VlrIpi_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeIpiTribXml2VlrIpiImpXml { get; set; }

    [Column("mp_nfeIpiIpintCst", TypeName = "tinyint")]
    public byte MpNfeIpiIpintCst { get; set; }

    [Column("mp_nfeImpImpVlrBc", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeImpImpVlrBc { get; set; }

    [Column("mp_nfeImpImpVlrDespAdu", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeImpImpVlrDespAdu { get; set; }

    [Column("mp_nfeImpImpVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeImpImpVlr { get; set; }

    [Column("mp_nfeImpImpVlrIof", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeImpImpVlrIof { get; set; }

    [Column("mp_nfeVlrBcIcmsUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsUfDest { get; set; }

    [Column("mp_nfeVlrBcIcmsUfDest_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcIcmsUfDestImpXml { get; set; }

    [Column("mp_nfeVlrBcFcpUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcFcpUfDest { get; set; }

    [Column("mp_nfeVlrBcFcpUfDest_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrBcFcpUfDestImpXml { get; set; }

    [Column("mp_nfePercFcpUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePercFcpUfDest { get; set; }

    [Column("mp_nfeAliqIcmsUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeAliqIcmsUfDest { get; set; }

    [Column("mp_nfeAliqIcmsInterUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeAliqIcmsInterUfDest { get; set; }

    [Column("mp_nfePercIcmsPartUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePercIcmsPartUfDest { get; set; }

    [Column("mp_nfeVlrFcpUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrFcpUfDest { get; set; }

    [Column("mp_nfeVlrIcmsUfDest", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsUfDest { get; set; }

    [Column("mp_nfeVlrIcmsUfDest_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsUfDestImpXml { get; set; }

    [Column("mp_nfeVlrIcmsUfRemet", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsUfRemet { get; set; }

    [Column("mp_nfeVlrIcmsUfRemet_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeVlrIcmsUfRemetImpXml { get; set; }

    [Column("mp_nfePisCofinsCst", TypeName = "tinyint")]
    public byte MpNfePisCofinsCst { get; set; }

    [Column("mp_nfePisAliqVlrBc", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqVlrBc { get; set; }

    [Column("mp_nfePisAliqVlrBc_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqVlrBcImpXml { get; set; }

    [Column("mp_nfePisAliq", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliq { get; set; }

    [Column("mp_nfePisAliq_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqImpXml { get; set; }

    [Column("mp_nfePisAliqVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqVlr { get; set; }

    [Column("mp_nfePisAliqVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqVlrImpXml { get; set; }

    [Column("mp_nfePisQtdeBcProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeBcProd { get; set; }

    [Column("mp_nfePisQtdeAliqProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeAliqProd { get; set; }

    [Column("mp_nfePisQtdeVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeVlr { get; set; }

    [Column("mp_nfePisQtdeVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeVlrImpXml { get; set; }

    [Column("mp_nfePisOutrBcVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrBcVlr { get; set; }

    [Column("mp_nfePisOutrBcVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrBcVlrImpXml { get; set; }

    [Column("mp_nfePisOutrAliq", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrAliq { get; set; }

    [Column("mp_nfePisOutrAliq_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrAliqImpXml { get; set; }

    [Column("mp_nfePisOutrVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrVlr { get; set; }

    [Column("mp_nfePisOutrVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisOutrVlrImpXml { get; set; }

    [Column("mp_nfePisVlrBcST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisVlrBcSt { get; set; }

    [Column("mp_nfePisVlrBcST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisVlrBcStImpXml { get; set; }

    [Column("mp_nfePisAliqST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqSt { get; set; }

    [Column("mp_nfePisQtdeBcProdST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeBcProdSt { get; set; }

    [Column("mp_nfePisQtdeBcProdST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisQtdeBcProdStImpXml { get; set; }

    [Column("mp_nfePisAliqProdST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisAliqProdSt { get; set; }

    [Column("mp_nfePisVlrST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisVlrSt { get; set; }

    [Column("mp_nfePisVlrST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfePisVlrStImpXml { get; set; }

    [Column("mp_nfeCofinsAliqVlrBc", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqVlrBc { get; set; }

    [Column("mp_nfeCofinsAliqVlrBc_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqVlrBcImpXml { get; set; }

    [Column("mp_nfeCofinsAliq", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliq { get; set; }

    [Column("mp_nfeCofinsAliq_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqImpXml { get; set; }

    [Column("mp_nfeCofinsAliqVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqVlr { get; set; }

    [Column("mp_nfeCofinsAliqVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqVlrImpXml { get; set; }

    [Column("mp_nfeCofinsQtdeBcProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeBcProd { get; set; }

    [Column("mp_nfeCofinsQtdeBcProd_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeBcProdImpXml { get; set; }

    [Column("mp_nfeCofinsQtdeAliqProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeAliqProd { get; set; }

    [Column("mp_nfeCofinsQtdeVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeVlr { get; set; }

    [Column("mp_nfeCofinsQtdeVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeVlrImpXml { get; set; }

    [Column("mp_nfeCofinsOutrBcVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrBcVlr { get; set; }

    [Column("mp_nfeCofinsOutrBcVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrBcVlrImpXml { get; set; }

    [Column("mp_nfeCofinsOutrAliq", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrAliq { get; set; }

    [Column("mp_nfeCofinsOutrAliq_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrAliqImpXml { get; set; }

    [Column("mp_nfeCofinsOutrBcProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrBcProd { get; set; }

    [Column("mp_nfeCofinsOutrBcProd_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrBcProdImpXml { get; set; }

    [Column("mp_nfeCofinsOutrAliqProd", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrAliqProd { get; set; }

    [Column("mp_nfeCofinsOutrVlr", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrVlr { get; set; }

    [Column("mp_nfeCofinsOutrVlr_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsOutrVlrImpXml { get; set; }

    [Column("mp_nfeCofinsVlrBcST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsVlrBcSt { get; set; }

    [Column("mp_nfeCofinsVlrBcST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsVlrBcStImpXml { get; set; }

    [Column("mp_nfeCofinsAliqST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqSt { get; set; }

    [Column("mp_nfeCofinsQtdeBcProdST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeBcProdSt { get; set; }

    [Column("mp_nfeCofinsQtdeBcProdST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsQtdeBcProdStImpXml { get; set; }

    [Column("mp_nfeCofinsAliqProdST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsAliqProdSt { get; set; }

    [Column("mp_nfeCofinsVlrST", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsVlrSt { get; set; }

    [Column("mp_nfeCofinsVlrST_ImpXml", TypeName = "NUMERIC(13, 2)")]
    public int? MpNfeCofinsVlrStImpXml { get; set; }

    [Column("mp_qtdAud", TypeName = "NUMERIC(13, 2)")]
    public int? MpQtdAud { get; set; }

    [Column("fk_tb_movimentacao")]
    public int? FkTbMovimentacao { get; set; }

    [Column("fk_tb_ncm")]
    public int? FkTbNcm { get; set; }

    [Column("fk_tb_atorAtend")]
    public int? FkTbAtorAtend { get; set; }

    [Column("fk_tb_produto")]
    public int? FkTbProduto { get; set; }

    [ForeignKey("FkTbAtorAtend")]
    [InverseProperty("TbMovimentacaoProduto")]
    public virtual TbAtor FkTbAtorAtendNavigation { get; set; }

    [ForeignKey("FkTbMovimentacao")]
    [InverseProperty("TbMovimentacaoProduto")]
    public virtual TbMovimentacao FkTbMovimentacaoNavigation { get; set; }

    [ForeignKey("FkTbProduto")]
    [InverseProperty("TbMovimentacaoProduto")]
    public virtual TbProduto FkTbProdutoNavigation { get; set; }
}