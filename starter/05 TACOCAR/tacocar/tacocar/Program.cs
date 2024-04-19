// See https://aka.ms/new-console-template for more information

//function that give me a paindrome number
Console.WriteLine(NextPalindrome(30));
Console.WriteLine(NextPalindrome(1234));

static int NextPalindrome(int n)
{
    while (true)
    {
        n++;
        if (IsPalindrome(n.ToString()))
        {
            return n;
        }
    }
}

static bool IsPalindrome(string s)
{
    int start = 0;
    int end = s.Length - 1;
    while (start < end)
    {
        if (s[start] != s[end])
        {
            return false;
        }
        start++;
        end--;
    }
    return true;
}