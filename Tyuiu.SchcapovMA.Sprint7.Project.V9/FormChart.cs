using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.LinkLabel;

namespace Tyuiu.SchcapovMA.Sprint7.Project.V9
{
    public partial class FormChart_SMA : Form
    {
        public FormChart_SMA()
        {
            InitializeComponent();
            {

            }
        }

        private void FormChart_SMA_Load(object sender, EventArgs e)
        {

            string filePath = "C:\\DataSprint7\\Данные фильмов.csv";
            var lines = File.ReadAllLines(filePath);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var headers = lines[0].Split(';');
            foreach (var header in headers)
            {
                if (!string.IsNullOrWhiteSpace(header))
                {
                    dataGridView1.Columns.Add(header.Trim(), header.Trim());
                }
            }
            //Добавить строки в грид
            for (int i = 1; i < lines.Length; i++)
            {
                var cells = lines[i].Split(';');
                if (cells.Length == headers.Length)
                {
                    dataGridView1.Rows.Add(cells);
                }
            }
            chart_SMA.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                double area = Convert.ToDouble(row.Cells[0].Value);
                int roomCount = Convert.ToInt32(row.Cells[2].Value);
                series.Points.AddXY(roomCount, area);
            }
            chart_SMA.Series.Add(series);
            chart_SMA.Show();

        }
    }
}
