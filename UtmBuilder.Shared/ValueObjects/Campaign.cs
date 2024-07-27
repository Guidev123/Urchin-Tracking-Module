using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Shared.ValueObjects;

public class Campaign : ValueObjectBase
{
    public Campaign(string source, string medium, string name,
                    string? id = null, string? term = null, string? content = null)
    {
        Source = source;
        Medium = medium;
        Name = name;
        Id = id;
        Term = term;
        Content = content;
    }
    public string Source { get; private set; }
    public string Name { get; private set; }
    public string Medium { get; private set; }
    public string? Id { get; private set; }
    public string? Term { get; private set; }
    public string? Content { get; private set; }
}
