﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_contSubGru")]
[Index("FkTbContGru", Name = "ifk_tb_contGru_tb_contSubGru")]
public partial class TbContSubGru
{
    [Key]
    [Column("id_contSubGru")]
    public int IdContSubGru { get; set; }

    [Column("csg_dtCri", TypeName = "DATETIME")]
    public DateTime CsgDtCri { get; set; }

    [Column("csg_dtAlt", TypeName = "DATETIME")]
    public DateTime CsgDtAlt { get; set; }

    [Column("csg_dtAcs", TypeName = "DATETIME")]
    public DateTime? CsgDtAcs { get; set; }

    [Column("csg_desc", TypeName = "varchar(60)")]
    public string CsgDesc { get; set; }

    [Column("csg_canc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CsgCanc { get; set; }

    [Column("csg_conc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CsgConc { get; set; }

    [Column("fk_tb_contGru")]
    public int? FkTbContGru { get; set; }

    [ForeignKey("FkTbContGru")]
    [InverseProperty("TbContSubGru")]
    public virtual TbContGru FkTbContGruNavigation { get; set; }

    [InverseProperty("FkTbContSubGruNavigation")]
    public virtual ICollection<TbCont> TbCont { get; set; } = new List<TbCont>();

    [InverseProperty("FkTbContSubGruNavigation")]
    public virtual ICollection<TbContExtSubGru> TbContExtSubGru { get; set; } = new List<TbContExtSubGru>();
}