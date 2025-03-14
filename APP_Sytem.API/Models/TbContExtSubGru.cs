﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_contExtSubGru")]
[Index("FkTbContSubGru", Name = "ifk_tb_contSubGru_tb_contExtSubGru")]
public partial class TbContExtSubGru
{
    [Key]
    [Column("id_contExtSubGru")]
    public int IdContExtSubGru { get; set; }

    [Column("cesg_deb", TypeName = "NUMERIC(13, 2)")]
    public decimal? CesgDeb { get; set; }

    [Column("cesg_cred", TypeName = "NUMERIC(13, 2)")]
    public decimal? CesgCred { get; set; }

    [Column("cesg_dtCri", TypeName = "DATETIME")]
    public DateTime CesgDtCri { get; set; }

    [Column("cesg_dtAlt", TypeName = "DATETIME")]
    public DateTime CesgDtAlt { get; set; }

    [Column("cesg_dtAcs", TypeName = "DATETIME")]
    public DateTime? CesgDtAcs { get; set; }

    [Column("cesg_canc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CesgCanc { get; set; }

    [Column("cesg_conc", TypeName = "NUMERIC(1, 0)")]
    public decimal? CesgConc { get; set; }

    [Column("fk_tb_contSubGru")]
    public int? FkTbContSubGru { get; set; }

    [ForeignKey("FkTbContSubGru")]
    [InverseProperty("TbContExtSubGru")]
    public virtual TbContSubGru FkTbContSubGruNavigation { get; set; }
}