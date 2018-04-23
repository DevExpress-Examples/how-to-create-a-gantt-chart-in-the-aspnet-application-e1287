using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Cpecify ScaleTypes
        WebChartControl1.Series[0].ArgumentScaleType = ScaleType.Qualitative;
        WebChartControl1.Series[0].ValueScaleType = ScaleType.DateTime;
        WebChartControl1.Series[1].ArgumentScaleType = ScaleType.Qualitative;
        WebChartControl1.Series[1].ValueScaleType = ScaleType.DateTime;
        (WebChartControl1.Series[1].Label as RangeBarSeriesLabel).Position = RangeBarLabelPosition.Inside;

        // Bound series to data
        WebChartControl1.DataSource = GanttData.CreateData();
        WebChartControl1.Series[0].ArgumentDataMember = "GanntTask";
        WebChartControl1.Series[0].ValueDataMembers.AddRange(new string[] { "GanntStart", "GanntEnd" });

        // Create argument descriptions for the summary function.
        SummaryFunctionArgumentDescription argument1Description =
            new SummaryFunctionArgumentDescription("GanntStart", ScaleType.DateTime);
        SummaryFunctionArgumentDescription argument2Description =
            new SummaryFunctionArgumentDescription("GanntEnd", ScaleType.DateTime);
        SummaryFunctionArgumentDescription argument3Description =
            new SummaryFunctionArgumentDescription("GanttPercentageComplete", ScaleType.Numerical);

        // Register the summary function in a chart.
        WebChartControl1.RegisterSummaryFunction("CalcPercentageComplete", "CalcPercentageComplete", 2,
            new SummaryFunctionArgumentDescription[] { argument1Description, argument2Description, argument3Description},
            CalcPercentageComplete);

        WebChartControl1.Series[1].ArgumentDataMember = "GanntTask";
        WebChartControl1.Series[1].SummaryFunction = "CalcPercentageComplete([GanntStart], [GanntEnd], [GanttPercentageComplete])";

        // Don't forget this !:)
        WebChartControl1.DataBind();
    }

    // Declare the summary function.
    private static SeriesPoint[] CalcPercentageComplete(Series series, object argument,
        string[] functionArguments, DataSourceValues[] values) {

        // Create an array of the resulting series points.
        SeriesPoint[] points = new SeriesPoint[1] { new SeriesPoint(argument.ToString(), new DateTime[] { new DateTime(), new DateTime() }) };

        // Calculate values
        DateTime start = Convert.ToDateTime(values[0][functionArguments[0]]);
        DateTime end = Convert.ToDateTime(values[0][functionArguments[1]]);
        double ganttPercentageComplete = Convert.ToDouble(values[0][functionArguments[2]]);

        TimeSpan ts = end - start;
        
        points[0].DateTimeValues[0] = start;
        points[0].DateTimeValues[1] = start + TimeSpan.FromHours(ts.TotalHours * ganttPercentageComplete/100);
        
        object ob = values[0][""];

        points[0].Tag = (ob as DataRowView).Row["GanttOwner"].ToString() + "|" + ganttPercentageComplete.ToString();

        return points;
    }

    protected void WebChartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
        if(e.Series.Name == "Actual") {
            e.LabelText = e.SeriesPoint.Tag.ToString().Split('|')[0];
            e.SecondLabelText = e.SeriesPoint.Tag.ToString().Split('|')[1] + "%";
        }
    }

}
    