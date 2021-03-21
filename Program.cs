using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            List<string> finalFurniture = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Purchase")
                {
                    Console.WriteLine("Bought furniture:");
                   
                    foreach (var item in finalFurniture)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine($"Total money spend: {totalSum:F2}");

                    break;
                }

                string pattern = @"[>]{2}(?<furniture>[A-Z]+[a-z]*)[<]{2}(?<price>\d+\.?\d+)!(?<count>\d+)";

                Regex regex = new Regex(pattern);

                MatchCollection furnitureDetails = regex.Matches(line);

                foreach (Match furniture in furnitureDetails)
                {
                    if (furnitureDetails.Count > 0)
                    {
                        finalFurniture.Add(furniture.Groups["furniture"].Value);
                        int quantity = (int.Parse)(furniture.Groups["count"].Value);
                        totalSum += (((double.Parse)(furniture.Groups["price"].Value)) * quantity);
                    }
                }
            }
        }
    }
}