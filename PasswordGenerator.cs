using System.Security.Cryptography;

namespace PWDGEN;

internal static class PasswordGenerator
{
    // Only characters that are easy to type on Windows and Android keyboards
    private const string CharSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#-_.";

    // Entropy levels: index 0-3
    public static readonly (int Entropy, string Label)[] EntropyLevels =
    [
        (60, "Low"),
        (80, "Medium"),
        (100, "High"),
        (128, "Very High")
    ];

    public static string Generate(int targetEntropy)
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string digits = "0123456789";
        const string special = "!@#-_.";

        double entropyPerChar = Math.Log2(CharSet.Length);
        int length = (int)Math.Ceiling(targetEntropy / entropyPerChar);

        string password;
        do
        {
            char firstChar = letters[RandomNumberGenerator.GetInt32(letters.Length)];
            string rest = RandomNumberGenerator.GetString(CharSet, length - 1);
            password = firstChar + rest;
        }
        while (!HasAllRequiredCharTypes(password, uppercase, lowercase, digits, special));

        return password;
    }

    private static bool HasAllRequiredCharTypes(string password, string uppercase, string lowercase, string digits, string special)
    {
        return password.AsSpan().IndexOfAny(uppercase) >= 0
            && password.AsSpan().IndexOfAny(lowercase) >= 0
            && password.AsSpan().IndexOfAny(digits) >= 0
            && password.AsSpan().IndexOfAny(special) >= 0;
    }
}
