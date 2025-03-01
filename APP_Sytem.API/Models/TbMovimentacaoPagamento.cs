﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_movimentacao_pagamento")]
[Index("FkTbMovimentacao", Name = "ifk_tb_movimentacao_tb_movimentacao_pagamento")]
[Index("FkTbSubFormaPagamento", Name = "ifk_tb_sub_forma_pagamento_tb_movimentacao_pagamento")]
public partial class TbMovimentacaoPagamento
{
    [Key]
    [Column("id_movimentacao_pagamento")]
    public int IdMovimentacaoPagamento { get; set; }

    [Column("mpg_dtCri", TypeName = "DATETIME")]
    public DateTime MpgDtCri { get; set; }

    [Column("mpg_dtAlt", TypeName = "DATETIME")]
    public DateTime MpgDtAlt { get; set; }

    [Column("mpg_dtAcs", TypeName = "DATETIME")]
    public DateTime? MpgDtAcs { get; set; }

    [Column("mpg_canc", TypeName = "NUMERIC(1, 0)")]
    public int? MpgCanc { get; set; }

    [Column("mpg_numPag", TypeName = "smallint")]
    public short MpgNumPag { get; set; }

    [Column("mpg_parcs", TypeName = "NUMERIC(13, 2)")]
    public int? MpgParcs { get; set; }

    [Column("mpg_nfeVlrPag", TypeName = "NUMERIC(13, 2)")]
    public int? MpgNfeVlrPag { get; set; }

    [Column("mpg_nfeTipoIntegr", TypeName = "tinyint")]
    public byte MpgNfeTipoIntegr { get; set; }

    [Column("mpg_nfeTipoBand", TypeName = "tinyint")]
    public byte MpgNfeTipoBand { get; set; }

    [Column("mpg_nfeNumAut", TypeName = "varchar(20)")]
    public string MpgNfeNumAut { get; set; }

    [Column("mpg_nfeVlrTroco", TypeName = "NUMERIC(13, 2)")]
    public double? MpgNfeVlrTroco { get; set; }

    [Column("mpg_nfeVlrMov", TypeName = "NUMERIC(13, 2)")]
    public double? MpgNfeVlrMov { get; set; }

    [Column("fk_tb_movimentacao")]
    public int? FkTbMovimentacao { get; set; }

    [Column("fk_tb_sub_forma_pagamento")]
    public int? FkTbSubFormaPagamento { get; set; }

    [ForeignKey("FkTbMovimentacao")]
    [InverseProperty("TbMovimentacaoPagamento")]
    public virtual TbMovimentacao FkTbMovimentacaoNavigation { get; set; }

    [ForeignKey("FkTbSubFormaPagamento")]
    [InverseProperty("TbMovimentacaoPagamento")]
    public virtual TbSubFormaPagamento FkTbSubFormaPagamentoNavigation { get; set; }

    [InverseProperty("FkTbMovimentacaoPagamentoNavigation")]
    public virtual ICollection<TbMovimentacaoPagamentoParcela> TbMovimentacaoPagamentoParcela { get; set; } = new List<TbMovimentacaoPagamentoParcela>();
}