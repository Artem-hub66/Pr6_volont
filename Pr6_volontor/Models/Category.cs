using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class Category
{
    public short Id { get; set; }

    public string NameCategor { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
