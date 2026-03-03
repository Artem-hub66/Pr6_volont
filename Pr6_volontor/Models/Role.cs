using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class Role
{
    public short Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
