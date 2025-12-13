using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BubenkoLG.Sprint6.Task6.V18.Lib
{
    public class DataService : ISprint6Task6V18
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("n"))
                    {
                        string[] words = line.Split(' ');

                        foreach (string word in words)
                        {
                            if (word.Contains("n"))
                            {
                                resStr = resStr + " " + word;
                            }
                        }
                    }
                }
            }

            return resStr.TrimStart();
        }

    }
}
