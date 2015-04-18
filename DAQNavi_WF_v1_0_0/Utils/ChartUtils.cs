using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DAQNavi_WF_v1_0_0
{
    public class ChartUtils
    {
        private ChartUtils()
        {
            // Util class - private constructor
        }


        public static void switchStyle(Chart chart, MetroFramework.MetroThemeStyle style)
        {
            if (style.Equals(MetroFramework.MetroThemeStyle.Light))
            {
                Color liniaGruba = Color.FromArgb(120, 120, 120);
                Color liniaCienka = Color.FromArgb(190, 190, 190);

                // Background
                chart.ChartAreas[0].BackColor = Color.FromArgb(255, 255, 255);

                // linie osi
                chart.ChartAreas[0].AxisX.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.LineColor = liniaGruba;

                // numeracja osi
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = liniaGruba;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = liniaGruba;

                // siatka gruba
                chart.ChartAreas[0].AxisX.MajorGrid.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisX.MajorTickMark.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.MajorTickMark.LineColor = liniaGruba;

                // siatka cienka
                chart.ChartAreas[0].AxisX.MinorGrid.LineColor = liniaCienka;
                chart.ChartAreas[0].AxisY.MinorGrid.LineColor = liniaCienka;
            }
            else
            {
                Color liniaGruba = Color.FromArgb(170, 170, 170);
                Color liniaCienka = Color.FromArgb(120, 120, 120);

                // Background
                chart.ChartAreas[0].BackColor = Color.FromArgb(100, 100, 100);

                // numeracja osi
                chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = liniaGruba;
                chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = liniaGruba;

                // linie osi
                chart.ChartAreas[0].AxisX.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.LineColor = liniaGruba;

                // siatka gruba
                chart.ChartAreas[0].AxisX.MajorGrid.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisX.MajorTickMark.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = liniaGruba;
                chart.ChartAreas[0].AxisY.MajorTickMark.LineColor = liniaGruba;

                // siatka cienka
                chart.ChartAreas[0].AxisX.MinorGrid.LineColor = liniaCienka;
                chart.ChartAreas[0].AxisY.MinorGrid.LineColor = liniaCienka;
            }
        }

        /* Ustawienie możliwości zoomowania na danym
           wykresie */
        public static void setChartZoomProperties(Chart chart)
        {
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart.ChartAreas[0].CursorX.AutoScroll = true;
            chart.ChartAreas[0].CursorY.AutoScroll = true;

            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
        }

        /* Czyszczenie wykresu z punktów */
        public static void clearChart(Chart chart)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
        }

        /* Obliczenie nowych wartości punktów dla danego wykresu,
           bazując na rozpiętości jego osi X. */
        public static void changeChartMarkerRatio(Chart chart, double ratio)
        {
            if (ratio <= 30)
            {
                for (int i = 0; i < chart.Series.Count; i++)
                {
                    chart.Series[i].MarkerSize = 8;
                }
            }
            else
            {
                for (int i = 0; i < chart.Series.Count; i++)
                {
                    chart.Series[i].MarkerSize = 0;
                }
            }
        }

        public static void fillUpChart(int channels, List<double> data, Chart chart, MetroFramework.Controls.MetroProgressBar bar)
        {
            int mySeries = 0;
            int xPoint = 0;
            bar.Maximum = data.Count;
            bar.Value = 0;
            chart.ChartAreas[0].AxisX.Maximum = 10;
            for (int i = 0; i < data.Count; ++i)
            {
                mySeries = (i % channels);
                if (mySeries == 0)
                {
                    xPoint++;
                }

                //MEMO LEAK
                 chart.Series[mySeries].Points.Add(new DataPoint(xPoint, data[i]));
                 chart.Series[mySeries].ToolTip = "X=#VALX\nY=#VALY";
            }
        }

        public static void fillUpChartAndGrid(int channels, List<double> data, Chart chart, MetroFramework.Controls.MetroProgressBar bar, MetroFramework.Controls.MetroGrid grid)
        {
            int mySeries = 0;
            int xPoint = 0;
            bar.Maximum = data.Count;
            bar.Value = 0;

            for (int i = 0; i < data.Count; ++i)
            {
                mySeries = (i % channels);
                if (mySeries == 0)
                {
                    xPoint++;
                }

                //MEMO LEAK
                chart.Series[mySeries].Points.Add(new DataPoint(xPoint, data[i]));
                chart.Series[mySeries].ToolTip = "X=#VALX\nY=#VALY";
                grid.Rows.Add();
                grid.Rows[xPoint - 1].Cells[mySeries].Value = data[i];


                bar.Invoke(new MethodInvoker(delegate
                {
                   bar.Increment(1);
                   bar.Refresh();
                 }));


            }
        }
    }
}

