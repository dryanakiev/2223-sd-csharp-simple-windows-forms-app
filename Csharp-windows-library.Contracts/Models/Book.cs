using System;
using System.Collections.Generic;

namespace Csharp_windows_library.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? BookName { get; set; }

    public string? AuthorFirstName { get; set; }

    public string? AuthorLastName { get; set; }

    public string? Genre { get; set; }

    public int? Rating { get; set; }
}
