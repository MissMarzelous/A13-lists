using System;
using System.Collections.Generic;
using System.Globalization;

namespace AddressBookFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("   ADDRESS BOOK ENTRY");
            Console.WriteLine("===========================");
            Console.WriteLine("(Leave blank and press Enter to finish)\n");

            List<string> addresses = CollectAddresses();

            if (addresses.Count == 0)
            {
                Console.WriteLine("No addresses entered. Exiting.");
                return;
            }

            List<string> formattedAddresses = FormatAddresses(addresses);
            PrintAddressList(formattedAddresses);
        }

        /// <summary>
        /// Collects addresses from the user until a blank entry is submitted.
        /// </summary>
        static List<string> CollectAddresses()
        {
            var addresses = new List<string>();

            while (true)
            {
                Console.Write($"Address {addresses.Count + 1}: ");
                string input = Console.ReadLine()?.Trim();

                // Blank entry signals the user is done
                if (string.IsNullOrEmpty(input))
                    break;

                addresses.Add(input);
            }

            return addresses;
        }

        /// <summary>
        /// Applies title-case formatting to each address in the list.
        /// </summary>
        static List<string> FormatAddresses(List<string> rawAddresses)
        {
            // Use the current culture's TextInfo for locale-aware title casing
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            var formatted = new List<string>();

            foreach (string address in rawAddresses)
            {
                // ToLower() first ensures consistent title-casing from any input case
                string titleCased = textInfo.ToTitleCase(address.ToLower());
                formatted.Add(titleCased);
            }

            return formatted;
        }

        /// <summary>
        /// Displays the formatted address list with numbered entries.
        /// </summary>
        static void PrintAddressList(List<string> addresses)
        {
            Console.WriteLine("\n===========================");
            Console.WriteLine("   FORMATTED ADDRESS LIST");
            Console.WriteLine("===========================");

            for (int i = 0; i < addresses.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}. {addresses[i]}");
            }

            Console.WriteLine("===========================");
            Console.WriteLine($"Total Addresses: {addresses.Count}");
        }
    }
}
