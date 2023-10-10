using System;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string testString = "John Doe, 42 years";
        Regex regex = new Regex(@"^([^,]+),\s([0-9]+)");
        Match match = regex.Match(testString);
        if (match.Success)
            Console.WriteLine("Name: " + match.Groups[1].Value + ". Age: " + match.Groups[2].Value);
    }
}