using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbMunicipio
{
    public int IdMunicipio { get; set; }

    public int? MuDesat { get; set; }

    public int? MuId { get; set; }

    public string? MuNome { get; set; }

    public int? FkTbEstadosBr { get; set; }

    public virtual TbEstadosBr? FkTbEstadosBrNavigation { get; set; }

    public virtual ICollection<TbAtor> TbAtors { get; set; } = new List<TbAtor>();
}
