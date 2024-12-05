namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Примеры использования методов
            int countBitsResult = CountBits(10);
            Console.WriteLine($"Count of bits in 10: {countBitsResult}");

            int persistenceResult = Persistence(39);
            Console.WriteLine($"Persistence of 39: {persistenceResult}");

            int digitalRootResult = DigitalRoot(942);
            Console.WriteLine($"Digital root of 942: {digitalRootResult}");
        }

        // Метод для подсчета значащих битов
        static int CountBits(int num)
        {
            // Переводим число в двоичное представление
            string binaryString = Convert.ToString(num, 2);
            int count = 0;

            // Подсчитываем количество единиц в двоичном представлении
            foreach (char bit in binaryString)
            {
                if (bit == '1')
                {
                    count++;
                }
            }

            return count;
        }

        // Метод для подсчета мультипликативной стойкости числа
        static int Persistence(int num)
        {
            int count = 0;

            // Если число однозначное, возвращаем 0
            if (num < 10)
            {
                return count;
            }

            while (num >= 10)
            {
                int product = 1;

                // Перемножаем все цифры числа
                while (num > 0)
                {
                    product *= num % 10;
                    num /= 10;
                }

                num = product; // Обновляем num на произведение цифр
                count++; // Увеличиваем счетчик
            }

            return count;
        }

        // Метод для подсчета цифрового корня числа
        static int DigitalRoot(int num)
        {
            // Если число однозначное, возвращаем его
            if (num < 10)
            {
                return num;
            }

            // Рекурсивно суммируем цифры числа
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return DigitalRoot(sum); // Рекурсивный вызов с суммой
        }
    }
}
