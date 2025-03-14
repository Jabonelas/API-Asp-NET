﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_contGru")]
public partial class TbContGru
{
    [Key]
    [Column("id_contGru")]
    public int IdContGru { get; set; }

    [Column("cg_contSec")]
    public int? CgContSec { get; set; }

    [Column("cg_dtCri", TypeName = "DATETIME")]
    public DateTime CgDtCri { get; set; }

    [Column("cg_dtAlt", TypeName = "DATETIME")]
    public DateTime CgDtAlt { get; set; }

    [Column("cg_dtAcs", TypeName = "DATETIME")]
    public DateTime? CgDtAcs { get; set; }

    [Column("cg_desc", TypeName = "varchar(60)")]
    public string CgDesc { get; set; }

    [Column("cg_canc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CgCanc { get; set; }

    [Column("cg_conc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CgConc { get; set; }

    [InverseProperty("FkTbContGruNavigation")]
    public virtual ICollection<TbContExtGru> TbContExtGru { get; set; } = new List<TbContExtGru>();

    [InverseProperty("FkTbContGruNavigation")]
    public virtual ICollection<TbContSubGru> TbContSubGru { get; set; } = new List<TbContSubGru>();
}