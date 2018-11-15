<!-- default file list -->
*Files to look at*:

* [GanttData.cs](./CS/WebSite/App_Code/GanttData.cs) (VB: [GanttData.vb](./VB/WebSite/App_Code/GanttData.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# How to create a Gantt Chart in the ASP.NET application


<p>This example demonstrates how to create a WebChartControl and bind it to data which represents a multi-task process. There are two series in the WebChartControl - "Planned" and "Actual". The first series is bound to data. The second series calculates via the <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument4948">Custom Summary Function</a> based on the complete percentage data field values. In addition, the WebChartControl.CustomDrawSeriesPoint event is handled in order to customize the text of the series bars labels.</p>

<br/>


