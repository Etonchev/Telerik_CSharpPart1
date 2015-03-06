using System;

class NumberAsWords
{
    static string digitToChar(int number)
    {
        string digit;
        switch (number)
        {
            case 1:
                digit = "one";
                break;
            case 2:
                digit = "two";
                break;
            case 3:
                digit = "three";
                break;
            case 4:
                digit = "four";
                break;
            case 5:
                digit = "five";
                break;
            case 6:
                digit = "six";
                break;
            case 7:
                digit = "seven";
                break;
            case 8:
                digit = "eight";
                break;
            case 9:
                digit = "nine";
                break;
            default:
                digit = "";
                break;
        }
        return digit;
    }

    static string tenthsToChar(int number)
    {
        string digit;
        switch (number)
        {
            case 1:
                digit = "one";
                break;
            case 2:
                digit = "twenty";
                break;
            case 3:
                digit = "thirty";
                break;
            case 4:
                digit = "fourty";
                break;
            case 5:
                digit = "fifty";
                break;
            case 6:
                digit = "sixty";
                break;
            case 7:
                digit = "seventy";
                break;
            case 8:
                digit = "eighty";
                break;
            case 9:
                digit = "ninety";
                break;
            default:
                digit = "";
                break;
        }
        return digit;
    }

    static string teensToChar(int number)
    {
        string digit;
        switch (number)
        {
            case 10:
                digit = "ten";
                break;
            case 11:
                digit = "eleven";
                break;
            case 12:
                digit = "twelve";
                break;
            case 13:
                digit = "thirteen";
                break;
            case 14:
                digit = "fourteen";
                break;
            case 15:
                digit = "fifteen";
                break;
            case 16:
                digit = "sixteen";
                break;
            case 17:
                digit = "seventeen";
                break;
            case 18:
                digit = "eightteen";
                break;
            case 19:
                digit = "nineteen";
                break;
            default:
                digit = "";
                break;
        }
        return digit;
    }

    static void Main()
    {
        string result = "";
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int firstDigit = n / 100;
        int secondDigit = n / 10 % 10;
        int thirdDigit = n % 10;

        if (firstDigit != 0)
        {
            result = digitToChar(firstDigit) + " hundred";
            if (secondDigit != 0)
            {
                result += " and ";
            }
        }

        if (secondDigit == 1)
        {
            result += teensToChar(n % 100);
        }

        if (secondDigit != 0 && secondDigit != 1)
        {
            result += tenthsToChar(secondDigit);
        }

        if (thirdDigit != 0 && secondDigit != 1)
        {
            result += " " + digitToChar(thirdDigit);
        }

        Console.WriteLine(result);

    }
}
