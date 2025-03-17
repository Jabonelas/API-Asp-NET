using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbRelacaoProdutoCadastroXml
{
    public int IdRelacaoProdutoCadastroXml { get; set; }

    public long RpcCodRef { get; set; }

    public string? RpcDesc { get; set; }

    public string? RpcCnpjFornecedor { get; set; }

    public DateTime RpcDtCri { get; set; }

    public DateTime RpcDtAlt { get; set; }

    public DateTime? RpcDtAcs { get; set; }

    public int? FkTbProduto { get; set; }

    public int? FkTbProdutoFilial { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual TbProdutoFilial? FkTbProdutoFilialNavigation { get; set; }

    public virtual TbProduto? FkTbProdutoNavigation { get; set; }

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();
}
