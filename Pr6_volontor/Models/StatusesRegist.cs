using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class StatusesRegist
{
    public short Id { get; set; }

    public string NameStatus { get; set; } = null!;

    public virtual ICollection<RegistVolont> RegistVolonts { get; set; } = new List<RegistVolont>();
}
