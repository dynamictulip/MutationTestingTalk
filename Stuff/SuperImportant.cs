using System.Text.RegularExpressions;

public class SuperImportant
{
    public static string Hello => "Hello";

    public static int Add(int a, int b)
    {
        return a + a;
    }

    public static bool IsLessThanFortyTwo(int num)
    {
        return num < 42;
    }

    public static bool IsGmailAddress(string input)
    {
        string gmailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.[a-zA-Z]{2,}$";

        return Regex.IsMatch(input, gmailPattern);
    }
}
