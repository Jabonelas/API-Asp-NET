﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APP_Sytem.API.Models;

[Table("tb_categoria_produto")]
[Index("FkTbSecaoProduto", Name = "ifk_tb_secao_produto_tb_categoria_produto")]
public partial class TbCategoriaProduto
{
    [Key]
    [Column("id_categoria_produto")]
    public int IdCategoriaProduto { get; set; }

    [Column("cp_dtCri", TypeName = "DATETIME")]
    public DateTime CpDtCri { get; set; }

    [Column("cp_dtAlt", TypeName = "DATETIME")]
    public DateTime CpDtAlt { get; set; }

    [Column("cp_dtAcs", TypeName = "DATETIME")]
    public DateTime? CpDtAcs { get; set; }

    [Column("cp_desat", TypeName = "NUMERIC(1, 0)")]
    public int? CpDesat { get; set; }

    [Column("cp_desc", TypeName = "varchar(60)")]
    public string CpDesc { get; set; }

    [Column("fk_tb_secao_produto")]
    public int? FkTbSecaoProduto { get; set; }

    [ForeignKey("FkTbSecaoProduto")]
    [InverseProperty("TbCategoriaProduto")]
    public virtual TbSecaoProduto FkTbSecaoProdutoNavigation { get; set; }

    [InverseProperty("FkTbCategoriaProdutoNavigation")]
    public virtual ICollection<TbProduto> TbProduto { get; set; } = new List<TbProduto>();

    [InverseProperty("FkTbCategoriaProdutoNavigation")]
    public virtual ICollection<TbSubcategoriaProduto> TbSubcategoriaProduto { get; set; } = new List<TbSubcategoriaProduto>();
}