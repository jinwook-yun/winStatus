using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Drawing;
using System.Threading;

namespace WinStatusBoard.View
{
    public class ViewChart
    {
        /// <summary>화면에서 보여질 차트 컴포넌트</summary> 
        private ChartControl Chart { get; set; }

        /// <summary>차트에 추가될 Series</summary> 
        private Series[] Series { get; set; }

        public SeriesViewBase[] SeriesViewBases { get; set; }

        private PieSeriesLabel pieLabel { get; set; } = new PieSeriesLabel();

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

        public ViewChart(ChartControl chart)
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
                Series[i] = new Series();
                Series[i].ArgumentScaleType = ScaleType.Qualitative;
                Series[i].ValueScaleType = ScaleType.Numerical;

                // ((BarSeriesView)series[i].View).BarWidth = 8;

                Series[i].View = SeriesViewBases[i];
               // Series[i].Label = SeriesLabelBases[i];
                
                Series[i].LabelsVisibility = DevExpress.Utils.DefaultBoolean.Default; //라벨 안보이게
                Series[i].Name = seriesName[i];
                Series[i].View.Color = (i == 0) ? Color.FromArgb(192, 80, 77) : Color.FromArgb(79, 129, 189);
            }
        }

        public void BindingChartData(DataTable data)
        {
            int totalCount = SeriesCount * SeriesMemberCount;

            SeriesPoint[] seriesPoint = new SeriesPoint[totalCount];

            for (int i = 0; i < totalCount; i++)
            {
                seriesPoint[i] = new SeriesPoint();
            }

            for (int i = 0; i < SeriesMemberCount; i++)
            {
                if (data.Rows.Count == 0)
                    continue;
                DataRow row = data.Rows[i];
                for (int j = 0; j < SeriesCount; j++)
                {
                    string colNm = SeriesPointValueColumnName[j];

                    if (string.IsNullOrEmpty(row[colNm].ToString()))
                        continue;
                    seriesPoint[i + (j * SeriesMemberCount)] = new SeriesPoint(row[SeriesMemberTitleColumnName].ToString(), new object[] { Convert.ToDouble(row[colNm].ToString().Replace(",", "").Replace("%", "")) });
                }
            }

            //하나의 Series에 여러 SeriesPoint 추가
            //예)하나의 출하계획에 여러 포인트 내수/수출/합계 추가
            for (int i = 0; i < SeriesCount; i++)
            {
                for (int j = 0; j < SeriesMemberCount; j++)
                {
                    if (data.Rows.Count == 0|| string.IsNullOrEmpty(seriesPoint[j].Argument))
                        continue;
                    Series[i].Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] { seriesPoint[(i * SeriesMemberCount) + j] });
                    Series[i].Label.TextPattern = "{A}:{VP:p0}";
                    Series[i].Label.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
           

            for (int i = 0; i < SeriesCount; i++)
            {
                Chart.Series.AddRange(new Series[] { Series[i] });
            }
        }

        public void SetChartDiagram()
        {
            XYDiagram = new XYDiagram();
            XYDiagram = (XYDiagram)Chart.Diagram;
            Chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            Chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            Chart.Legend.Margins.All = 10;
            Chart.Legend.MarkerSize = new System.Drawing.Size(40, 60);

            Chart.Legend.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisX.Label.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisY.Label.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            XYDiagram.AxisY.Label.TextPattern = "{V:#,#}";
            XYDiagram.AxisY.Tickmarks.MinorVisible = false;
        }

        public void SetPieChartLabel()
        {
            pieLabel.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieLabel.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            pieLabel.LineVisibility = DevExpress.Utils.DefaultBoolean.False;
            pieLabel.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;       
            pieLabel.TextPattern = "{A}:{VP:p0}";
            Thread.Sleep(500);
            for (int i = 0; i < SeriesCount; i++)
            {
                for (int j = 0; j < SeriesMemberCount; j++)
                {
                    Series[i].Label = pieLabel;
                }
            }
        }
    }
}
