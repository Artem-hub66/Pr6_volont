using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class Event
{
    public short Id { get; set; }

    public string NameEvent { get; set; } = null!;

    public short IdCategorie { get; set; }

    public DateOnly DateEvent { get; set; }

    public string Location { get; set; } = null!;

    public int CountUser { get; set; }

    public short IdUser { get; set; }

    public short IdStatusEvent { get; set; }

    public virtual Category IdCategorieNavigation { get; set; } = null!;

    public virtual StatusesEvent IdStatusEventNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<RegistVolont> RegistVolonts { get; set; } = new List<RegistVolont>();
}
