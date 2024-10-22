using System;

class Program
{
    static void Main()
    {
        string input = "racecar";
        bool result = Polindrome(input);
        Console.WriteLine(result); 
    }
    static bool Polindrome(string str)
    {
        str = str.ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; 
            }
            left++;
            right--;
        }
        return true;
    }
}
