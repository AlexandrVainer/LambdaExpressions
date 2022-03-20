namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 5, 6, 11, 12, 13, 14, 22, 23, 33, 44, 55 ,77};

            int[] evenArray = GetFiltered(array, (number) => number % 2 == 0);

            int[] notEvenArray = GetFiltered(array, (number) => number % 2 != 0);

            int[] has3Array = GetFiltered(array, (number) => number.ToString().Contains("3"));

            int[] hasSameNumberArray = GetFiltered(array, (number) =>
            {
                char firstChar = number.ToString()[0];
                foreach (char c in number.ToString())
                    if (c != firstChar)
                        return false;
                return true;
            });

            //
            System.Console.WriteLine("Original array items:");
            Print(array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Even array items:");
            Print(evenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Not even array items:");
            Print(notEvenArray);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has 3 array items:");
            Print(has3Array);
            System.Console.WriteLine("\n********************");
            System.Console.WriteLine("Has same number array items:");
            Print(hasSameNumberArray);
            System.Console.WriteLine("\n********************");
        }
        static int[] GetFiltered(int[] arr, Func<int, bool> filter)
        {
            int[] filteredArr = new int[arr.Length];
            int count = 0;
            foreach (int i in arr)
                if (filter(i))
                    filteredArr[count++] = i;
            Array.Resize(ref filteredArr, count); ;
            return filteredArr;

        }

        public static void Print(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i + ",");
            Console.WriteLine();
        }
    }


}
