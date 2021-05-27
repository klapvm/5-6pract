using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4BurKla
{ 
    public class Student
    {
        ArrayList ID = new ArrayList();
        ArrayList FIO = new ArrayList();
        ArrayList GROUP = new ArrayList();
        ArrayList DATA = new ArrayList();
        int kolvo = 0;
        int id = 0;
        public void Zapolnenie()
        {
            Console.Write("Введите колво студентов: ");
            kolvo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kolvo; i++)
            {
                ID.Add(i);
                Console.Write("Введите ФИО студента: ");
                string fio = Console.ReadLine();
                FIO.Add(fio);
                Console.Write("Введите группу студента: ");
                string group = Console.ReadLine();
                GROUP.Add(group);
                Console.Write("Введите дату рождения студента: ");
                string data = Console.ReadLine();
                DATA.Add(data);
                id++;
                Console.WriteLine("\n");
            }
        }

        public void Add()
        {
            kolvo++;
            ID.Add(id);
            Console.Write("Введите ФИО студента: ");
            string fio = Console.ReadLine();
            FIO.Add(fio);
            Console.Write("Введите группу студента: ");
            string group = Console.ReadLine();
            GROUP.Add(group);
            Console.Write("Введите дату рождения студента: ");
            string data = Console.ReadLine();
            DATA.Add(data);

        }
        
        public void Show()
        { 
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine(ID[i]);
                Console.WriteLine(FIO[i]);
                Console.WriteLine(GROUP[i]);
                Console.WriteLine(DATA[i]+ "\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Zapolnenie();
            Console.WriteLine("\nВыберете действие: \n 1 - вывод списка студентов\n2 - добавить студента\n6-выход");
            int sw = Convert.ToInt32(Console.ReadLine());
            while (sw != 6)
            {
                switch (sw)
                {
                    case 1:
                        student.Show();
                        Console.WriteLine("\nВыберете действие: \n1 - вывод списка студентов\n2 - добавить студента\n6-выход");
                        sw = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        student.Add();
                        Console.WriteLine("\nВыберете действие: \n 1 - вывод списка студентов\n2 - добавить студента\n6-выход");
                        sw = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
