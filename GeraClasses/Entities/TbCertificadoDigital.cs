using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbCertificadoDigital
{
    public int IdCertificadoDigital { get; set; }

    public DateTime CdDtCri { get; set; }

    public DateTime CdDtAlt { get; set; }

    public DateTime? CdDtAcs { get; set; }

    public string? CdCnpj { get; set; }

    public string? CdRazSoc { get; set; }

    public byte[]? CdRawData { get; set; }

    public string? CdPwd { get; set; }

    public string? CdSerial { get; set; }

    public DateTime? CdDtPub { get; set; }

    public DateTime? CdDtExp { get; set; }

    public int? CdAtivo { get; set; }

    public string? CdTipo { get; set; }

    public string? CdModoEmissao { get; set; }

    public int CdX509Version { get; set; }

    public string? CdSHa1string { get; set; }

    public int? CdCanc { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual ICollection<TbAtor> TbAtors { get; set; } = new List<TbAtor>();
}
