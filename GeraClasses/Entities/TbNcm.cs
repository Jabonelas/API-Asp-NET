using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbNcm
{
    public int IdNcm { get; set; }

    public DateTime NcDtCri { get; set; }

    public DateTime NcDtAlt { get; set; }

    public DateTime? NcDtAcs { get; set; }

    public decimal? NcDesat { get; set; }

    public string? NcAnoDoAto { get; set; }

    public int NcNumAto { get; set; }

    public int? NcParentOid { get; set; }

    public string? NcRootNcm { get; set; }

    public string? NcNcmBase { get; set; }

    public string? NcNcmFull { get; set; }

    public string? NcDesc { get; set; }

    public DateTime NcDtIni { get; set; }

    public DateTime NcDtFim { get; set; }

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();

    public virtual ICollection<TbSubcategoriaProduto> TbSubcategoriaProdutos { get; set; } = new List<TbSubcategoriaProduto>();
}
