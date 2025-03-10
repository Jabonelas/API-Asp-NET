﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_cont")]
[Index("FkTbAtor", Name = "ifk_tb_ator_tb_cont")]
[Index("FkTbContSubGru", Name = "ifk_tb_contSubGru_tb_cont")]
public partial class TbCont
{
    [Key]
    [Column("id_cont")]
    public int IdCont { get; set; }

    [Column("ct_desc", TypeName = "varchar(60)")]
    public string CtDesc { get; set; }

    [Column("ct_saldo", TypeName = "NUMERIC(13, 2)")]
    public decimal? CtSaldo { get; set; }

    [Column("ct_dtCri", TypeName = "DATETIME")]
    public DateTime CtDtCri { get; set; }

    [Column("ct_dAlt", TypeName = "DATETIME")]
    public DateTime CtDAlt { get; set; }

    [Column("ct_dtAcs", TypeName = "DATETIME")]
    public DateTime? CtDtAcs { get; set; }

    [Column("ct_canc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CtCanc { get; set; }

    [Column("ct_conc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CtConc { get; set; }

    [Column("fk_tb_ator")]
    public int? FkTbAtor { get; set; }

    [Column("fk_tb_contSubGru")]
    public int? FkTbContSubGru { get; set; }

    [ForeignKey("FkTbAtor")]
    [InverseProperty("TbCont")]
    public virtual TbAtor FkTbAtorNavigation { get; set; }

    [ForeignKey("FkTbContSubGru")]
    [InverseProperty("TbCont")]
    public virtual TbContSubGru FkTbContSubGruNavigation { get; set; }

    [InverseProperty("FkTbContNavigation")]
    public virtual ICollection<TbContExt> TbContExt { get; set; } = new List<TbContExt>();
}