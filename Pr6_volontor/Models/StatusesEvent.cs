using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class StatusesEvent
{
    public short Id { get; set; }

    public string NameStatus { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
