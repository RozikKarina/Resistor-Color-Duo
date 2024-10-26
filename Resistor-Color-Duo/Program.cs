using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    private static readonly Dictionary<string, int> colorValues = new Dictionary<string, int>
    {
        { "black", 0 },
        { "brown", 1 },
        { "red", 2 },
        { "orange", 3 },
        { "yellow", 4 },
        { "green", 5 },
        { "blue", 6 },
        { "violet", 7 },
        { "grey", 8 },
        { "white", 9 }
    };

    public static int Value(string[] colors)
    {
        if (colors.Length < 2)
            throw new ArgumentException("At least two colors are required.");

        // Get the values of the first two colors and concatenate them
        int firstDigit = colorValues[colors[0].ToLower()];
        int secondDigit = colorValues[colors[1].ToLower()];

        // Combine the two values to form a two-digit number
        return firstDigit * 10 + secondDigit;
    }
}