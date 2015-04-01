using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace DAQNavi_WF_v1_0_0
{
    public class ChartUtils
    {
        private ChartUtils()
        {
            // Util class - private constructor
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
    }
}

