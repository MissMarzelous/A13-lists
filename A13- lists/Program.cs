using System;
using System.Collections.Generic;
using System.Linq;

//Purpose: Establish and store list details from user entry.
public class Program
{
    public static string UpperCaseMethod(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException("no");
        return input.First().ToString().ToUpper() + input.Substring(1);
    }


    public static void Main(string[] args)
    {
         static string UpCase(string value)
        {
            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        // Establish List
        List<string> info = new List<string>();
        Console.WriteLine("Enter your first name please: ");
        string FN = Console.ReadLine();
        Console.WriteLine("Enter your last name please: ");
        string LN = Console.ReadLine();
        Console.WriteLine("Enter street: ");
        string Str = Console.ReadLine();
        Console.WriteLine("Enter City: ");
        string citi = Console.ReadLine();
        Console.WriteLine("Enter State: ");
        string StTe = Console.ReadLine();
        Console.WriteLine("Enter Zip Code: ");
        string zIp = Console.ReadLine();

        //add to items to list
        info.Add(FN);
        info.Add(LN);
        info.Add(Str);
        info.Add(citi);
        info.Add(StTe);
        info.Add(zIp);

        Console.WriteLine("User's Information:\n ");
        foreach (var piece in info)
        {
            Console.WriteLine(UpCase(piece.ToLower()));
        }

    }
 
    // END PROGRAM
}
