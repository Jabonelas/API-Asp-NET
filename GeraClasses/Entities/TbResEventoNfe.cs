using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbResEventoNfe
{
    public int IdResEventoNfe { get; set; }

    public string? RefCnpj { get; set; }

    public string? RefCpf { get; set; }

    public string? RefNfeChave { get; set; }

    public decimal? RefNfeVersao { get; set; }

    public DateTime RefDtCri { get; set; }

    public DateTime RefDtAlt { get; set; }

    public DateTime? RefDtAcs { get; set; }

    public long RefNsu { get; set; }

    public short RefCodOrg { get; set; }

    public DateTime RefDtEvt { get; set; }

    public int RefSTpEvt { get; set; }

    public short RefNumSeqEvt { get; set; }

    public string? RefDescEvt { get; set; }

    public string? RefNfeNumProtEvt { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }
}
