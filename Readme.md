<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128573482/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1287)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Chart for ASP.NET Web Forms - Emulate Gantt Functionality

This example demonstrates how to create a WebChartControl and bind it to data which represents a multi-task process.

The WebChartControl contains two series: **Planned** and **Actual**. The first series is bound to data. For the second series, the component uses the [Custom Summary Function](http://documentation.devexpress.com/#XtraCharts/CustomDocument4948) to calculate data based on the complete percentage data field values.

Additionally, the component raises the [WebChartControl.CustomDrawSeriesPoint](https://docs.devexpress.com/AspNet/DevExpress.XtraCharts.Web.WebChartControl.CustomDrawSeriesPoint) event to customize the text of bar labels.

## Files to Look At:

* [GanttData.cs](./CS/WebSite/App_Code/GanttData.cs) (VB: [GanttData.vb](./VB/WebSite/App_Code/GanttData.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-chart-emulate-gantt-functionality&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-chart-emulate-gantt-functionality&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
