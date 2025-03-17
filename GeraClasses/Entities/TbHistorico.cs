using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbHistorico
{
    public int IdHistorico { get; set; }

    public DateTime HiDtCri { get; set; }

    public string? HiSqlTableName { get; set; }

    public string? HiSqlColumnName { get; set; }

    public string? HiConteudoAnterior { get; set; }

    public string? HiConteudoNovo { get; set; }

    public int? FkTbEst { get; set; }

    public int? FkTbAtor { get; set; }

    public virtual TbAtor? FkTbAtorNavigation { get; set; }

    public virtual TbEst? FkTbEstNavigation { get; set; }
}
