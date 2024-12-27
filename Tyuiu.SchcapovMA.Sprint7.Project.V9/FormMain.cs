using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SchcapovMA.Sprint7.Project.V9.Lib;


namespace Tyuiu.SchcapovMA.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = "C:\\DataSprint7\\Данные фильмов.scv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;

        private void buttonHelp_SMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_SMA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Выберите файл CSV"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    var lines = File.ReadAllLines(filePath);
                    dataGridViewTabl_SMA.Rows.Clear();
                    dataGridViewTabl_SMA.Columns.Clear();

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var headers = lines[0].Split(';');
                    foreach (var header in headers)
                    {
                        if (!string.IsNullOrWhiteSpace(header))
                        {
                            dataGridViewTabl_SMA.Columns.Add(header.Trim(), header.Trim());
                        }
                    }
                    //Добавить строки в грид
                    for (int i = 1; i < lines.Length; i++)
                    {
                        var cells = lines[i].Split(';');
                        if (cells.Length == headers.Length)
                        {
                            dataGridViewTabl_SMA.Rows.Add(cells);
                        }
                    }
                    buttonSaveFile_SMA.Enabled = true;

                    MessageBox.Show("Данные успешно загружены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveFile_SMA_Click(object sender, EventArgs e)
        {
            saveFileDialog_SMA.FileName = "OutPutFile.csv";
            saveFileDialog_SMA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SMA.ShowDialog();

            string path1 = saveFileDialog_SMA.FileName;



            FileInfo fileInfo = new FileInfo(path1);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path1);
            }
            int rows = dataGridViewTabl_SMA.RowCount;
            int columns = dataGridViewTabl_SMA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewTabl_SMA.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str += dataGridViewTabl_SMA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path1, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonGraf_SMA_Click(object sender, EventArgs e)
        {
            FormChart_SMA formChart = new FormChart_SMA();
            formChart.ShowDialog();
        }

        private void dataGridViewTabl_SMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
