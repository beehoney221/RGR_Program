using System.Reflection.Metadata;
using System;
using System.Globalization;

class Prikol
{
    public static void ObAvtore()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Расчётно-графическая работа по программированию");
        Console.WriteLine("Омский государственный технический университет");
        Console.WriteLine("Факультет информационных технологий и компьютерных систем");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Группа: МО-221");
        Console.WriteLine("Тютюник Мария Сергеевна");
        Console.ResetColor();
        Console.ReadLine();
    }
    public static void Vihod()
    {
        Environment.Exit(0);
    }

    public static void DayOW()
    {
        Console.Clear();
        List<string> w = new List<string>() { "ВС", "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ" };
        Console.WriteLine(">> День недели -> числа\n");
        Console.WriteLine("Первое число интервала");
        Console.Write("Введите число: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите год: ");
        int y = Convert.ToInt32(Console.ReadLine());
        DateTime dt1 = new DateTime(y, m, d);
        Console.WriteLine("Второе число интервала");
        Console.Write("Введите число: ");
        d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите месяц: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите год: ");
        y = Convert.ToInt32(Console.ReadLine());
        DateTime dt2 = new DateTime(y, m, d);
        Console.Write("Введите день недели (ПН, ВТ и тп): ");
        string day = Console.ReadLine();
        int dow = w.IndexOf(day);
        int kol = dt2.Subtract(dt1).Days;
        Console.Clear();
        Console.WriteLine(">> День недели -> числа >> {0} - {1}, {2}\n", dt1.ToShortDateString(), dt2.ToShortDateString(), day);
        ChColor(dow);
        for (int i = 0; i < kol; i++)
        {
            if (Convert.ToInt32(dt1.AddDays(i).DayOfWeek) == dow) Console.WriteLine(dt1.AddDays(i).ToLongDateString());
            if (dt1.AddDays(i) == dt2) break;
        }
        Console.ResetColor();
        Console.WriteLine("\nДля выхода нажмите Enter...");
        Console.ReadLine();
    }
    public static void Date()
    {
        Console.Clear();
        Console.WriteLine(">> Дата -> день недели\n");
        Console.WriteLine("Введите число");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год");
        int y = Convert.ToInt32(Console.ReadLine());
        DateTime dt = new DateTime(y, m, d);
        if (Convert.ToInt32(dt.DayOfWeek) == 0) ChColor(6);
        else ChColor(Convert.ToInt32(dt.DayOfWeek - 1));
        Console.WriteLine("\n{0} - {1}", dt.ToLongDateString(), dt.ToString("dddd", new CultureInfo("ru-RU")));
        Console.ResetColor();
        Console.WriteLine("\nДля выхода нажмите Enter...");
        Console.ReadLine();
    }
    public static void Calendar(List<string> w, List<string> m)
    {
        Console.Clear();
        Console.WriteLine(">> Календарь\n");
        string[] lines = { "1 - Месяц", "2 - Семестр", "3 - Календарный год", "4 - Учебный год", "5 - Выход" };
        int code;
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(lines[i]);
            }
            code = Convert.ToInt32(Console.ReadLine());
            switch (code)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Месяц\n");
                    Console.WriteLine("Какой месяц? (1 - январь, 2 - февраль и т.д.)");
                    int month = Convert.ToInt32(Console.ReadLine());
                    string mon = m[month - 1];
                    Console.WriteLine("Какой год? (пр. 2008)");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Месяц >> {0} {1}\n", mon, year);                
                    VM(year, month, w);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Семестр\n");
                    Console.WriteLine("Какой семестр? (1 (сентябрь - январь) или 2 (февраль - июнь))");
                    int sem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Какой год? (пр. 2008)");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();                    
                    string ws = "";
                    switch (sem)
                    {
                        case 1: 
                            ws = "Первый семестр (сентябрь - январь)"; 
                            Console.WriteLine(">> Календарь >> Семестр >> {0} {1}-{2}\n", ws, year, year + 1);
                            for (month = 9; month <= 12; month++)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n\t\t" + m[month-1] + "\n");
                                Console.ResetColor();
                                VM(year, month, w);
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\n\t\t" + m[0] + "\n");
                            Console.ResetColor();
                            VM(year + 1, 1, w);
                            Console.ReadLine();
                            break;
                        case 2: 
                            ws = "Второй семестр (февраль - июнь)";
                            Console.WriteLine(">> Календарь >> Семестр >> {0} {1}-{2}\n", ws, year, year + 1);
                            for (month = 2; month <= 6; month++)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\n\t\t" + m[month - 1] + "\n");
                                Console.ResetColor();
                                VM(year + 1, month, w);
                            }
                            Console.ReadLine();
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Календарный год\n");
                    Console.WriteLine("Какой год? (пр. 2008)");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Календарный год >> {0}\n", year);
                    for (month = 1; month <= 12; month++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t" + m[month - 1] + "\n");
                        Console.ResetColor();
                        VM(year, month, w);
                    }
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Учебный год\n");
                    Console.WriteLine("Какой год? (пр. 2008)");
                    year = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(">> Календарь >> Учебный год >> {0}-{1}\n", year, year + 1);
                    for (month = 9; month <= 12; month++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t" + m[month - 1] + "\n");
                        Console.ResetColor();
                        VM(year, month, w);
                    }
                    for (month = 1; month <= 6; month++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t" + m[month - 1] + "\n");
                        Console.ResetColor();
                        VM(year + 1, month, w);
                    }
                    Console.ReadLine();
                    break;
                case 5: Main(); break;
            }            
        }
    }
    static void VM (int y, int m, List<string> w)
    {
        foreach (var day in w)
        {
            ChColor(w.IndexOf(day));
            Console.Write(day + "\t");
            Console.ResetColor();
        } 
        Console.WriteLine();
        for (int d = 1; d <= DateTime.DaysInMonth(y, m); d++)
        {
            DateTime dt = new DateTime(y, m, d);
            if (Convert.ToInt32(dt.DayOfWeek) == 0) ChColor(6);
            else ChColor(Convert.ToInt32(dt.DayOfWeek) - 1);
            if (d == 1)
            {
                string result;
                if (Convert.ToInt32(dt.DayOfWeek) == 0)
                {
                    result = string.Concat(Enumerable.Repeat("\t", 6));
                    Console.WriteLine(result + d);
                }
                else
                {
                    result = string.Concat(Enumerable.Repeat("\t", Convert.ToInt32(dt.DayOfWeek) - 1));
                    Console.Write(result + "1\t");
                }
            }
            else
            {
                if (Convert.ToInt32(dt.DayOfWeek) == 0) Console.WriteLine(d);
                else Console.Write(d + "\t");
            }
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    static void ChColor (int d)
    {
        switch (d)
        {
            case 0: Console.ForegroundColor = ConsoleColor.Red; break;
            case 1: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
            case 2: Console.ForegroundColor = ConsoleColor.Yellow; break;
            case 3: Console.ForegroundColor = ConsoleColor.Green; break;
            case 4: Console.ForegroundColor = ConsoleColor.Blue; break;
            case 5: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
            case 6: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
        }
    }
    public static void Main()
    {
        List<string> week = new List<string>() { "ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС"};
        List <string> month = new List<string> { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        string[] lines = { "1 - Календарь", "2 - Дата -> день недели", "3 - День недели -> числа", "4 - Об авторе", "5 - Выход" };
        int code;
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine(lines[i]);
            }
            code = Convert.ToInt32(Console.ReadLine());
            switch (code)
            {
                case 1: Calendar(week, month); break;
                case 2: Date(); break;
                case 3: DayOW(); break;
                case 4: ObAvtore(); break;
                case 5: Vihod(); break;
            }
        }
    }
}
