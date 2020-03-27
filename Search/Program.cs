using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //string catalog = @"C:\Users\Игорь\Desktop\Тест";
            WriteLine("Введите путь к каталогу в котором нужно найти файл:\n");
            string catalog = ReadLine();

            WriteLine("Введите название файла с расширением который нужно найти:\n");
            string fileName = ReadLine();

            //проводим поиск в выбранном каталоге и во всех его подкаталогах
            foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName,
                SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                    //по полному пути к файлу создаём объект класса FileInfo
                    FI = new FileInfo(findedFile);
                    //найденный результат выводим в консоль (имя, путь, размер, дата создания файла)
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
                        " Создан: " + FI.CreationTime);

                }
                catch //слишком длинное имя файла
                {
                    continue;
                }

            }
        }
    }
}
