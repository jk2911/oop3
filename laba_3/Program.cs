using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] student = new object[]
            {
                new Student("Максим", "Гой", "ФИТ", 3),
                new Student("Иван", "Валуй", "Александрович", 2001, "ЛЕСХОЗ", 2, 4),
                new Student("Матвей", "Головий", "Александрович", 2000, "ЛЕСХОЗ", 3, 5),
                new Student("Илья", "Будник", "ЛЕСХОЗ", 4),
                new Student("Илья", "Будник", "ХТИТ", 7),
                new Student("Иван", "Валуй", "Александрович", 1999, "ФИТ", 4, 5),
                new Student("Николай", "Белодед", "Петрович", 2000, "Рокоссовского 12-1-323", 333845117, "ФИТ", 3, 3),
                new Student("Арсений", "Кравжуль", "Петрович", 2001, "Плеханова 52-3-555", 331411738, "ФИТ", 2, 5),
            };
            Console.WriteLine("Список факультета\n");
            foreach(Student i in student)
            {
                if (i.FACULTY == "ФИТ")
                    Console.WriteLine(i.NAME + " " + i.SURNAME + " " + i.PATRONYMIC + " " + i.ID);
            };
            Console.Write("\n///////////////////////////////////////\n");
            Console.WriteLine("\nСписок группы\n");
            foreach (Student i in student)
            {
                if (i.FACULTY == "ФИТ")
                {
                    if (i.GROUP == 3)
                        Console.WriteLine(i.NAME + " " + i.SURNAME + " " + i.PATRONYMIC + " " + i.ID);
                }
            };
            Console.ReadKey();
        }
    }
}
