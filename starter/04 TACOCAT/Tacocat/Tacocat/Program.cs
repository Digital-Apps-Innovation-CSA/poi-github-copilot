
//Function to validate palindrome string

// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsPalindrome("ana"));
Console.WriteLine(IsPalindrome("sol"));


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