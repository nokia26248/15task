namespace _15task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введи строку");
            string str = Console.ReadLine().ToLower();

            //Количество слов
            string[] slova = (str.Split(' '));
            Console.WriteLine($"Количество слов: {slova.Length}");

            //Количесво предложений
            string[] predl = (str.Split('.', '!', '?'));
            Console.WriteLine($"Количество предложений: {predl.Length}");

            //Средняя длина слова
            int summa = 0;
            string[] dlina = (str.Split(' '));

            for (int i = 0; i < dlina.Length; i++)
            {
                summa += dlina[i].Length;
            }

            Console.WriteLine($"Средняя длина слов: {summa} букв");

            //Гласные и согласные буквы
            char[] pon = { 'а', 'у', 'о', 'и', 'э', 'ы', 'я', 'ю', 'е', 'ё', };
            int gl = 0;
            int sg = 0;
            bool sogl2 = true;

            for (int i = 0;i < str.Length;i++)
            {
                if (char.IsLetter(str[i]))
                {
                    for (int j = 0; j < pon.Length; j++)
                    {
                        if (str[i] == pon[j])
                        {
                            gl++;
                            sogl2 = false;
                        }
                    }
                    if (sogl2 = true)
                    {
                        sg++;
                    }
                }
            }

            Console.WriteLine($"Количество гласных: {gl}");
            Console.WriteLine($"Количество согласных: {sg}");
        }
    }
}
