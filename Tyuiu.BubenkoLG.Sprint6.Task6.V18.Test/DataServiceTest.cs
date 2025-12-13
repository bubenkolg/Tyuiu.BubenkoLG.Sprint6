using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint6.Task6.V18.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\InPutDataFileTask6V18.txt";

        [TestMethod]
        public void CheckedExistsFile()
        {
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string text = "gMxrJi NEzHYMM cHshl VAYYbnhDwTg cqqToIKFd OmduE fGf m DdvgjSJAlQx OJQBG etujsEyNxkCsy bBYQQ TUczey NtFbXoZ sNnk pmYGtO CMmHkUlnNoZen rvzAEwiXzIsLRa WqU xakZKciG nqrB";
            string wait = "VAYYbnhDwTg sNnk nqrB";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
