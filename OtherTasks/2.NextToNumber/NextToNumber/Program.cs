using System;

class Program
{
    static void Main()
    {
        long numberM = long.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;


        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                return;
            }
            else if (char.IsDigit(text[i]))
            {
                result *= (text[i] - '0');
            }
            else if ((text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122))
            {
                if ((text[i] >= 65 && text[i] <= 90))
                {
                    result += text[i] - 65;
                }
                else if ((text[i] >= 97 && text[i] <= 122))
                {
                    result += text[i] - 97;
                }
            }
            else
            {
                result %= numberM;
            }
        }
        Console.WriteLine(result);

    }
}