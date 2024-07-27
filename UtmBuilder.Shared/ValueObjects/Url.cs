using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Shared.ValueObjects.Exceptions;

namespace UtmBuilder.Shared.ValueObjects;

public class Url : ValueObjectBase
{
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }
    public string Address { get; private set; }
}
