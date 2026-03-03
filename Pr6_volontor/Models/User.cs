using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class User
{
    public short Id { get; set; }

    public string FullName { get; set; } = null!;

    public short IdRole { get; set; }

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<RegistVolont> RegistVolonts { get; set; } = new List<RegistVolont>();
}
