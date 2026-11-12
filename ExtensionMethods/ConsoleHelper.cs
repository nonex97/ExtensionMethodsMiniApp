using System;

public static class ConsoleHelper
{
    public static string RequestString(this string message)
    {
        string output = "";

        while (string.IsNullOrWhiteSpace(output))
        {
            Console.Write(message);
            output = Console.ReadLine();
        }

        return output;        
    }

    public static int RequestInt(this string message, int minValue, int maxValue)
    {
        return message.RequestInt(true, minValue, maxValue);
    }

    public static int RequestInt(this string message)
    {
        return message.RequestInt(false); // message is already passed in, so we only need to pas useMinMax
    }

    private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0) // it's private so it can be used internally by other methods, min and max value are set 0 by default so if we don't use them we don't need to set them
    {
        int output = 0;
        bool isValidInt = false;
        bool isInValidRange = true;

        while (isValidInt == false || isInValidRange == false)
        {
            Console.Write(message);
            isValidInt = int.TryParse(Console.ReadLine(), out output);

            if (useMinMax == true)
            {
                isInValidRange = (output >= minValue && output <= maxValue); // this line is the same as commented code below but more sleek, we set the bool to either true/false since that's what the check returns
                
                //if (output >= minValue && output <= maxValue)
                //{
                //    isInValidRange = true;
                //}
                //else
                //{
                //    isInValidRange = false;
                //}
            }
        }

        return output;
    }
}
