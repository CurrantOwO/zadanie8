using System;
using studentlib;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tМеню");
            Console.WriteLine("\nДля выполнения действий нажмите следующую цифру:\n");
            Console.WriteLine("\t1.Показать Информацию о студентах");
            // Console.WriteLine();
            Console.WriteLine("\t2.Добавить студента\n\t3.Удалить сдутента\n\t4.Изменить студента\n\t5.Поиск студентов\n\t6.Выход\n");
            Student a = new Student();

            a.fio = "Зябликов Василий Петячкин";
            a.dat = "12.10.2003";
            a.grp = 12;
            a.fio = "Зяблов Васий Потчкин";
            a.dat = "12.10.2000";
            a.grp = 12;
            a.fio = "Баулов Валентин Валович";
            a.dat = "04.11.1997";
            a.grp = 8;
            a.fio = "Енулов Антон Вилович";
            a.dat = "02.12.2005";
            a.grp = 6;
            a.fio = "Рубцов Сергей Виторович";
            a.dat = "03.12.1919";
            a.grp = 808;
            int n = 0;
            while (n != 6)
            {
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Вся информация о студентах\n\t2.Список студентов с инициалами\n\t" +
                                "3.Список студентов старше 18\n\t4.Список студентов младше 18\n");
                            int no = Convert.ToInt32(Console.ReadLine());
                            switch (no)
                            {
                                case 1: { a.Info(); break; }
                                case 2: { a.Inic(); break; }
                                case 3: { a.sor('s'); break; }
                                case 4: { a.sor('a'); break; }
                            }
                            break;
                        }
                    case 2: { a.add(); break; }
                    case 3: { a.Dell(); break; }
                    case 4: { a.redakt(); break; }
                    case 5:
                        {
                            Console.WriteLine("\nЧто именно вы хотите?\n\n\t1.Найти студента по id\n\t2.Найти студента по фамилии\n"); 
                            int no = Convert.ToInt32(Console.ReadLine());
                            switch (no)
                            {
                                case 1: { a.Sid(); break; }
                                case 2: { a.ser(); break; }
                            }
                            break;
                        }
                }
            }
        }
    }
}
