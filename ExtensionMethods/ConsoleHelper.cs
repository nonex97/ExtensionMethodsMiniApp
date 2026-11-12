using System;

public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";
        
        while (string.IsNullOrEmpty(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }
        return output;
    }

    public static int RequestInt(this string message)
    {
        return message.RequestInt(false);
    }

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return message.RequestInt(true, minValue, maxValue);
    }

    private static int RequestInt(this string message, bool checkMinMax, int minValue = 0, int maxValue = 0)
    {
        int output = 0;
        bool isValid = false;
        bool isInrange = true;

        while (isValid == false || isInrange == false)
        {
            Console.Write(message);
            isValid = int.TryParse(Console.ReadLine(), out output);
            if (checkMinMax == true)
            {
                isInrange = (output >= minValue && output <= maxValue);
            }
        }
        return output;
    }

    public static decimal RequestDecimal(this string message)
    {
        decimal output = 0.0m;
        bool isValidDecimal = false;

        while (isValidDecimal == false)
        {
            Console.Write(message);
            isValidDecimal = decimal.TryParse(Console.ReadLine(), out output);
        }       

        return output;
    }
}