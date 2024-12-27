using System.Data;
using Tyuiu.SchcapovMA.Sprint7.Project.V9.Lib;
namespace Tyuiu.SchcapovMA.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        
        public void ValidLoadDataSet()
        {
            DataService ds = new DataService();

            string path = "C:\\Users\\Haier\\AppData\\Local\\Temp\\Dataset.csv";
            FileInfo fi = new FileInfo(path);
            bool fileEx = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);

        }
        [TestMethod]
        public void rlySortedUbyv()
        {
            DataService ds = new DataService();
            string[,] basa = {
                                { "ID", "��������",    "������������"},
                                { "1",   "��������� ���������", "240"},
                                { "2",   "�������� ������", "180"},
                                { "3",   "���������� ����", "300"}
                             };
            int column = 0;

            string[,] sortedbasa = { { "ID", "��������",    "������������"},
                                     { "3", "���������� ����", "300" },
                                     { "2",   "�������� ������", "180"},
                                     { "1",   "��������� ���������", "240"}
                                   };

            string[,] result = ds.SortUbyv(basa, column);
            CollectionAssert.AreEqual(result, sortedbasa);
        }
        [TestMethod]
        public void rlySortedVozr()
        {
            DataService ds = new DataService();

            string[,] basa = {
                                { "ID", "��������",    "������������"},
                                { "1",   "��������� ���������", "240"},
                                { "2",   "�������� ������", "180"},
                                { "3",   "���������� ����", "300"}
                             };
            int column = 2;
            string[,] sortedbasa = { { "ID", "��������", "������������" },
                                     { "2",   "�������� ������", "180"},
                                     { "1",   "��������� ���������", "240"},
                                     { "3",   "���������� ����", "300"}
                                   };

            string[,] result = ds.SortVozr(basa, column);
            CollectionAssert.AreEqual(sortedbasa, result);

        }
        }
    }