using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APP_System.Domain.Interfaces;

public partial class BancoSqliteContext : DbContext
{
    public BancoSqliteContext()
    {
    }

    public BancoSqliteContext(DbContextOptions<BancoSqliteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAtor> TbAtors { get; set; }

    public virtual DbSet<TbCategoriaProduto> TbCategoriaProdutos { get; set; }

    public virtual DbSet<TbCertificadoDigital> TbCertificadoDigitals { get; set; }

    public virtual DbSet<TbClasCont1> TbClasCont1s { get; set; }

    public virtual DbSet<TbClasCont2> TbClasCont2s { get; set; }

    public virtual DbSet<TbCodigoProduto> TbCodigoProdutos { get; set; }

    public virtual DbSet<TbCont> TbConts { get; set; }

    public virtual DbSet<TbContExt> TbContExts { get; set; }

    public virtual DbSet<TbContExtGru> TbContExtGrus { get; set; }

    public virtual DbSet<TbContExtSec> TbContExtSecs { get; set; }

    public virtual DbSet<TbContExtSubGru> TbContExtSubGrus { get; set; }

    public virtual DbSet<TbContGru> TbContGrus { get; set; }

    public virtual DbSet<TbContSec> TbContSecs { get; set; }

    public virtual DbSet<TbContSubGru> TbContSubGrus { get; set; }

    public virtual DbSet<TbEst> TbEsts { get; set; }

    public virtual DbSet<TbEstadosBr> TbEstadosBrs { get; set; }

    public virtual DbSet<TbFormaPagamento> TbFormaPagamentos { get; set; }

    public virtual DbSet<TbHistorico> TbHistoricos { get; set; }

    public virtual DbSet<TbJornadum> TbJornada { get; set; }

    public virtual DbSet<TbMarcaProduto> TbMarcaProdutos { get; set; }

    public virtual DbSet<TbMatriz> TbMatrizs { get; set; }

    public virtual DbSet<TbMovimentacao> TbMovimentacaos { get; set; }

    public virtual DbSet<TbMovimentacaoCaixa> TbMovimentacaoCaixas { get; set; }

    public virtual DbSet<TbMovimentacaoImpressao> TbMovimentacaoImpressaos { get; set; }

    public virtual DbSet<TbMovimentacaoPagamento> TbMovimentacaoPagamentos { get; set; }

    public virtual DbSet<TbMovimentacaoPagamentoParcela> TbMovimentacaoPagamentoParcelas { get; set; }

    public virtual DbSet<TbMovimentacaoProduto> TbMovimentacaoProdutos { get; set; }

    public virtual DbSet<TbMunicipio> TbMunicipios { get; set; }

    public virtual DbSet<TbNcm> TbNcms { get; set; }

    public virtual DbSet<TbNfe> TbNves { get; set; }

    public virtual DbSet<TbNfeEnviadaFilial> TbNfeEnviadaFilials { get; set; }

    public virtual DbSet<TbPai> TbPais { get; set; }

    public virtual DbSet<TbPdv> TbPdvs { get; set; }

    public virtual DbSet<TbPlanCont> TbPlanConts { get; set; }

    public virtual DbSet<TbProduto> TbProdutos { get; set; }

    public virtual DbSet<TbProdutoFilial> TbProdutoFilials { get; set; }

    public virtual DbSet<TbRede> TbRedes { get; set; }

    public virtual DbSet<TbRegioesBr> TbRegioesBrs { get; set; }

    public virtual DbSet<TbRelacaoProdutoCadastroXml> TbRelacaoProdutoCadastroXmls { get; set; }

    public virtual DbSet<TbResEventoNfe> TbResEventoNves { get; set; }

    public virtual DbSet<TbRespostaNfe> TbRespostaNves { get; set; }

    public virtual DbSet<TbSecaoProduto> TbSecaoProdutos { get; set; }

    public virtual DbSet<TbSubFormaPagamento> TbSubFormaPagamentos { get; set; }

    public virtual DbSet<TbSubcategoriaProduto> TbSubcategoriaProdutos { get; set; }

    public virtual DbSet<TbUnidadeMonetarium> TbUnidadeMonetaria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\\\\\\\App_System\\\\\\\\App_System_Banco\\\\\\\\bancoSQLite.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbAtor>(entity =>
        {
            entity.HasKey(e => e.IdAtor);

            entity.ToTable("tb_ator");

            entity.HasIndex(e => e.FkTbCertificadoDigital, "ifk_tb_certificado_digital_tb_ator");

            entity.HasIndex(e => e.FkTbEstadosBr, "ifk_tb_estados_br_tb_ator");

            entity.HasIndex(e => e.FkTbMatriz, "ifk_tb_matriz_tb_ator");

            entity.HasIndex(e => e.FkTbMunicipio, "ifk_tb_municipio_tb_ator");

            entity.Property(e => e.IdAtor).HasColumnName("id_ator");
            entity.Property(e => e.AtAtorH).HasColumnName("at_atorH");
            entity.Property(e => e.AtAtorTipo)
                .HasColumnType("tinyint")
                .HasColumnName("at_atorTipo");
            entity.Property(e => e.AtCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("at_canc");
            entity.Property(e => e.AtCnae)
                .HasColumnType("varchar(12)")
                .HasColumnName("at_cnae");
            entity.Property(e => e.AtCnpj)
                .HasColumnType("varchar(18)")
                .HasColumnName("at_cnpj");
            entity.Property(e => e.AtCpf)
                .HasColumnType("varchar(14)")
                .HasColumnName("at_cpf");
            entity.Property(e => e.AtDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("at_desat");
            entity.Property(e => e.AtDirMov)
                .HasColumnType("tinyint")
                .HasColumnName("at_dirMov");
            entity.Property(e => e.AtDirRede)
                .HasColumnType("tinyint")
                .HasColumnName("at_dirRede");
            entity.Property(e => e.AtDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("at_dtAcs");
            entity.Property(e => e.AtDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("at_dtAlt");
            entity.Property(e => e.AtDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("at_dtCri");
            entity.Property(e => e.AtDtNasc)
                .HasColumnType("varchar(5)")
                .HasColumnName("at_dtNasc");
            entity.Property(e => e.AtEmail)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_email");
            entity.Property(e => e.AtEmailCont)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_emailCont");
            entity.Property(e => e.AtEndBairro)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_end_Bairro");
            entity.Property(e => e.AtEndCep)
                .HasColumnType("varchar(9)")
                .HasColumnName("at_end_Cep");
            entity.Property(e => e.AtEndCompl)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_end_Compl");
            entity.Property(e => e.AtEndLogr)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_end_Logr");
            entity.Property(e => e.AtEndMun)
                .HasColumnType("INTEGER")
                .HasColumnName("at_end_Mun");
            entity.Property(e => e.AtEndNum)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_end_Num");
            entity.Property(e => e.AtEndPontoRef).HasColumnName("at_end_PontoRef");
            entity.Property(e => e.AtEstH).HasColumnName("at_estH");
            entity.Property(e => e.AtGenero)
                .HasColumnType("tinyint")
                .HasColumnName("at_genero");
            entity.Property(e => e.AtIdMl)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_idMl");
            entity.Property(e => e.AtInscEst)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_inscEst");
            entity.Property(e => e.AtInscEstSubst)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_inscEstSubst");
            entity.Property(e => e.AtInscMun)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_inscMun");
            entity.Property(e => e.AtInscSuframa)
                .HasColumnType("varchar(9)")
                .HasColumnName("at_inscSuframa");
            entity.Property(e => e.AtManutPdv)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("at_manutPdv");
            entity.Property(e => e.AtMetaMensal)
                .HasColumnType("NUMERIC(10, 2)")
                .HasColumnName("at_metaMensal");
            entity.Property(e => e.AtNfeCodRegTrib)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeCodRegTrib");
            entity.Property(e => e.AtNfeCredSn)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("at_nfeCredSn");
            entity.Property(e => e.AtNfeCscIdHom)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeCscIdHom");
            entity.Property(e => e.AtNfeCscIdProd)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeCscIdProd");
            entity.Property(e => e.AtNfeCscTokenHom)
                .HasColumnType("varchar(100)")
                .HasColumnName("at_nfeCscTokenHom");
            entity.Property(e => e.AtNfeCscTokenProd)
                .HasColumnType("varchar(100)")
                .HasColumnName("at_nfeCscTokenProd");
            entity.Property(e => e.AtNfeEnqSn)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeEnqSN");
            entity.Property(e => e.AtNfeIndInscEst)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeIndInscEst");
            entity.Property(e => e.AtNfeRecBrutaEnqSn)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeRecBrutaEnqSN");
            entity.Property(e => e.AtNfeTipoAmb)
                .HasColumnType("tinyint")
                .HasColumnName("at_nfeTipoAmb");
            entity.Property(e => e.AtNomeFant)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_nomeFant");
            entity.Property(e => e.AtNomeUsuario)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_nomeUsuario");
            entity.Property(e => e.AtObsCom).HasColumnName("at_obsCom");
            entity.Property(e => e.AtObsFisc).HasColumnName("at_obsFisc");
            entity.Property(e => e.AtPercComisAtend)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("at_percComisAtend");
            entity.Property(e => e.AtPersTim)
                .HasColumnType("tinyint")
                .HasColumnName("at_persTim");
            entity.Property(e => e.AtProp)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("at_prop");
            entity.Property(e => e.AtRazSoc)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_razSoc");
            entity.Property(e => e.AtReceitaBrutaTotal)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("at_receitaBrutaTotal");
            entity.Property(e => e.AtReceitaBrutaTotalImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("at_receitaBrutaTotal_ImpXml");
            entity.Property(e => e.AtRespon)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_respon");
            entity.Property(e => e.AtRevenda)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("at_revenda");
            entity.Property(e => e.AtRgRne)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_rgRne");
            entity.Property(e => e.AtSenhaUsuarioHashCode)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_senhaUsuarioHashCode");
            entity.Property(e => e.AtTelCel)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_telCel");
            entity.Property(e => e.AtTelFixo)
                .HasColumnType("varchar(20)")
                .HasColumnName("at_telFixo");
            entity.Property(e => e.AtTelFixoRamal)
                .HasColumnType("varchar(10)")
                .HasColumnName("at_telFixoRamal");
            entity.Property(e => e.AtWebsite)
                .HasColumnType("varchar(60)")
                .HasColumnName("at_website");
            entity.Property(e => e.FkTbCertificadoDigital).HasColumnName("fk_tb_certificado_digital");
            entity.Property(e => e.FkTbEstadosBr).HasColumnName("fk_tb_estados_br");
            entity.Property(e => e.FkTbMatriz).HasColumnName("fk_tb_matriz");
            entity.Property(e => e.FkTbMunicipio).HasColumnName("fk_tb_municipio");

            entity.HasOne(d => d.FkTbCertificadoDigitalNavigation).WithMany(p => p.TbAtors).HasForeignKey(d => d.FkTbCertificadoDigital);

            entity.HasOne(d => d.FkTbEstadosBrNavigation).WithMany(p => p.TbAtors).HasForeignKey(d => d.FkTbEstadosBr);

            entity.HasOne(d => d.FkTbMatrizNavigation).WithMany(p => p.TbAtors).HasForeignKey(d => d.FkTbMatriz);

            entity.HasOne(d => d.FkTbMunicipioNavigation).WithMany(p => p.TbAtors).HasForeignKey(d => d.FkTbMunicipio);
        });

        modelBuilder.Entity<TbCategoriaProduto>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaProduto);

            entity.ToTable("tb_categoria_produto");

            entity.HasIndex(e => e.FkTbSecaoProduto, "ifk_tb_secao_produto_tb_categoria_produto");

            entity.Property(e => e.IdCategoriaProduto).HasColumnName("id_categoria_produto");
            entity.Property(e => e.CpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cp_desat");
            entity.Property(e => e.CpDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("cp_desc");
            entity.Property(e => e.CpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtAcs");
            entity.Property(e => e.CpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtAlt");
            entity.Property(e => e.CpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtCri");
            entity.Property(e => e.FkTbSecaoProduto).HasColumnName("fk_tb_secao_produto");

            entity.HasOne(d => d.FkTbSecaoProdutoNavigation).WithMany(p => p.TbCategoriaProdutos).HasForeignKey(d => d.FkTbSecaoProduto);
        });

        modelBuilder.Entity<TbCertificadoDigital>(entity =>
        {
            entity.HasKey(e => e.IdCertificadoDigital);

            entity.ToTable("tb_certificado_digital");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_certificado_digital");

            entity.Property(e => e.IdCertificadoDigital).HasColumnName("id_certificado_digital");
            entity.Property(e => e.CdAtivo)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cd_ativo");
            entity.Property(e => e.CdCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cd_canc");
            entity.Property(e => e.CdCnpj)
                .HasColumnType("varchar(18)")
                .HasColumnName("cd_cnpj");
            entity.Property(e => e.CdDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cd_dtAcs");
            entity.Property(e => e.CdDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cd_dtAlt");
            entity.Property(e => e.CdDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cd_dtCri");
            entity.Property(e => e.CdDtExp)
                .HasColumnType("DATETIME")
                .HasColumnName("cd_dtExp");
            entity.Property(e => e.CdDtPub)
                .HasColumnType("DATETIME")
                .HasColumnName("cd_dtPub");
            entity.Property(e => e.CdModoEmissao)
                .HasColumnType("varchar(50)")
                .HasColumnName("cd_modoEmissao");
            entity.Property(e => e.CdPwd)
                .HasColumnType("varchar(64)")
                .HasColumnName("cd_pwd");
            entity.Property(e => e.CdRawData).HasColumnName("cd_rawData");
            entity.Property(e => e.CdRazSoc)
                .HasColumnType("varchar(60)")
                .HasColumnName("cd_razSoc");
            entity.Property(e => e.CdSHa1string)
                .HasColumnType("varchar(128)")
                .HasColumnName("cd_sHA1String");
            entity.Property(e => e.CdSerial)
                .HasColumnType("varchar(128)")
                .HasColumnName("cd_serial");
            entity.Property(e => e.CdTipo)
                .HasColumnType("varchar(50)")
                .HasColumnName("cd_tipo");
            entity.Property(e => e.CdX509Version)
                .HasColumnType("INT")
                .HasColumnName("cd_x509Version");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbCertificadoDigitals).HasForeignKey(d => d.FkTbAtor);
        });

        modelBuilder.Entity<TbClasCont1>(entity =>
        {
            entity.HasKey(e => e.IdClasCont1);

            entity.ToTable("tb_clasCont1");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_clasCont1");

            entity.Property(e => e.IdClasCont1).HasColumnName("id_clasCont1");
            entity.Property(e => e.Cc1Desat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cc1_desat");
            entity.Property(e => e.Cc1Desc)
                .HasColumnType("varchar(48)")
                .HasColumnName("cc1_desc");
            entity.Property(e => e.Cc1DtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cc1_dtAcs");
            entity.Property(e => e.Cc1DtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cc1_dtAlt");
            entity.Property(e => e.Cc1DtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cc1_dtCri");
            entity.Property(e => e.Cc1Saida)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cc1_saida");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbClasCont1s).HasForeignKey(d => d.FkTbRede);
        });

        modelBuilder.Entity<TbClasCont2>(entity =>
        {
            entity.HasKey(e => e.IdClasCont2);

            entity.ToTable("tb_clasCont2");

            entity.HasIndex(e => e.FkTbPdv, "ifk_tb_pdv_tb_clasCont2");

            entity.Property(e => e.IdClasCont2).HasColumnName("id_clasCont2");
            entity.Property(e => e.Cc2ClasCont1).HasColumnName("cc2_clasCont1");
            entity.Property(e => e.Cc2Desat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cc2_desat");
            entity.Property(e => e.Cc2Desc)
                .HasColumnType("varchar(60)")
                .HasColumnName("cc2_desc");
            entity.Property(e => e.Cc2DtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cc2_dtAcs");
            entity.Property(e => e.Cc2DtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cc2_dtAlt");
            entity.Property(e => e.Cc2DtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cc2_dtCri");
            entity.Property(e => e.FkTbPdv).HasColumnName("fk_tb_pdv");

            entity.HasOne(d => d.FkTbPdvNavigation).WithMany(p => p.TbClasCont2s).HasForeignKey(d => d.FkTbPdv);
        });

        modelBuilder.Entity<TbCodigoProduto>(entity =>
        {
            entity.HasKey(e => e.IdCodigoProduto);

            entity.ToTable("tb_codigo_produto");

            entity.HasIndex(e => e.FkTbProduto, "ifk_tb_produto_tb_codigo_produto");

            entity.Property(e => e.IdCodigoProduto).HasColumnName("id_codigo_produto");
            entity.Property(e => e.CpBarras)
                .HasColumnType("varchar(14)")
                .HasColumnName("cp_barras");
            entity.Property(e => e.CpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cp_desat");
            entity.Property(e => e.CpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtAcs");
            entity.Property(e => e.CpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtAlt");
            entity.Property(e => e.CpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cp_dtCri");
            entity.Property(e => e.FkTbProduto).HasColumnName("fk_tb_produto");

            entity.HasOne(d => d.FkTbProdutoNavigation).WithMany(p => p.TbCodigoProdutos).HasForeignKey(d => d.FkTbProduto);
        });

        modelBuilder.Entity<TbCont>(entity =>
        {
            entity.HasKey(e => e.IdCont);

            entity.ToTable("tb_cont");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_cont");

            entity.HasIndex(e => e.FkTbContSubGru, "ifk_tb_contSubGru_tb_cont");

            entity.Property(e => e.IdCont).HasColumnName("id_cont");
            entity.Property(e => e.CtCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ct_canc");
            entity.Property(e => e.CtConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ct_conc");
            entity.Property(e => e.CtDAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("ct_dAlt");
            entity.Property(e => e.CtDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("ct_desc");
            entity.Property(e => e.CtDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("ct_dtAcs");
            entity.Property(e => e.CtDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("ct_dtCri");
            entity.Property(e => e.CtSaldo)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ct_saldo");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.FkTbContSubGru).HasColumnName("fk_tb_contSubGru");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbConts).HasForeignKey(d => d.FkTbAtor);

            entity.HasOne(d => d.FkTbContSubGruNavigation).WithMany(p => p.TbConts).HasForeignKey(d => d.FkTbContSubGru);
        });

        modelBuilder.Entity<TbContExt>(entity =>
        {
            entity.HasKey(e => e.IdContExt);

            entity.ToTable("tb_contExt");

            entity.HasIndex(e => e.FkTbCont, "ifk_tb_cont_tb_contExt");

            entity.Property(e => e.IdContExt).HasColumnName("id_contExt");
            entity.Property(e => e.CeCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ce_canc");
            entity.Property(e => e.CeConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ce_conc");
            entity.Property(e => e.CeCred)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ce_cred");
            entity.Property(e => e.CeDeb)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ce_deb");
            entity.Property(e => e.CeDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("ce_dtAcs");
            entity.Property(e => e.CeDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("ce_dtAlt");
            entity.Property(e => e.CeDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("ce_dtCri");
            entity.Property(e => e.FkTbCont).HasColumnName("fk_tb_cont");

            entity.HasOne(d => d.FkTbContNavigation).WithMany(p => p.TbContExts).HasForeignKey(d => d.FkTbCont);
        });

        modelBuilder.Entity<TbContExtGru>(entity =>
        {
            entity.HasKey(e => e.IdContExtGru);

            entity.ToTable("tb_contExtGru");

            entity.HasIndex(e => e.FkTbContGru, "ifk_tb_contGru_tb_contExtGru");

            entity.Property(e => e.IdContExtGru).HasColumnName("id_contExtGru");
            entity.Property(e => e.CegCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ceg_canc");
            entity.Property(e => e.CegConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ceg_conc");
            entity.Property(e => e.CegCred)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ceg_cred");
            entity.Property(e => e.CegDeb)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ceg_deb");
            entity.Property(e => e.CegDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("ceg_dtAcs");
            entity.Property(e => e.CegDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("ceg_dtAlt");
            entity.Property(e => e.CegDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("ceg_dtCri");
            entity.Property(e => e.FkTbContGru).HasColumnName("fk_tb_contGru");

            entity.HasOne(d => d.FkTbContGruNavigation).WithMany(p => p.TbContExtGrus).HasForeignKey(d => d.FkTbContGru);
        });

        modelBuilder.Entity<TbContExtSec>(entity =>
        {
            entity.HasKey(e => e.IdContExtSec);

            entity.ToTable("tb_contExtSec");

            entity.Property(e => e.IdContExtSec).HasColumnName("id_contExtSec");
            entity.Property(e => e.CesCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ces_canc");
            entity.Property(e => e.CesConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ces_conc");
            entity.Property(e => e.CesCred)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ces_cred");
            entity.Property(e => e.CesDeb)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("ces_deb");
            entity.Property(e => e.CesDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("ces_dtAcs");
            entity.Property(e => e.CesDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("ces_dtAlt");
            entity.Property(e => e.CesDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("ces_dtCri");
            entity.Property(e => e.FkTbContSec).HasColumnName("fk_tb_contSec");

            entity.HasOne(d => d.FkTbContSecNavigation).WithMany(p => p.TbContExtSecs).HasForeignKey(d => d.FkTbContSec);
        });

        modelBuilder.Entity<TbContExtSubGru>(entity =>
        {
            entity.HasKey(e => e.IdContExtSubGru);

            entity.ToTable("tb_contExtSubGru");

            entity.HasIndex(e => e.FkTbContSubGru, "ifk_tb_contSubGru_tb_contExtSubGru");

            entity.Property(e => e.IdContExtSubGru).HasColumnName("id_contExtSubGru");
            entity.Property(e => e.CesgCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cesg_canc");
            entity.Property(e => e.CesgConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cesg_conc");
            entity.Property(e => e.CesgCred)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("cesg_cred");
            entity.Property(e => e.CesgDeb)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("cesg_deb");
            entity.Property(e => e.CesgDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cesg_dtAcs");
            entity.Property(e => e.CesgDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cesg_dtAlt");
            entity.Property(e => e.CesgDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cesg_dtCri");
            entity.Property(e => e.FkTbContSubGru).HasColumnName("fk_tb_contSubGru");

            entity.HasOne(d => d.FkTbContSubGruNavigation).WithMany(p => p.TbContExtSubGrus).HasForeignKey(d => d.FkTbContSubGru);
        });

        modelBuilder.Entity<TbContGru>(entity =>
        {
            entity.HasKey(e => e.IdContGru);

            entity.ToTable("tb_contGru");

            entity.Property(e => e.IdContGru).HasColumnName("id_contGru");
            entity.Property(e => e.CgCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cg_canc");
            entity.Property(e => e.CgConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cg_conc");
            entity.Property(e => e.CgContSec).HasColumnName("cg_contSec");
            entity.Property(e => e.CgDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("cg_desc");
            entity.Property(e => e.CgDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cg_dtAcs");
            entity.Property(e => e.CgDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cg_dtAlt");
            entity.Property(e => e.CgDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cg_dtCri");
        });

        modelBuilder.Entity<TbContSec>(entity =>
        {
            entity.HasKey(e => e.IdContSec);

            entity.ToTable("tb_contSec");

            entity.Property(e => e.IdContSec).HasColumnName("id_contSec");
            entity.Property(e => e.CsCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cs_canc");
            entity.Property(e => e.CsConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("cs_conc");
            entity.Property(e => e.CsDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("cs_desc");
            entity.Property(e => e.CsDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("cs_dtAcs");
            entity.Property(e => e.CsDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("cs_dtAlt");
            entity.Property(e => e.CsDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("cs_dtCri");
        });

        modelBuilder.Entity<TbContSubGru>(entity =>
        {
            entity.HasKey(e => e.IdContSubGru);

            entity.ToTable("tb_contSubGru");

            entity.HasIndex(e => e.FkTbContGru, "ifk_tb_contGru_tb_contSubGru");

            entity.Property(e => e.IdContSubGru).HasColumnName("id_contSubGru");
            entity.Property(e => e.CsgCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("csg_canc");
            entity.Property(e => e.CsgConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("csg_conc");
            entity.Property(e => e.CsgDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("csg_desc");
            entity.Property(e => e.CsgDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("csg_dtAcs");
            entity.Property(e => e.CsgDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("csg_dtAlt");
            entity.Property(e => e.CsgDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("csg_dtCri");
            entity.Property(e => e.FkTbContGru).HasColumnName("fk_tb_contGru");

            entity.HasOne(d => d.FkTbContGruNavigation).WithMany(p => p.TbContSubGrus).HasForeignKey(d => d.FkTbContGru);
        });

        modelBuilder.Entity<TbEst>(entity =>
        {
            entity.HasKey(e => e.IdEst);

            entity.ToTable("tb_est");

            entity.HasIndex(e => e.FkTbMatriz, "ifk_tb_matriz_tb_est");

            entity.Property(e => e.IdEst).HasColumnName("id_est");
            entity.Property(e => e.EsBiosCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_biosCaption");
            entity.Property(e => e.EsBiosSerialNumber)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_biosSerialNumber");
            entity.Property(e => e.EsBiosSmbiosbiosversion)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_biosSMBIOSBIOSVersion");
            entity.Property(e => e.EsBiosSoftwareElementId)
                .HasColumnType("varchar(256)")
                .HasColumnName("es_biosSoftwareElementID");
            entity.Property(e => e.EsBoardManufacturer)
                .HasColumnType("varchar(256)")
                .HasColumnName("es_boardManufacturer");
            entity.Property(e => e.EsBoardProduct)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_boardProduct");
            entity.Property(e => e.EsBoardSerialNumber)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_boardSerialNumber");
            entity.Property(e => e.EsBoardStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_boardStatus");
            entity.Property(e => e.EsBoardVersion)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_boardVersion");
            entity.Property(e => e.EsDskCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_dskCaption");
            entity.Property(e => e.EsDskIndex)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_dskIndex");
            entity.Property(e => e.EsDskSerialNumber)
                .HasColumnType("varchar(128)")
                .HasColumnName("es_dskSerialNumber");
            entity.Property(e => e.EsDskSignature)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_dskSignature");
            entity.Property(e => e.EsDskSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_dskSize");
            entity.Property(e => e.EsDskStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_dskStatus");
            entity.Property(e => e.EsDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("es_dtAcs");
            entity.Property(e => e.EsDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("es_dtAlt");
            entity.Property(e => e.EsDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("es_dtCri");
            entity.Property(e => e.EsGpuAdapterRam)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuAdapterRAM");
            entity.Property(e => e.EsGpuAvailability)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_gpuAvailability");
            entity.Property(e => e.EsGpuConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuConfigManagerErrorCode");
            entity.Property(e => e.EsGpuCurrentBitsPerPixel)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuCurrentBitsPerPixel");
            entity.Property(e => e.EsGpuCurrentHorizontalResolution)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuCurrentHorizontalResolution");
            entity.Property(e => e.EsGpuCurrentNumberOfColors)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_gpuCurrentNumberOfColors");
            entity.Property(e => e.EsGpuCurrentRefreshRate)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuCurrentRefreshRate");
            entity.Property(e => e.EsGpuCurrentScanMode)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_gpuCurrentScanMode");
            entity.Property(e => e.EsGpuCurrentVerticalResolution)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuCurrentVerticalResolution");
            entity.Property(e => e.EsGpuDitherType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_gpuDitherType");
            entity.Property(e => e.EsGpuDriverVersion)
                .HasColumnType("varchar(50)")
                .HasColumnName("es_gpuDriverVersion");
            entity.Property(e => e.EsGpuStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_gpuStatus");
            entity.Property(e => e.EsGpuVideoProcessor)
                .HasColumnType("varchar(100)")
                .HasColumnName("es_gpuVideoProcessor");
            entity.Property(e => e.EsNicAdapterType)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_nicAdapterType");
            entity.Property(e => e.EsNicAdapterTypeId)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_nicAdapterTypeID");
            entity.Property(e => e.EsNicCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_nicCaption");
            entity.Property(e => e.EsNicCfgDhcpenabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_nicCfgDHCPEnabled");
            entity.Property(e => e.EsNicCfgDhcpserver)
                .HasColumnType("varchar(48)")
                .HasColumnName("es_nicCfgDHCPServer");
            entity.Property(e => e.EsNicCfgDnsdomain)
                .HasColumnType("varchar(255)")
                .HasColumnName("es_nicCfgDNSDomain");
            entity.Property(e => e.EsNicCfgIpaddress).HasColumnName("es_nicCfgIPAddress");
            entity.Property(e => e.EsNicCfgIpaddressVpn).HasColumnName("es_nicCfgIPAddressVpn");
            entity.Property(e => e.EsNicCfgIpconnectionMetric)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_nicCfgIPConnectionMetric");
            entity.Property(e => e.EsNicCfgIpenabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_nicCfgIPEnabled");
            entity.Property(e => e.EsNicDescription)
                .HasColumnType("varchar(128)")
                .HasColumnName("es_nicDescription");
            entity.Property(e => e.EsNicInterfaceIndex)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_nicInterfaceIndex");
            entity.Property(e => e.EsNicMacAddress)
                .HasColumnType("varchar(32)")
                .HasColumnName("es_nicMacAddress");
            entity.Property(e => e.EsNicMacAddressVpn)
                .HasColumnType("varchar(32)")
                .HasColumnName("es_nicMacAddressVpn");
            entity.Property(e => e.EsNicManufacturer)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_nicManufacturer");
            entity.Property(e => e.EsNicName)
                .HasColumnType("varchar(128)")
                .HasColumnName("es_nicName");
            entity.Property(e => e.EsNicNetEnabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_nicNetEnabled");
            entity.Property(e => e.EsNicSpeed)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_nicSpeed");
            entity.Property(e => e.EsPcAutomaticManagedPagefile)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcAutomaticManagedPagefile");
            entity.Property(e => e.EsPcAutomaticResetBootOption)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcAutomaticResetBootOption");
            entity.Property(e => e.EsPcAutomaticResetCapability)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcAutomaticResetCapability");
            entity.Property(e => e.EsPcBootRomsupported)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcBootROMSupported");
            entity.Property(e => e.EsPcBootupState)
                .HasColumnType("varchar(50)")
                .HasColumnName("es_pcBootupState");
            entity.Property(e => e.EsPcCurrentTimeZone)
                .HasColumnType("smallint")
                .HasColumnName("es_pcCurrentTimeZone");
            entity.Property(e => e.EsPcDaylightInEffect)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcDaylightInEffect");
            entity.Property(e => e.EsPcDnshostName)
                .HasColumnType("varchar(255)")
                .HasColumnName("es_pcDNSHostName");
            entity.Property(e => e.EsPcDomainRole)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcDomainRole");
            entity.Property(e => e.EsPcEnableDaylightSavingsTime)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcEnableDaylightSavingsTime");
            entity.Property(e => e.EsPcHypervisorPresent)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcHypervisorPresent");
            entity.Property(e => e.EsPcLdCaption)
                .HasColumnType("varchar(60)")
                .HasColumnName("es_pcLdCaption");
            entity.Property(e => e.EsPcLdCompressed)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcLdCompressed");
            entity.Property(e => e.EsPcLdConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcLdConfigManagerErrorCode");
            entity.Property(e => e.EsPcLdDeviceId)
                .HasColumnType("varchar(60)")
                .HasColumnName("es_pcLdDeviceID");
            entity.Property(e => e.EsPcLdDriveType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcLdDriveType");
            entity.Property(e => e.EsPcLdFileSystem)
                .HasColumnType("varchar(20)")
                .HasColumnName("es_pcLdFileSystem");
            entity.Property(e => e.EsPcLdFreeSpace)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcLdFreeSpace");
            entity.Property(e => e.EsPcLdLastErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcLdLastErrorCode");
            entity.Property(e => e.EsPcLdName)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_pcLdName");
            entity.Property(e => e.EsPcLdSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcLdSize");
            entity.Property(e => e.EsPcLdVolumeDirty)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcLdVolumeDirty");
            entity.Property(e => e.EsPcLdVolumeSerialNumber)
                .HasColumnType("varchar(60)")
                .HasColumnName("es_pcLdVolumeSerialNumber");
            entity.Property(e => e.EsPcManufacturer)
                .HasColumnType("varchar(50)")
                .HasColumnName("es_pcManufacturer");
            entity.Property(e => e.EsPcNetworkServerModeEnabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcNetworkServerModeEnabled");
            entity.Property(e => e.EsPcNumberOfLogicalProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcNumberOfLogicalProcessors");
            entity.Property(e => e.EsPcNumberOfProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcNumberOfProcessors");
            entity.Property(e => e.EsPcOsBuildNumber)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_pcOsBuildNumber");
            entity.Property(e => e.EsPcOsCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_pcOsCaption");
            entity.Property(e => e.EsPcOsCodeSet)
                .HasColumnType("varchar(6)")
                .HasColumnName("es_pcOsCodeSet");
            entity.Property(e => e.EsPcOsCountryCode)
                .HasColumnType("varchar(256)")
                .HasColumnName("es_pcOsCountryCode");
            entity.Property(e => e.EsPcOsCurrentTimeZone)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcOsCurrentTimeZone");
            entity.Property(e => e.EsPcOsFreePhysicalMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsFreePhysicalMemory");
            entity.Property(e => e.EsPcOsFreeSpaceInPagingFiles)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsFreeSpaceInPagingFiles");
            entity.Property(e => e.EsPcOsFreeVirtualMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsFreeVirtualMemory");
            entity.Property(e => e.EsPcOsInstallDate)
                .HasColumnType("DATETIME")
                .HasColumnName("es_pcOsInstallDate");
            entity.Property(e => e.EsPcOsLastBootUpTime)
                .HasColumnType("DATETIME")
                .HasColumnName("es_pcOsLastBootUpTime");
            entity.Property(e => e.EsPcOsLocalDateTime)
                .HasColumnType("DATETIME")
                .HasColumnName("es_pcOsLocalDateTime");
            entity.Property(e => e.EsPcOsLocale)
                .HasColumnType("varchar(6)")
                .HasColumnName("es_pcOsLocale");
            entity.Property(e => e.EsPcOsNumberOfProcesses)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOsNumberOfProcesses");
            entity.Property(e => e.EsPcOsNumberOfUsers)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOsNumberOfUsers");
            entity.Property(e => e.EsPcOsOperatingSystemSku)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOsOperatingSystemSKU");
            entity.Property(e => e.EsPcOsPortableOperatingSystem)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcOsPortableOperatingSystem");
            entity.Property(e => e.EsPcOsPrimary)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcOsPrimary");
            entity.Property(e => e.EsPcOsProductType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOsProductType");
            entity.Property(e => e.EsPcOsRegisteredUser)
                .HasColumnType("varchar(100)")
                .HasColumnName("es_pcOsRegisteredUser");
            entity.Property(e => e.EsPcOsSerialNumber)
                .HasColumnType("varchar(50)")
                .HasColumnName("es_pcOsSerialNumber");
            entity.Property(e => e.EsPcOsServicePackMajorVersion)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcOsServicePackMajorVersion");
            entity.Property(e => e.EsPcOsServicePackMinorVersion)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcOsServicePackMinorVersion");
            entity.Property(e => e.EsPcOsSizeStoredInPagingFiles)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsSizeStoredInPagingFiles");
            entity.Property(e => e.EsPcOsSuiteMask)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOsSuiteMask");
            entity.Property(e => e.EsPcOsSystemDrive)
                .HasColumnType("varchar(2)")
                .HasColumnName("es_pcOsSystemDrive");
            entity.Property(e => e.EsPcOsTotalSwapSpaceSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsTotalSwapSpaceSize");
            entity.Property(e => e.EsPcOsTotalVirtualMemorySize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsTotalVirtualMemorySize");
            entity.Property(e => e.EsPcOsTotalVisibleMemorySize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcOsTotalVisibleMemorySize");
            entity.Property(e => e.EsPcOsVersion)
                .HasColumnType("varchar(20)")
                .HasColumnName("es_pcOsVersion");
            entity.Property(e => e.EsPcOsarchitecture)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_pcOSArchitecture");
            entity.Property(e => e.EsPcOslanguage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOSLanguage");
            entity.Property(e => e.EsPcOsproductSuite)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcOSProductSuite");
            entity.Property(e => e.EsPcPcsystemType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPCSystemType");
            entity.Property(e => e.EsPcPgFlAllocatedBaseSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPgFlAllocatedBaseSize");
            entity.Property(e => e.EsPcPgFlCurrentUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPgFlCurrentUsage");
            entity.Property(e => e.EsPcPgFlPeakUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPgFlPeakUsage");
            entity.Property(e => e.EsPcPowElementName)
                .HasColumnType("varchar(60)")
                .HasColumnName("es_pcPowElementName");
            entity.Property(e => e.EsPcPowInstanceId)
                .HasColumnType("varchar(60)")
                .HasColumnName("es_pcPowInstanceID");
            entity.Property(e => e.EsPcPrcAddressWidth)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcAddressWidth");
            entity.Property(e => e.EsPcPrcArchitecture)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcArchitecture");
            entity.Property(e => e.EsPcPrcAvailability)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcAvailability");
            entity.Property(e => e.EsPcPrcCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("es_pcPrcCaption");
            entity.Property(e => e.EsPcPrcCharacteristics)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcCharacteristics");
            entity.Property(e => e.EsPcPrcConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcConfigManagerErrorCode");
            entity.Property(e => e.EsPcPrcConfigManagerUserConfig)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcPrcConfigManagerUserConfig");
            entity.Property(e => e.EsPcPrcCpuStatus)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcCpuStatus");
            entity.Property(e => e.EsPcPrcCurrentClockSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcCurrentClockSpeed");
            entity.Property(e => e.EsPcPrcCurrentVoltage)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcCurrentVoltage");
            entity.Property(e => e.EsPcPrcDataWidth)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcDataWidth");
            entity.Property(e => e.EsPcPrcExtClock)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcExtClock");
            entity.Property(e => e.EsPcPrcFamily)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcFamily");
            entity.Property(e => e.EsPcPrcL2cacheSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcL2CacheSize");
            entity.Property(e => e.EsPcPrcL2cacheSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcL2CacheSpeed");
            entity.Property(e => e.EsPcPrcL3cacheSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcL3CacheSize");
            entity.Property(e => e.EsPcPrcL3cacheSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcL3CacheSpeed");
            entity.Property(e => e.EsPcPrcLevel)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcLevel");
            entity.Property(e => e.EsPcPrcLoadPercentage)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcLoadPercentage");
            entity.Property(e => e.EsPcPrcMaxClockSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcMaxClockSpeed");
            entity.Property(e => e.EsPcPrcName)
                .HasColumnType("varchar(100)")
                .HasColumnName("es_pcPrcName");
            entity.Property(e => e.EsPcPrcNumberOfCores)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcNumberOfCores");
            entity.Property(e => e.EsPcPrcNumberOfEnabledCore)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcNumberOfEnabledCore");
            entity.Property(e => e.EsPcPrcNumberOfLogicalProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcNumberOfLogicalProcessors");
            entity.Property(e => e.EsPcPrcPowerManagementSupported)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcPrcPowerManagementSupported");
            entity.Property(e => e.EsPcPrcProcessorId)
                .HasColumnType("varchar(100)")
                .HasColumnName("es_pcPrcProcessorId");
            entity.Property(e => e.EsPcPrcProcessorType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcProcessorType");
            entity.Property(e => e.EsPcPrcRevision)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcRevision");
            entity.Property(e => e.EsPcPrcSecondLevelAddressTranslationExtensions)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("es_pcPrcSecondLevelAddressTranslationExtensions");
            entity.Property(e => e.EsPcPrcStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("es_pcPrcStatus");
            entity.Property(e => e.EsPcPrcStatusInfo)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcPrcStatusInfo");
            entity.Property(e => e.EsPcPrcSystemName)
                .HasColumnType("varchar(255)")
                .HasColumnName("es_pcPrcSystemName");
            entity.Property(e => e.EsPcPrcThreadCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_pcPrcThreadCount");
            entity.Property(e => e.EsPcTotalPhysicalMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_pcTotalPhysicalMemory");
            entity.Property(e => e.EsPcUserName)
                .HasColumnType("varchar(255)")
                .HasColumnName("es_pcUserName");
            entity.Property(e => e.EsPcWakeUpType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("es_pcWakeUpType");
            entity.Property(e => e.EsProcHandle)
                .HasColumnType("varchar(256)")
                .HasColumnName("es_procHandle");
            entity.Property(e => e.EsProcHandleCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procHandleCount");
            entity.Property(e => e.EsProcKernelModeTime)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procKernelModeTime");
            entity.Property(e => e.EsProcOtherOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procOtherOperationCount");
            entity.Property(e => e.EsProcOtherTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procOtherTransferCount");
            entity.Property(e => e.EsProcPageFaults)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procPageFaults");
            entity.Property(e => e.EsProcPageFileUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procPageFileUsage");
            entity.Property(e => e.EsProcPeakPageFileUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procPeakPageFileUsage");
            entity.Property(e => e.EsProcPeakVirtualSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procPeakVirtualSize");
            entity.Property(e => e.EsProcPeakWorkingSetSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procPeakWorkingSetSize");
            entity.Property(e => e.EsProcPriority)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procPriority");
            entity.Property(e => e.EsProcPrivatePageCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procPrivatePageCount");
            entity.Property(e => e.EsProcProcessId)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procProcessId");
            entity.Property(e => e.EsProcReadOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procReadOperationCount");
            entity.Property(e => e.EsProcReadTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procReadTransferCount");
            entity.Property(e => e.EsProcThreadCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("es_procThreadCount");
            entity.Property(e => e.EsProcUserModeTime)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procUserModeTime");
            entity.Property(e => e.EsProcVirtualSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procVirtualSize");
            entity.Property(e => e.EsProcWorkingSetSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procWorkingSetSize");
            entity.Property(e => e.EsProcWriteOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procWriteOperationCount");
            entity.Property(e => e.EsProcWriteTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("es_procWriteTransferCount");
            entity.Property(e => e.FkTbMatriz).HasColumnName("fk_tb_matriz");

            entity.HasOne(d => d.FkTbMatrizNavigation).WithMany(p => p.TbEsts).HasForeignKey(d => d.FkTbMatriz);
        });

        modelBuilder.Entity<TbEstadosBr>(entity =>
        {
            entity.HasKey(e => e.IdEstadosBr);

            entity.ToTable("tb_estados_br");

            entity.HasIndex(e => e.FkTbRegioesBr, "ifk_tb_regioes_br_tb_estados_br");

            entity.Property(e => e.IdEstadosBr).HasColumnName("id_estados_br");
            entity.Property(e => e.EbDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("eb_desat");
            entity.Property(e => e.EbId)
                .HasColumnType("tinyint")
                .HasColumnName("eb_id");
            entity.Property(e => e.EbNome)
                .HasColumnType("varchar(20)")
                .HasColumnName("eb_nome");
            entity.Property(e => e.EbSigla)
                .HasColumnType("varchar(2)")
                .HasColumnName("eb_sigla");
            entity.Property(e => e.FkTbRegioesBr).HasColumnName("fk_tb_regioes_br");

            entity.HasOne(d => d.FkTbRegioesBrNavigation).WithMany(p => p.TbEstadosBrs).HasForeignKey(d => d.FkTbRegioesBr);
        });

        modelBuilder.Entity<TbFormaPagamento>(entity =>
        {
            entity.HasKey(e => e.IdFormaPagamento);

            entity.ToTable("tb_forma_pagamento");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_forma_pagamento");

            entity.Property(e => e.IdFormaPagamento).HasColumnName("id_forma_pagamento");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");
            entity.Property(e => e.FpAtalhoTecl)
                .HasColumnType("nchar(1)")
                .HasColumnName("fp_atalhoTecl");
            entity.Property(e => e.FpCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("fp_canc");
            entity.Property(e => e.FpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("fp_desat");
            entity.Property(e => e.FpDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("fp_desc");
            entity.Property(e => e.FpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("fp_dtAcs");
            entity.Property(e => e.FpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("fp_dtAlt");
            entity.Property(e => e.FpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("fp_dtCri");
            entity.Property(e => e.FpIntParcBase)
                .HasColumnType("smallint")
                .HasColumnName("fp_intParcBase");
            entity.Property(e => e.FpNfeIndPag)
                .HasColumnType("INT")
                .HasColumnName("fp_nfeIndPag");
            entity.Property(e => e.FpNfeTipoIntegr)
                .HasColumnType("tinyint")
                .HasColumnName("fp_nfeTipoIntegr");
            entity.Property(e => e.FpNfeTipoPag)
                .HasColumnType("INT")
                .HasColumnName("fp_nfeTipoPag");
            entity.Property(e => e.FpOrdExib)
                .HasColumnType("smallint")
                .HasColumnName("fp_ordExib");
            entity.Property(e => e.FpParcMax)
                .HasColumnType("smallint")
                .HasColumnName("fp_parcMax");
            entity.Property(e => e.FpParcMin)
                .HasColumnType("smallint")
                .HasColumnName("fp_parcMin");
            entity.Property(e => e.FpTaxa0)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa0");
            entity.Property(e => e.FpTaxa1)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa1");
            entity.Property(e => e.FpTaxa10)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa10");
            entity.Property(e => e.FpTaxa11)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa11");
            entity.Property(e => e.FpTaxa12)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa12");
            entity.Property(e => e.FpTaxa2)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa2");
            entity.Property(e => e.FpTaxa3)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa3");
            entity.Property(e => e.FpTaxa4)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa4");
            entity.Property(e => e.FpTaxa5)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa5");
            entity.Property(e => e.FpTaxa6)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa6");
            entity.Property(e => e.FpTaxa7)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa7");
            entity.Property(e => e.FpTaxa8)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa8");
            entity.Property(e => e.FpTaxa9)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("fp_taxa9");
            entity.Property(e => e.FpTaxaData)
                .HasColumnType("DATETIME")
                .HasColumnName("fp_taxaData");
            entity.Property(e => e.FpTaxaDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("fp_taxaDesc");
            entity.Property(e => e.FpVlrMax)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("fp_vlrMax");
            entity.Property(e => e.FpVlrMin)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("fp_vlrMin");

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbFormaPagamentos).HasForeignKey(d => d.FkTbRede);
        });

        modelBuilder.Entity<TbHistorico>(entity =>
        {
            entity.HasKey(e => e.IdHistorico);

            entity.ToTable("tb_historico");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_historico");

            entity.HasIndex(e => e.FkTbEst, "ifk_tb_est_tb_historico");

            entity.Property(e => e.IdHistorico).HasColumnName("id_historico");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.FkTbEst).HasColumnName("fk_tb_est");
            entity.Property(e => e.HiConteudoAnterior).HasColumnName("hi_conteudoAnterior");
            entity.Property(e => e.HiConteudoNovo).HasColumnName("hi_conteudoNovo");
            entity.Property(e => e.HiDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("hi_dtCri");
            entity.Property(e => e.HiSqlColumnName)
                .HasColumnType("VARCHAR(100)")
                .HasColumnName("hi_sqlColumnName");
            entity.Property(e => e.HiSqlTableName)
                .HasColumnType("VARCHAR(100)")
                .HasColumnName("hi_sqlTableName");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbHistoricos).HasForeignKey(d => d.FkTbAtor);

            entity.HasOne(d => d.FkTbEstNavigation).WithMany(p => p.TbHistoricos).HasForeignKey(d => d.FkTbEst);
        });

        modelBuilder.Entity<TbJornadum>(entity =>
        {
            entity.HasKey(e => e.IdJornada);

            entity.ToTable("tb_jornada");

            entity.HasIndex(e => e.FkTbEst, "ifk_tb_est_tb_jornada");

            entity.HasIndex(e => e.FkTbPdv, "ifk_tb_pdv_tb_jornada");

            entity.Property(e => e.IdJornada).HasColumnName("id_jornada");
            entity.Property(e => e.FkTbEst).HasColumnName("fk_tb_est");
            entity.Property(e => e.FkTbPdv).HasColumnName("fk_tb_pdv");
            entity.Property(e => e.JoAberta)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("jo_aberta");
            entity.Property(e => e.JoCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("jo_canc");
            entity.Property(e => e.JoDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("jo_desat");
            entity.Property(e => e.JoDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("jo_dtAcs");
            entity.Property(e => e.JoDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("jo_dtAlt");
            entity.Property(e => e.JoDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("jo_dtCri");
            entity.Property(e => e.JoNumSeq)
                .HasColumnType("bigint")
                .HasColumnName("jo_numSeq");

            entity.HasOne(d => d.FkTbEstNavigation).WithMany(p => p.TbJornada).HasForeignKey(d => d.FkTbEst);

            entity.HasOne(d => d.FkTbPdvNavigation).WithMany(p => p.TbJornada).HasForeignKey(d => d.FkTbPdv);
        });

        modelBuilder.Entity<TbMarcaProduto>(entity =>
        {
            entity.HasKey(e => e.IdMarcaProduto);

            entity.ToTable("tb_marca_produto");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_marca_produto");

            entity.Property(e => e.IdMarcaProduto).HasColumnName("id_marca_produto");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");
            entity.Property(e => e.MpDesat).HasColumnName("mp_desat");
            entity.Property(e => e.MpDesc)
                .HasColumnType("varchar(48)")
                .HasColumnName("mp_desc");
            entity.Property(e => e.MpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtAcs");
            entity.Property(e => e.MpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtAlt");
            entity.Property(e => e.MpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtCri");

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbMarcaProdutos).HasForeignKey(d => d.FkTbRede);
        });

        modelBuilder.Entity<TbMatriz>(entity =>
        {
            entity.HasKey(e => e.IdMatriz);

            entity.ToTable("tb_matriz");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_matriz");

            entity.Property(e => e.IdMatriz).HasColumnName("id_matriz");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");
            entity.Property(e => e.MtCnpj)
                .HasColumnType("varchar(18)")
                .HasColumnName("mt_cnpj");
            entity.Property(e => e.MtDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mt_desat");
            entity.Property(e => e.MtDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mt_dtAcs");
            entity.Property(e => e.MtDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mt_dtAlt");
            entity.Property(e => e.MtDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mt_dtCri");
            entity.Property(e => e.MtEfetuaTestesEletro)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mt_efetuaTestesEletro");
            entity.Property(e => e.MtHrAbertLj)
                .HasColumnType("smallint")
                .HasColumnName("mt_hrAbertLj");
            entity.Property(e => e.MtHrFchLj)
                .HasColumnType("smallint")
                .HasColumnName("mt_hrFchLj");
            entity.Property(e => e.MtNomeFant)
                .HasColumnType("varchar(60)")
                .HasColumnName("mt_nomeFant");
            entity.Property(e => e.MtPersTim)
                .HasColumnType("tinyint")
                .HasColumnName("mt_persTim");
            entity.Property(e => e.MtRazSoc)
                .HasColumnType("varchar(60)")
                .HasColumnName("mt_razSoc");

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbMatrizs).HasForeignKey(d => d.FkTbRede);
        });

        modelBuilder.Entity<TbMovimentacao>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacao);

            entity.ToTable("tb_movimentacao");

            entity.HasIndex(e => e.FkTbAtorAtend, "ifk_tb_ator_atend_tb_movimentacao");

            entity.HasIndex(e => e.FkTbAtorDest, "ifk_tb_ator_dest_tb_movimentacao");

            entity.HasIndex(e => e.FkTbAtorEmit, "ifk_tb_ator_emit_tb_movimentacao");

            entity.HasIndex(e => e.FkTbClasCont2, "ifk_tb_clasCont2_tb_movimentacao");

            entity.HasIndex(e => e.FkTbJornada, "ifk_tb_jornada_tb_movimentacao");

            entity.Property(e => e.IdMovimentacao).HasColumnName("id_movimentacao");
            entity.Property(e => e.FkTbAtorAtend).HasColumnName("fk_tb_ator_atend");
            entity.Property(e => e.FkTbAtorDest).HasColumnName("fk_tb_ator_dest");
            entity.Property(e => e.FkTbAtorEmit).HasColumnName("fk_tb_ator_emit");
            entity.Property(e => e.FkTbClasCont2).HasColumnName("fk_tb_clasCont2");
            entity.Property(e => e.FkTbJornada).HasColumnName("fk_tb_jornada");
            entity.Property(e => e.MvCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mv_canc");
            entity.Property(e => e.MvCodSeqAbertFechCx)
                .HasColumnType("bigint")
                .HasColumnName("mv_codSeqAbertFechCx");
            entity.Property(e => e.MvConc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mv_conc");
            entity.Property(e => e.MvCpfTmp)
                .HasColumnType("varchar(11)")
                .HasColumnName("mv_cpf_tmp");
            entity.Property(e => e.MvCxAberto)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mv_cxAberto");
            entity.Property(e => e.MvDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mv_dtAcs");
            entity.Property(e => e.MvDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mv_dtAlt");
            entity.Property(e => e.MvDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mv_dtCri");
            entity.Property(e => e.MvMovAbertCx).HasColumnName("mv_movAbertCx");
            entity.Property(e => e.MvMovTipo)
                .HasColumnType("smallint")
                .HasColumnName("mv_movTipo");
            entity.Property(e => e.MvNfeBcIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeBcIcms");
            entity.Property(e => e.MvNfeCfop)
                .HasColumnType("varchar(3)")
                .HasColumnName("mv_nfeCfop");
            entity.Property(e => e.MvNfeChave)
                .HasColumnType("varchar(50)")
                .HasColumnName("mv_nfeChave");
            entity.Property(e => e.MvNfeDtEmis)
                .HasColumnType("DATETIME")
                .HasColumnName("mv_nfeDtEmis");
            entity.Property(e => e.MvNfeEnfilGer)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mv_nfeEnfilGer");
            entity.Property(e => e.MvNfeFinEmis)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeFinEmis");
            entity.Property(e => e.MvNfeIdentLocDestOp)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeIdentLocDestOp");
            entity.Property(e => e.MvNfeIndInterm)
                .HasColumnType("INT")
                .HasColumnName("mv_nfeIndInterm");
            entity.Property(e => e.MvNfeIndOpConsumFin)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeIndOpConsumFin");
            entity.Property(e => e.MvNfeIndPresCompEstMomOp)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeIndPresCompEstMomOp");
            entity.Property(e => e.MvNfeMod)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeMod");
            entity.Property(e => e.MvNfeModFrete)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeModFrete");
            entity.Property(e => e.MvNfeNatOp)
                .HasColumnType("varchar(60)")
                .HasColumnName("mv_nfeNatOp");
            entity.Property(e => e.MvNfeProcEmis)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeProcEmis");
            entity.Property(e => e.MvNfeTipo)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeTipo");
            entity.Property(e => e.MvNfeTipoAmb)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeTipoAmb");
            entity.Property(e => e.MvNfeTipoDfe)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeTipoDfe");
            entity.Property(e => e.MvNfeTipoEmis)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeTipoEmis");
            entity.Property(e => e.MvNfeTipoImpDanfe)
                .HasColumnType("tinyint")
                .HasColumnName("mv_nfeTipoImpDanfe");
            entity.Property(e => e.MvNfeVerProcEmis)
                .HasColumnType("varchar(20)")
                .HasColumnName("mv_nfeVerProcEmis");
            entity.Property(e => e.MvNfeVlrBcIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrBcIcmsSt");
            entity.Property(e => e.MvNfeVlrIcmsDeson)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrIcmsDeson");
            entity.Property(e => e.MvNfeVlrTotCofins)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotCofins");
            entity.Property(e => e.MvNfeVlrTotDesc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotDesc");
            entity.Property(e => e.MvNfeVlrTotFcp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotFcp");
            entity.Property(e => e.MvNfeVlrTotFcpRetSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotFcpRetSt");
            entity.Property(e => e.MvNfeVlrTotFcpSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotFcpSt");
            entity.Property(e => e.MvNfeVlrTotFrete)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotFrete");
            entity.Property(e => e.MvNfeVlrTotIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotIcms");
            entity.Property(e => e.MvNfeVlrTotIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotIcmsSt");
            entity.Property(e => e.MvNfeVlrTotImpImp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotImpImp");
            entity.Property(e => e.MvNfeVlrTotIpi)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotIpi");
            entity.Property(e => e.MvNfeVlrTotIpiDevol)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotIpiDevol");
            entity.Property(e => e.MvNfeVlrTotNf)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotNF");
            entity.Property(e => e.MvNfeVlrTotOutro)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotOutro");
            entity.Property(e => e.MvNfeVlrTotPis)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotPis");
            entity.Property(e => e.MvNfeVlrTotProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotProd");
            entity.Property(e => e.MvNfeVlrTotSeg)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotSeg");
            entity.Property(e => e.MvNfeVlrTotTrib)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTotTrib");
            entity.Property(e => e.MvNfeVlrTroco)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_nfeVlrTroco");
            entity.Property(e => e.MvNfeXmlProcRes).HasColumnName("mv_nfeXmlProcRes");
            entity.Property(e => e.MvNumSeq)
                .HasColumnType("bigint")
                .HasColumnName("mv_numSeq");
            entity.Property(e => e.MvQtdItens)
                .HasColumnType("bigint")
                .HasColumnName("mv_qtdItens");
            entity.Property(e => e.MvQuit)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mv_quit");
            entity.Property(e => e.MvVlrTotPag)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mv_vlrTotPag");

            entity.HasOne(d => d.FkTbAtorAtendNavigation).WithMany(p => p.TbMovimentacaoFkTbAtorAtendNavigations).HasForeignKey(d => d.FkTbAtorAtend);

            entity.HasOne(d => d.FkTbAtorDestNavigation).WithMany(p => p.TbMovimentacaoFkTbAtorDestNavigations).HasForeignKey(d => d.FkTbAtorDest);

            entity.HasOne(d => d.FkTbAtorEmitNavigation).WithMany(p => p.TbMovimentacaoFkTbAtorEmitNavigations).HasForeignKey(d => d.FkTbAtorEmit);

            entity.HasOne(d => d.FkTbClasCont2Navigation).WithMany(p => p.TbMovimentacaos).HasForeignKey(d => d.FkTbClasCont2);

            entity.HasOne(d => d.FkTbJornadaNavigation).WithMany(p => p.TbMovimentacaos).HasForeignKey(d => d.FkTbJornada);
        });

        modelBuilder.Entity<TbMovimentacaoCaixa>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacaoCaixa);

            entity.ToTable("tb_movimentacao_caixa");

            entity.HasIndex(e => e.FkTbMovimentacao, "ifk_tb_movimentacao_tb_movimentacao_caixa");

            entity.Property(e => e.IdMovimentacaoCaixa).HasColumnName("id_movimentacao_caixa");
            entity.Property(e => e.FkTbMovimentacao).HasColumnName("fk_tb_movimentacao");
            entity.Property(e => e.McCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mc_canc");

            entity.HasOne(d => d.FkTbMovimentacaoNavigation).WithMany(p => p.TbMovimentacaoCaixas).HasForeignKey(d => d.FkTbMovimentacao);
        });

        modelBuilder.Entity<TbMovimentacaoImpressao>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacaoImpressao);

            entity.ToTable("tb_movimentacao_impressao");

            entity.HasIndex(e => e.FkTbMovimentacao, "ifk_tb_movimentacao_tb_movimentacao_impressao");

            entity.Property(e => e.IdMovimentacaoImpressao).HasColumnName("id_movimentacao_impressao");
            entity.Property(e => e.FkTbMovimentacao).HasColumnName("fk_tb_movimentacao");
            entity.Property(e => e.MiDcanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mi_dcanc");
            entity.Property(e => e.MiDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mi_dtAcs");
            entity.Property(e => e.MiDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mi_dtAlt");
            entity.Property(e => e.MiDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mi_dtCri");
            entity.Property(e => e.MiPdf).HasColumnName("mi_pdf");
            entity.Property(e => e.MiTipo)
                .HasColumnType("tinyint")
                .HasColumnName("mi_tipo");

            entity.HasOne(d => d.FkTbMovimentacaoNavigation).WithMany(p => p.TbMovimentacaoImpressaos).HasForeignKey(d => d.FkTbMovimentacao);
        });

        modelBuilder.Entity<TbMovimentacaoPagamento>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacaoPagamento);

            entity.ToTable("tb_movimentacao_pagamento");

            entity.HasIndex(e => e.FkTbMovimentacao, "ifk_tb_movimentacao_tb_movimentacao_pagamento");

            entity.HasIndex(e => e.FkTbSubFormaPagamento, "ifk_tb_sub_forma_pagamento_tb_movimentacao_pagamento");

            entity.Property(e => e.IdMovimentacaoPagamento).HasColumnName("id_movimentacao_pagamento");
            entity.Property(e => e.FkTbMovimentacao).HasColumnName("fk_tb_movimentacao");
            entity.Property(e => e.FkTbSubFormaPagamento).HasColumnName("fk_tb_sub_forma_pagamento");
            entity.Property(e => e.MpgCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mpg_canc");
            entity.Property(e => e.MpgDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mpg_dtAcs");
            entity.Property(e => e.MpgDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mpg_dtAlt");
            entity.Property(e => e.MpgDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mpg_dtCri");
            entity.Property(e => e.MpgNfeNumAut)
                .HasColumnType("varchar(20)")
                .HasColumnName("mpg_nfeNumAut");
            entity.Property(e => e.MpgNfeTipoBand)
                .HasColumnType("tinyint")
                .HasColumnName("mpg_nfeTipoBand");
            entity.Property(e => e.MpgNfeTipoIntegr)
                .HasColumnType("tinyint")
                .HasColumnName("mpg_nfeTipoIntegr");
            entity.Property(e => e.MpgNfeVlrMov)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpg_nfeVlrMov");
            entity.Property(e => e.MpgNfeVlrPag)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpg_nfeVlrPag");
            entity.Property(e => e.MpgNfeVlrTroco)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpg_nfeVlrTroco");
            entity.Property(e => e.MpgNumPag)
                .HasColumnType("smallint")
                .HasColumnName("mpg_numPag");
            entity.Property(e => e.MpgParcs)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpg_parcs");

            entity.HasOne(d => d.FkTbMovimentacaoNavigation).WithMany(p => p.TbMovimentacaoPagamentos).HasForeignKey(d => d.FkTbMovimentacao);

            entity.HasOne(d => d.FkTbSubFormaPagamentoNavigation).WithMany(p => p.TbMovimentacaoPagamentos).HasForeignKey(d => d.FkTbSubFormaPagamento);
        });

        modelBuilder.Entity<TbMovimentacaoPagamentoParcela>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacaoPagamentoParcela);

            entity.ToTable("tb_movimentacao_pagamento_parcela");

            entity.HasIndex(e => e.FkTbMovimentacaoPagamento, "ifk_tb_movimentacao_pagamento_tb_movimentacao_pagamento_parcela");

            entity.HasIndex(e => e.FkTbSubFormaPagamento, "ifk_tb_sub_forma_pagamento_tb_movimentacao_pagamento_parcela");

            entity.Property(e => e.IdMovimentacaoPagamentoParcela).HasColumnName("id_movimentacao_pagamento_parcela");
            entity.Property(e => e.FkTbMovimentacaoPagamento).HasColumnName("fk_tb_movimentacao_pagamento");
            entity.Property(e => e.FkTbSubFormaPagamento).HasColumnName("fk_tb_sub_forma_pagamento");
            entity.Property(e => e.MppCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mpp_canc");
            entity.Property(e => e.MppDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mpp_dtAcs");
            entity.Property(e => e.MppDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mpp_dtAlt");
            entity.Property(e => e.MppDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mpp_dtCri");
            entity.Property(e => e.MppDtVenc)
                .HasColumnType("DATETIME")
                .HasColumnName("mpp_dtVenc");
            entity.Property(e => e.MppNumParc)
                .HasColumnType("smallint")
                .HasColumnName("mpp_numParc");
            entity.Property(e => e.MppQtdParc)
                .HasColumnType("smallint")
                .HasColumnName("mpp_qtdParc");
            entity.Property(e => e.MppTaxaParc)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mpp_taxaParc");
            entity.Property(e => e.MppVlrCli)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpp_vlrCli");
            entity.Property(e => e.MppVlrRec)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mpp_vlrRec");

            entity.HasOne(d => d.FkTbMovimentacaoPagamentoNavigation).WithMany(p => p.TbMovimentacaoPagamentoParcelas).HasForeignKey(d => d.FkTbMovimentacaoPagamento);

            entity.HasOne(d => d.FkTbSubFormaPagamentoNavigation).WithMany(p => p.TbMovimentacaoPagamentoParcelas).HasForeignKey(d => d.FkTbSubFormaPagamento);
        });

        modelBuilder.Entity<TbMovimentacaoProduto>(entity =>
        {
            entity.HasKey(e => e.IdMovimentacaoProduto);

            entity.ToTable("tb_movimentacao_produto");

            entity.HasIndex(e => e.FkTbAtorAtend, "ifk_tb_atorAtend_tb_movimentacao_produto");

            entity.HasIndex(e => e.FkTbMovimentacao, "ifk_tb_movimentacao_tb_movimentacao_produto");

            entity.HasIndex(e => e.FkTbProduto, "ifk_tb_produto_tb_movimentacao_produto");

            entity.Property(e => e.IdMovimentacaoProduto).HasColumnName("id_movimentacao_produto");
            entity.Property(e => e.FkTbAtorAtend).HasColumnName("fk_tb_atorAtend");
            entity.Property(e => e.FkTbMovimentacao).HasColumnName("fk_tb_movimentacao");
            entity.Property(e => e.FkTbNcm).HasColumnName("fk_tb_ncm");
            entity.Property(e => e.FkTbProduto).HasColumnName("fk_tb_produto");
            entity.Property(e => e.MpCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mp_canc");
            entity.Property(e => e.MpCest)
                .HasColumnType("varchar(7)")
                .HasColumnName("mp_cest");
            entity.Property(e => e.MpCodRef)
                .HasColumnType("bigint")
                .HasColumnName("mp_codRef");
            entity.Property(e => e.MpDesc)
                .HasColumnType("varchar(120)")
                .HasColumnName("mp_desc");
            entity.Property(e => e.MpDescCurta)
                .HasColumnType("varchar(25)")
                .HasColumnName("mp_descCurta");
            entity.Property(e => e.MpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtAcs");
            entity.Property(e => e.MpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtAlt");
            entity.Property(e => e.MpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("mp_dtCri");
            entity.Property(e => e.MpEan)
                .HasColumnType("varchar(15)")
                .HasColumnName("mp_ean");
            entity.Property(e => e.MpMovProOrig).HasColumnName("mp_movProOrig");
            entity.Property(e => e.MpNfeAliqIcms)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfeAliqIcms");
            entity.Property(e => e.MpNfeAliqIcmsInterUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeAliqIcmsInterUfDest");
            entity.Property(e => e.MpNfeAliqIcmsSt)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfeAliqIcmsSt");
            entity.Property(e => e.MpNfeAliqIcmsUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeAliqIcmsUfDest");
            entity.Property(e => e.MpNfeBcFcpRetAnt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeBcFcpRetAnt");
            entity.Property(e => e.MpNfeCfop)
                .HasColumnType("INT")
                .HasColumnName("mp_nfeCfop");
            entity.Property(e => e.MpNfeCfopImpXml)
                .HasColumnType("smallint")
                .HasColumnName("mp_nfeCfop_ImpXml");
            entity.Property(e => e.MpNfeCofinsAliq)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliq");
            entity.Property(e => e.MpNfeCofinsAliqImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliq_ImpXml");
            entity.Property(e => e.MpNfeCofinsAliqProdSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqProdST");
            entity.Property(e => e.MpNfeCofinsAliqSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqST");
            entity.Property(e => e.MpNfeCofinsAliqVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqVlr");
            entity.Property(e => e.MpNfeCofinsAliqVlrBc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqVlrBc");
            entity.Property(e => e.MpNfeCofinsAliqVlrBcImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqVlrBc_ImpXml");
            entity.Property(e => e.MpNfeCofinsAliqVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsAliqVlr_ImpXml");
            entity.Property(e => e.MpNfeCofinsOutrAliq)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrAliq");
            entity.Property(e => e.MpNfeCofinsOutrAliqImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrAliq_ImpXml");
            entity.Property(e => e.MpNfeCofinsOutrAliqProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrAliqProd");
            entity.Property(e => e.MpNfeCofinsOutrBcProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrBcProd");
            entity.Property(e => e.MpNfeCofinsOutrBcProdImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrBcProd_ImpXml");
            entity.Property(e => e.MpNfeCofinsOutrBcVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrBcVlr");
            entity.Property(e => e.MpNfeCofinsOutrBcVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrBcVlr_ImpXml");
            entity.Property(e => e.MpNfeCofinsOutrVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrVlr");
            entity.Property(e => e.MpNfeCofinsOutrVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsOutrVlr_ImpXml");
            entity.Property(e => e.MpNfeCofinsQtdeAliqProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeAliqProd");
            entity.Property(e => e.MpNfeCofinsQtdeBcProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeBcProd");
            entity.Property(e => e.MpNfeCofinsQtdeBcProdImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeBcProd_ImpXml");
            entity.Property(e => e.MpNfeCofinsQtdeBcProdSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeBcProdST");
            entity.Property(e => e.MpNfeCofinsQtdeBcProdStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeBcProdST_ImpXml");
            entity.Property(e => e.MpNfeCofinsQtdeVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeVlr");
            entity.Property(e => e.MpNfeCofinsQtdeVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsQtdeVlr_ImpXml");
            entity.Property(e => e.MpNfeCofinsVlrBcSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsVlrBcST");
            entity.Property(e => e.MpNfeCofinsVlrBcStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsVlrBcST_ImpXml");
            entity.Property(e => e.MpNfeCofinsVlrSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsVlrST");
            entity.Property(e => e.MpNfeCofinsVlrStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeCofinsVlrST_ImpXml");
            entity.Property(e => e.MpNfeCsosn)
                .HasColumnType("smallint")
                .HasColumnName("mp_nfeCsosn");
            entity.Property(e => e.MpNfeCst)
                .HasColumnType("smallint")
                .HasColumnName("mp_nfeCst");
            entity.Property(e => e.MpNfeImpImpVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeImpImpVlr");
            entity.Property(e => e.MpNfeImpImpVlrBc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeImpImpVlrBc");
            entity.Property(e => e.MpNfeImpImpVlrDespAdu)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeImpImpVlrDespAdu");
            entity.Property(e => e.MpNfeImpImpVlrIof)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeImpImpVlrIof");
            entity.Property(e => e.MpNfeIndValProdTotNfe)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeIndValProdTotNfe");
            entity.Property(e => e.MpNfeIpiCnpjProd)
                .HasColumnType("varchar(18)")
                .HasColumnName("mp_nfeIpiCnpjProd");
            entity.Property(e => e.MpNfeIpiCselo)
                .HasColumnType("varchar(60)")
                .HasColumnName("mp_nfeIpiCSelo");
            entity.Property(e => e.MpNfeIpiIpintCst)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeIpiIpintCst");
            entity.Property(e => e.MpNfeIpiQselo)
                .HasColumnType("INT")
                .HasColumnName("mp_nfeIpiQSelo");
            entity.Property(e => e.MpNfeIpiTribCst)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeIpiTribCst");
            entity.Property(e => e.MpNfeIpiTribXml1PercIpi)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml1PercIPI");
            entity.Property(e => e.MpNfeIpiTribXml1VlrBc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml1VlrBC");
            entity.Property(e => e.MpNfeIpiTribXml1VlrBcImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml1VlrBC_ImpXml");
            entity.Property(e => e.MpNfeIpiTribXml2VlrIpi)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml2VlrIpi");
            entity.Property(e => e.MpNfeIpiTribXml2VlrIpiImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml2VlrIpi_ImpXml");
            entity.Property(e => e.MpNfeIpiTribXml2VlrUnit)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml2VlrUnit");
            entity.Property(e => e.MpNfeIpiTribXml2qUnid)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeIpiTribXml2qUnid");
            entity.Property(e => e.MpNfeIpicEnq)
                .HasColumnType("varchar(3)")
                .HasColumnName("mp_nfeIpicEnq");
            entity.Property(e => e.MpNfeModBc)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeModBc");
            entity.Property(e => e.MpNfeModBcSt)
                .HasColumnType("INT")
                .HasColumnName("mp_nfeModBcSt");
            entity.Property(e => e.MpNfeMotDesonIcms)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeMotDesonIcms");
            entity.Property(e => e.MpNfeNcmImpXml)
                .HasColumnType("varchar(8)")
                .HasColumnName("mp_nfeNcm_ImpXml");
            entity.Property(e => e.MpNfePercAliqCredSn)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercAliqCredSn");
            entity.Property(e => e.MpNfePercAliqIcmsEfet)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercAliqIcmsEfet");
            entity.Property(e => e.MpNfePercAliqSuportada)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercAliqSuportada");
            entity.Property(e => e.MpNfePercDif)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercDif");
            entity.Property(e => e.MpNfePercFcp)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercFcp");
            entity.Property(e => e.MpNfePercFcpRetAntSt)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercFcpRetAntSt");
            entity.Property(e => e.MpNfePercFcpRetSt)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercFcpRetSt");
            entity.Property(e => e.MpNfePercFcpUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePercFcpUfDest");
            entity.Property(e => e.MpNfePercIcmsPartUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePercIcmsPartUfDest");
            entity.Property(e => e.MpNfePercMvaSt)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercMvaSt");
            entity.Property(e => e.MpNfePercRedBcEfet)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercRedBcEfet");
            entity.Property(e => e.MpNfePercRedBcIcms)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercRedBcIcms");
            entity.Property(e => e.MpNfePercRedBcIcmsSt)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("mp_nfePercRedBcIcmsSt");
            entity.Property(e => e.MpNfePisAliq)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliq");
            entity.Property(e => e.MpNfePisAliqImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliq_ImpXml");
            entity.Property(e => e.MpNfePisAliqProdSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqProdST");
            entity.Property(e => e.MpNfePisAliqSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqST");
            entity.Property(e => e.MpNfePisAliqVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqVlr");
            entity.Property(e => e.MpNfePisAliqVlrBc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqVlrBc");
            entity.Property(e => e.MpNfePisAliqVlrBcImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqVlrBc_ImpXml");
            entity.Property(e => e.MpNfePisAliqVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisAliqVlr_ImpXml");
            entity.Property(e => e.MpNfePisCofinsCst)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfePisCofinsCst");
            entity.Property(e => e.MpNfePisCofinsReg)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfePisCofinsReg");
            entity.Property(e => e.MpNfePisOutrAliq)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrAliq");
            entity.Property(e => e.MpNfePisOutrAliqImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrAliq_ImpXml");
            entity.Property(e => e.MpNfePisOutrBcVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrBcVlr");
            entity.Property(e => e.MpNfePisOutrBcVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrBcVlr_ImpXml");
            entity.Property(e => e.MpNfePisOutrVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrVlr");
            entity.Property(e => e.MpNfePisOutrVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisOutrVlr_ImpXml");
            entity.Property(e => e.MpNfePisQtdeAliqProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeAliqProd");
            entity.Property(e => e.MpNfePisQtdeBcProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeBcProd");
            entity.Property(e => e.MpNfePisQtdeBcProdSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeBcProdST");
            entity.Property(e => e.MpNfePisQtdeBcProdStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeBcProdST_ImpXml");
            entity.Property(e => e.MpNfePisQtdeVlr)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeVlr");
            entity.Property(e => e.MpNfePisQtdeVlrImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisQtdeVlr_ImpXml");
            entity.Property(e => e.MpNfePisVlrBcSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisVlrBcST");
            entity.Property(e => e.MpNfePisVlrBcStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisVlrBcST_ImpXml");
            entity.Property(e => e.MpNfePisVlrSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisVlrST");
            entity.Property(e => e.MpNfePisVlrStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfePisVlrST_ImpXml");
            entity.Property(e => e.MpNfeProdOrigem)
                .HasColumnType("tinyint")
                .HasColumnName("mp_nfeProdOrigem");
            entity.Property(e => e.MpNfeVlrBcEfet)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcEfet");
            entity.Property(e => e.MpNfeVlrBcFcp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcFcp");
            entity.Property(e => e.MpNfeVlrBcFcpImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcFcp_ImpXml");
            entity.Property(e => e.MpNfeVlrBcFcpRetSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcFcpRetSt");
            entity.Property(e => e.MpNfeVlrBcFcpUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcFcpUfDest");
            entity.Property(e => e.MpNfeVlrBcFcpUfDestImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcFcpUfDest_ImpXml");
            entity.Property(e => e.MpNfeVlrBcIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcms");
            entity.Property(e => e.MpNfeVlrBcIcmsImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcms_ImpXml");
            entity.Property(e => e.MpNfeVlrBcIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcmsSt");
            entity.Property(e => e.MpNfeVlrBcIcmsStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcmsSt_ImpXml");
            entity.Property(e => e.MpNfeVlrBcIcmsStRet)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcmsStRet");
            entity.Property(e => e.MpNfeVlrBcIcmsUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcmsUfDest");
            entity.Property(e => e.MpNfeVlrBcIcmsUfDestImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrBcIcmsUfDest_ImpXml");
            entity.Property(e => e.MpNfeVlrCredIcmsSn)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrCredIcmsSn");
            entity.Property(e => e.MpNfeVlrFcp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrFcp");
            entity.Property(e => e.MpNfeVlrFcpRetSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrFcpRetSt");
            entity.Property(e => e.MpNfeVlrFcpUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrFcpUfDest");
            entity.Property(e => e.MpNfeVlrIcmsDeson)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsDeson");
            entity.Property(e => e.MpNfeVlrIcmsDesonImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsDeson_ImpXml");
            entity.Property(e => e.MpNfeVlrIcmsDif)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsDif");
            entity.Property(e => e.MpNfeVlrIcmsDifImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsDif_ImpXml");
            entity.Property(e => e.MpNfeVlrIcmsEfet)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsEfet");
            entity.Property(e => e.MpNfeVlrIcmsOp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsOp");
            entity.Property(e => e.MpNfeVlrIcmsOpImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsOp_ImpXml");
            entity.Property(e => e.MpNfeVlrIcmsPropSubst)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsPropSubst");
            entity.Property(e => e.MpNfeVlrIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsSt");
            entity.Property(e => e.MpNfeVlrIcmsStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsSt_ImpXml");
            entity.Property(e => e.MpNfeVlrIcmsStRet)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsStRet");
            entity.Property(e => e.MpNfeVlrIcmsUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsUfDest");
            entity.Property(e => e.MpNfeVlrIcmsUfDestImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsUfDest_ImpXml");
            entity.Property(e => e.MpNfeVlrIcmsUfRemet)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsUfRemet");
            entity.Property(e => e.MpNfeVlrIcmsUfRemetImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrIcmsUfRemet_ImpXml");
            entity.Property(e => e.MpNfeVlrTotIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrTotIcms");
            entity.Property(e => e.MpNfeVlrTotIcmsImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_nfeVlrTotIcms_ImpXml");
            entity.Property(e => e.MpNumItem)
                .HasColumnType("smallint")
                .HasColumnName("mp_numItem");
            entity.Property(e => e.MpObs).HasColumnName("mp_obs");
            entity.Property(e => e.MpPisCofinsIncidencia)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mp_pisCofinsIncidencia");
            entity.Property(e => e.MpQtdAud)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_qtdAud");
            entity.Property(e => e.MpQtdCom)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("mp_qtdCom");
            entity.Property(e => e.MpQtdDevolver)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("mp_qtdDevolver");
            entity.Property(e => e.MpQtdDevolvida)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("mp_qtdDevolvida");
            entity.Property(e => e.MpTipoDesc)
                .HasColumnType("nchar(1)")
                .HasColumnName("mp_tipoDesc");
            entity.Property(e => e.MpUnMedCom)
                .HasColumnType("tinyint")
                .HasColumnName("mp_unMedCom");
            entity.Property(e => e.MpUnMedComImpXml)
                .HasColumnType("varchar(10)")
                .HasColumnName("mp_unMedCom_ImpXml");
            entity.Property(e => e.MpVlrDesc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrDesc");
            entity.Property(e => e.MpVlrFrete)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrFrete");
            entity.Property(e => e.MpVlrFreteImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrFrete_ImpXml");
            entity.Property(e => e.MpVlrOutro)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrOutro");
            entity.Property(e => e.MpVlrProdTot)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrProdTot");
            entity.Property(e => e.MpVlrProdTotImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrProdTot_ImpXml");
            entity.Property(e => e.MpVlrSeg)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrSeg");
            entity.Property(e => e.MpVlrUnCom)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("mp_vlrUnCom");

            entity.HasOne(d => d.FkTbAtorAtendNavigation).WithMany(p => p.TbMovimentacaoProdutos).HasForeignKey(d => d.FkTbAtorAtend);

            entity.HasOne(d => d.FkTbMovimentacaoNavigation).WithMany(p => p.TbMovimentacaoProdutos).HasForeignKey(d => d.FkTbMovimentacao);

            entity.HasOne(d => d.FkTbProdutoNavigation).WithMany(p => p.TbMovimentacaoProdutos).HasForeignKey(d => d.FkTbProduto);
        });

        modelBuilder.Entity<TbMunicipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio);

            entity.ToTable("tb_municipio");

            entity.HasIndex(e => e.FkTbEstadosBr, "ifk_tb_estados_br_tb_municipio");

            entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");
            entity.Property(e => e.FkTbEstadosBr).HasColumnName("fk_tb_estados_br");
            entity.Property(e => e.MuDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("mu_desat");
            entity.Property(e => e.MuId)
                .HasColumnType("INT")
                .HasColumnName("mu_id");
            entity.Property(e => e.MuNome)
                .HasColumnType("varchar(40)")
                .HasColumnName("mu_nome");

            entity.HasOne(d => d.FkTbEstadosBrNavigation).WithMany(p => p.TbMunicipios).HasForeignKey(d => d.FkTbEstadosBr);
        });

        modelBuilder.Entity<TbNcm>(entity =>
        {
            entity.HasKey(e => e.IdNcm);

            entity.ToTable("tb_ncm");

            entity.Property(e => e.IdNcm).HasColumnName("id_ncm");
            entity.Property(e => e.NcAnoDoAto)
                .HasColumnType("varchar(10)")
                .HasColumnName("nc_anoDoAto");
            entity.Property(e => e.NcDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nc_desat");
            entity.Property(e => e.NcDesc)
                .HasColumnType("varchar(2048)")
                .HasColumnName("nc_desc");
            entity.Property(e => e.NcDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("nc_dtAcs");
            entity.Property(e => e.NcDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("nc_dtAlt");
            entity.Property(e => e.NcDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("nc_dtCri");
            entity.Property(e => e.NcDtFim)
                .HasColumnType("DATETIME")
                .HasColumnName("nc_dtFim");
            entity.Property(e => e.NcDtIni)
                .HasColumnType("DATETIME")
                .HasColumnName("nc_dtIni");
            entity.Property(e => e.NcNcmBase)
                .HasColumnType("varchar(8)")
                .HasColumnName("nc_ncmBase");
            entity.Property(e => e.NcNcmFull)
                .HasColumnType("varchar(8)")
                .HasColumnName("nc_ncmFull");
            entity.Property(e => e.NcNumAto)
                .HasColumnType("INT")
                .HasColumnName("nc_numAto");
            entity.Property(e => e.NcParentOid).HasColumnName("nc_parentOid");
            entity.Property(e => e.NcRootNcm)
                .HasColumnType("varchar(2)")
                .HasColumnName("nc_rootNcm");
        });

        modelBuilder.Entity<TbNfe>(entity =>
        {
            entity.HasKey(e => e.IdNfe);

            entity.ToTable("tb_nfe");

            entity.HasIndex(e => e.FkTbMovimentacao, "ifk_tb_movimentacao_tb_nfe");

            entity.Property(e => e.IdNfe).HasColumnName("id_nfe");
            entity.Property(e => e.FkTbMovimentacao).HasColumnName("fk_tb_movimentacao");
            entity.Property(e => e.NfDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_desat");
            entity.Property(e => e.NfDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_dtAcs");
            entity.Property(e => e.NfDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_dtAlt");
            entity.Property(e => e.NfDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_dtCri");
            entity.Property(e => e.NfNfe1ConteudoXmloriginalOuterXml).HasColumnName("nf_nfe1ConteudoXMLOriginalOuterXml");
            entity.Property(e => e.NfNfe1Cstat)
                .HasColumnType("INT")
                .HasColumnName("nf_nfe1CStat");
            entity.Property(e => e.NfNfe1DhRecbto)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfe1DhRecbto");
            entity.Property(e => e.NfNfe1ResProtNfeInfProt0ChNfe).HasColumnName("nf_nfe1ResProtNFeInfProt0ChNFe");
            entity.Property(e => e.NfNfe1ResProtNfeInfProt0Cstat)
                .HasColumnType("INT")
                .HasColumnName("nf_nfe1ResProtNFeInfProt0CStat");
            entity.Property(e => e.NfNfe1ResProtNfeInfProt0DhRecbto)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfe1ResProtNFeInfProt0DhRecbto");
            entity.Property(e => e.NfNfe1ResProtNfeInfProt0Nprot)
                .HasColumnType("varchar(30)")
                .HasColumnName("nf_nfe1ResProtNFeInfProt0NProt");
            entity.Property(e => e.NfNfe1ResProtNfeInfProt0Xmotivo).HasColumnName("nf_nfe1ResProtNFeInfProt0XMotivo");
            entity.Property(e => e.NfNfe1RetornoWsstring).HasColumnName("nf_nfe1RetornoWSString");
            entity.Property(e => e.NfNfe1WsxmlinnerText).HasColumnName("nf_nfe1WSXMLInnerText");
            entity.Property(e => e.NfNfe1Xmotivo).HasColumnName("nf_nfe1XMotivo");
            entity.Property(e => e.NfNfe2ConteudoXmlouterXml).HasColumnName("nf_nfe2ConteudoXMLOuterXml");
            entity.Property(e => e.NfNfe2ResCstat)
                .HasColumnType("INT")
                .HasColumnName("nf_nfe2ResCStat");
            entity.Property(e => e.NfNfe2ResDhRecbto)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfe2ResDhRecbto");
            entity.Property(e => e.NfNfe2ResNrec).HasColumnName("nf_nfe2ResNRec");
            entity.Property(e => e.NfNfe2ResProtNfeInfProt0ChNfe).HasColumnName("nf_nfe2ResProtNFeInfProt0ChNFe");
            entity.Property(e => e.NfNfe2ResProtNfeInfProt0Cstat)
                .HasColumnType("INT")
                .HasColumnName("nf_nfe2ResProtNFeInfProt0CStat");
            entity.Property(e => e.NfNfe2ResProtNfeInfProt0DhRecbto)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfe2ResProtNFeInfProt0DhRecbto");
            entity.Property(e => e.NfNfe2ResProtNfeInfProt0Xmotivo).HasColumnName("nf_nfe2ResProtNFeInfProt0XMotivo");
            entity.Property(e => e.NfNfe2RetornoWsstring).HasColumnName("nf_nfe2RetornoWSString");
            entity.Property(e => e.NfNfe2RetornoWsxmlinnerText).HasColumnName("nf_nfe2RetornoWSXMLInnerText");
            entity.Property(e => e.NfNfeArqProcAutDist).HasColumnName("nf_nfeArqProcAutDist");
            entity.Property(e => e.NfNfeArqProcAutDistImpXml).HasColumnName("nf_nfeArqProcAutDist_ImpXml");
            entity.Property(e => e.NfNfeBcIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeBcIcms");
            entity.Property(e => e.NfNfeBcIcmsImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeBcIcms_ImpXml");
            entity.Property(e => e.NfNfeCamArqProcAutDist)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeCamArqProcAutDist");
            entity.Property(e => e.NfNfeCamArqProcAutDistImpXml)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeCamArqProcAutDist_ImpXml");
            entity.Property(e => e.NfNfeCfop)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCfop");
            entity.Property(e => e.NfNfeCfopImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCfop_ImpXml");
            entity.Property(e => e.NfNfeChave)
                .HasColumnType("varchar(50)")
                .HasColumnName("nf_nfeChave");
            entity.Property(e => e.NfNfeChaveDv)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeChaveDv");
            entity.Property(e => e.NfNfeChaveDvImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeChaveDv_ImpXml");
            entity.Property(e => e.NfNfeChaveImpXml)
                .HasColumnType("varchar(50)")
                .HasColumnName("nf_nfeChave_ImpXml");
            entity.Property(e => e.NfNfeCod)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCod");
            entity.Property(e => e.NfNfeCodImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCod_ImpXml");
            entity.Property(e => e.NfNfeCodMunFg)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCodMunFg");
            entity.Property(e => e.NfNfeCodMunFg1).HasColumnName("nf_nfeCodMunFg_");
            entity.Property(e => e.NfNfeCodMunFgImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeCodMunFg_ImpXml");
            entity.Property(e => e.NfNfeCsosn)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCsosn");
            entity.Property(e => e.NfNfeCsosnImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCsosn_ImpXml");
            entity.Property(e => e.NfNfeCst)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCst");
            entity.Property(e => e.NfNfeCstImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCst_ImpXml");
            entity.Property(e => e.NfNfeCstat)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCstat");
            entity.Property(e => e.NfNfeCstatImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeCstat_ImpXml");
            entity.Property(e => e.NfNfeDhRecbto).HasColumnName("nf_nfeDhRecbto");
            entity.Property(e => e.NfNfeDhRecbtoImpXml).HasColumnName("nf_nfeDhRecbto_ImpXml");
            entity.Property(e => e.NfNfeDtAut)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeDtAut");
            entity.Property(e => e.NfNfeDtAutImpXml)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeDtAut_ImpXml");
            entity.Property(e => e.NfNfeDtEmis)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeDtEmis");
            entity.Property(e => e.NfNfeDtEmisImpXml)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeDtEmis_ImpXml");
            entity.Property(e => e.NfNfeEnvSfz)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeEnvSfz");
            entity.Property(e => e.NfNfeEnvSfzImpXml)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeEnvSfz_ImpXml");
            entity.Property(e => e.NfNfeFinEmis)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeFinEmis");
            entity.Property(e => e.NfNfeFinEmisImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeFinEmis_ImpXml");
            entity.Property(e => e.NfNfeHaProtSfz)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeHaProtSfz");
            entity.Property(e => e.NfNfeHaProtSfzImpXml)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeHaProtSfz_ImpXml");
            entity.Property(e => e.NfNfeIdentLocDestOp)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIdentLocDestOp");
            entity.Property(e => e.NfNfeIdentLocDestOpImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIdentLocDestOp_ImpXml");
            entity.Property(e => e.NfNfeIndInterm)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeIndInterm");
            entity.Property(e => e.NfNfeIndIntermImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeIndInterm_ImpXml");
            entity.Property(e => e.NfNfeIndOpConsumFin)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIndOpConsumFin");
            entity.Property(e => e.NfNfeIndOpConsumFinImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIndOpConsumFin_ImpXml");
            entity.Property(e => e.NfNfeIndPresCompEstMomOp)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIndPresCompEstMomOp");
            entity.Property(e => e.NfNfeIndPresCompEstMomOpImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeIndPresCompEstMomOp_ImpXml");
            entity.Property(e => e.NfNfeInfoCompl).HasColumnName("nf_nfeInfoCompl");
            entity.Property(e => e.NfNfeInfoComplImpXml).HasColumnName("nf_nfeInfoCompl_ImpXml");
            entity.Property(e => e.NfNfeMod)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeMod");
            entity.Property(e => e.NfNfeModFrete)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeModFrete");
            entity.Property(e => e.NfNfeModFreteImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeModFrete_ImpXml");
            entity.Property(e => e.NfNfeModImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeMod_ImpXml");
            entity.Property(e => e.NfNfeNatOp)
                .HasColumnType("varchar(60)")
                .HasColumnName("nf_nfeNatOp");
            entity.Property(e => e.NfNfeNomeArqProcAutDist)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeNomeArqProcAutDist");
            entity.Property(e => e.NfNfeNomeArqProcAutDistImpXml)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeNomeArqProcAutDist_ImpXml");
            entity.Property(e => e.NfNfeNum)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNum");
            entity.Property(e => e.NfNfeNumHom)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNumHom");
            entity.Property(e => e.NfNfeNumHomImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNumHom_ImpXml");
            entity.Property(e => e.NfNfeNumImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNum_ImpXml");
            entity.Property(e => e.NfNfeNumProd)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNumProd");
            entity.Property(e => e.NfNfeNumProdImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeNumProd_ImpXml");
            entity.Property(e => e.NfNfeNumProtAut)
                .HasColumnType("varchar(15)")
                .HasColumnName("nf_nfeNumProtAut");
            entity.Property(e => e.NfNfeNumProtAutImpXml)
                .HasColumnType("varchar(15)")
                .HasColumnName("nf_nfeNumProtAut_ImpXml");
            entity.Property(e => e.NfNfeProcAutExHres)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeProcAutExHRes");
            entity.Property(e => e.NfNfeProcAutExHresImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeProcAutExHRes_ImpXml");
            entity.Property(e => e.NfNfeProcAutExMsg).HasColumnName("nf_nfeProcAutExMsg");
            entity.Property(e => e.NfNfeProcAutExMsgImpXml).HasColumnName("nf_nfeProcAutExMsg_ImpXml");
            entity.Property(e => e.NfNfeProcEmis)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeProcEmis");
            entity.Property(e => e.NfNfeProcEmisImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeProcEmis_ImpXml");
            entity.Property(e => e.NfNfeProcResultsXmldist).HasColumnName("nf_nfeProcResultsXMLDist");
            entity.Property(e => e.NfNfeProdNumPulo)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeProdNumPulo");
            entity.Property(e => e.NfNfeRejSfz)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeRejSfz");
            entity.Property(e => e.NfNfeRejSfzImpXml)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeRejSfz_ImpXml");
            entity.Property(e => e.NfNfeSerie)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerie");
            entity.Property(e => e.NfNfeSerieHom)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerieHom");
            entity.Property(e => e.NfNfeSerieHomImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerieHom_ImpXml");
            entity.Property(e => e.NfNfeSerieImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerie_ImpXml");
            entity.Property(e => e.NfNfeSerieProd)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerieProd");
            entity.Property(e => e.NfNfeSerieProdImpXml)
                .HasColumnType("smallint")
                .HasColumnName("nf_nfeSerieProd_ImpXml");
            entity.Property(e => e.NfNfeServico)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeServico");
            entity.Property(e => e.NfNfeSit)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeSit");
            entity.Property(e => e.NfNfeSitImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeSit_ImpXml");
            entity.Property(e => e.NfNfeSolTransm)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeSolTransm");
            entity.Property(e => e.NfNfeSolTransmDt)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeSolTransmDt");
            entity.Property(e => e.NfNfeSolTransmDtImpXml)
                .HasColumnType("DATETIME")
                .HasColumnName("nf_nfeSolTransmDt_ImpXml");
            entity.Property(e => e.NfNfeSolTransmImpXml)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_nfeSolTransm_ImpXml");
            entity.Property(e => e.NfNfeTipo)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipo");
            entity.Property(e => e.NfNfeTipoAmb)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoAmb");
            entity.Property(e => e.NfNfeTipoAmbImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoAmb_ImpXml");
            entity.Property(e => e.NfNfeTipoDfe)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoDfe");
            entity.Property(e => e.NfNfeTipoDfeImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoDfe_ImpXml");
            entity.Property(e => e.NfNfeTipoEmis)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoEmis");
            entity.Property(e => e.NfNfeTipoEmisImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoEmis_ImpXml");
            entity.Property(e => e.NfNfeTipoImpDanfe)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoImpDanfe");
            entity.Property(e => e.NfNfeTipoImpDanfeImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipoImpDanfe_ImpXml");
            entity.Property(e => e.NfNfeTipoImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTipo_ImpXml");
            entity.Property(e => e.NfNfeTransmCorrigir).HasColumnName("nf_nfeTransmCorrigir");
            entity.Property(e => e.NfNfeTransmCorrigirImpXml).HasColumnName("nf_nfeTransmCorrigir_ImpXml");
            entity.Property(e => e.NfNfeTransmLog).HasColumnName("nf_nfeTransmLog");
            entity.Property(e => e.NfNfeTransmLogImpXml).HasColumnName("nf_nfeTransmLog_ImpXml");
            entity.Property(e => e.NfNfeTransmStatus)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTransmStatus");
            entity.Property(e => e.NfNfeTransmStatusImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeTransmStatus_ImpXml");
            entity.Property(e => e.NfNfeUf)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeUf");
            entity.Property(e => e.NfNfeUf1).HasColumnName("nf_nfeUf_");
            entity.Property(e => e.NfNfeUfImpXml)
                .HasColumnType("tinyint")
                .HasColumnName("nf_nfeUf_ImpXml");
            entity.Property(e => e.NfNfeVerProcEmis)
                .HasColumnType("varchar(20)")
                .HasColumnName("nf_nfeVerProcEmis");
            entity.Property(e => e.NfNfeVerProcEmisImpXml)
                .HasColumnType("varchar(20)")
                .HasColumnName("nf_nfeVerProcEmis_ImpXml");
            entity.Property(e => e.NfNfeVersao)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("nf_nfeVersao");
            entity.Property(e => e.NfNfeVersaoImpXml)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("nf_nfeVersao_ImpXml");
            entity.Property(e => e.NfNfeVlrBcIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrBcIcmsSt");
            entity.Property(e => e.NfNfeVlrBcIcmsStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrBcIcmsSt_ImpXml");
            entity.Property(e => e.NfNfeVlrIcmsDeson)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrIcmsDeson");
            entity.Property(e => e.NfNfeVlrIcmsDesonImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrIcmsDeson_ImpXml");
            entity.Property(e => e.NfNfeVlrTotCofins)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotCofins");
            entity.Property(e => e.NfNfeVlrTotCofinsImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotCofins_ImpXml");
            entity.Property(e => e.NfNfeVlrTotDesc)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotDesc");
            entity.Property(e => e.NfNfeVlrTotDescImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotDesc_ImpXml");
            entity.Property(e => e.NfNfeVlrTotFcp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcp");
            entity.Property(e => e.NfNfeVlrTotFcpImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcp_ImpXml");
            entity.Property(e => e.NfNfeVlrTotFcpRetSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcpRetSt");
            entity.Property(e => e.NfNfeVlrTotFcpRetStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcpRetSt_ImpXml");
            entity.Property(e => e.NfNfeVlrTotFcpSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcpSt");
            entity.Property(e => e.NfNfeVlrTotFcpStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFcpSt_ImpXml");
            entity.Property(e => e.NfNfeVlrTotFrete)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFrete");
            entity.Property(e => e.NfNfeVlrTotFreteImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotFrete_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIcms)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcms");
            entity.Property(e => e.NfNfeVlrTotIcmsFcp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsFcp");
            entity.Property(e => e.NfNfeVlrTotIcmsFcpImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsFcp_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIcmsImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcms_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIcmsInterUfDest)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsInterUfDest");
            entity.Property(e => e.NfNfeVlrTotIcmsInterUfDestImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsInterUfDest_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIcmsInterUfRem)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsInterUfRem");
            entity.Property(e => e.NfNfeVlrTotIcmsInterUfRemImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsInterUfRem_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIcmsSt)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsSt");
            entity.Property(e => e.NfNfeVlrTotIcmsStImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIcmsSt_ImpXml");
            entity.Property(e => e.NfNfeVlrTotImpImp)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotImpImp");
            entity.Property(e => e.NfNfeVlrTotImpImpImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotImpImp_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIpi)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIpi");
            entity.Property(e => e.NfNfeVlrTotIpiDevol)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIpiDevol");
            entity.Property(e => e.NfNfeVlrTotIpiDevolImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIpiDevol_ImpXml");
            entity.Property(e => e.NfNfeVlrTotIpiImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotIpi_ImpXml");
            entity.Property(e => e.NfNfeVlrTotNf)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotNF");
            entity.Property(e => e.NfNfeVlrTotNfImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotNF_ImpXml");
            entity.Property(e => e.NfNfeVlrTotOutro)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotOutro");
            entity.Property(e => e.NfNfeVlrTotOutroImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotOutro_ImpXml");
            entity.Property(e => e.NfNfeVlrTotPis)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotPis");
            entity.Property(e => e.NfNfeVlrTotPisImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotPis_ImpXml");
            entity.Property(e => e.NfNfeVlrTotProd)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotProd");
            entity.Property(e => e.NfNfeVlrTotProdImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotProd_ImpXml");
            entity.Property(e => e.NfNfeVlrTotSeg)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotSeg");
            entity.Property(e => e.NfNfeVlrTotSegImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotSeg_ImpXml");
            entity.Property(e => e.NfNfeVlrTotTrib)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotTrib");
            entity.Property(e => e.NfNfeVlrTotTribImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTotTrib_ImpXml");
            entity.Property(e => e.NfNfeVlrTrocoImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_nfeVlrTroco_ImpXml");
            entity.Property(e => e.NfNfeXmlArqAutPath)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeXmlArqAutPath");
            entity.Property(e => e.NfNfeXmlArqAutPathImpXml)
                .HasColumnType("varchar(255)")
                .HasColumnName("nf_nfeXmlArqAutPath_ImpXml");
            entity.Property(e => e.NfNfeXmlAss).HasColumnName("nf_nfeXmlAss");
            entity.Property(e => e.NfNfeXmlAssImpXml).HasColumnName("nf_nfeXmlAss_ImpXml");
            entity.Property(e => e.NfNfeXmlAutBkp).HasColumnName("nf_nfeXmlAutBkp");
            entity.Property(e => e.NfNfeXmlAutBkpImpXml).HasColumnName("nf_nfeXmlAutBkp_ImpXml");
            entity.Property(e => e.NfNfeXmlAutErro)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeXmlAutErro");
            entity.Property(e => e.NfNfeXmlAutErroImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeXmlAutErro_ImpXml");
            entity.Property(e => e.NfNfeXmlCancErro)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeXmlCancErro");
            entity.Property(e => e.NfNfeXmlCancErroImpXml)
                .HasColumnType("INT")
                .HasColumnName("nf_nfeXmlCancErro_ImpXml");
            entity.Property(e => e.NfNfeXmlCorrigir).HasColumnName("nf_nfeXmlCorrigir");
            entity.Property(e => e.NfNfeXmlCorrigirImpXml).HasColumnName("nf_nfeXmlCorrigir_ImpXml");
            entity.Property(e => e.NfNfeXmlEnv).HasColumnName("nf_nfeXmlEnv");
            entity.Property(e => e.NfNfeXmlEnvImpXml).HasColumnName("nf_nfeXmlEnv_ImpXml");
            entity.Property(e => e.NfNfeXmlEvtCancDist).HasColumnName("nf_nfeXmlEvtCancDist");
            entity.Property(e => e.NfNfeXmlEvtCancDistImpXml).HasColumnName("nf_nfeXmlEvtCancDist_ImpXml");
            entity.Property(e => e.NfNfeXmlOrig).HasColumnName("nf_nfeXmlOrig");
            entity.Property(e => e.NfNfeXmlOrigImpXml).HasColumnName("nf_nfeXmlOrig_ImpXml");
            entity.Property(e => e.NfNfeXmlProcAutDist).HasColumnName("nf_nfeXmlProcAutDist");
            entity.Property(e => e.NfNfeXmlProcAutDistImpXml).HasColumnName("nf_nfeXmlProcAutDist_ImpXml");
            entity.Property(e => e.NfNfeXmlProcRes).HasColumnName("nf_nfeXmlProcRes");
            entity.Property(e => e.NfNfeXmlProcResImpXml).HasColumnName("nf_nfeXmlProcRes_ImpXml");
            entity.Property(e => e.NfNfeXmlRetWs).HasColumnName("nf_nfeXmlRetWs");
            entity.Property(e => e.NfNfeXmlRetWsImpXml).HasColumnName("nf_nfeXmlRetWs_ImpXml");
            entity.Property(e => e.NfProntoEnviar)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nf_prontoEnviar");
            entity.Property(e => e.NfVlrTotPag)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_vlrTotPag");
            entity.Property(e => e.NfVlrTotPagImpXml)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("nf_vlrTotPag_ImpXml");

            entity.HasOne(d => d.FkTbMovimentacaoNavigation).WithMany(p => p.TbNves).HasForeignKey(d => d.FkTbMovimentacao);
        });

        modelBuilder.Entity<TbNfeEnviadaFilial>(entity =>
        {
            entity.HasKey(e => e.IdNfeEnviadaFilial);

            entity.ToTable("tb_nfe_enviada_filial");

            entity.HasIndex(e => e.FkTbNfe, "ifk_tb_nfe_tb_nfe_enviada_filial");

            entity.HasIndex(e => e.FkTbPdv, "ifk_tb_pdv_tb_nfe_enviada_filial");

            entity.Property(e => e.IdNfeEnviadaFilial).HasColumnName("id_nfe_enviada_filial");
            entity.Property(e => e.FkTbNfe).HasColumnName("fk_tb_nfe");
            entity.Property(e => e.FkTbPdv).HasColumnName("fk_tb_pdv");
            entity.Property(e => e.NefDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("nef_desat");
            entity.Property(e => e.NefDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("nef_dtAcs");
            entity.Property(e => e.NefDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("nef_dtAlt");
            entity.Property(e => e.NefDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("nef_dtCri");

            entity.HasOne(d => d.FkTbNfeNavigation).WithMany(p => p.TbNfeEnviadaFilials).HasForeignKey(d => d.FkTbNfe);

            entity.HasOne(d => d.FkTbPdvNavigation).WithMany(p => p.TbNfeEnviadaFilials).HasForeignKey(d => d.FkTbPdv);
        });

        modelBuilder.Entity<TbPai>(entity =>
        {
            entity.HasKey(e => e.IdPais);

            entity.ToTable("tb_pais");

            entity.HasIndex(e => e.FkTbUnidadeMonetaria, "ifk_tb_unidade_monetaria_tb_pais");

            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.FkTbUnidadeMonetaria).HasColumnName("fk_tb_unidade_monetaria");
            entity.Property(e => e.PsCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ps_canc");
            entity.Property(e => e.PsDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("ps_desat");
            entity.Property(e => e.PsId)
                .HasColumnType("smallint")
                .HasColumnName("ps_id");
            entity.Property(e => e.PsNome)
                .HasColumnType("varchar(256)")
                .HasColumnName("ps_nome");
            entity.Property(e => e.PsSigla)
                .HasColumnType("varchar(3)")
                .HasColumnName("ps_sigla");

            entity.HasOne(d => d.FkTbUnidadeMonetariaNavigation).WithMany(p => p.TbPais).HasForeignKey(d => d.FkTbUnidadeMonetaria);
        });

        modelBuilder.Entity<TbPdv>(entity =>
        {
            entity.HasKey(e => e.IdPdv);

            entity.ToTable("tb_pdv");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_pdv");

            entity.Property(e => e.IdPdv).HasColumnName("id_pdv");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.PdvBiosCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_biosCaption");
            entity.Property(e => e.PdvBiosSerialNumber)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_biosSerialNumber");
            entity.Property(e => e.PdvBiosSmbiosbiosversion)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_biosSMBIOSBIOSVersion");
            entity.Property(e => e.PdvBiosSoftwareElementId)
                .HasColumnType("varchar(256)")
                .HasColumnName("pdv_biosSoftwareElementID");
            entity.Property(e => e.PdvBoardManufacturer)
                .HasColumnType("varchar(256)")
                .HasColumnName("pdv_boardManufacturer");
            entity.Property(e => e.PdvBoardProduct)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_boardProduct");
            entity.Property(e => e.PdvBoardSerialNumber)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_boardSerialNumber");
            entity.Property(e => e.PdvBoardStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_boardStatus");
            entity.Property(e => e.PdvBoardVersion)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_boardVersion");
            entity.Property(e => e.PdvDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_desat");
            entity.Property(e => e.PdvDskCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_dskCaption");
            entity.Property(e => e.PdvDskIndex)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_dskIndex");
            entity.Property(e => e.PdvDskSerialNumber)
                .HasColumnType("varchar(128)")
                .HasColumnName("pdv_dskSerialNumber");
            entity.Property(e => e.PdvDskSignature)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_dskSignature");
            entity.Property(e => e.PdvDskSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_dskSize");
            entity.Property(e => e.PdvDskStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_dskStatus");
            entity.Property(e => e.PdvDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_dtAcs");
            entity.Property(e => e.PdvDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_dtAlt");
            entity.Property(e => e.PdvDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_dtCri");
            entity.Property(e => e.PdvGpuAdapterRam)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuAdapterRAM");
            entity.Property(e => e.PdvGpuAvailability)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_gpuAvailability");
            entity.Property(e => e.PdvGpuConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuConfigManagerErrorCode");
            entity.Property(e => e.PdvGpuCurrentBitsPerPixel)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuCurrentBitsPerPixel");
            entity.Property(e => e.PdvGpuCurrentHorizontalResolution)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuCurrentHorizontalResolution");
            entity.Property(e => e.PdvGpuCurrentNumberOfColors)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_gpuCurrentNumberOfColors");
            entity.Property(e => e.PdvGpuCurrentRefreshRate)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuCurrentRefreshRate");
            entity.Property(e => e.PdvGpuCurrentScanMode)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_gpuCurrentScanMode");
            entity.Property(e => e.PdvGpuCurrentVerticalResolution)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuCurrentVerticalResolution");
            entity.Property(e => e.PdvGpuDitherType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_gpuDitherType");
            entity.Property(e => e.PdvGpuDriverVersion)
                .HasColumnType("varchar(50)")
                .HasColumnName("pdv_gpuDriverVersion");
            entity.Property(e => e.PdvGpuStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_gpuStatus");
            entity.Property(e => e.PdvGpuVideoProcessor)
                .HasColumnType("varchar(100)")
                .HasColumnName("pdv_gpuVideoProcessor");
            entity.Property(e => e.PdvHost)
                .HasColumnType("varchar(300)")
                .HasColumnName("pdv_host");
            entity.Property(e => e.PdvNfeHomNum)
                .HasColumnType("INT")
                .HasColumnName("pdv_nfeHomNum");
            entity.Property(e => e.PdvNfeHomSerie)
                .HasColumnType("smallint")
                .HasColumnName("pdv_nfeHomSerie");
            entity.Property(e => e.PdvNfeProdNum)
                .HasColumnType("INT")
                .HasColumnName("pdv_nfeProdNum");
            entity.Property(e => e.PdvNfeProdSerie)
                .HasColumnType("smallint")
                .HasColumnName("pdv_nfeProdSerie");
            entity.Property(e => e.PdvNicAdapterType)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_nicAdapterType");
            entity.Property(e => e.PdvNicAdapterTypeId)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_nicAdapterTypeID");
            entity.Property(e => e.PdvNicCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_nicCaption");
            entity.Property(e => e.PdvNicCfgDhcpenabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_nicCfgDHCPEnabled");
            entity.Property(e => e.PdvNicCfgDhcpserver)
                .HasColumnType("varchar(48)")
                .HasColumnName("pdv_nicCfgDHCPServer");
            entity.Property(e => e.PdvNicCfgDnsdomain)
                .HasColumnType("varchar(255)")
                .HasColumnName("pdv_nicCfgDNSDomain");
            entity.Property(e => e.PdvNicCfgIpaddress).HasColumnName("pdv_nicCfgIPAddress");
            entity.Property(e => e.PdvNicCfgIpaddressVpn).HasColumnName("pdv_nicCfgIPAddressVpn");
            entity.Property(e => e.PdvNicCfgIpconnectionMetric)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_nicCfgIPConnectionMetric");
            entity.Property(e => e.PdvNicCfgIpenabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_nicCfgIPEnabled");
            entity.Property(e => e.PdvNicDescription)
                .HasColumnType("varchar(128)")
                .HasColumnName("pdv_nicDescription");
            entity.Property(e => e.PdvNicInterfaceIndex)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_nicInterfaceIndex");
            entity.Property(e => e.PdvNicMacAddress)
                .HasColumnType("varchar(32)")
                .HasColumnName("pdv_nicMacAddress");
            entity.Property(e => e.PdvNicMacAddressVpn)
                .HasColumnType("varchar(32)")
                .HasColumnName("pdv_nicMacAddressVpn");
            entity.Property(e => e.PdvNicManufacturer)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_nicManufacturer");
            entity.Property(e => e.PdvNicName)
                .HasColumnType("varchar(128)")
                .HasColumnName("pdv_nicName");
            entity.Property(e => e.PdvNicNetEnabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_nicNetEnabled");
            entity.Property(e => e.PdvNicSpeed)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_nicSpeed");
            entity.Property(e => e.PdvPcAutomaticManagedPagefile)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcAutomaticManagedPagefile");
            entity.Property(e => e.PdvPcAutomaticResetBootOption)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcAutomaticResetBootOption");
            entity.Property(e => e.PdvPcAutomaticResetCapability)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcAutomaticResetCapability");
            entity.Property(e => e.PdvPcBootRomsupported)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcBootROMSupported");
            entity.Property(e => e.PdvPcBootupState)
                .HasColumnType("varchar(50)")
                .HasColumnName("pdv_pcBootupState");
            entity.Property(e => e.PdvPcCurrentTimeZone)
                .HasColumnType("smallint")
                .HasColumnName("pdv_pcCurrentTimeZone");
            entity.Property(e => e.PdvPcDaylightInEffect)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcDaylightInEffect");
            entity.Property(e => e.PdvPcDnshostName)
                .HasColumnType("varchar(255)")
                .HasColumnName("pdv_pcDNSHostName");
            entity.Property(e => e.PdvPcDomainRole)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcDomainRole");
            entity.Property(e => e.PdvPcEnableDaylightSavingsTime)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcEnableDaylightSavingsTime");
            entity.Property(e => e.PdvPcHypervisorPresent)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcHypervisorPresent");
            entity.Property(e => e.PdvPcLdCaption)
                .HasColumnType("varchar(60)")
                .HasColumnName("pdv_pcLdCaption");
            entity.Property(e => e.PdvPcLdCompressed)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcLdCompressed");
            entity.Property(e => e.PdvPcLdConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcLdConfigManagerErrorCode");
            entity.Property(e => e.PdvPcLdDeviceId)
                .HasColumnType("varchar(60)")
                .HasColumnName("pdv_pcLdDeviceID");
            entity.Property(e => e.PdvPcLdDriveType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcLdDriveType");
            entity.Property(e => e.PdvPcLdFileSystem)
                .HasColumnType("varchar(20)")
                .HasColumnName("pdv_pcLdFileSystem");
            entity.Property(e => e.PdvPcLdFreeSpace)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcLdFreeSpace");
            entity.Property(e => e.PdvPcLdLastErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcLdLastErrorCode");
            entity.Property(e => e.PdvPcLdName)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_pcLdName");
            entity.Property(e => e.PdvPcLdSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcLdSize");
            entity.Property(e => e.PdvPcLdVolumeDirty)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcLdVolumeDirty");
            entity.Property(e => e.PdvPcLdVolumeSerialNumber)
                .HasColumnType("varchar(60)")
                .HasColumnName("pdv_pcLdVolumeSerialNumber");
            entity.Property(e => e.PdvPcManufacturer)
                .HasColumnType("varchar(50)")
                .HasColumnName("pdv_pcManufacturer");
            entity.Property(e => e.PdvPcNetworkServerModeEnabled)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcNetworkServerModeEnabled");
            entity.Property(e => e.PdvPcNumberOfLogicalProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcNumberOfLogicalProcessors");
            entity.Property(e => e.PdvPcNumberOfProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcNumberOfProcessors");
            entity.Property(e => e.PdvPcOsBuildNumber)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_pcOsBuildNumber");
            entity.Property(e => e.PdvPcOsCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_pcOsCaption");
            entity.Property(e => e.PdvPcOsCodeSet)
                .HasColumnType("varchar(6)")
                .HasColumnName("pdv_pcOsCodeSet");
            entity.Property(e => e.PdvPcOsCountryCode)
                .HasColumnType("varchar(256)")
                .HasColumnName("pdv_pcOsCountryCode");
            entity.Property(e => e.PdvPcOsCurrentTimeZone)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcOsCurrentTimeZone");
            entity.Property(e => e.PdvPcOsFreePhysicalMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsFreePhysicalMemory");
            entity.Property(e => e.PdvPcOsFreeSpaceInPagingFiles)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsFreeSpaceInPagingFiles");
            entity.Property(e => e.PdvPcOsFreeVirtualMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsFreeVirtualMemory");
            entity.Property(e => e.PdvPcOsInstallDate)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_pcOsInstallDate");
            entity.Property(e => e.PdvPcOsLastBootUpTime)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_pcOsLastBootUpTime");
            entity.Property(e => e.PdvPcOsLocalDateTime)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_pcOsLocalDateTime");
            entity.Property(e => e.PdvPcOsLocale)
                .HasColumnType("varchar(6)")
                .HasColumnName("pdv_pcOsLocale");
            entity.Property(e => e.PdvPcOsNumberOfProcesses)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOsNumberOfProcesses");
            entity.Property(e => e.PdvPcOsNumberOfUsers)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOsNumberOfUsers");
            entity.Property(e => e.PdvPcOsOperatingSystemSku)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOsOperatingSystemSKU");
            entity.Property(e => e.PdvPcOsPortableOperatingSystem)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcOsPortableOperatingSystem");
            entity.Property(e => e.PdvPcOsPrimary)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcOsPrimary");
            entity.Property(e => e.PdvPcOsProductType)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOsProductType");
            entity.Property(e => e.PdvPcOsRegisteredUser)
                .HasColumnType("varchar(100)")
                .HasColumnName("pdv_pcOsRegisteredUser");
            entity.Property(e => e.PdvPcOsSerialNumber)
                .HasColumnType("varchar(50)")
                .HasColumnName("pdv_pcOsSerialNumber");
            entity.Property(e => e.PdvPcOsServicePackMajorVersion)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcOsServicePackMajorVersion");
            entity.Property(e => e.PdvPcOsServicePackMinorVersion)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcOsServicePackMinorVersion");
            entity.Property(e => e.PdvPcOsSizeStoredInPagingFiles)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsSizeStoredInPagingFiles");
            entity.Property(e => e.PdvPcOsSuiteMask)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOsSuiteMask");
            entity.Property(e => e.PdvPcOsSystemDrive)
                .HasColumnType("varchar(2)")
                .HasColumnName("pdv_pcOsSystemDrive");
            entity.Property(e => e.PdvPcOsTotalSwapSpaceSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsTotalSwapSpaceSize");
            entity.Property(e => e.PdvPcOsTotalVirtualMemorySize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsTotalVirtualMemorySize");
            entity.Property(e => e.PdvPcOsTotalVisibleMemorySize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcOsTotalVisibleMemorySize");
            entity.Property(e => e.PdvPcOsVersion)
                .HasColumnType("varchar(20)")
                .HasColumnName("pdv_pcOsVersion");
            entity.Property(e => e.PdvPcOsarchitecture)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_pcOSArchitecture");
            entity.Property(e => e.PdvPcOslanguage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOSLanguage");
            entity.Property(e => e.PdvPcOsproductSuite)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcOSProductSuite");
            entity.Property(e => e.PdvPcPcsystemType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPCSystemType");
            entity.Property(e => e.PdvPcPgFlAllocatedBaseSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPgFlAllocatedBaseSize");
            entity.Property(e => e.PdvPcPgFlCurrentUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPgFlCurrentUsage");
            entity.Property(e => e.PdvPcPgFlPeakUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPgFlPeakUsage");
            entity.Property(e => e.PdvPcPowElementName)
                .HasColumnType("varchar(60)")
                .HasColumnName("pdv_pcPowElementName");
            entity.Property(e => e.PdvPcPowInstanceId)
                .HasColumnType("varchar(60)")
                .HasColumnName("pdv_pcPowInstanceID");
            entity.Property(e => e.PdvPcPrcAddressWidth)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcAddressWidth");
            entity.Property(e => e.PdvPcPrcArchitecture)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcArchitecture");
            entity.Property(e => e.PdvPcPrcAvailability)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcAvailability");
            entity.Property(e => e.PdvPcPrcCaption)
                .HasColumnType("varchar(64)")
                .HasColumnName("pdv_pcPrcCaption");
            entity.Property(e => e.PdvPcPrcCharacteristics)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcCharacteristics");
            entity.Property(e => e.PdvPcPrcConfigManagerErrorCode)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcConfigManagerErrorCode");
            entity.Property(e => e.PdvPcPrcConfigManagerUserConfig)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcPrcConfigManagerUserConfig");
            entity.Property(e => e.PdvPcPrcCpuStatus)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcCpuStatus");
            entity.Property(e => e.PdvPcPrcCurrentClockSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcCurrentClockSpeed");
            entity.Property(e => e.PdvPcPrcCurrentVoltage)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcCurrentVoltage");
            entity.Property(e => e.PdvPcPrcDataWidth)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcDataWidth");
            entity.Property(e => e.PdvPcPrcExtClock)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcExtClock");
            entity.Property(e => e.PdvPcPrcFamily)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcFamily");
            entity.Property(e => e.PdvPcPrcL2cacheSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcL2CacheSize");
            entity.Property(e => e.PdvPcPrcL2cacheSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcL2CacheSpeed");
            entity.Property(e => e.PdvPcPrcL3cacheSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcL3CacheSize");
            entity.Property(e => e.PdvPcPrcL3cacheSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcL3CacheSpeed");
            entity.Property(e => e.PdvPcPrcLevel)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcLevel");
            entity.Property(e => e.PdvPcPrcLoadPercentage)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcLoadPercentage");
            entity.Property(e => e.PdvPcPrcMaxClockSpeed)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcMaxClockSpeed");
            entity.Property(e => e.PdvPcPrcName)
                .HasColumnType("varchar(100)")
                .HasColumnName("pdv_pcPrcName");
            entity.Property(e => e.PdvPcPrcNumberOfCores)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcNumberOfCores");
            entity.Property(e => e.PdvPcPrcNumberOfEnabledCore)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcNumberOfEnabledCore");
            entity.Property(e => e.PdvPcPrcNumberOfLogicalProcessors)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcNumberOfLogicalProcessors");
            entity.Property(e => e.PdvPcPrcPowerManagementSupported)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcPrcPowerManagementSupported");
            entity.Property(e => e.PdvPcPrcProcessorId)
                .HasColumnType("varchar(100)")
                .HasColumnName("pdv_pcPrcProcessorId");
            entity.Property(e => e.PdvPcPrcProcessorType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcProcessorType");
            entity.Property(e => e.PdvPcPrcRevision)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcRevision");
            entity.Property(e => e.PdvPcPrcSecondLevelAddressTranslationExtensions)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pcPrcSecondLevelAddressTranslationExtensions");
            entity.Property(e => e.PdvPcPrcStatus)
                .HasColumnType("varchar(10)")
                .HasColumnName("pdv_pcPrcStatus");
            entity.Property(e => e.PdvPcPrcStatusInfo)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcPrcStatusInfo");
            entity.Property(e => e.PdvPcPrcSystemName)
                .HasColumnType("varchar(255)")
                .HasColumnName("pdv_pcPrcSystemName");
            entity.Property(e => e.PdvPcPrcThreadCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_pcPrcThreadCount");
            entity.Property(e => e.PdvPcTotalPhysicalMemory)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_pcTotalPhysicalMemory");
            entity.Property(e => e.PdvPcUserName)
                .HasColumnType("varchar(255)")
                .HasColumnName("pdv_pcUserName");
            entity.Property(e => e.PdvPcWakeUpType)
                .HasColumnType("NUMERIC(5, 0)")
                .HasColumnName("pdv_pcWakeUpType");
            entity.Property(e => e.PdvPdvNum)
                .HasColumnType("smallint")
                .HasColumnName("pdv_pdvNum");
            entity.Property(e => e.PdvPdvUpdNewVer)
                .HasColumnType("varchar(20)")
                .HasColumnName("pdv_pdvUpdNewVer");
            entity.Property(e => e.PdvPdvUpdNewVerDt)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_pdvUpdNewVerDt");
            entity.Property(e => e.PdvPdvUpdReady)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pdv_pdvUpdReady");
            entity.Property(e => e.PdvPdvUpdRunVer)
                .HasColumnType("varchar(20)")
                .HasColumnName("pdv_pdvUpdRunVer");
            entity.Property(e => e.PdvPdvUpdRunVerDt)
                .HasColumnType("DATETIME")
                .HasColumnName("pdv_pdvUpdRunVerDt");
            entity.Property(e => e.PdvPersTim)
                .HasColumnType("tinyint")
                .HasColumnName("pdv_persTim");
            entity.Property(e => e.PdvProcHandle)
                .HasColumnType("varchar(256)")
                .HasColumnName("pdv_procHandle");
            entity.Property(e => e.PdvProcHandleCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procHandleCount");
            entity.Property(e => e.PdvProcKernelModeTime)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procKernelModeTime");
            entity.Property(e => e.PdvProcOtherOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procOtherOperationCount");
            entity.Property(e => e.PdvProcOtherTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procOtherTransferCount");
            entity.Property(e => e.PdvProcPageFaults)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procPageFaults");
            entity.Property(e => e.PdvProcPageFileUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procPageFileUsage");
            entity.Property(e => e.PdvProcPeakPageFileUsage)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procPeakPageFileUsage");
            entity.Property(e => e.PdvProcPeakVirtualSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procPeakVirtualSize");
            entity.Property(e => e.PdvProcPeakWorkingSetSize)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procPeakWorkingSetSize");
            entity.Property(e => e.PdvProcPriority)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procPriority");
            entity.Property(e => e.PdvProcPrivatePageCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procPrivatePageCount");
            entity.Property(e => e.PdvProcProcessId)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procProcessId");
            entity.Property(e => e.PdvProcReadOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procReadOperationCount");
            entity.Property(e => e.PdvProcReadTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procReadTransferCount");
            entity.Property(e => e.PdvProcThreadCount)
                .HasColumnType("NUMERIC(10, 0)")
                .HasColumnName("pdv_procThreadCount");
            entity.Property(e => e.PdvProcUserModeTime)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procUserModeTime");
            entity.Property(e => e.PdvProcVirtualSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procVirtualSize");
            entity.Property(e => e.PdvProcWorkingSetSize)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procWorkingSetSize");
            entity.Property(e => e.PdvProcWriteOperationCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procWriteOperationCount");
            entity.Property(e => e.PdvProcWriteTransferCount)
                .HasColumnType("NUMERIC(20, 0)")
                .HasColumnName("pdv_procWriteTransferCount");
            entity.Property(e => e.PdvServ)
                .HasColumnType("varchar(300)")
                .HasColumnName("pdv_serv");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbPdvs).HasForeignKey(d => d.FkTbAtor);
        });

        modelBuilder.Entity<TbPlanCont>(entity =>
        {
            entity.HasKey(e => e.IdPlanCont);

            entity.ToTable("tb_planCont");

            entity.Property(e => e.IdPlanCont).HasColumnName("id_planCont");
            entity.Property(e => e.PcCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pc_canc");
            entity.Property(e => e.PcDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pc_desat");
            entity.Property(e => e.PcDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("pc_desc");
            entity.Property(e => e.PcDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("pc_dtAcs");
            entity.Property(e => e.PcDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("pc_dtAlt");
            entity.Property(e => e.PcDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("pc_dtCri");
        });

        modelBuilder.Entity<TbProduto>(entity =>
        {
            entity.HasKey(e => e.IdProduto);

            entity.ToTable("tb_produto");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_produto");

            entity.HasIndex(e => e.FkTbCategoriaProduto, "ifk_tb_categoria_produto_tb_produto");

            entity.HasIndex(e => e.FkTbEst, "ifk_tb_est_tb_produto");

            entity.HasIndex(e => e.FkTbMarcaProduto, "ifk_tb_marca_produto_tb_produto");

            entity.HasIndex(e => e.FkTbNcm, "ifk_tb_ncm_tb_produto");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_produto");

            entity.HasIndex(e => e.FkTbRelacaoProdutoCadastroXml, "ifk_tb_relacao_produto_cadastro_XML_tb_produto");

            entity.HasIndex(e => e.FkTbSubcategoriaProduto, "ifk_tb_subcategoria_produto_tb_produto");

            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.FkTbCategoriaProduto).HasColumnName("fk_tb_categoria_produto");
            entity.Property(e => e.FkTbEst).HasColumnName("fk_tb_est");
            entity.Property(e => e.FkTbMarcaProduto).HasColumnName("fk_tb_marca_produto");
            entity.Property(e => e.FkTbNcm).HasColumnName("fk_tb_ncm");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");
            entity.Property(e => e.FkTbRelacaoProdutoCadastroXml).HasColumnName("fk_tb_relacao_produto_cadastro_XML");
            entity.Property(e => e.FkTbSubcategoriaProduto).HasColumnName("fk_tb_subcategoria_produto");
            entity.Property(e => e.PdAtivo)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pd_ativo");
            entity.Property(e => e.PdBarras)
                .HasColumnType("varchar(512)")
                .HasColumnName("pd_barras");
            entity.Property(e => e.PdCodRef)
                .HasColumnType("bigint")
                .HasColumnName("pd_codRef");
            entity.Property(e => e.PdCodRefStr)
                .HasColumnType("varchar(20)")
                .HasColumnName("pd_codRefStr");
            entity.Property(e => e.PdCstUnComBase)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("pd_cstUnComBase");
            entity.Property(e => e.PdDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pd_desat");
            entity.Property(e => e.PdDesc)
                .HasColumnType("varchar(120)")
                .HasColumnName("pd_desc");
            entity.Property(e => e.PdDescCurta)
                .HasColumnType("varchar(25)")
                .HasColumnName("pd_descCurta");
            entity.Property(e => e.PdDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("pd_dtAlt");
            entity.Property(e => e.PdDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("pd_dtCri");
            entity.Property(e => e.PdEspecie)
                .HasColumnType("tinyint")
                .HasColumnName("pd_especie");
            entity.Property(e => e.PdEstMaxBase)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("pd_estMaxBase");
            entity.Property(e => e.PdEstMinBase)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("pd_estMinBase");
            entity.Property(e => e.PdEstTot)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("pd_estTot");
            entity.Property(e => e.PdFxEta)
                .HasColumnType("tinyint")
                .HasColumnName("pd_fxEta");
            entity.Property(e => e.PdGenero)
                .HasColumnType("tinyint")
                .HasColumnName("pd_genero");
            entity.Property(e => e.PdImpRef)
                .HasColumnType("varchar(60)")
                .HasColumnName("pd_impRef");
            entity.Property(e => e.PdInvend)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pd_invend");
            entity.Property(e => e.PdNfeCsosn)
                .HasColumnType("smallint")
                .HasColumnName("pd_nfeCsosn");
            entity.Property(e => e.PdNfeProdOrigem)
                .HasColumnType("tinyint")
                .HasColumnName("pd_nfeProdOrigem");
            entity.Property(e => e.PdProTipo)
                .HasColumnType("tinyint")
                .HasColumnName("pd_proTipo");
            entity.Property(e => e.PdTmpStr).HasColumnName("pd_tmpStr");
            entity.Property(e => e.PdUnMedCom)
                .HasColumnType("tinyint")
                .HasColumnName("pd_unMedCom");
            entity.Property(e => e.PdVend)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pd_vend");
            entity.Property(e => e.PdVlrUnComBase)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("pd_vlrUnComBase");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbAtor);

            entity.HasOne(d => d.FkTbCategoriaProdutoNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbCategoriaProduto);

            entity.HasOne(d => d.FkTbEstNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbEst);

            entity.HasOne(d => d.FkTbMarcaProdutoNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbMarcaProduto);

            entity.HasOne(d => d.FkTbNcmNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbNcm);

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbRede);

            entity.HasOne(d => d.FkTbRelacaoProdutoCadastroXmlNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbRelacaoProdutoCadastroXml);

            entity.HasOne(d => d.FkTbSubcategoriaProdutoNavigation).WithMany(p => p.TbProdutos).HasForeignKey(d => d.FkTbSubcategoriaProduto);
        });

        modelBuilder.Entity<TbProdutoFilial>(entity =>
        {
            entity.HasKey(e => e.IdProdutoFilial);

            entity.ToTable("tb_produto_filial");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_produto_filial");

            entity.HasIndex(e => e.FkTbProduto, "ifk_tb_produto_tb_produto_filial");

            entity.Property(e => e.IdProdutoFilial).HasColumnName("id_produto_filial");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.FkTbProduto).HasColumnName("fk_tb_produto");
            entity.Property(e => e.PfAtorFil).HasColumnName("pf_atorFil");
            entity.Property(e => e.PfCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pf_canc");
            entity.Property(e => e.PfCodRef)
                .HasColumnType("bigint")
                .HasColumnName("pf_codRef");
            entity.Property(e => e.PfCstUnCom)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("pf_cstUnCom");
            entity.Property(e => e.PfDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("pf_desat");
            entity.Property(e => e.PfDesc)
                .HasColumnType("varchar(120)")
                .HasColumnName("pf_desc");
            entity.Property(e => e.PfDescCurta)
                .HasColumnType("varchar(25)")
                .HasColumnName("pf_descCurta");
            entity.Property(e => e.PfDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("pf_dtAcs");
            entity.Property(e => e.PfDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("pf_dtAlt");
            entity.Property(e => e.PfDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("pf_dtCri");
            entity.Property(e => e.PfEst)
                .HasColumnType("NUMERIC(13, 3)")
                .HasColumnName("pf_est");
            entity.Property(e => e.PfEstMax)
                .HasColumnType("money")
                .HasColumnName("pf_estMax");
            entity.Property(e => e.PfEstMin)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("pf_estMin");
            entity.Property(e => e.PfProTipo)
                .HasColumnType("tinyint")
                .HasColumnName("pf_proTipo");
            entity.Property(e => e.PfUnMedCom)
                .HasColumnType("tinyint")
                .HasColumnName("pf_unMedCom");
            entity.Property(e => e.PfVlrUnCom)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("pf_vlrUnCom");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbProdutoFilials).HasForeignKey(d => d.FkTbAtor);

            entity.HasOne(d => d.FkTbProdutoNavigation).WithMany(p => p.TbProdutoFilials).HasForeignKey(d => d.FkTbProduto);
        });

        modelBuilder.Entity<TbRede>(entity =>
        {
            entity.HasKey(e => e.IdRede);

            entity.ToTable("tb_rede");

            entity.Property(e => e.IdRede).HasColumnName("id_rede");
            entity.Property(e => e.ReDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("re_desat");
            entity.Property(e => e.ReDesatSinc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("re_desatSinc");
            entity.Property(e => e.ReDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("re_desc");
            entity.Property(e => e.ReDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("re_dtAcs");
            entity.Property(e => e.ReDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("re_dtAlt");
            entity.Property(e => e.ReDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("re_dtCri");
            entity.Property(e => e.RePersTim)
                .HasColumnType("tinyint")
                .HasColumnName("re_PersTim");
        });

        modelBuilder.Entity<TbRegioesBr>(entity =>
        {
            entity.HasKey(e => e.IdRegioesBr);

            entity.ToTable("tb_regioes_br");

            entity.HasIndex(e => e.FkTbPais, "ifk_tb_pais_tb_regioes_br");

            entity.Property(e => e.IdRegioesBr).HasColumnName("id_regioes_br");
            entity.Property(e => e.FkTbPais).HasColumnName("fk_tb_pais");
            entity.Property(e => e.RbDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("rb_desat");
            entity.Property(e => e.RbId)
                .HasColumnType("tinyint")
                .HasColumnName("rb_id");
            entity.Property(e => e.RbNome)
                .HasColumnType("varchar(12)")
                .HasColumnName("rb_nome");
            entity.Property(e => e.RbSigla)
                .HasColumnType("varchar(2)")
                .HasColumnName("rb_sigla");

            entity.HasOne(d => d.FkTbPaisNavigation).WithMany(p => p.TbRegioesBrs).HasForeignKey(d => d.FkTbPais);
        });

        modelBuilder.Entity<TbRelacaoProdutoCadastroXml>(entity =>
        {
            entity.HasKey(e => e.IdRelacaoProdutoCadastroXml);

            entity.ToTable("tb_relacao_produto_cadastro_XML");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_relacao_produto_cadastro_XML");

            entity.HasIndex(e => e.FkTbProdutoFilial, "ifk_tb_produto_filial_tb_relacao_produto_cadastro_XML");

            entity.HasIndex(e => e.FkTbProduto, "ifk_tb_produto_tb_relacao_produto_cadastro_XML");

            entity.Property(e => e.IdRelacaoProdutoCadastroXml).HasColumnName("id_relacao_produto_cadastro_XML");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.FkTbProduto).HasColumnName("fk_tb_produto");
            entity.Property(e => e.FkTbProdutoFilial).HasColumnName("fk_tb_produto_filial");
            entity.Property(e => e.RpcCnpjFornecedor)
                .HasColumnType("varchar(18)")
                .HasColumnName("rpc_cnpj_fornecedor");
            entity.Property(e => e.RpcCodRef)
                .HasColumnType("bigint")
                .HasColumnName("rpc_codRef");
            entity.Property(e => e.RpcDesc)
                .HasColumnType("varchar(48)")
                .HasColumnName("rpc_desc");
            entity.Property(e => e.RpcDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("rpc_dtAcs");
            entity.Property(e => e.RpcDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("rpc_dtAlt");
            entity.Property(e => e.RpcDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("rpc_dtCri");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbRelacaoProdutoCadastroXmls).HasForeignKey(d => d.FkTbAtor);

            entity.HasOne(d => d.FkTbProdutoNavigation).WithMany(p => p.TbRelacaoProdutoCadastroXmls).HasForeignKey(d => d.FkTbProduto);

            entity.HasOne(d => d.FkTbProdutoFilialNavigation).WithMany(p => p.TbRelacaoProdutoCadastroXmls).HasForeignKey(d => d.FkTbProdutoFilial);
        });

        modelBuilder.Entity<TbResEventoNfe>(entity =>
        {
            entity.HasKey(e => e.IdResEventoNfe);

            entity.ToTable("tb_resEventoNFe");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_resEventoNFe");

            entity.Property(e => e.IdResEventoNfe).HasColumnName("id_resEventoNFe");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.RefCnpj)
                .HasColumnType("varchar(18)")
                .HasColumnName("ref_cnpj");
            entity.Property(e => e.RefCodOrg)
                .HasColumnType("smallint")
                .HasColumnName("ref_codOrg");
            entity.Property(e => e.RefCpf)
                .HasColumnType("varchar(14)")
                .HasColumnName("ref_cpf");
            entity.Property(e => e.RefDescEvt)
                .HasColumnType("varchar(60)")
                .HasColumnName("ref_descEvt");
            entity.Property(e => e.RefDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("ref_dtAcs");
            entity.Property(e => e.RefDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("ref_dtAlt");
            entity.Property(e => e.RefDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("ref_dtCri");
            entity.Property(e => e.RefDtEvt)
                .HasColumnType("TIMESTAMP(8)")
                .HasColumnName("ref_dtEvt");
            entity.Property(e => e.RefNfeChave)
                .HasColumnType("varchar(50)")
                .HasColumnName("ref_nfeChave");
            entity.Property(e => e.RefNfeNumProtEvt)
                .HasColumnType("varchar(15)")
                .HasColumnName("ref_nfeNumProtEvt");
            entity.Property(e => e.RefNfeVersao)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("ref_nfeVersao");
            entity.Property(e => e.RefNsu)
                .HasColumnType("bigint")
                .HasColumnName("ref_nsu");
            entity.Property(e => e.RefNumSeqEvt)
                .HasColumnType("smallint")
                .HasColumnName("ref_numSeqEvt");
            entity.Property(e => e.RefSTpEvt)
                .HasColumnType("INT")
                .HasColumnName("ref_sTpEvt");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbResEventoNves).HasForeignKey(d => d.FkTbAtor);
        });

        modelBuilder.Entity<TbRespostaNfe>(entity =>
        {
            entity.HasKey(e => e.IdRespostaNfe);

            entity.ToTable("tb_resposta_NFe");

            entity.HasIndex(e => e.FkTbAtor, "ifk_tb_ator_tb_resposta_NFe");

            entity.Property(e => e.IdRespostaNfe).HasColumnName("id_resposta_NFe");
            entity.Property(e => e.FkTbAtor).HasColumnName("fk_tb_ator");
            entity.Property(e => e.RnfeCnpj)
                .HasColumnType("varchar(18)")
                .HasColumnName("rnfe_cnpj");
            entity.Property(e => e.RnfeCpf)
                .HasColumnType("varchar(14)")
                .HasColumnName("rnfe_cpf");
            entity.Property(e => e.RnfeDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("rnfe_dtAcs");
            entity.Property(e => e.RnfeDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("rnfe_dtAlt");
            entity.Property(e => e.RnfeDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("rnfe_dtCri");
            entity.Property(e => e.RnfeInscEst)
                .HasColumnType("varchar(20)")
                .HasColumnName("rnfe_inscEst");
            entity.Property(e => e.RnfeMaxNsu)
                .HasColumnType("bigint")
                .HasColumnName("rnfe_maxNsu");
            entity.Property(e => e.RnfeNfeChave)
                .HasColumnType("varchar(50)")
                .HasColumnName("rnfe_nfeChave");
            entity.Property(e => e.RnfeNfeDtAut)
                .HasColumnType("DATETIME")
                .HasColumnName("rnfe_nfeDtAut");
            entity.Property(e => e.RnfeNfeDtEmis)
                .HasColumnType("DATETIME")
                .HasColumnName("rnfe_nfeDtEmis");
            entity.Property(e => e.RnfeNfeNumProtAut)
                .HasColumnType("varchar(15)")
                .HasColumnName("rnfe_nfeNumProtAut");
            entity.Property(e => e.RnfeNfeSit)
                .HasColumnType("tinyint")
                .HasColumnName("rnfe_nfeSit");
            entity.Property(e => e.RnfeNfeTipo)
                .HasColumnType("tinyint")
                .HasColumnName("rnfe_nfeTipo");
            entity.Property(e => e.RnfeNfeVersao)
                .HasColumnType("NUMERIC(6, 3)")
                .HasColumnName("rnfe_nfeVersao");
            entity.Property(e => e.RnfeNfeVlrTotNf)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("rnfe_nfeVlrTotNF");
            entity.Property(e => e.RnfeNsu)
                .HasColumnType("bigint")
                .HasColumnName("rnfe_nsu");
            entity.Property(e => e.RnfeRazSoc)
                .HasColumnType("varchar(60)")
                .HasColumnName("rnfe_razSoc");
            entity.Property(e => e.RnfeUltNsu)
                .HasColumnType("bigint")
                .HasColumnName("rnfe_ultNsu");

            entity.HasOne(d => d.FkTbAtorNavigation).WithMany(p => p.TbRespostaNves).HasForeignKey(d => d.FkTbAtor);
        });

        modelBuilder.Entity<TbSecaoProduto>(entity =>
        {
            entity.HasKey(e => e.IdSecaoProduto);

            entity.ToTable("tb_secao_produto");

            entity.HasIndex(e => e.FkTbRede, "ifk_tb_rede_tb_secao_produto");

            entity.Property(e => e.IdSecaoProduto).HasColumnName("id_secao_produto");
            entity.Property(e => e.FkTbRede).HasColumnName("fk_tb_rede");
            entity.Property(e => e.SpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("sp_desat");
            entity.Property(e => e.SpDesc)
                .HasColumnType("varchar(48)")
                .HasColumnName("sp_desc");
            entity.Property(e => e.SpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("sp_dtAcs");
            entity.Property(e => e.SpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("sp_dtAlt");
            entity.Property(e => e.SpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("sp_dtCri");

            entity.HasOne(d => d.FkTbRedeNavigation).WithMany(p => p.TbSecaoProdutos).HasForeignKey(d => d.FkTbRede);
        });

        modelBuilder.Entity<TbSubFormaPagamento>(entity =>
        {
            entity.HasKey(e => e.IdSubFormaPagamento);

            entity.ToTable("tb_sub_forma_pagamento");

            entity.HasIndex(e => e.FkTbFormaPagamento, "ifk_tb_forma_pagamento_tb_sub_forma_pagamento");

            entity.Property(e => e.IdSubFormaPagamento).HasColumnName("id_sub_forma_pagamento");
            entity.Property(e => e.FkTbFormaPagamento).HasColumnName("fk_tb_forma_pagamento");
            entity.Property(e => e.SfpAtalhoTecl)
                .HasColumnType("nchar(1)")
                .HasColumnName("sfp_atalhoTecl");
            entity.Property(e => e.SfpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("sfp_desat");
            entity.Property(e => e.SfpDesc)
                .HasColumnType("varchar(60)")
                .HasColumnName("sfp_desc");
            entity.Property(e => e.SfpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("sfp_dtAcs");
            entity.Property(e => e.SfpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("sfp_dtAlt");
            entity.Property(e => e.SfpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("sfp_dtCri");
            entity.Property(e => e.SfpIntParc)
                .HasColumnType("smallint")
                .HasColumnName("sfp_intParc");
            entity.Property(e => e.SfpNfeTipoBand)
                .HasColumnType("tinyint")
                .HasColumnName("sfp_nfeTipoBand");
            entity.Property(e => e.SfpOrdExib)
                .HasColumnType("smallint")
                .HasColumnName("sfp_ordExib");

            entity.HasOne(d => d.FkTbFormaPagamentoNavigation).WithMany(p => p.TbSubFormaPagamentos).HasForeignKey(d => d.FkTbFormaPagamento);
        });

        modelBuilder.Entity<TbSubcategoriaProduto>(entity =>
        {
            entity.HasKey(e => e.IdSubcategoriaProduto);

            entity.ToTable("tb_subcategoria_produto");

            entity.HasIndex(e => e.FkTbNcm, "ifk_tb_Ncm_tb_subcategoria_produto");

            entity.HasIndex(e => e.FkTbCategoriaProduto, "ifk_tb_categoria_produto_tb_subcategoria_produto");

            entity.Property(e => e.IdSubcategoriaProduto).HasColumnName("id_subcategoria_produto");
            entity.Property(e => e.FkTbCategoriaProduto).HasColumnName("fk_tb_categoria_produto");
            entity.Property(e => e.FkTbNcm).HasColumnName("fk_tb_Ncm");
            entity.Property(e => e.ScpDesat)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("scp_desat");
            entity.Property(e => e.ScpDesc)
                .HasColumnType("varchar(48)")
                .HasColumnName("scp_desc");
            entity.Property(e => e.ScpDescMax)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("scp_descMax");
            entity.Property(e => e.ScpDtAcs)
                .HasColumnType("DATETIME")
                .HasColumnName("scp_dtAcs");
            entity.Property(e => e.ScpDtAlt)
                .HasColumnType("DATETIME")
                .HasColumnName("scp_dtAlt");
            entity.Property(e => e.ScpDtCri)
                .HasColumnType("DATETIME")
                .HasColumnName("scp_dtCri");
            entity.Property(e => e.ScpNcmNum)
                .HasColumnType("varchar(8)")
                .HasColumnName("scp_ncmNum");
            entity.Property(e => e.ScpNfeCsosn)
                .HasColumnType("smallint")
                .HasColumnName("scp_nfeCsosn");
            entity.Property(e => e.ScpNfePisCofinsReg)
                .HasColumnType("tinyint")
                .HasColumnName("scp_nfePisCofinsReg");

            entity.HasOne(d => d.FkTbCategoriaProdutoNavigation).WithMany(p => p.TbSubcategoriaProdutos).HasForeignKey(d => d.FkTbCategoriaProduto);

            entity.HasOne(d => d.FkTbNcmNavigation).WithMany(p => p.TbSubcategoriaProdutos).HasForeignKey(d => d.FkTbNcm);
        });

        modelBuilder.Entity<TbUnidadeMonetarium>(entity =>
        {
            entity.HasKey(e => e.IdUnidadeMonetaria);

            entity.ToTable("tb_unidade_monetaria");

            entity.Property(e => e.IdUnidadeMonetaria).HasColumnName("id_unidade_monetaria");
            entity.Property(e => e.UnCambio)
                .HasColumnType("NUMERIC(13, 2)")
                .HasColumnName("un_cambio");
            entity.Property(e => e.UnCambioDt).HasColumnName("un_cambioDt");
            entity.Property(e => e.UnCanc)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("un_canc");
            entity.Property(e => e.UnId)
                .HasColumnType("smallint")
                .HasColumnName("un_id");
            entity.Property(e => e.UnInter)
                .HasColumnType("NUMERIC(1, 0)")
                .HasColumnName("un_inter");
            entity.Property(e => e.UnNome)
                .HasColumnType("varchar(256)")
                .HasColumnName("un_nome");
            entity.Property(e => e.UnSigla)
                .HasColumnType("varchar(3)")
                .HasColumnName("un_sigla");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
