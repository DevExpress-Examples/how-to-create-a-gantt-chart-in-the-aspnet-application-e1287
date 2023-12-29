<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128573482/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1287)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [GanttData.cs](./CS/WebSite/App_Code/GanttData.cs) (VB: [GanttData.vb](./VB/WebSite/App_Code/GanttData.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to create a Gantt Chart in the ASP.NET application


<p>This example demonstrates how to create a WebChartControl and bind it to data which represents a multi-task process. There are two series in the WebChartControl - "Planned" and "Actual". The first series is bound to data. The second series calculates via the <a href="http://documentation.devexpress.com/#XtraCharts/CustomDocument4948">Custom Summary Function</a> based on the complete percentage data field values. In addition, the WebChartControl.CustomDrawSeriesPoint event is handled in order to customize the text of the series bars labels.</p>

<br/>


