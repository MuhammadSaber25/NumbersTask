using System.Xml.Linq;

namespace NumbersTask
{
    internal class Program
    {
        public static int x = 1;
        static List<int> Element = [];
        public static void Operations()
        {
            do
            {
                Console.WriteLine();

                Console.WriteLine("P - Print numbers\r\nA - Add a number\r\nM - Display mean of the numbers\r\nS - Display the smallest number\r\nL - Display the largest number\r\nF - Find the number\r\nC - Clear List\r\nQ - Quit\r\n");

                Console.Write("Enter your choice:");

                string Choice = Console.ReadLine().ToLower();

                Console.WriteLine();

                switch (Choice)
                {
                    case "p":
                        if (Element.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", Element)}]");
                        }
                        break;

                    case "a":

                        Console.Write("Enter item:");
                        int Item = int.Parse(Console.ReadLine());

                        if (CheckDuplicate(Element, Item))
                        {
                            Console.WriteLine(value: "This item already exists");
                        }
                        else
                        {
                            Element.Add(Item);
                            Console.WriteLine($"{Item} added");
                        }

                        break;

                    case "m":
                        if (Element.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            Console.WriteLine($"The mean is {CalculateAvrage(Element)}");
                        }
                        break;

                    case "s":
                        if (Element.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"The smallest number is {GetSmallestElement(Element)}");
                        }
                        break;

                    case "l":
                        if (Element.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            Console.WriteLine($"The largest number is {GetLargestElement(Element)}");
                        }
                        break;

                    case "q":
                        x = 0;
                        Console.WriteLine("Goodbye");
                        break;

                    case "f":
                        if (Element.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");
                        }
                        else
                        {
                            Console.Write("Enter Number:");
                            int Number = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{SearchItem(Element, Number)}");
                        }
                        break;

                    case "c":
                        Element.Clear();
                        Console.WriteLine($"List has been cleared");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            }
            while (x == 1);
        }
        private static int GetLargestElement(List<int> elemant)
        {
            int x = elemant[0];

            for (int i = 1; i <= elemant.Count() - 1; i++)
            {
                if (x > elemant[i])
                {
                    continue;
                }
                x = elemant[i];

            }
            return x;
        }
        private static int GetSmallestElement(List<int> elemant)
        {
            int x = elemant[0];

            for (int i = 1; i <= elemant.Count() - 1; i++)
            {
                if (x < elemant[i])
                {
                    continue;
                }
                x = elemant[i];

            }
            return x;
        }
        private static double CalculateAvrage(List<int> elemant)
        {
            int avr = 0;

            for (int i = 0; i <= elemant.Count() - 1; i++)
            {
                avr += elemant[i];

            }

            return (avr / elemant.Count());
        }
        private static bool CheckDuplicate(List<int> elemant, int x)
        {

            for (int i = 0; i <= elemant.Count() - 1; i++)
            {
                if (x == elemant[i])
                {
                    return true;
                }
            }
            return false;
        }

        private static string SearchItem(List<int> elemant, int x)
        {
            string res = "Not Found";

            for (int i = 0; i <= elemant.Count() - 1; i++)
            {
                if (x == elemant[i])
                {
                    res = "Found";
                    break;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
           Operations();
        }
    }
}
