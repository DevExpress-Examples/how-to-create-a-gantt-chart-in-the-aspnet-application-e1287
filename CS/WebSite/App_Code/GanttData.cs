using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;

/// <summary>
/// Summary description for GanttData
/// </summary>
public class GanttData : DataSet
{
	public GanttData()
	{
        DataTable table = new DataTable("table");

        table.Columns.Add("GanntTask", typeof(string));
        table.Columns.Add("GanntStart", typeof(DateTime));
        table.Columns.Add("GanntEnd", typeof(DateTime));
        table.Columns.Add("GanttPercentageComplete", typeof(Int32));
        table.Columns.Add("GanttOwner", typeof(string));

        Tables.AddRange(new DataTable[] { table });
    }

    public static GanttData CreateData() {
        GanttData ds = new GanttData();
        DataTable table = ds.Tables["table"];

        table.Rows.Add(new object[] { "Analysing", new DateTime(2009,1,1), new DateTime(2009,1,5), 90,  "John"});
        table.Rows.Add(new object[] { "Planning", new DateTime(2009,1,5), new DateTime(2009,1,10), 80, "Williams" });
        table.Rows.Add(new object[] { "Implementation", new DateTime(2009,1,10), new DateTime(2009,1,25), 85, "Iverson" });
        table.Rows.Add(new object[] { "Maintaince", new DateTime(2009,1,25), new DateTime(2009,2,5), 90, "Young" });

        return ds;
    }

    #region Disable Serialization for Tables and Relations
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables {
        get { return base.Tables; }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations {
        get { return base.Relations; }
    }
    #endregion Disable Serialization for Tables and Relations

}



