using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbAtor
{
    public int IdAtor { get; set; }

    public string? AtInscEstSubst { get; set; }

    public byte AtPersTim { get; set; }

    public byte AtDirRede { get; set; }

    public byte AtDirMov { get; set; }

    public DateTime AtDtCri { get; set; }

    public DateTime AtDtAlt { get; set; }

    public DateTime? AtDtAcs { get; set; }

    public int? AtDesat { get; set; }

    public byte AtGenero { get; set; }

    public byte AtNfeIndInscEst { get; set; }

    public byte AtNfeCodRegTrib { get; set; }

    public byte AtAtorTipo { get; set; }

    public string? AtCnpj { get; set; }

    public string? AtCpf { get; set; }

    public string? AtRgRne { get; set; }

    public string? AtIdMl { get; set; }

    public string? AtRazSoc { get; set; }

    public string? AtNomeFant { get; set; }

    public string? AtEndLogr { get; set; }

    public string? AtEndNum { get; set; }

    public string? AtEndCompl { get; set; }

    public string? AtEndBairro { get; set; }

    public string? AtEndPontoRef { get; set; }

    public string? AtEndCep { get; set; }

    public Guid? AtEndMun { get; set; }

    public string? AtTelFixo { get; set; }

    public string? AtTelFixoRamal { get; set; }

    public string? AtTelCel { get; set; }

    public string? AtRespon { get; set; }

    public string? AtInscEst { get; set; }

    public string? AtInscMun { get; set; }

    public string? AtInscSuframa { get; set; }

    public string? AtEmail { get; set; }

    public string? AtWebsite { get; set; }

    public string? AtDtNasc { get; set; }

    public string? AtEmailCont { get; set; }

    public string? AtObsCom { get; set; }

    public string? AtObsFisc { get; set; }

    public string? AtCnae { get; set; }

    public int? AtProp { get; set; }

    public int? AtNfeCredSn { get; set; }

    public string? AtNfeCscTokenProd { get; set; }

    public byte AtNfeCscIdProd { get; set; }

    public string? AtNfeCscTokenHom { get; set; }

    public byte AtNfeCscIdHom { get; set; }

    public int? AtRevenda { get; set; }

    public byte AtNfeEnqSn { get; set; }

    public byte AtNfeRecBrutaEnqSn { get; set; }

    public int? AtReceitaBrutaTotal { get; set; }

    public int? AtReceitaBrutaTotalImpXml { get; set; }

    public byte AtNfeTipoAmb { get; set; }

    public int? AtPercComisAtend { get; set; }

    public int AtMetaMensal { get; set; }

    public string? AtNomeUsuario { get; set; }

    public string? AtSenhaUsuarioHashCode { get; set; }

    public int? AtManutPdv { get; set; }

    public int? AtAtorH { get; set; }

    public int? AtEstH { get; set; }

    public int? AtCanc { get; set; }

    public int? FkTbMunicipio { get; set; }

    public int? FkTbEstadosBr { get; set; }

    public int? FkTbCertificadoDigital { get; set; }

    public int? FkTbMatriz { get; set; }

    public virtual TbCertificadoDigital? FkTbCertificadoDigitalNavigation { get; set; }

    public virtual TbEstadosBr? FkTbEstadosBrNavigation { get; set; }

    public virtual TbMatriz? FkTbMatrizNavigation { get; set; }

    public virtual TbMunicipio? FkTbMunicipioNavigation { get; set; }

    public virtual ICollection<TbCertificadoDigital> TbCertificadoDigitals { get; set; } = new List<TbCertificadoDigital>();

    public virtual ICollection<TbCont> TbConts { get; set; } = new List<TbCont>();

    public virtual ICollection<TbHistorico> TbHistoricos { get; set; } = new List<TbHistorico>();

    public virtual ICollection<TbMovimentacao> TbMovimentacaoFkTbAtorAtendNavigations { get; set; } = new List<TbMovimentacao>();

    public virtual ICollection<TbMovimentacao> TbMovimentacaoFkTbAtorDestNavigations { get; set; } = new List<TbMovimentacao>();

    public virtual ICollection<TbMovimentacao> TbMovimentacaoFkTbAtorEmitNavigations { get; set; } = new List<TbMovimentacao>();

    public virtual ICollection<TbMovimentacaoProduto> TbMovimentacaoProdutos { get; set; } = new List<TbMovimentacaoProduto>();

    public virtual ICollection<TbPdv> TbPdvs { get; set; } = new List<TbPdv>();

    public virtual ICollection<TbProdutoFilial> TbProdutoFilials { get; set; } = new List<TbProdutoFilial>();

    public virtual ICollection<TbProduto> TbProdutos { get; set; } = new List<TbProduto>();

    public virtual ICollection<TbRelacaoProdutoCadastroXml> TbRelacaoProdutoCadastroXmls { get; set; } = new List<TbRelacaoProdutoCadastroXml>();

    public virtual ICollection<TbResEventoNfe> TbResEventoNves { get; set; } = new List<TbResEventoNfe>();

    public virtual ICollection<TbRespostaNfe> TbRespostaNves { get; set; } = new List<TbRespostaNfe>();
}
