using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbRede
{
    public int IdRede { get; set; }

    public DateTime ReDtCri { get; set; }

    public DateTime ReDtAlt { get; set; }

    public DateTime? ReDtAcs { get; set; }

    public string? ReDesc { get; set; }

    public int? ReDesat { get; set; }

    public int? ReDesatSinc { get; set; }

    public byte RePersTim { get; set; }

    public virtual ICollection<TbClasCont1> TbClasCont1s { get; set; } = new List<TbClasCont1>();

    public virtual ICollection<TbFormaPagamento> TbFormaPagamentos { get; set; } = new List<TbFormaPagamento>();

    public virtual ICollection<TbMarcaProduto> TbMarcaProdutos { get; set; } = new List<TbMarcaProduto>();

    public virtual ICollection<TbMatriz> TbMatrizs { get; set; } = new List<TbMatriz>();

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();

    public virtual ICollection<TbSecaoProduto> TbSecaoProdutos { get; set; } = new List<TbSecaoProduto>();
}
