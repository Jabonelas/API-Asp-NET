﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_resposta_NFe")]
[Index("FkTbAtor", Name = "ifk_tb_ator_tb_resposta_NFe")]
public partial class TbRespostaNfe
{
    [Key]
    [Column("id_resposta_NFe")]
    public int IdRespostaNfe { get; set; }

    [Column("rnfe_cnpj", TypeName = "varchar(18)")]
    public string RnfeCnpj { get; set; }

    [Column("rnfe_cpf", TypeName = "varchar(14)")]
    public string RnfeCpf { get; set; }

    [Column("rnfe_inscEst", TypeName = "varchar(20)")]
    public string RnfeInscEst { get; set; }

    [Column("rnfe_nfeChave", TypeName = "varchar(50)")]
    public string RnfeNfeChave { get; set; }

    [Column("rnfe_nfeDtAut", TypeName = "DATETIME")]
    public DateTime RnfeNfeDtAut { get; set; }

    [Column("rnfe_nfeDtEmis", TypeName = "DATETIME")]
    public DateTime RnfeNfeDtEmis { get; set; }

    [Column("rnfe_nfeNumProtAut", TypeName = "varchar(15)")]
    public string RnfeNfeNumProtAut { get; set; }

    [Column("rnfe_nfeSit", TypeName = "tinyint")]
    public byte RnfeNfeSit { get; set; }

    [Column("rnfe_nfeTipo", TypeName = "tinyint")]
    public byte RnfeNfeTipo { get; set; }

    [Column("rnfe_nfeVersao", TypeName = "NUMERIC(6, 3)")]
    public decimal? RnfeNfeVersao { get; set; }

    [Column("rnfe_nfeVlrTotNF", TypeName = "NUMERIC(13, 2)")]
    public decimal? RnfeNfeVlrTotNf { get; set; }

    [Column("rnfe_razSoc", TypeName = "varchar(60)")]
    public string RnfeRazSoc { get; set; }

    [Column("rnfe_dtCri", TypeName = "DATETIME")]
    public DateTime RnfeDtCri { get; set; }

    [Column("rnfe_dtAlt", TypeName = "DATETIME")]
    public DateTime RnfeDtAlt { get; set; }

    [Column("rnfe_dtAcs", TypeName = "DATETIME")]
    public DateTime? RnfeDtAcs { get; set; }

    [Column("rnfe_nsu", TypeName = "bigint")]
    public long RnfeNsu { get; set; }

    [Column("rnfe_ultNsu", TypeName = "bigint")]
    public long RnfeUltNsu { get; set; }

    [Column("rnfe_maxNsu", TypeName = "bigint")]
    public long RnfeMaxNsu { get; set; }

    [Column("fk_tb_ator")]
    public int? FkTbAtor { get; set; }

    [ForeignKey("FkTbAtor")]
    [InverseProperty("TbRespostaNfe")]
    public virtual TbAtor FkTbAtorNavigation { get; set; }
}