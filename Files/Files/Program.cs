using System;
using System.IO;
using System.Text;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Введите путь к файлу:");
            //string filePath = Console.ReadLine();

            //FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);

            //Console.WriteLine("Введите категорию продукта:");
            //string category = Console.ReadLine();

            //Console.WriteLine("Введите название продукта:");
            //string productName = Console.ReadLine();

            //Console.WriteLine("Введите количество товара в наличии:");
            //int stockQuantity = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите цену за единицу товара:");
            //double unitPrice = double.Parse(Console.ReadLine());

            //string productInfo = $"Категория: {category}\nНазвание: {productName}\nКоличество в наличии: {stockQuantity}\nЦена за единицу: {unitPrice:C}";

            //byte[] writeBytes = Encoding.UTF8.GetBytes(productInfo); 

            //fs.Write(writeBytes, 0, writeBytes.Length);
            //fs.Flush(); 

            //fs.Seek(0, SeekOrigin.Begin); 

            //byte[] readBytes = new byte[fs.Length];
            //fs.Read(readBytes, 0, readBytes.Length);

            //string readText = Encoding.UTF8.GetString(readBytes);

            //Console.WriteLine("Данные, прочитанные из файла:\n{0}", readText);

            //fs.Close(); 

            const int MB = 1024 * 1024;
            byte[] data = new byte[MB];

            string filePath = "C:\\1\\onemb.txt";
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }
    }
}
