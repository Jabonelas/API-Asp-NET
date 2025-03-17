using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbSecaoProduto
{
    public int IdSecaoProduto { get; set; }

    public DateTime SpDtCri { get; set; }

    public DateTime SpDtAlt { get; set; }

    public DateTime? SpDtAcs { get; set; }

    public int? SpDesat { get; set; }

    public string? SpDesc { get; set; }

    public int? FkTbRede { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }

    public virtual ICollection<TbCategoriaProduto> TbCategoriaProdutos { get; set; } = new List<TbCategoriaProduto>();
}
