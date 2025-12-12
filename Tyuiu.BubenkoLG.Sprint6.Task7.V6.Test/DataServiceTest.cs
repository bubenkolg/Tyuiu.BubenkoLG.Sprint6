using Tyuiu.BubenkoLG.Sprint6.Task7.V6.Lib;

namespace Tyuiu.BubenkoLG.Sprint6.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsInPutFile()
        {
            string path1 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\InPutDataFileTask7V6.csv";
            FileInfo fileInfo1 = new FileInfo(path1);
            bool fileExists1 = fileInfo1.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists1);
        }
        [TestMethod]
        public void CheckedExistsOutPutFile()
        {
            string path2 = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\OutPutFileTask7V6.csv";
            FileInfo fileInfo2 = new FileInfo(path2);
            bool fileExists2 = fileInfo2.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists2);
        }
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Людмила Георгиевна\Desktop\source\repos\Tyuiu.BubenkoLG.Sprint6\InPutDataFileTask7V6.csv";
            int[,] res = new int[10, 10];
            int[,] wait = { { -14, -1, 2, 18, -17, 7, -16, 10, 12, 17 },
                              { 8, -17, 10, -19, -4, -11, 8, 14, -15, -8 },
                              { -14, -5, -10, -20, 19, -3, -19, -15, -10, 8 },
                              { 3, 17, -10, -9, -1, 18, -10, -18, 17, 15 },
                              { 7, 16, 0, 9, -3, 14, 12, 17, 10, 6 },
                              { -1, 17, -3, 20, 11, 14, -15, 3, -4, -6 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                              { -8, -7, 3, 3, -18, -13, -11, -19, -1, -12 },
                              { - 11, -18, 2, -6, -9, -18, -16, -10, 1, -13 },
                              { 12, -13, 7, 20, 9, -8, 8, -20, 6, -18 } };
            res = ds.GetMatrix(path);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(wait[i,j], res[i,j]);
                }
            }
        }
    }
}
