Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.ComponentModel

''' <summary>
''' Summary description for GanttData
''' </summary>
Public Class GanttData
    Inherits DataSet

    Public Sub New()
        Dim table As New DataTable("table")

        table.Columns.Add("GanntTask", GetType(String))
        table.Columns.Add("GanntStart", GetType(Date))
        table.Columns.Add("GanntEnd", GetType(Date))
        table.Columns.Add("GanttPercentageComplete", GetType(Int32))
        table.Columns.Add("GanttOwner", GetType(String))

        Tables.AddRange(New DataTable() { table })
    End Sub

    Public Shared Function CreateData() As GanttData
        Dim ds As New GanttData()
        Dim table As DataTable = ds.Tables("table")

        table.Rows.Add(New Object() { "Analysing", New Date(2009,1,1), New Date(2009,1,5), 90, "John"})
        table.Rows.Add(New Object() { "Planning", New Date(2009,1,5), New Date(2009,1,10), 80, "Williams" })
        table.Rows.Add(New Object() { "Implementation", New Date(2009,1,10), New Date(2009,1,25), 85, "Iverson" })
        table.Rows.Add(New Object() { "Maintaince", New Date(2009,1,25), New Date(2009,2,5), 90, "Young" })

        Return ds
    End Function

    #Region "Disable Serialization for Tables and Relations"
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Tables() As DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Relations() As DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property
    #End Region ' Disable Serialization for Tables and Relations

End Class



