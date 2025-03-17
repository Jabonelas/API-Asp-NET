using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbEstadosBr
{
    public int IdEstadosBr { get; set; }

    public int? EbDesat { get; set; }

    public byte? EbId { get; set; }

    public string? EbSigla { get; set; }

    public string? EbNome { get; set; }

    public int? FkTbRegioesBr { get; set; }

    public virtual TbRegioesBr? FkTbRegioesBrNavigation { get; set; }

    public virtual ICollection<TbAtor> TbAtors { get; set; } = new List<TbAtor>();

    public virtual ICollection<TbMunicipio> TbMunicipios { get; set; } = new List<TbMunicipio>();
}
