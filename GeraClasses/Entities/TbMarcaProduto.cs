using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMarcaProduto
{
    public int IdMarcaProduto { get; set; }

    public DateTime MpDtCri { get; set; }

    public DateTime MpDtAlt { get; set; }

    public DateTime? MpDtAcs { get; set; }

    public int? MpDesat { get; set; }

    public string? MpDesc { get; set; }

    public int? FkTbRede { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }

    public virtual ICollection<TbEst> TbEsts { get; set; } = new List<TbEst>();

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();
}
