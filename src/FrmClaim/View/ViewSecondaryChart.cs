using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Drawing;

namespace WinStatusBoard.View
{
    public class ViewSecondaryChart
    {
        /// <summary>화면에서 보여질 차트 컴포넌트</summary> 
        private ChartControl Chart { get; set; }

        /// <summary>차트에 추가될 Series</summary> 
        private Series[] Series { get; set; }
        private SecondaryAxisY secondaryAxisY { get; set; }

        public SeriesViewBase[] SeriesViewBases { get; set; }
        public ViewType[] SeriesViewTypes { get; set; }

        /// <summary>차트에 추가될 Diagram</summary> 
        private XYDiagram XYDiagram { get; set; }

        /// <summary>차트에 보여질 시리즈 개수</summary> 
        public int SeriesCount { get; set; }

        /// <summary>차트에 추가될 X축 값 개수</summary> 
        public int SeriesMemberCount { get; set; }

        /// <summary>X축에 표시될 명칭 테이블 컬럼명</summary> 
        public string SeriesMemberTitleColumnName { get; set; }

        /// <summary>X축에 표시될 포인트값 테이블 컬럼명</summary> 
        public string[] SeriesPointValueColumnName { get; set; }

        public ViewSecondaryChart(ChartControl chart)
        {
            Chart = chart;
        }

        public void SetSeries(string[] seriesName)
        {
            Series = new Series[SeriesCount];

            //클리어를 해줘야 시리즈 개수가 늘어나지 않는다
            if (Series != null) { Chart.Series.Clear(); }

            for (int i = 0; i < seriesName.Length; i++)
            {
                Series[i] = new Series(seriesName[i], SeriesViewTypes[i]);
                Series[i].ArgumentScaleType = ScaleType.Qualitative;
                Series[i].ValueScaleType = ScaleType.Numerical;
                Series[i].LabelsVisibility = DevExpress.Utils.DefaultBoolean.Default; //라벨 안보이게
                // Series[i].View.Color = (i == 0) ? Color.FromArgb(192, 80, 77) : Color.FromArgb(79, 129, 189);

                if (SeriesViewTypes[i].Equals(ViewType.Line))
                {
                    ((LineSeriesView)Series[i].View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
                    ((LineSeriesView)Series[i].View).LineMarkerOptions.Size = 5;

                    if (i == 3)
                    {
                        Series[i].View.Color = Color.Black;
                    }
                } 
            }
        }

        public void BindingChartData(DataTable data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];

                for (int j = 0; j < SeriesCount; j++)
                {
                    Series[j].Points.Add(new SeriesPoint(dr[SeriesMemberTitleColumnName].ToString(), Convert.ToInt32(dr[SeriesPointValueColumnName[j]].ToString().Replace(",", ""))));
                }
            }

            for (int i = 0; i < SeriesCount; i++)
            {
                Chart.Series.AddRange(new Series[] { Series[i] });
            }

            SetSecondaryAxisY();
        }

        public void SetSecondaryAxisY()
        {
            ((XYDiagram)Chart.Diagram).SecondaryAxesY.Clear();
            secondaryAxisY = new SecondaryAxisY();
            ((XYDiagram)Chart.Diagram).SecondaryAxesY.Add(secondaryAxisY);

            for (int i = 0; i < SeriesViewTypes.Length; i++)
            {
                if (SeriesViewTypes[i].Equals(ViewType.Line))
                {
                    ((LineSeriesView)Series[i].View).AxisY = secondaryAxisY;
                    ((LineSeriesView)Series[i].View).LineStyle.Thickness = 5;
                }
            }

            secondaryAxisY.Label.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            secondaryAxisY.Label.TextPattern = "{V:#,###}";
            secondaryAxisY.Tickmarks.MinorVisible = false;

        }

        public void SetChartDiagram()
        {
            XYDiagram = new XYDiagram();
            XYDiagram = (XYDiagram)Chart.Diagram;
            Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            Chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            Chart.Legend.Margins.All = 10;
            Chart.Legend.MarkerSize = new System.Drawing.Size(30, 50);

            Chart.Legend.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisX.Label.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisY.Label.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            XYDiagram.AxisY.Label.TextPattern = "{V:#,##0}";
            XYDiagram.AxisY.Tickmarks.MinorVisible = false;
        }

        public void SetChartTitle(string title)
        {
            ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            chartTitle1.Text = title;

            if (Chart.Titles.Count >= 0)
            {
                Chart.Titles.Clear();
            }

            Chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
        }
    }
}
