using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbCodigoProduto
{
    public int IdCodigoProduto { get; set; }

    public decimal? CpDesat { get; set; }

    public DateTime CpDtCri { get; set; }

    public DateTime CpDtAlt { get; set; }

    public DateTime? CpDtAcs { get; set; }

    public string? CpBarras { get; set; }

    public int? FkTbProduto { get; set; }

    public virtual TbProduto? FkTbProdutoNavigation { get; set; }
}
