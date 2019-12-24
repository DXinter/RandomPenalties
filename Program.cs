using System;
using System.Collections.Generic;
using System.Threading;

namespace Penalty
{
    class Program
    {
        static Random r = new Random();
        const string s = "'A' - добавить жести; 'C' - очистить консоль; I - показать наказания";                 
        static void Main()
        {
            Default();
            MainCommands();
        }

        private static void Default()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Я хочу поиграть с тобой :)\n{s}");       
        }

        private static string MainCommands()
        {
            var pen = new List<string>
            {  
            "Пинок",
            "Пресс 30 раз",
            "Приседания 40 раз",
            "Крути два раза",
            "Предидущее наказание",
            "Лещ",
            "Плечо",
            "Плохая тачка",
            "Без зарядов",
            "Удар в пресак",
            "Подтягивания 10 раз",
            "Фофан",
            "Давай пой",
            "Супер лещ",
            "Годзилла"
            };        
            string[] mockery = new string[] 
            { 
                "Тебе понравится!",
                "Будь мужиком!",
                "О, вот повезло!",
                "Я не буду это выполнять! ",
                "Как мне надоело проигрывать.",
                "Жопа в огне.",
                "Одно и тоже падает.",
                "Прикольно.",
                "Все, пацаны, в росход.",
                "Только не в коп",
                "Какие сладкие оттенки",
                "Надоели мне ваши игрушки",
                "Давай уберем это много",
                "Чтож так не прет?!"
            };
            string[] Fatality = new string[] { "", "", "", "", "", "", "", "", "", "X2" };
               
            while (true)
            {                 
                    var operation = Console.ReadLine()?.ToUpper();

                if (!string.IsNullOrEmpty(operation))
                {
                    if (operation == "C" || operation == "С")
                    {
                        Console.Clear();
                        Default();
                        Console.ReadLine();
                    }
                      
                    if (operation == "A" || operation == "Ф")
                    {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Давай мути игру:");
                            string add = Console.ReadLine();
                        if (!string.IsNullOrEmpty(add))
                        {
                            pen.Add(add);                       
                            MissionImpossible();
                            Console.WriteLine();                        
                        }                                       
                    }

                    if (operation == "I" || operation == "Ш")
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------------");                       
                        foreach (string s in pen)
                        {
                            Console.WriteLine(s);
                        }                                             
                        Console.WriteLine("------------------------");
                        Console.ResetColor();
                    }

                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{GetRandom(mockery)}");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{GetRandom(pen.ToArray())} " + $"({GetRandom(Fatality)})");
                
            }
        }
        private static string GetRandom(string [] sourse)
        {
            return sourse[r.Next(sourse.Length)];
        }
        private static void Tannenbaum()
        {
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(497, 500);
            Thread.Sleep(500);
            Console.Beep(497, 500);
            Console.Beep(277, 500);
            Console.Beep(277, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(329, 500);
            Console.Beep(247, 500);
            Console.Beep(417, 500);
            Console.Beep(417, 500);
            Console.Beep(370, 500);
            Console.Beep(417, 500);
            Console.Beep(329, 500);
        }
        private static void MissionImpossible()
        {
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(932, 150);
            Thread.Sleep(150);
            Console.Beep(1047, 150);
            Thread.Sleep(150);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(784, 150);
            Thread.Sleep(300);
            Console.Beep(699, 150);
            Thread.Sleep(150);
            Console.Beep(740, 150);
            Thread.Sleep(150);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }
    }
}