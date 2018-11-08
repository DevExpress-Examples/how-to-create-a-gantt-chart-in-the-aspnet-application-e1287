<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v15.1, Version=15.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
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
             Height="283px" Width="924px" OnCustomDrawSeriesPoint="WebChartControl1_CustomDrawSeriesPoint">
            <SeriesSerializable>
                <cc1:Series  Name="Planned" 
                     ValueScaleType="DateTime">
                    <ViewSerializable>
<cc1:OverlappedGanttSeriesView barwidth="0.8" hiddenserializablestring="to be serialized"></cc1:OverlappedGanttSeriesView>
</ViewSerializable>
                    <LabelSerializable>
<cc1:RangeBarSeriesLabel hiddenserializablestring="to be serialized">
                    </cc1:RangeBarSeriesLabel>
</LabelSerializable>
                    <PointOptionsSerializable>
<cc1:RangeBarPointOptions hiddenserializablestring="to be serialized"></cc1:RangeBarPointOptions>
</PointOptionsSerializable>
                    <LegendPointOptionsSerializable>
<cc1:RangeBarPointOptions hiddenserializablestring="to be serialized"></cc1:RangeBarPointOptions>
</LegendPointOptionsSerializable>
                </cc1:Series>
                <cc1:Series  Name="Actual" 
                     ValueScaleType="DateTime">
                    <ViewSerializable>
<cc1:OverlappedGanttSeriesView hiddenserializablestring="to be serialized"></cc1:OverlappedGanttSeriesView>
</ViewSerializable>
                    <LabelSerializable>
<cc1:RangeBarSeriesLabel hiddenserializablestring="to be serialized">
                    </cc1:RangeBarSeriesLabel>
</LabelSerializable>
                    <PointOptionsSerializable>
<cc1:RangeBarPointOptions hiddenserializablestring="to be serialized"></cc1:RangeBarPointOptions>
</PointOptionsSerializable>
                    <LegendPointOptionsSerializable>
<cc1:RangeBarPointOptions hiddenserializablestring="to be serialized"></cc1:RangeBarPointOptions>
</LegendPointOptionsSerializable>
                </cc1:Series>
            </SeriesSerializable>
            <SeriesTemplate  
                >
                <PointOptionsSerializable>
<cc1:PointOptions HiddenSerializableString="to be serialized">
                </cc1:PointOptions>
</PointOptionsSerializable>
                <LabelSerializable>
<cc1:SideBySideBarSeriesLabel HiddenSerializableString="to be serialized" LineVisible="True">
                </cc1:SideBySideBarSeriesLabel>
</LabelSerializable>
                <LegendPointOptionsSerializable>
<cc1:PointOptions HiddenSerializableString="to be serialized">
                </cc1:PointOptions>
</LegendPointOptionsSerializable>
                <ViewSerializable>
<cc1:SideBySideBarSeriesView HiddenSerializableString="to be serialized">
                </cc1:SideBySideBarSeriesView>
</ViewSerializable>
            </SeriesTemplate>
            <DiagramSerializable>
<cc1:GanttDiagram>
                <axisx visibleinpanesserializable="-1">
<Range SideMarginsEnabled="True"></Range>
</axisx>
                <axisy visibleinpanesserializable="-1">
<Label Angle="90"></Label>

<Range SideMarginsEnabled="True"></Range>
</axisy>
            </cc1:GanttDiagram>
</DiagramSerializable>
            <FillStyle >
                <OptionsSerializable>
<cc1:SolidFillOptions HiddenSerializableString="to be serialized" />
</OptionsSerializable>
            </FillStyle>
        </dxchartsui:WebChartControl>
        &nbsp;

    </div>
    </form>
</body>
</html>