namespace Generics276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generic Programs");
            Console.WriteLine("Select the program given below");
            Console.WriteLine("\n1:SimpleArray\n2:Genericmethod");
            int option = Convert.ToInt32(Console.ReadLine());
            int[] intArray = { 2, 3, 4, 5 };
            double[] doubleArray = { 2.3, 4.5, 5.7, 7.8 };
            char[] charArray = { 'A', 'N', 'D', 'L' };
            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    break;
                case 2:
                    Genericmethod.ToPrint<int>(intArray);
                    Genericmethod.ToPrint<double>(doubleArray);
                    Genericmethod.ToPrint<char>(charArray);
                    break;
                default:
                    Console.WriteLine("Please select the program given below");
                    break;
            }
        }
    }
}