using System;
using System.Collections.Generic;

namespace APP_System.Domain.Interfaces;

public partial class TbJornadum
{
    public int IdJornada { get; set; }

    public DateTime JoDtCri { get; set; }

    public DateTime JoDtAlt { get; set; }

    public DateTime? JoDtAcs { get; set; }

    public int? JoDesat { get; set; }

    public long JoNumSeq { get; set; }

    public int? JoAberta { get; set; }

    public int? JoCanc { get; set; }

    public int? FkTbPdv { get; set; }

    public int? FkTbEst { get; set; }

    public virtual TbEst? FkTbEstNavigation { get; set; }

    public virtual TbPdv? FkTbPdvNavigation { get; set; }

    public virtual ICollection<TbMovimentacao> TbMovimentacaos { get; set; } = new List<TbMovimentacao>();
}
