using System;

namespace _7._3___structuree
{
    class Program
    {
        struct sotrudniki
        {
            public string FamNameOtch;
            public int DateofBirth;
            public string Doljn;
            public int zp;

            public sotrudniki(string a, int b, string c, int d)
            {
                FamNameOtch = a;
                DateofBirth = b;
                Doljn = c;
                zp = d;
            }
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Сотрудники:   ");
            Console.WriteLine("                         ");
            sotrudniki[] X = new sotrudniki[8];
            X[0].FamNameOtch = "Евгеньевич Евгений Баженов";
            X[0].DateofBirth = 1989;
            X[0].Doljn = " [бухгалтер] ";
            X[0].zp = 30000;

            X[1] = new sotrudniki("Емельянов Устин Владиславович", 1980, " [Программист] ", 50000);
            X[2] = new sotrudniki("Быков Корнелий Иринеевич", 1999, " [IT Руководитель] ", 75000);
            X[3] = new sotrudniki("Комиссаров Пантелей Кириллович", 2002, " [Отдел кадров] ", 47500);
            X[4] = new sotrudniki("Грибова Ирина Натальевна", 1987, " [Стажер] ", 29000);
            X[5] = new sotrudniki("Иванов Аким Георгиевич", 1991, " [Уборщий] ", 25000);
            X[6] = new sotrudniki("Юдин Гордей Русланович", 1998, " [Администратор] ", 42000);
            X[7] = new sotrudniki("Михайлов Михаил Петрович", 2002, " [Менеджер IT] ", 62000);
            {
                for (int i = 0; i <= 7; i++)
                {
                    Console.WriteLine(X[i].FamNameOtch + ": " + X[i].DateofBirth + " год " + X[i].Doljn + X[i].zp + " руб");

                }
            }
            double max = X[0].DateofBirth;
            int z = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i].DateofBirth > 1990 && X[i].zp > 30000)
                {
                    max = X[i].DateofBirth;
                    z = i;
                    Console.WriteLine("                         ");
                    Console.WriteLine("                         ");
                    Console.WriteLine("                         ");
                    Console.WriteLine("Сотрудники с возрастом меньше 30 лет и информация о нем:");
                    Console.WriteLine("ФИО: {0} \n Год рождения: {1}\n Должность: {2}\n Зарплата: {3} руб", X[z].FamNameOtch, X[z].DateofBirth, X[z].Doljn, X[z].zp);
                }
            }
        }
    }
}