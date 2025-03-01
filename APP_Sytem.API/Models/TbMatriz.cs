﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_matriz")]
[Index("FkTbRede", Name = "ifk_tb_rede_tb_matriz")]
public partial class TbMatriz
{
    [Key]
    [Column("id_matriz")]
    public int IdMatriz { get; set; }

    [Column("mt_cnpj", TypeName = "varchar(18)")]
    public string MtCnpj { get; set; }

    [Column("mt_nomeFant", TypeName = "varchar(60)")]
    public string MtNomeFant { get; set; }

    [Column("mt_razSoc", TypeName = "varchar(60)")]
    public string MtRazSoc { get; set; }

    [Column("mt_dtCri", TypeName = "DATETIME")]
    public DateTime MtDtCri { get; set; }

    [Column("mt_dtAlt", TypeName = "DATETIME")]
    public DateTime MtDtAlt { get; set; }

    [Column("mt_dtAcs", TypeName = "DATETIME")]
    public DateTime? MtDtAcs { get; set; }

    [Column("mt_hrAbertLj", TypeName = "smallint")]
    public short MtHrAbertLj { get; set; }

    [Column("mt_hrFchLj", TypeName = "smallint")]
    public short MtHrFchLj { get; set; }

    [Column("mt_efetuaTestesEletro", TypeName = "NUMERIC(1, 0)")]
    public int? MtEfetuaTestesEletro { get; set; }

    [Column("mt_desat", TypeName = "NUMERIC(1, 0)")]
    public int? MtDesat { get; set; }

    [Column("mt_persTim", TypeName = "tinyint")]
    public byte MtPersTim { get; set; }

    [Column("fk_tb_rede")]
    public int? FkTbRede { get; set; }

    [ForeignKey("FkTbRede")]
    [InverseProperty("TbMatriz")]
    public virtual TbRede FkTbRedeNavigation { get; set; }

    [InverseProperty("FkTbMatrizNavigation")]
    public virtual ICollection<TbAtor> TbAtor { get; set; } = new List<TbAtor>();
}