Imports System
Imports System.Data
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' Cpecify ScaleTypes
        WebChartControl1.Series(0).ArgumentScaleType = ScaleType.Qualitative
        WebChartControl1.Series(0).ValueScaleType = ScaleType.DateTime
        WebChartControl1.Series(1).ArgumentScaleType = ScaleType.Qualitative
        WebChartControl1.Series(1).ValueScaleType = ScaleType.DateTime
        TryCast(WebChartControl1.Series(1).Label, RangeBarSeriesLabel).Position = RangeBarLabelPosition.Inside

        ' Bound series to data
        WebChartControl1.DataSource = GanttData.CreateData()
        WebChartControl1.Series(0).ArgumentDataMember = "GanntTask"
        WebChartControl1.Series(0).ValueDataMembers.AddRange(New String() { "GanntStart", "GanntEnd" })

        ' Create argument descriptions for the summary function.
        Dim argument1Description As New SummaryFunctionArgumentDescription("GanntStart", ScaleType.DateTime)
        Dim argument2Description As New SummaryFunctionArgumentDescription("GanntEnd", ScaleType.DateTime)
        Dim argument3Description As New SummaryFunctionArgumentDescription("GanttPercentageComplete", ScaleType.Numerical)

        ' Register the summary function in a chart.
        WebChartControl1.RegisterSummaryFunction("CalcPercentageComplete", "CalcPercentageComplete", 2, New SummaryFunctionArgumentDescription() { argument1Description, argument2Description, argument3Description}, AddressOf CalcPercentageComplete)

        WebChartControl1.Series(1).ArgumentDataMember = "GanntTask"
        WebChartControl1.Series(1).SummaryFunction = "CalcPercentageComplete([GanntStart], [GanntEnd], [GanttPercentageComplete])"

        ' Don't forget this !:)
        WebChartControl1.DataBind()
    End Sub

    ' Declare the summary function.
    Private Shared Function CalcPercentageComplete(ByVal series As Series, ByVal argument As Object, ByVal functionArguments() As String, ByVal values() As DataSourceValues, ByVal colors() As Object) As SeriesPoint()

        ' Create an array of the resulting series points.
        Dim points() As SeriesPoint = { New SeriesPoint(argument.ToString(), New Date() { New Date(), New Date() }) }

        ' Calculate values
        Dim start As Date = Convert.ToDateTime(values(0)(functionArguments(0)))
        Dim [end] As Date = Convert.ToDateTime(values(0)(functionArguments(1)))
        Dim ganttPercentageComplete As Double = Convert.ToDouble(values(0)(functionArguments(2)))

        Dim ts As TimeSpan = [end].Subtract(start)

        points(0).DateTimeValues(0) = start
        points(0).DateTimeValues(1) = start.Add(TimeSpan.FromHours(ts.TotalHours * ganttPercentageComplete/100))

        Dim ob As Object = values(0)("")

        points(0).Tag = (TryCast(ob, DataRowView)).Row("GanttOwner").ToString() & "|" & ganttPercentageComplete.ToString()

        Return points
    End Function

    Protected Sub WebChartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
        If e.Series.Name = "Actual" Then
            e.LabelText = e.SeriesPoint.Tag.ToString().Split("|"c)(0)
            e.SecondLabelText = e.SeriesPoint.Tag.ToString().Split("|"c)(1) & "%"
        End If
    End Sub

End Class
