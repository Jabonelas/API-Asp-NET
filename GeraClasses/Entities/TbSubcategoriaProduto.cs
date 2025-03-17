using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbSubcategoriaProduto
{
    public int IdSubcategoriaProduto { get; set; }

    public byte ScpNfePisCofinsReg { get; set; }

    public DateTime ScpDtCri { get; set; }

    public DateTime ScpDtAlt { get; set; }

    public DateTime? ScpDtAcs { get; set; }

    public string? ScpDesc { get; set; }

    public int? ScpDesat { get; set; }

    public string? ScpNcmNum { get; set; }

    public short ScpNfeCsosn { get; set; }

    public int? ScpDescMax { get; set; }

    public int? FkTbCategoriaProduto { get; set; }

    public int? FkTbNcm { get; set; }

    public virtual TbCategoriaProduto? FkTbCategoriaProdutoNavigation { get; set; }

    public virtual TbNcm? FkTbNcmNavigation { get; set; }

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();
}
