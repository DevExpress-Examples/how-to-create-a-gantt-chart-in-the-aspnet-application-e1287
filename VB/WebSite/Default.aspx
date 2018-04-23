<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v8.3.Web, Version=8.3.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v8.3, Version=8.3.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxchartsui:WebChartControl ID="WebChartControl1" runat="server" ClientInstanceName="chart"
			DiagramTypeName="GanttDiagram" Height="283px" Width="924px" OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint">
			<SeriesSerializable>
				<cc1:Series LabelTypeName="RangeBarSeriesLabel" Name="Planned" PointOptionsTypeName="RangeBarPointOptions"
					SeriesViewTypeName="OverlappedGanttSeriesView" ValueScaleType="DateTime">
					<view barwidth="0.8" hiddenserializablestring="to be serialized"></view>
					<label hiddenserializablestring="to be serialized">
					</label>
					<pointoptions hiddenserializablestring="to be serialized"></pointoptions>
					<legendpointoptions hiddenserializablestring="to be serialized"></legendpointoptions>
				</cc1:Series>
				<cc1:Series LabelTypeName="RangeBarSeriesLabel" Name="Actual" PointOptionsTypeName="RangeBarPointOptions"
					SeriesViewTypeName="OverlappedGanttSeriesView" ValueScaleType="DateTime">
					<view hiddenserializablestring="to be serialized"></view>
					<label hiddenserializablestring="to be serialized">
					</label>
					<pointoptions hiddenserializablestring="to be serialized"></pointoptions>
					<legendpointoptions hiddenserializablestring="to be serialized"></legendpointoptions>
				</cc1:Series>
			</SeriesSerializable>
			<SeriesTemplate LabelTypeName="SideBySideBarSeriesLabel" PointOptionsTypeName="PointOptions"
				SeriesViewTypeName="SideBySideBarSeriesView">
				<PointOptions HiddenSerializableString="to be serialized">
				</PointOptions>
				<Label HiddenSerializableString="to be serialized" LineVisible="True">
				</Label>
				<LegendPointOptions HiddenSerializableString="to be serialized">
				</LegendPointOptions>
				<View HiddenSerializableString="to be serialized">
				</View>
			</SeriesTemplate>
			<Diagram>
				<axisx visibleinpanesserializable="-1">
<Range SideMarginsEnabled="True"></Range>
</axisx>
				<axisy visibleinpanesserializable="-1">
<Label Angle="90"></Label>

<Range SideMarginsEnabled="True"></Range>
</axisy>
			</Diagram>
			<FillStyle FillOptionsTypeName="SolidFillOptions">
				<Options HiddenSerializableString="to be serialized" />
			</FillStyle>
		</dxchartsui:WebChartControl>
		&nbsp;

	</div>
	</form>
</body>
</html>