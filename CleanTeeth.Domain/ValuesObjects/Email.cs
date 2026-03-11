using CleanTeeth.Domain.Exceptions;
using System.Text.RegularExpressions;

namespace CleanTeeth.Domain.ValuesObjects;

public sealed record Email
{
    private static readonly Regex _emailRegex =
        new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

    public string Value { get; } = null!;

    public Email(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new BusinessRuleException($"El {nameof(email)} es obligatorio");
        }

        if (!_emailRegex.IsMatch(email.Trim()))
        {
            throw new BusinessRuleException($"El {nameof(email)} no tiene un formato válido");
        }

        Value = email.Trim().ToLowerInvariant();
    }
}