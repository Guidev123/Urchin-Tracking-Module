using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Shared.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string DEFAULT_ERROR_MESSAGE = "URL is invalid!";

    public InvalidUrlException(string message = DEFAULT_ERROR_MESSAGE) : base(message)
    {
    }

    public static void ThrowIfInvalid(string address, string message = DEFAULT_ERROR_MESSAGE)
    {
        if (string.IsNullOrEmpty(address)) throw new InvalidUrlException(message);

        if (!UrlRegex().IsMatch(address)) throw new InvalidUrlException();
    }

    [GeneratedRegex("^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
    private static partial Regex UrlRegex();
}
