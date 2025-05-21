/*
            Сериализация данных

Это преобразование данных в байты, но это unsave-контекст, поэтому

Поток - это

Буфер это виртуальная область памяти, имеющая максимальный объем данных
 
 */


using System.Text;

namespace Serialization_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем объект FileStream (принимается массив байтов)
            /*using (FileStream fs = new FileStream("Example.txt", FileMode.OpenOrCreate)) // файл лежит в папке с exe
            {
                byte[] buffer = new byte[fs.Length];
                int bytes = fs.Read(buffer, 0, buffer.Length); // заполняем буфер байтами из нашего файла
                string text = Encoding.UTF8.GetString(buffer, 0, bytes); 
                Console.WriteLine(text);


                byte[] data = Encoding.UTF8.GetBytes("Hello");
                fs.Write(data, 0, data.Length);
            }*/



            // Stream Reader/Writer
            /*using (StreamWriter sw = new StreamWriter("Example.txt"))
            {
                sw.Write("Hello");
            }

            using (StreamReader sr = new StreamReader("Example.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }*/



            // File & FileInfo
            /*
            // File - статический класс
            if (File.Exists("Example.txt"))
            {
                string data = File.ReadAllText("Example.txt"); // Записываем весь текст в строку 
                Console.WriteLine(data);
            }

            // FileInfo - обычный класс ( для работы с одним и тем же файлом много раз)
            FileInfo file = new FileInfo("Example.txt");
            if (file.Exists)
            {
                using (StreamReader sr = file.OpenText())
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }*/


            // Директории
            /* Directory.CreateDirectory("new");
             Directory.Delete("new");*/



            /*int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;
            string longestLine = "";

            using StreamReader sr = new StreamReader("Example.txt");
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;
                    string[] words = line.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;

                    if (line.Length > longestLine.Length)
                    {
                        longestLine = line;
                    }
                }
                Console.WriteLine($"Кол-во строк: {lineCount}");
                Console.WriteLine($"Кол-во символов: {charCount}");
                Console.WriteLine($"Кол-во слов: {wordCount}");
                Console.WriteLine($"Самая длинная лстрока: {longestLine}");
            }*/



            Work.DoWork("TextFiles");


        }
    }
}
