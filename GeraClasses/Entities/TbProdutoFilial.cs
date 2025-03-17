using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbProdutoFilial
{
    public int IdProdutoFilial { get; set; }

    public long PfCodRef { get; set; }

    public string? PfDesc { get; set; }

    public string? PfDescCurta { get; set; }

    public byte PfProTipo { get; set; }

    public byte PfUnMedCom { get; set; }

    public DateTime PfDtCri { get; set; }

    public DateTime PfDtAlt { get; set; }

    public DateTime? PfDtAcs { get; set; }

    public int? PfAtorFil { get; set; }

    public int? PfVlrUnCom { get; set; }

    public int? PfCstUnCom { get; set; }

    public int? PfEstMin { get; set; }

    public int? PfEstMax { get; set; }

    public int? PfEst { get; set; }

    public int? PfDesat { get; set; }

    public int? PfCanc { get; set; }

    public int? FkTbProduto { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual TbProduto? FkTbProdutoNavigation { get; set; }

    public virtual ICollection<TbRelacaoProdutoCadastroXml> TbRelacaoProdutoCadastroXmls { get; set; } = new List<TbRelacaoProdutoCadastroXml>();
}
