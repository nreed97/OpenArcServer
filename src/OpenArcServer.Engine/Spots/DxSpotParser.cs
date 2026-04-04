namespace OpenArcServer.Engine.Spots;

public static class DxSpotParser
{
    /// <summary>
    /// Parse "DX 14025.0 W1AW good signal" or "DX 14025 W1AW" style input.
    /// The "DX" verb is already stripped from input before this is called;
    /// pass the argument portion: "14025.0 W1AW good signal"
    /// Returns (freq, call, comment) or null if unparseable.
    /// </summary>
    public static (float Freq, string Call, string Comment)? Parse(string args)
    {
        if (string.IsNullOrWhiteSpace(args))
            return null;

        var parts = args.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2)
            return null;

        if (!float.TryParse(parts[0],
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out var freq))
            return null;

        var call = parts[1].ToUpperInvariant();
        var comment = parts.Length > 2
            ? string.Join(' ', parts[2..])
            : string.Empty;

        return (freq, call, comment);
    }
}
