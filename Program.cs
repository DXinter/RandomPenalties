using System;
using System.Collections.Generic;

namespace Penalty
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {          
            List<string> pen = new List<string>();
            string[] mockery = new string[] { "Тебе понравится!", 
                "Будь мужиком!",
                "О, вот повезло!",
                "Я не буду это выполнять! ",
                "Как мне надоело проигрывать.",
                "Жопа в огне.",
                "Одно и тоже падает.",
                "Прикольно.",
                "Все пацаны в росход.",
                "Только не в коп"};
            string[] Fatality = new string[] { "", "", "", "", "", "", "", "", "", "X2" };
            Console.WriteLine("Я хочу поиграть с тобой :)");
            Set(pen);
            MainCommands(pen, mockery, Fatality);
        }
        private static string MainCommands(List<string> pen, string[] mockery, string [] Fatality)
        {
            string operation;
            while (true)
            {               
                operation = Convert.ToString(Console.ReadLine()).ToUpper();
                if (operation == "C" || operation == "С")
                    Console.Clear();
                if (operation == "A" || operation == "Ф")
                {
                    Console.WriteLine("Давай мути игру:");
                    string add = Console.ReadLine();
                    pen.Add(add);
                }
                
                Randoms(pen, mockery, Fatality);
            }
        }
        private static void Randoms(List<string> pen, string[] mockery, string [] Fatality)
        {
            int rnd1 = Lucky(mockery);           
            int rnd = Penalties(pen);
            int rndF = Fatalities(Fatality);

            Console.WriteLine($"{mockery[rnd1]}");
            Console.WriteLine($"{pen[rnd]} " + $"({Fatality[rndF]})");
        }

        private static void Set(List<string> pen)
        {
            pen.Add("Пинок");
            pen.Add("Пресс 30 раз");
            pen.Add("Приседания 40 раз");
            pen.Add("Двойное наказание");
            pen.Add("Предидущее наказание");
            pen.Add("Лещ");
            pen.Add("Плечо");
            pen.Add("Плохая тачка");
            pen.Add("Без зарядов");
            pen.Add("Удар в пресак");
        }

        public static int Penalties(List<string> input)
        {
            int rnd = 0;
            return rnd = r.Next(input.Count);
        }
        public static int Lucky(string[] input)
        {
            int rnd = 0;          
            return rnd = r.Next(input.Length);
        }
        public static int Fatalities(string[] input)
        {        
            int rndF = 0;
            return rndF = r.Next(input.Length);
        }
    }
}