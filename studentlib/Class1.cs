using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlib
{
    public class Student
    {
        private int Id;
        private string FIO;
        private int Group;
        private string Data;
        ArrayList inf = new ArrayList();
        public int id
        {
            get { return Id; }
            set { if (value >= 0) Id = value; }
        }
        public int grp
        {
            get { return Group; }
            set { if (value >= 0) Group = value; inf.Add(Group); }
        }
        public string fio
        {
            get { return FIO; }
            set { if (value != "" || value != " ") FIO = value; inf.Add(FIO); }
        }
        public string dat
        {
            get { return Data; }
            set { if (value != "" || value != " ") Data = value; inf.Add(Data); }
        }
        public void Info()//список всех студентов
        {
            int li = 1;
            for (int i = 0; i < inf.Count; i++)
            {
                if (i == 0 || i % 3 == 0) { Console.WriteLine("Студент №" + li); li++; Console.WriteLine("\t" + inf[i]); }
                else { Console.WriteLine("\t" + inf[i]); }
            }
        }
        public void add()//добавляем данные
        {
            string n, d;
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            fio = n;
            grp = g;
            dat = d;
            Info();
        }
        public void redakt()//изменяем
        {
            string n, d;
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            inf[nu - 1] = n;
            inf[nu] = d;
            inf[nu + 1] = g;
            Info();
        }
        public void Dell()//удоляем
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            inf.RemoveRange(nu - 1, 3);
            Info();
        }
        public void Sid()//поиск по id
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            for (int i = nu - 1; i < du + 2; i++) { Console.WriteLine("\t" + inf[i]); }
        }
        public void Old()//считаем возраст у студентов под вводим id
        {
            Console.Write("Выберите номер студента: ");
            int nu = Convert.ToInt32(Console.ReadLine());
            int du = nu;
            if (nu > 1) { for (int i = 1; i < du; i++) nu = nu + 2; }
            string s = inf[nu] + "";
            Console.WriteLine(s);
            s = s.Substring(s.Length - 4);
            int z = Convert.ToInt32(s);
            z = 2020 - z;
            Console.WriteLine("В этом году студенту " + z);
        }
        public void Inic()//Выводим инициалы
        {
            for (int i = 0; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                string[] inc = s.Split(' ');
                string z = inc[1], l = inc[2];
                s = inc[0] + " " + z[0] + ". " + l[0] + ". ";
                Console.WriteLine("\n\t" + s);
            }
        }
        public void sor(char la)//сортировка по возрасту "s" "a" 
        {
            if (la == 's') { Console.WriteLine("Суденты старше 18 лет:"); }
            else if (la == 'a') { Console.WriteLine("Суденты младше 18 лет:"); }
            for (int i = 1; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                s = s.Substring(s.Length - 4);
                int z = Convert.ToInt32(s);
                z = 2020 - z;
                if (z > 18 && la == 's')
                {
                    Console.WriteLine("\nСтудент №" + i % 3);
                    Console.WriteLine("\t" + inf[i - 1] + "\n\t" + inf[i] + "\n\t" + inf[i + 1]);
                }
                else if (z < 18 && la == 'a')
                {
                    Console.WriteLine("\nСтудент №" + i % 3);
                    Console.WriteLine("\t" + inf[i - 1] + "\n\t" + inf[i] + "\n\t" + inf[i + 1]);
                }
            }
        }
        public void ser()//Поиск по фамилии
        {
            string sa = Convert.ToString(Console.ReadLine());
            int za = 0;
            for (int i = 0; i < inf.Count; i += 3)
            {
                string s = inf[i] + "";
                int a = 0;
                for (int la = 0; la < sa.Length; la++)
                {
                    if (sa[la] == s[la]) { a++; }
                }
                if (a == sa.Length) { Console.WriteLine(s); za++; }
            }
            if(za == 0) { Console.WriteLine("\nСовпадения не найдены\n"); }
        }
    }

}
