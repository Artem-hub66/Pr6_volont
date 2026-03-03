using System;
using System.Collections.Generic;

namespace Pr6_volontor.Models;

public partial class RegistVolont
{
    public short Id { get; set; }

    public short IdEvent { get; set; }

    public short IdUser { get; set; }

    public DateOnly DateRegist { get; set; }

    public short IdStatusRegist { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;

    public virtual StatusesRegist IdStatusRegistNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
