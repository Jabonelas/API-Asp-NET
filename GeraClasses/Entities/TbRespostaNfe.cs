using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbRespostaNfe
{
    public int IdRespostaNfe { get; set; }

    public string? RnfeCnpj { get; set; }

    public string? RnfeCpf { get; set; }

    public string? RnfeInscEst { get; set; }

    public string? RnfeNfeChave { get; set; }

    public DateTime RnfeNfeDtAut { get; set; }

    public DateTime RnfeNfeDtEmis { get; set; }

    public string? RnfeNfeNumProtAut { get; set; }

    public byte RnfeNfeSit { get; set; }

    public byte RnfeNfeTipo { get; set; }

    public decimal? RnfeNfeVersao { get; set; }

    public decimal? RnfeNfeVlrTotNf { get; set; }

    public string? RnfeRazSoc { get; set; }

    public DateTime RnfeDtCri { get; set; }

    public DateTime RnfeDtAlt { get; set; }

    public DateTime? RnfeDtAcs { get; set; }

    public long RnfeNsu { get; set; }

    public long RnfeUltNsu { get; set; }

    public long RnfeMaxNsu { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }
}
