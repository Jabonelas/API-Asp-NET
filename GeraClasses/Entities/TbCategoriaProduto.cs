using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbCategoriaProduto
{
    public int IdCategoriaProduto { get; set; }

    public DateTime CpDtCri { get; set; }

    public DateTime CpDtAlt { get; set; }

    public DateTime? CpDtAcs { get; set; }

    public int? CpDesat { get; set; }

    public string? CpDesc { get; set; }

    public int? FkTbSecaoProduto { get; set; }

    public virtual TbSecaoProduto? FkTbSecaoProdutoNavigation { get; set; }

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();

    public virtual ICollection<TbSubcategoriaProduto> TbSubcategoriaProdutos { get; set; } = new List<TbSubcategoriaProduto>();
}
