using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbProduto
{
    public int IdProduto { get; set; }

    public DateTime PdDtCri { get; set; }

    public DateTime PdDtAlt { get; set; }

    public int? PdDesat { get; set; }

    public byte PdGenero { get; set; }

    public byte PdUnMedCom { get; set; }

    public long PdCodRef { get; set; }

    public string? PdCodRefStr { get; set; }

    public string? PdBarras { get; set; }

    public string? PdImpRef { get; set; }

    public byte PdProTipo { get; set; }

    public byte PdEspecie { get; set; }

    public int? PdEstTot { get; set; }

    public int? PdInvend { get; set; }

    public string? PdDescCurta { get; set; }

    public string? PdDesc { get; set; }

    public byte PdFxEta { get; set; }

    public int? PdVlrUnComBase { get; set; }

    public int? PdCstUnComBase { get; set; }

    public int? PdEstMinBase { get; set; }

    public int? PdEstMaxBase { get; set; }

    public byte PdNfeProdOrigem { get; set; }

    public short PdNfeCsosn { get; set; }

    public int? PdVend { get; set; }

    public string? PdTmpStr { get; set; }

    public int? PdAtivo { get; set; }

    public int? FkTbEst { get; set; }

    public int? FkTbRede { get; set; }

    public int? FkTbNcm { get; set; }

    public int? FkTbAtor { get; set; }

    public int? FkTbRelacaoProdutoCadastroXml { get; set; }

    public int? FkTbMarcaProduto { get; set; }

    public int? FkTbSubcategoriaProduto { get; set; }

    public int? FkTbCategoriaProduto { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual TbCategoriaProduto? FkTbCategoriaProdutoNavigation { get; set; }

    public virtual TbEst? FkTbEstNavigation { get; set; }

    public virtual TbMarcaProduto? FkTbMarcaProdutoNavigation { get; set; }

    public virtual TbNcm? FkTbNcmNavigation { get; set; }

    public virtual TbRede? FkTbRedeNavigation { get; set; }

    public virtual TbRelacaoProdutoCadastroXml? FkTbRelacaoProdutoCadastroXmlNavigation { get; set; }

    public virtual TbSubcategoriaProduto? FkTbSubcategoriaProdutoNavigation { get; set; }

    public virtual ICollection<TbCodigoProduto> TbCodigoProdutos { get; set; } = new List<TbCodigoProduto>();

    public virtual ICollection<TbMovimentacaoProduto> TbMovimentacaoProdutos { get; set; } = new List<TbMovimentacaoProduto>();

    public virtual ICollection<TbProdutoFilial> TbProdutoFilials { get; set; } = new List<TbProdutoFilial>();

    public virtual ICollection<TbRelacaoProdutoCadastroXml> TbRelacaoProdutoCadastroXmls { get; set; } = new List<TbRelacaoProdutoCadastroXml>();
}
