using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Drawing;

namespace WinStatusBoard.View
{
    public class ViewChart
    {
        /// <summary>화면에서 보여질 차트 컴포넌트</summary> 
        private ChartControl Chart { get; set; }

        /// <summary>차트에 추가될 Series</summary> 
        private Series[] Series { get; set; }

        public SeriesViewBase[] SeriesViewBases { get; set; }

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

        //public void SetSeriesView(SeriesViewBase[] seriesViewBases)
        //{
            
        //}

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

            int rowCnt = (data.Rows.Count == SeriesMemberCount) ? SeriesMemberCount : data.Rows.Count;

            for (int i = 0; i < rowCnt; i++)
            {
                DataRow row = data.Rows[i];
                for (int j = 0; j < SeriesCount; j++)
                {
                    string colNm = SeriesPointValueColumnName[j];

                    seriesPoint[i + (j * rowCnt)] = new SeriesPoint(row[SeriesMemberTitleColumnName].ToString(), new object[] { Convert.ToInt64(row[colNm].ToString().Replace(",", "").Replace("%", "")) });
                }
            }
           

            //하나의 Series에 여러 SeriesPoint 추가
            //예)하나의 출하계획에 여러 포인트 내수/수출/합계 추가
            for (int i = 0; i < SeriesCount; i++)
            {
                for (int j = 0; j < rowCnt; j++)
                {
                    Series[i].Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] { seriesPoint[(i * rowCnt) + j] });
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
            Chart.Legend.MarkerSize = new System.Drawing.Size(30, 50);

            Chart.Legend.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisX.Label.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            XYDiagram.AxisY.Label.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            XYDiagram.AxisY.Label.TextPattern = "{V:#,##0}";
            XYDiagram.AxisY.Tickmarks.MinorVisible = false;
        }

        public void SetChartTitle(string title)
        {           
            ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            chartTitle1.Text = title;

            if(Chart.Titles.Count >= 0)
            {
                Chart.Titles.Clear();
            }

            Chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
        }
    }
}
