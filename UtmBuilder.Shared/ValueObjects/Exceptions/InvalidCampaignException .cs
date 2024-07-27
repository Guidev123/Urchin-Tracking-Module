using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Shared.ValueObjects.Exceptions;

public class InvalidCampaignException : Exception
{
    private const string DefaultErrorMessage = "UTM parameters are invalid";

    public InvalidCampaignException(string message = DefaultErrorMessage) : base(message)
    {
    }

    public static void ThrowIfNull(string? item, string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(item)) throw new InvalidCampaignException(message);
    }
}
