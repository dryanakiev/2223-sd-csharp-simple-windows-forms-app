using System;
using System.Collections.Generic;

namespace Csharp_windows_library.Models;

public partial class OwnedBook
{
    public int? UserId { get; set; }

    public int? BookId { get; set; }
    public virtual Book? Book { get; set; }

    public virtual User? User { get; set; }
}
