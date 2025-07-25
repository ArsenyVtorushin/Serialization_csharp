//experiment
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_csharp
{
    public class Work
    {
      
        public static void DoWork(string name)
        {
            HashSet<string> stopwords = new HashSet<string>();

            using (StreamReader sr = new StreamReader("stopwords.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    stopwords.Add(line);
                }
            }



            List<string> words = new List<string>(); // может надо за ф-ю

            DirectoryInfo directory = new DirectoryInfo(name);
            
            foreach (FileInfo file in directory.GetFiles())
            {
                using StreamReader sr = new StreamReader(file.FullName);
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words2 = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        bool flag = true;
                        foreach (string word in words2)
                            foreach (string stw in stopwords)
                                if (word == stw)
                                    flag = false;

                        if (flag) 
                            words.AddRange(words2);
                    }
                }
            }

            foreach (DirectoryInfo directory2 in directory.GetDirectories())
            {
                DoWork(directory2.FullName);
            }



            using (StreamWriter sw = new StreamWriter("result.txt"))
            {
                var sorted_words = words.OrderBy(words => words.Count());
            }
        }
    }
}
