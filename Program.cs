namespace kontrolnaia
// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше либо равна 3 символа.
{
    internal class NewBaseType
    {
        private static void Main(string[] args)
        {
            string[] A;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
            A = stroka.Split(' ');
            var result = new string[A.Length];
            var realSize = 0;
            foreach (var value in A)
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);
        }
    }
}   


